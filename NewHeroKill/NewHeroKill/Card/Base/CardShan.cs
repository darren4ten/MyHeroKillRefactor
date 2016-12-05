using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Base
{
    public class CardShan : AbstractCard, IEffectCard
    {
        public CardShan()
        {

        }
        /// <summary>
        /// 响应使用
        /// </summary>
        /// <param name="p"></param>
        /// <param name="players"></param>
        /// <returns></returns>
        public bool RequestUse(AbstractPlayer p, List<AbstractPlayer> players)
        {
            bool flag = base.RequestUse(p, players);
            DrawEffect(p, players);
            return flag;
        }

        /// <summary>
        /// 重写绘制效果
        /// </summary>
        /// <param name="AbstractPlayer"></param>
        protected  void DrawEffect(AbstractPlayer p,
                List<AbstractPlayer> players)
        {
           
        }
    }
}
