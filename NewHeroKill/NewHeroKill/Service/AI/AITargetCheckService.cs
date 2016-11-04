using NewHeroKill.Card;
using NewHeroKill.Player;
using System.Collections.Generic;

namespace NewHeroKill.Service.AI
{



    /// <summary>
    /// AI在准备出某张牌的时候进行的可用目标检测
    /// @author user
    /// 
    /// </summary>
    public class AITargetCheckService
    {

        /// <summary>
        /// 根据准备出的牌
        /// 获得可以对其使用的目标列表 </summary>
        /// <param name="player"> </param>
        /// <param name="c">
        /// @return </param>
        public static IList<AbstractPlayer> getEnableTargets(AbstractPlayer player, AbstractCard c)
        {
            IList<AbstractPlayer> list = player.GetFunction().GetAllPlayers();
            IList<AbstractPlayer> result = new List<AbstractPlayer>();
            for (int i = 0; i < list.Count; i++)
            {
                if (c.TargetCheck4SinglePlayer(player, list[i]))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

    }

}