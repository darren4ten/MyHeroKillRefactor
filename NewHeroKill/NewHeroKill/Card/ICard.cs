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

        /**
         * 花色图片的文件名常量
         */
        public static const String HEITAO_FN = "color_heitao";
        public static const String HONGXIN_FN = "color_hongxin";
        public static const String MEIHUA_FN = "color_meihua";
        public static const String FANGKUAI_FN = "color_fangkuai";

        /**
         * 使用目标类型
         * 
         */
        public static const int AOE = 0;
        public static const int SELECT = 1;
        public static const int NONE = 2;


        /**
         *  使用
         * 
         */
        void Use(AbstractPlayer p, List<AbstractPlayer> players);
        /**
         * 被动响应使用
         */
        bool RequestUse(AbstractPlayer p, List<AbstractPlayer> players);
        /**
         * 丢弃
         */
        void ThrowIt(AbstractPlayer p);
        /**
         * 交给玩家
         */
        void PassToPlayer(AbstractPlayer fromP, AbstractPlayer receiverP);
        /**
         * 是否需要射程
         */
        bool IsNeedRange();
    }

}
