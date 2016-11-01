using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Equipment
{
    public abstract class AbstractWeaponCard : AbstractEquipmentCard
         , IWeaponCard
    {

        public AbstractWeaponCard()
            : base()
        {

        }

        public AbstractWeaponCard(int id, int number, ECardColorTypes color)
            : base(id, number, color)
        {

        }

        /// <summary>
        /// 带装备出杀 包含一系列流程 各个子类武器将重写其中的部分的流程 来实现其技能特效
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <param name="card"></param>
        public void ShaWithEquipment(AbstractPlayer p, AbstractPlayer target,
                AbstractCard card)
        {
            // 杀结算之前的触发技能
            UseSkillBeforeSha(p, target);
            // 如果对方有防具且判定为生效则返回
            if (CheckArmor(p, target))
            {
                FalseTrigger(p, target);
                return;
            }
            // 造成伤害或者被闪掉调用对应的触发事件
            if (CallSha(p, target))
            {
                DamageTrigger(p, target);
            }
            else
            {
                Console.WriteLine("chufa");
                FalseTrigger(p, target);
            }
            // 结算完后的触发事件
            AfterSha(p, target);

        }

        public override void AfterSha(AbstractPlayer p, AbstractPlayer target)
        {
            // TODO Auto-generated method stub

        }

        public bool CallSha(AbstractPlayer p, AbstractPlayer target)
        {
            return p.GetAction().Sha(target);
        }

        /// <summary>
        /// 防具判定
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool CheckArmor(AbstractPlayer p, AbstractPlayer target)
        {
            // 判定防具
            IArmor am = (IArmor)target.GetState().GetEquipment().GetArmor();
            if (am == null || !am.Check(this, target))
            {
                return false;
            }
            return true;
        }


        public override void DamageTrigger(AbstractPlayer p, AbstractPlayer target)
        {
            // TODO Auto-generated method stub

        }

        public override void FalseTrigger(AbstractPlayer p, AbstractPlayer target)
        {
            // TODO Auto-generated method stub

        }

        public override void UseSkillBeforeSha(AbstractPlayer p, AbstractPlayer target)
        {
            // TODO Auto-generated method stub

        }
    }
}
