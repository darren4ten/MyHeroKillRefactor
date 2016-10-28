using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerTrigger
    {
        //使用杀触发
        void AfterSha();

        //使用闪触发
        void AfterShan();

        //使用桃触发
        void AfterYao();

        //加血触发
        void AfterAddHP();

        //在掉血之前触发
        void BeforeLoseHP();

        //扣血触发
        void AfterLoseHP(AbstractPlayer murderer);

        //获得手牌触发
        void AfterGetHandCard();

        //丢失手牌触发
        void AfterLoseHandCard();

        //获得装备触发
        void AfterLoadEquipmentCard();

        //丢失装备触发
        void AfterUnloadEquipmentCard();

        //没有手牌触发
        void AfterNoCards();

        // //翻出判定牌后触发
        //  void afterDetermine(AbstractCard c, boolean result);

        //使用锦囊触发
        void AfterMagic();

        //死亡触发
        void AfterDead();
    }
}
