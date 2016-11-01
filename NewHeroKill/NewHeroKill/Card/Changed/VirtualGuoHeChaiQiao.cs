using NewHeroKill.Card.Kit;
using NewHeroKill.Data.Const;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Changed
{
    public class VirtualGuoHeChaiQiao : CardGuoHeChaiQiao, IVirtualCard, IEffectCard
    {
        AbstractCard realCard;

        public VirtualGuoHeChaiQiao(AbstractCard real)
        {
            this.realCard = real;
            this.name = "过河拆桥";
            //this.effectImage = ImgUtil.getPngImgByName("ef_guohechaiqiao");
        }


        public int GetCardType()
        {
            return Const_Game.GUOHECHAIQIAO;
        }


        public override AbstractCard GetRealCard()
        {
            return realCard;
        }

        //使用
        public override void Use(AbstractPlayer p, AbstractPlayer toP)
        {
            Console.WriteLine("过河拆桥线程：" + Thread.CurrentThread.Name);
            //绘制
            DrawEffect(p, toP);
            // 如果无懈，则return
            AskWuXieKeJi(p, null);
            //if (isWuXie) {
            //    ViewManagement.getInstance().printBattleMsg(getName() + "无效");
            //    ViewManagement.getInstance().refreshAll();
            //    return;
            //}
            //SwingUtilities.invokeLater(new Runnable() {
            //    @Override
            //    public void run() {
            //        Panel_Control pc = (Panel_Control)p.getPanel();
            //        Panel_SelectCard ps = new Panel_SelectCard(p, toP,Panel_SelectCard.CHAI);
            //        pc.getMain().add(ps,0);
            //        pc.getHand().unableToUseCard();
            //        ps.setLocation(200,pc.getMain().getHeight()/9);
            //        pc.getMain().validate();
            //    }
            //});

        }

        //绘制
        protected void DrawEffect(AbstractPlayer p, AbstractPlayer toP)
        {
            //ViewManagement.getInstance().printBattleMsg(
            //        p.getInfo().getName() + "对" + toP.getInfo().getName()
            //                + "使用了"+getName());
            //SwingUtilities.invokeLater(new Runnable() {
            //    @Override
            //    public void run() {
            //        if (getEffectImage() != null)
            //            PaintService.drawEffectImage(getEffectImage(), p);
            //            PaintService.drawLine(p, toP);
            //    }
            //});
        }
    }

}
