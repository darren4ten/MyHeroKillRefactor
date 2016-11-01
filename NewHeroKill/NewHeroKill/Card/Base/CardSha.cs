using NewHeroKill.Card.Equipment;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Base
{
    public class CardSha : AbstractCard, IEffectCard
    {

        public CardSha()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AbstractPlayer"></param>
        public override void Use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            base.Use(p, players);
            Console.WriteLine("目标数：" + players.Count());
            List<AbstractPlayer> list = new List<AbstractPlayer>(players);
            for (int i = 0; i < list.Count(); i++)
            {
                AbstractPlayer tmp = list[i];
                //// 绘制杀的效果
                //ViewManagement.getInstance().printBattleMsg(
                //        p.getInfo().getName() + "对" + tmp.getInfo().getName()
                //        + "使用了杀" );
                //try {
                //    SwingUtilities.invokeAndWait(new Runnable() {
                //        @Override
                //        public void run() {
                //            p.refreshView();
                //            PaintService.drawEffectImage(getEffectImage(),p);
                //            PaintService.drawLine(p,tmp);
                //        }
                //    });
                //} catch (InterruptedException e) {
                //    e.printStackTrace();
                //} catch (InvocationTargetException e) {
                //    e.printStackTrace();
                //}
                ////drawEffect(p, players);
                ExecuteSha(p, tmp);
                // 刷新
                tmp.RefreshView();

            }
            // ViewManagement.getInstance().refreshAll();
        }

        /// <summary>
        /// 执行杀牌的杀流程
        /// </summary>
        /// <param name="p"></param>
        /// <param name="toP"></param>
        public void ExecuteSha(AbstractPlayer p, AbstractPlayer toP)
        {
            if (!toP.GetAction().AvoidSha(p, this))
            {
                // 如果使用者带武器，则调用武器的杀
                AbstractWeaponCard awc = (AbstractWeaponCard)p.GetState()
                        .GetEquipment().GetWeapons();
                if (awc != null)
                {
                    awc.ShaWithEquipment(p, toP, this);
                }
                else
                {
                    // 判定防具
                    IArmor am = (IArmor)toP.GetState().GetEquipment().GetArmor();
                    if (am == null || !am.Check(this, toP))
                    {
                        p.GetAction().Sha(toP);
                    }
                }
            }
            p.RefreshView();
        }

        /// <summary>
        /// 使用目标检测
        /// </summary>
        /// <param name="ph"></param>
        public void TargetCheck(Panel_HandCards ph)
        {

            // 遍历 检测
            List<Panel_Player> list = ph.getMain().getPlayers();
            for (int i = 0; i < list.Count(); i++)
            {
                Panel_Player pp = list.ElementAt(i);
                //如果死亡
                if (pp.getPanelState() == Panel_Player.DEAD || pp.getPanelState() == Panel_Player.DISABLE)
                {
                    Console.WriteLine("this is dead");
                    continue;
                }
                // 如果需要射程
                if (!this.IsInRange(ph.getPlayer(), pp.getPlayer()))
                {
                    pp.disableToUse();
                    continue;
                }
                pp.enableToUse();
            }

        }

        /// <summary>
        /// 判断user是否能对target使用这张牌
        /// </summary>
        /// <param name="user"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public override bool TargetCheck4SinglePlayer(AbstractPlayer user,
                AbstractPlayer target)
        {
            bool b = !user.GetState().IsUsedSha();
            bool b2 = IsInRange(user, target);
            return b && b2;
        }

    }

}
