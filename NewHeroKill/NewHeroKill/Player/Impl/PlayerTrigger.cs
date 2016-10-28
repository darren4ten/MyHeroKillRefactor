using NewHeroKill.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    public class PlayerTrigger : IPlayerTrigger
    {
        //人物模型
        protected AbstractPlayer player;

        public PlayerTrigger() { }
        //构造器
        public PlayerTrigger(AbstractPlayer p)
        {
            this.player = p;
        }

        public void AfterAddHP()
        {
            // TODO Auto-generated method stub

        }

        public void AfterGetHandCard()
        {
            // TODO Auto-generated method stub

        }

        public void AfterLoadEquipmentCard()
        {
            // TODO Auto-generated method stub

        }

        public void AfterLoseHP(AbstractPlayer murderer)
        {
            // TODO Auto-generated method stub

        }

        public void AfterLoseHandCard()
        {
            // TODO Auto-generated method stub

        }

        public void AfterMagic()
        {
            // TODO Auto-generated method stub

        }
        /// <summary>
        /// 杀后触发
        /// 默认开关关闭
        /// </summary>
        public void AfterSha()
        {
            player.GetState().SetUsedSha(true);
        }

        public void AfterShan()
        {
            // TODO Auto-generated method stub

        }

        public void AfterTao()
        {
            // TODO Auto-generated method stub

        }

        public void AfterUnloadEquipmentCard()
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 死亡触发
        /// </summary>
        public void AfterDead()
        {
            // TODO Auto-generated method stub

        }

        public void AfterNullCards()
        {
            // TODO Auto-generated method stub

        }

        /// <summary>
        /// 判定触发
        /// 参数1：判定牌
        /// 参数2：判定结果
        /// </summary>
        /// <param name="c"></param>
        /// <param name="result"></param>
        public void afterCheck(AbstractCard c, bool result)
        {
            c.Gc();
        }

    }

}
