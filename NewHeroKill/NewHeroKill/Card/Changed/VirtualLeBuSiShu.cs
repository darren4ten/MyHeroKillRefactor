using NewHeroKill.Card.Kit;
using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Changed
{
    public class VirtualLeBuSiShu : CardLeBuSiShu, IVirtualCard, IDelayKit
    {
        AbstractCard realCard;

        AbstractPlayer owner;
        public VirtualLeBuSiShu(AbstractCard real)
        {
            this.realCard = real;
        }

        public override int getCardType()
        {
            // TODO Auto-generated method stub
            return 0;
        }
        public override AbstractCard getRealCard()
        {
            return realCard;
        }

        public override void use(AbstractPlayer p, AbstractPlayer toP)
        {
            //final AbstractPlayer target = players.get(0);
            owner = toP;
            //显示信息及绘制等效果
            //ViewManagement.getInstance().printBattleMsg(p.GetInfo().GetName()+"对"+toP.GetInfo().GetName()+"使用了【国色】");
            //try {
            //    SwingUtilities.invokeAndWait(new Runnable() {

            //        //@Override
            //        public void run() {
            //            PaintService.drawLine(p, toP);
            //        }
            //    });
            //} catch (InterruptedException e) {
            //    e.printStackTrace();
            //} catch (InvocationTargetException e) {
            //    e.printStackTrace();
            //}
            ////牌堆收回
            //ModuleManagement.getInstance().getGcList().remove(this);
            //目标判定区添加
            toP.GetState().GetCheckedCardList().Add(this);
            p.RefreshView();
            toP.RefreshView();
        }


        public override void DoKit()
        {
            //AbstractCard cc = ModuleManagement.getInstance().showOneCheckCard();
            //bool flag = owner.GetFunction().CheckRollCard(cc, ECardColorTypes.HONGXIN);
            //try {
            //    Thread.Sleep(1500);
            //} catch (InterruptedException e) {
            //    e.printStackTrace();
            //}
            //if(flag){			
            //    ViewManagement.getInstance().printBattleMsg(getName()+"失效");
            //}else{
            //    ViewManagement.getInstance().printBattleMsg(getName()+"生效");
            //}
            //owner.GetProcess().SetCanUseCard(flag);
            //owner.GetState().GetCheckedCardList().Remove(this);
        }

        public int GetKitCardType()
        {
            return Const_Game.LEBUSISHU;
        }


        public override String GetShowNameInPanel()
        {
            return "乐";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Image ShowImg()
        {
            // TODO Auto-generated method stub
            return null;
        }

        public String GetName()
        {
            return "乐不思蜀";
        }
    }

}
