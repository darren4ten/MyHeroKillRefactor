using NewHeroKill.Card;
using NewHeroKill.Card.Base;
using NewHeroKill.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{

    public class PlayerAction : IPlayerAction
    {
        // 人物模型
        protected AbstractPlayer player;

        // 构造器
        public PlayerAction(AbstractPlayer p)
        {
            this.player = p;
        }

        /// <summary>
        /// 玩家加血 -- 调用加血触发事件
        /// </summary>
        /// <param name="num"></param>
        public void AddHP(int num)
        {
            player.GetState().SetCurHP(player.GetState().GetCurHP() + num);
            if (player.GetState().GetCurHP() > player.GetInfo().GetMaxHP())
            {
                player.GetState().SetCurHP(player.GetInfo().GetMaxHP());
            }
            // 调用加血触发
            player.GetTrigger().AfterAddHP();
        }

        /// <summary>
        /// 装载装备
        /// </summary>
        /// <param name="c"></param>
        public void LoadEquipmentCard(AbstractCard c)
        {
            AbstractEquipmentCard ceq = (AbstractEquipmentCard)c;
            ceq.load(player);
            //触发
            player.GetTrigger().AfterLoadEquipmentCard();
        }

        /// <summary>
        /// 玩家扣血 -- 调用扣血触发事件
        /// </summary>
        /// <param name="num">扣血数量</param>
        /// <param name="murderer">凶手</param>
        public void LoseHP(int num, AbstractPlayer murderer)
        {
            int hp = player.GetState().GetCurHP();
            hp -= num;
            player.GetState().SetCurHP(hp);
            //ViewManagement.getInstance().printMsg(
            //        player.getInfo().getName() + "受到" + num + "点伤害");
            player.RefreshView();
        // TODO 如果血量不足，则开始求桃
        hp:
            while (player.GetState().GetCurHP() <= 0)
            {
                // 先求自己
                if (player.GetRequest().RequestYao())
                {
                    player.GetAction().TaoSave(player);
                    if (player.GetState().GetCurHP() > 0)
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
                // 再求其他人
                List<AbstractPlayer> list = player.GetFunction().GetAllPlayers();
                for (int i = 0; i < list.Count(); i++)
                {
                    // 因为有卡死bug，暂时不问凶手求桃
                    // 经研究为swing中的多线程问题 2013-4-5已解决
                    // if(list.get(i)==murderer)continue;
                    if (list.ElementAt(i).GetRequest().RequestYao())
                    {
                        player.GetAction().TaoSave(player);
                        if (player.GetState().GetCurHP() > 0) break;
                    }
                }
                player.GetAction().Dead(murderer);
                return;
            }

            // 调用触发事件
            this.player.GetTrigger().AfterLoseHP(murderer);
            player.RefreshView();
            if (murderer != null)
                murderer.RefreshView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public void LoseHandCard(int num)
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 
        /// </summary>
        public void Magic()
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 玩家动作 -- 杀 参数p为被杀者！ player才是出杀者 2013-3-27曾因混淆出过bug
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Sha(AbstractPlayer p)
        {
            bool flag = false;
            if (!p.GetRequest().RequestShan())
            {
                p.GetAction().LoseHP(1 + player.GetState().GetExtDamage(), player);
                flag = true;
            }
            // 开关
            player.GetState().SetUsedSha(true);
            // 调用触发事件
            player.GetTrigger().AfterSha();
            return flag;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Shan()
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 桃 加1点血
        /// </summary>
        public void Tao()
        {
            player.GetAction().AddHP(1);
            //调用触发
            player.GetTrigger().AfterAddHP();
        }

        /// <summary>
        /// 卸载装备
        /// </summary>
        /// <param name="c"></param>
        public void UnloadEquipmentCard(AbstractCard c)
        {
            AbstractEquipmentCard aec = (AbstractEquipmentCard)c;
            //触发已经在武器卸载中调用
            aec.unload(player);
        }

        /// <summary>
        /// 将指定的牌添加到手牌中
        /// </summary>
        /// <param name="c"></param>
        public void AddCardToHandCard(AbstractCard c)
        {
            //ViewManagement.getInstance().printMsg(
            //        player.getInfo().getName() + "获得了" + c.toString());
            player.GetState().GetCardList().Add(c);
            //触发
            player.GetTrigger().AfterGetHandCard();
        }

        /// <summary>
        /// 牌堆中摸一张
        /// </summary>
        public void AddOneCardFromList()
        {

            //player.getState().GetCardList().add(
            //        ModuleManagement.getInstance().getOneCard());
            //触发
            player.GetTrigger().AfterGetHandCard();
        }

        /// <summary>
        ///  删除指定序列的手牌
        /// </summary>
        /// <param name="index"></param>
        public void RemoveCard(int index)
        {
            player.GetState().GetCardList().RemoveAt(index);
            // 丢失手牌触发
            player.GetTrigger().AfterLoseHandCard();
        }

        /// <summary>
        /// 删除指定的某张牌
        /// </summary>
        /// <param name="c"></param>
        public void RemoveCard(AbstractCard c)
        {
            player.GetState().GetCardList().Remove(c);
            // 丢失手牌触发
            player.GetTrigger().AfterLoseHandCard();
        }

        /// <summary>
        /// 人物死亡
        /// </summary>
        /// <param name="murderer"></param>
        public void Dead(AbstractPlayer murderer)
        {
            //// 全局列表中删除
            //ModuleManagement.getInstance().getPlayerList().remove(player);
            // 设置死亡状态
            player.GetState().SetDead(true);
            player.GetState().SetCurHP(0);
            // 删除手牌
            foreach (AbstractCard c in player.GetState().GetCardList())
            {
                c.Gc();
            }
            player.GetState().GetCardList().Clear();
            // 上下家重置
            player.GetFunction().GetLastPlayer().setNextPlayer(
                    player.GetNextPlayer());
            //检测该人物死亡是否终止游戏
            if (player.GetState().GetId() == EIdentity.ZHUGONG)
            {
                if (GetFanZei() > 0)
                {
                    //Frame_Main.me.gameOver(GameOver.FANZEI_WIN);
                }
                else
                {
                    //Frame_Main.me.gameOver(GameOver.NEIJIAN_WIN);
                }
                return;
            }
            if (player.GetState().GetId() == EIdentity.FANZEI || player.GetState().GetId() == EIdentity.NEIJIAN)
            {
                int alive = GetFanZeiOrNeiJian();
                Console.WriteLine("反贼或内奸还剩：" + alive + "个");
                if (alive == 0)
                {
                    //Frame_Main.me.gameOver(GameOver.ZHUGONG_WIN);
                    return;
                }
            }
            // 死亡触发事件
            player.GetTrigger().AfterDead();
            //死亡后的奖惩
            if (murderer != null)
            {
                // 如果死亡者是反贼 凶手获得3张牌
                if (player.GetState().GetId() == EIdentity.FANZEI)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        murderer.GetAction().AddOneCardFromList();
                    }
                }
                //主公误杀忠臣则掉光所有牌
                if (player.GetState().GetId() == EIdentity.ZHONGCHEN &&
                        murderer.GetState().GetId() == EIdentity.ZHUGONG)
                {
                    murderer.GetState().GetCardList().Clear();
                    murderer.GetState().GetEquipment().RemoveALL();
                    //AISpeakService.sayFuckBoss(player);
                }
                player.RefreshView();
                murderer.RefreshView();
            }
            //如果在回合中死亡，直接跳出回合，下家开始
            if (player.GetStageNum() != EStageState.STAGE_END)
            {
                Console.WriteLine("dead" + Thread.CurrentThread.Name);
                player.GetNextPlayer().Process();
            }
        }

        private int GetFanZeiOrNeiJian()
        {
            int alive = 0;
            //for (AbstractPlayer p : ModuleManagement.getInstance().getPlayerList()) {
            //    if(p.getState().getId()==Identity.FANZEI || p.getState().getId() == Identity.NEIJIAN){
            //        alive++;
            //    }
            //}
            return alive;
        }

        private int GetFanZei()
        {
            int alive = 0;
            //for (AbstractPlayer p : ModuleManagement.getInstance().getPlayerList()) {
            //    if(p.getState().getId()==Identity.FANZEI){
            //        alive++;
            //    }
            //}
            return alive;
        }

        /// <summary>
        /// 桃-救人
        /// </summary>
        /// <param name="p"></param>
        public void TaoSave(AbstractPlayer p)
        {
            player.GetAction().Tao();
            //触发
            player.GetTrigger().AfterAddHP();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShaWithEquipment()
        {
            // TODO Auto-generated method stub

        }


        public void ShaWithSkill()
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 处理判定牌 默认什么都不做返回
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public AbstractCard DealWithCheckCard(AbstractCard c)
        {
            return c;
        }

        /// <summary>
        /// 决斗 如果目标出杀，则返回true
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool JueDou(AbstractPlayer p)
        {
            if (p.GetRequest().RequestSha())
            {
                return true;
            }
            else
            {
                p.GetAction().LoseHP(1 + player.GetState().GetExtDamage(), player);
                return false;
            }
        }

        /// <summary>
        /// 是否回避杀
        /// </summary>
        /// <param name="murder"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool AvoidSha(AbstractPlayer murder, CardSha card)
        {
            return false;
        }

    }
}
