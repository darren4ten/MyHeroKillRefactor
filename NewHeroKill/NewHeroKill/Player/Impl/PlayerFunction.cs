using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{

    /// <summary>
    /// 封装了玩家的一些通用操作函数
    /// </summary>
    public class PlayerFunction : IPlayerFunction
    {
        AbstractPlayer player;
        public PlayerFunction(AbstractPlayer player)
        {
            this.player = player;
        }

        /// <summary>
        /// 获取上家
        /// </summary>
        /// <returns></returns>
        public AbstractPlayer GetLastPlayer()
        {
            AbstractPlayer p = player;
            while (p.GetNextPlayer() != player)
            {
                p = p.GetNextPlayer();
            }
            return p;
        }

        /// <summary>
        /// 是否满血
        /// </summary>
        /// <returns></returns>
        public bool IsFullHP()
        {
            return (player.GetState().getCurHP() == player.GetInfo().getMaxHP());
        }

        /// <summary>
        /// 没血
        /// </summary>
        public void IsNullHP()
        {

        }

        /// <summary>
        /// 计算两个玩家之间的距离
        /// 两者各按逆时针计算，取最小值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetDistance(AbstractPlayer p)
        {
            AbstractPlayer pNext = player.GetNextPlayer();
            int i = 1;
            int j = 1;
            while (pNext != p)
            {
                i++;
                pNext = pNext.GetNextPlayer();
            }
            pNext = p.GetNextPlayer();
            while (pNext != player)
            {
                j++;
                pNext = pNext.GetNextPlayer();
            }
            return i <= j ? i : j;
        }

        /// <summary>
        /// 获取场上全部玩家
        /// </summary>
        /// <returns></returns>
        public List<AbstractPlayer> GetAllPlayers()
        {
            List<AbstractPlayer> list = new List<AbstractPlayer>();
            AbstractPlayer p = player.GetNextPlayer();
            while (p != player)
            {
                list.Add(p);
                p = p.GetNextPlayer();
            }
            return list;
        }

        /// <summary>
        /// 获取场上玩家所有手牌
        /// </summary>
        /// <returns></returns>
        public List<String> GetAllPlayersHandCard()
        {
            List<String> listRes = new List<String>();
            //List<AbstractPlayer> list = getAllPlayers();
            //for (int i = 0; i < list.Count(); i++) {
            //    StringBuilder sb = new StringBuilder(list.get(i).getInfo().getName()+":");
            //    for (int j = 0; j < list.get(i).getState().getCardList().size(); j++) {
            //        String s =  list.get(i).getState().getCardList().get(j).toString();
            //        sb.append(s+",");
            //    }
            //    listRes.add(new String(sb));
            //}
            return listRes;
        }

        /// <summary>
        /// 获取攻击距离 
        /// </summary>
        /// <returns></returns>
        public int GetAttackDistance()
        {
            return player.GetState().GetAttDistance();
        }

        /// <summary>
        /// 获取防守距离 
        /// </summary>
        /// <returns></returns>
        public int GetDefenceDistance()
        {
            return player.GetState().GetDefDistance();
        }

        /// <summary>
        /// 锦囊使用距离
        /// 默认与攻击距离相同
        /// </summary>
        /// <returns></returns>
        public int GetKitUseDistance()
        {
            return GetAttackDistance();
        }

        /// <summary>
        /// 翻一张牌判定花色
        /// </summary>
        /// <param name="card"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public bool CheckRollCard(AbstractCard card, List<ECardColorTypes> colors)
        {
            bool result = false;
            for (int i = 0; i < colors.Count; i++)
            {
                if (card.getColor() == colors[i])
                {
                    result = true;
                    break;
                }
            }
            //判定牌触发
            player.GetTrigger().afterCheck(card, result);
            return result;
        }

        /// <summary>
        /// 翻一张牌判定数值
        /// </summary>
        /// <param name="card"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public bool CheckRollCard(AbstractCard card, int max, int min)
        {
            int n = card.GetNumber();
            return n >= min && n <= max;
        }

        /// <summary>
        /// 检测是否在使用范围内
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsInRange(AbstractPlayer target)
        {
            int p2p = GetDistance(target);
            int att = GetAttackDistance();
            int def = GetDefenceDistance();
            return (att - def) >= p2p;

        }
        /// <summary>
        /// 是否同一国家
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsSameCountry(AbstractPlayer target)
        {
            return player.GetInfo().getCountry() == target.GetInfo().getCountry();
        }

        /// <summary>
        /// 是否同性
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool IsSameSex(AbstractPlayer target)
        {
            return player.GetInfo().sex == target.GetInfo().sex;
        }

    }
}
