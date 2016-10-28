using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerTrigger
    {
        /// <summary>
        /// 使用杀触发
        /// </summary>
        void AfterSha();

        /// <summary>
        /// 使用闪触发
        /// </summary>
        void AfterShan();

        /// <summary>
        /// 使用桃触发
        /// </summary>
        void AfterYao();

        /// <summary>
        /// 加血触发
        /// </summary>
        void AfterAddHP();

        /// <summary>
        /// 在掉血之前触发
        /// </summary>
        void BeforeLoseHP();

        /// <summary>
        /// 扣血触发
        /// </summary>
        /// <param name="murderer"></param>
        void AfterLoseHP(AbstractPlayer murderer);

        /// <summary>
        /// 获得手牌触发
        /// </summary>
        void AfterGetHandCard();

        /// <summary>
        /// 丢失手牌触发
        /// </summary>
        void AfterLoseHandCard();

        /// <summary>
        /// 获得装备触发
        /// </summary>
        void AfterLoadEquipmentCard();

        /// <summary>
        /// 丢失装备触发
        /// </summary>
        void AfterUnloadEquipmentCard();

        /// <summary>
        /// 没有手牌触发
        /// </summary>
        void AfterNoCards();

        // //翻出判定牌后触发
        //  void afterDetermine(AbstractCard c, boolean result);

        /// <summary>
        /// 使用锦囊触发
        /// </summary>
        void AfterMagic();

        /// <summary>
        /// 死亡触发
        /// </summary>
        void AfterDead();
    }
}
