using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Kit
{
    public class CardLeBuSiShu : AbstractKitCard, IDelayKit
    {
        AbstractPlayer owner;
        public CardLeBuSiShu()
        {
        }

        public override void Use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            base.Use(p, players);
            AbstractPlayer target = players.ElementAt(0);
            owner = target;

            ////牌堆收回
            //ModuleManagement.getInstance().getGcList().remove(this);
            //目标判定区添加
            target.GetState().GetCheckedCardList().Add(this);
            p.RefreshView();
            target.RefreshView();
        }

        /// <summary>
        ///  锦囊发动
        /// </summary>
        public override void DoKit()
        {
            //无懈
            AskWuXieKeJi(owner, null);
            if (isWuXie)
            {
                //ViewManagement.getInstance().printBattleMsg(GetName() + "无效");
                //ViewManagement.getInstance().refreshAll();
                owner.GetProcess().SetCanUseCard(true);
                owner.GetState().GetCheckedCardList().Remove(this);
                Gc();
                return;
            }
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
            owner.GetState().GetCheckedCardList().Remove(this);
            Gc();
        }

        public override String GetShowNameInPanel()
        {
            return "乐";
        }


        public override int GetKitCardType()
        {
            return type;
        }


        public override void TargetCheck(Panel_HandCards ph)
        {
            List<Panel_Player> list = ph.getMain().getPlayers();
            foreach (Panel_Player pp in list)
            {
                if (!pp.getPlayer().getState().isDead())
                {
                    if (pp.getPlayer().getState().hasDelayKit(Const_Game.LEBUSISHU))
                    {
                        pp.disableToUse();
                    }
                }
            }
        }
        public AbstractPlayer GetOwner()
        {
            return owner;
        }
        public void SetOwner(AbstractPlayer owner)
        {
            this.owner = owner;
        }

    }

}
