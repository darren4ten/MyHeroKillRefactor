using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{

    public interface ICard
    {

        ///**
        // * 花色图片的文件名常量
        // */
        //public static const String HEITAO_FN = "color_heitao";
        //public static const String HONGXIN_FN = "color_hongxin";
        //public static const String MEIHUA_FN = "color_meihua";
        //public static const String FANGKUAI_FN = "color_fangkuai";


        /// <summary>
        /// 使用
        /// </summary>
        /// <param name="p"></param>
        /// <param name="players"></param>
        void Use(AbstractPlayer p, List<AbstractPlayer> players);

        /// <summary>
        /// 被动响应使用
        /// </summary>
        /// <param name="p"></param>
        /// <param name="players"></param>
        /// <returns></returns>
        bool RequestUse(AbstractPlayer p, List<AbstractPlayer> players);
        
        /// <summary>
        /// 丢弃
        /// </summary>
        /// <param name="p"></param>
        void ThrowIt(AbstractPlayer p);
       
        /// <summary>
        /// 交给玩家
        /// </summary>
        /// <param name="fromP"></param>
        /// <param name="receiverP"></param>
        void PassToPlayer(AbstractPlayer fromP, AbstractPlayer receiverP);
      
        /// <summary>
        /// 是否需要射程
        /// </summary>
        /// <returns></returns>
        bool IsNeedRange();
    }

}
