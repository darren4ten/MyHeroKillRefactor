using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    public interface IWeaponCard
    {//带武器出杀，包含以下几个流程
        void ShaWithEquipment(AbstractPlayer p, AbstractPlayer target, AbstractCard card);

        //杀前的技能
        void UseSkillBeforeSha(AbstractPlayer p, AbstractPlayer target);
        //对方防具判定
        bool CheckArmor(AbstractPlayer p, AbstractPlayer target);
        //调用人物的杀
        bool CallSha(AbstractPlayer p, AbstractPlayer target);
        //如果杀成功触发
        void DamageTrigger(AbstractPlayer p, AbstractPlayer target);
        //如果被闪触发
        void FalseTrigger(AbstractPlayer p, AbstractPlayer target);
        //杀完后的触发
        void AfterSha(AbstractPlayer p, AbstractPlayer target);

    }
}
