using NewHeroKill.Card;
using NewHeroKill.Player;
using System.Collections.Generic;

namespace NewHeroKill.Service.AI
{



    /// <summary>
    /// AI��׼����ĳ���Ƶ�ʱ����еĿ���Ŀ����
    /// @author user
    /// 
    /// </summary>
    public class AITargetCheckService
    {

        /// <summary>
        /// ����׼��������
        /// ��ÿ��Զ���ʹ�õ�Ŀ���б� </summary>
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