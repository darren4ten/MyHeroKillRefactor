using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Data.Const
{
    public class Const_UI
    {

        //窗体的宽度和高度以及坐标
        public static int FRAME_WIDTH = 1000;
        public static int FRAME_HEIGHT = 700;

        //代理对象图像的宽度和高度

        public static int PROXYWIDTH = 160;
        public static int PROXYHEIGHT = 200;
        //牌的高度和宽度
        public static int CARD_WIDTH = 100;
        public static int CARD_HEIGHT = 200;

        //牌抬起的高度
        public static int CARD_UP = 50;

        //人物版面的宽度和高度
        public static int PLAYER_PANEL_WIDTH = 170;
        public static int PLAYER_PANEL_HEIGHT = 200;

        //血条面板的宽度和长度
        public static int HPPANEL_WIDTH = 20;
        public static int HPPANEL_HEIGHT = 120;

        //确定取消弃牌按钮的偏移量
        public static int BUTTON_OFFSET = 30;
        public static int BUTTON_OFFSET_SKIP = 50;

        //组件不可用时的透明度
        public static float PANEL_UNABLE = .3f;
        public static float CARD_UNABLE = .5f;

    }
}
