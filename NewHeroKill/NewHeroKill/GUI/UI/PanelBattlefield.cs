using NewHeroKill.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.UI
{
    public class PanelBattlefield : Panel
    {
        //已经打出的所有牌
        List<AbstractCard> _handoutCards = new List<AbstractCard>();
        //正在显示的牌数组
        List<AbstractCard> _onshowingCards = new List<AbstractCard>();
        /// <summary>
        /// 向战场中打一张牌
        /// </summary>
        /// <param name="cardsList"></param>
        public void AddCards(List<AbstractCard> cardsList)
        {

        }

        /// <summary>
        /// 清理战场
        /// </summary>
        public void ClearBattlefield()
        {

        }

        /// <summary>
        /// 绘制战场图
        /// </summary>
        public void ShowBattlefield()
        {

        }
    }
}
