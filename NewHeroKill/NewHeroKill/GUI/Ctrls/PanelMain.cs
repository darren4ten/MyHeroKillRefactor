using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGDI.Ctrls
{
    public class PanelMain
    {

        public static int Width = 660;

        public static int Height = 428;

        public static int HeaderHeight = 36;
        public static int BorderWidth = 8;

        public void Paint(Graphics g)
        {
            var imgBack = Image.FromFile("Img/bg.jpg");

            int x = PanelMain.Width + 2 * PanelMain.BorderWidth;
            int y = PanelMain.Height+ PanelMain.HeaderHeight;


            var rectDest = new Rectangle() { X = 0, Y = 0, Width = x, Height = y };
            var rectSrc = new Rectangle() { X = 0, Y = 0, Width = imgBack.Width, Height = imgBack.Height };
            //600-400
            //()
            g.DrawImage(imgBack, rectDest, rectSrc, GraphicsUnit.Pixel);
            Console.WriteLine("绘制完成:{0},{1}", imgBack.Width, imgBack.Height);
        }
    }
}
