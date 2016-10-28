using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    public interface IWeaponCard
    {
        /// <summary>
        /// 带武器出杀，包含以下几个流程
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <param name="card"></param>
        void ShaWithEquipment(AbstractPlayer p, AbstractPlayer target, AbstractCard card);

        /// <summary>
        /// 杀前的技能
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        void UseSkillBeforeSha(AbstractPlayer p, AbstractPlayer target);

        /// <summary>
        /// 对方防具判定
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        bool CheckArmor(AbstractPlayer p, AbstractPlayer target);

        /// <summary>
        /// 调用人物的杀
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        bool CallSha(AbstractPlayer p, AbstractPlayer target);

        /// <summary>
        /// 如果杀成功触发
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        void DamageTrigger(AbstractPlayer p, AbstractPlayer target);

        /// <summary>
        /// 如果被闪触发
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        void FalseTrigger(AbstractPlayer p, AbstractPlayer target);

        /// <summary>
        /// 杀完后的触发
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        void AfterSha(AbstractPlayer p, AbstractPlayer target);

    }
}
