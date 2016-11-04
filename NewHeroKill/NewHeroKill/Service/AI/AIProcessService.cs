using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Threading;

namespace NewHeroKill.Service.AI
{
    /// <summary>
    /// AI控制类
    /// 
    /// @author user
    /// 
    /// </summary>
    public class AIProcessService
    {
        internal AbstractPlayer p;
        internal NewHeroKill.Service.UsableCardCheckService check = new NewHeroKill.Service.UsableCardCheckService();
        /// <summary>
        /// 构造器 传入一个人物模型 </summary>
        /// <param name="p"> </param>
        public AIProcessService(AbstractPlayer p)
        {
            this.p = p;
        }

        // 回合开始
        public virtual void stage_begin()
        {
            p.SetStageNum(EStageState.STAGE_BEGIN);
        }

        // 判定阶段
        public virtual void stage_check()
        {
            p.SetStageNum(EStageState.STAGE_CHECK);
        }

        // 摸牌阶段
        public virtual void stage_addCards()
        {
            p.SetStageNum(EStageState.STAGE_ADDCARDS);
            p.GetAction().AddOneCardFromList();
            p.GetAction().AddOneCardFromList();
            p.Panel.refresh();
        }

        /// <summary>
        ///  出牌阶段
        ///  随机取1张能用的手牌，检测是否能用，若可用则下一步
        ///  判断牌的使用每目标类型，如果是要选择的，则建立一个可选玩家集合，若该集合非空，则随机选一个；
        ///  TODO
        /// </summary>
        public virtual void stage_useCards()
        {
            p.SetStageNum(EStageState.STAGE_USECARDS);

            Thread.Sleep(1500);

            //测试阶段 目标暂时设置为下家
            //List<AbstractPlayer> list = new ArrayList<AbstractPlayer>();
            //测试AI目标检测函数
            /*List<AbstractPlayer> list = AITargetCheckService.getEnableTargets(player, c)
			
            list.add(p.getNextPlayer());*/
            //获取1张可用的牌
            IList<AbstractCard> listA = check.getAvailableCard(p.GetState().GetCardList(), p);
            AbstractCard c = null;
            if (listA.Count > 0)
            {
                int index = (new Random()).Next(listA.Count);
                c = listA[index];
                //listA.get(index).use(p, list);
                //p.getState().getCardList().remove(listA.get(index));
                IList<AbstractPlayer> listTargets = AITargetCheckService.getEnableTargets(p, c);
                if (listTargets.Count == 0)
                {
                    return;
                }
                IList<AbstractPlayer> listArgs = new List<AbstractPlayer>();
                listArgs.Add(listTargets[(new Random()).Next(listTargets.Count)]);
                c.Use(p, listArgs);
            }
        }

        // 弃牌阶段
        public virtual void stage_throwCrads()
        {

            Thread.Sleep(500);
            p.SetStageNum(EStageState.STAGE_THROWCRADS);
            Console.WriteLine(p.GetState().GetId().ToString() + p.GetInfo().GetName() + "弃牌");
            while (p.GetState().GetCardList().Count > p.GetState().GetCurHP())
            {
                p.GetState().GetCardList()[0].throwIt(p);
            }
            p.Panel.refresh();

        }

        // 回合结束
        public virtual void stage_end()
        {
            p.SetStageNum(EStageState.STAGE_END);
            //ViewManagement.getInstance().printMsg(p.getState().getId().toString()+p.getInfo().getName()+"结束");
            Console.WriteLine(p.GetState().GetId().ToString() + p.GetInfo().GetName() + "结束");
        }

    }

}