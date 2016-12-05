using NewHeroKill.Card.Equipment;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Base
{
    public class CardSha : AbstractCard
    {

        public CardSha()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AbstractPlayer"></param>
        public void Use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            base.Use(p, players);
            Console.WriteLine("目标数：" + players.Count());
            List<AbstractPlayer> list = new List<AbstractPlayer>(players);
            for (int i = 0; i < list.Count(); i++)
            {
                AbstractPlayer tmp = list[i];


            }
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
        public void TargetCheck(GameObject ph)
        {



        }

        /// <summary>
        /// 判断user是否能对target使用这张牌
        /// </summary>
        /// <param name="user"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public new bool TargetCheck4SinglePlayer(AbstractPlayer user,
                AbstractPlayer target)
        {
            bool b = !user.GetState().IsUsedSha();
            bool b2 = IsInRange(user, target);
            return b && b2;
        }

    }

}
