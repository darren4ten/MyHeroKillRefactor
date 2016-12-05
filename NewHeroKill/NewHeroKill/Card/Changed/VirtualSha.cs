using NewHeroKill.Card.Base;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Changed
{
    /// <summary>
    /// 虚拟的【杀】
    /// </summary>
    public class VirtualSha : IVirtualCard
    {
        AbstractCard realCard;
        public VirtualSha(AbstractCard realCard)
        {
            this.realCard = realCard;
        }

        /// <summary>
        /// 虚拟牌的使用
        /// </summary>
        /// <param name="p"></param>
        /// <param name="toP"></param>
        public void Use(AbstractPlayer p, AbstractPlayer toP)
        {
            CardSha cs = new CardSha();
            //// 调用杀
            //ViewManagement.getInstance().printBattleMsg(
            //        p.getInfo().getName() + "对" + toP.getInfo().getName()
            //        + "使用了杀" );
            //try {
            //    SwingUtilities.invokeAndWait(new Runnable() {
            //        @Override
            //        public void run() {
            //            p.refreshView();
            //            PaintService.drawEffectImage(cs.getEffectImage(),p);
            //            PaintService.drawLine(p,toP);
            //        }
            //    });
            //} catch (InterruptedException e) {
            //    e.printStackTrace();
            //} catch (InvocationTargetException e) {
            //    e.printStackTrace();
            //}
            cs.ExecuteSha(p, toP);
        }

        public int GetCardType()
        {
            // TODO Auto-generated method stub
            return 0;
        }


        public AbstractCard GetRealCard()
        {
            return realCard;
        }

    }

}
