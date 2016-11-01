using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Base
{
    public class CardTao : AbstractCard, IEffectCard
    {
        public CardTao()
        {

        }
        public CardTao(int id, int number, ECardColorTypes color)
            : base(id, number, color)
        {

            this.name = "桃";
            this.type = Const_Game.TAO;
            this.targetType = ETargetType.NONE;
        }

        public Image ShowImg()
        {
            //return ImgUtil.getPngImgByName("ktao");
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="players"></param>
        public override void use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            base.Use(p, players);
            //// TODO Auto-generated method stub
            //ViewManagement.getInstance().printBattleMsg(p.getInfo().getName()+"使用了桃");
            p.GetAction().Tao();
            p.getPanel().refresh();
        }


        protected override void DrawEffect(AbstractPlayer p, List<AbstractPlayer> players)
        {
            //try {
            //    SwingUtilities.invokeAndWait(new Runnable() {

            //        @Override
            //        public void run() {
            //            PaintService.drawEffectImage(getEffectImage(), p);
            //            PaintService.clearAfter(1000);
            //        }
            //    });
            //} catch (InterruptedException e) {
            //    // TODO Auto-generated catch block
            //    e.printStackTrace();
            //} catch (InvocationTargetException e) {
            //    // TODO Auto-generated catch block
            //    e.printStackTrace();
            //}
        }


        public override Image GetEffectImage()
        {
            //return ImgUtil.getPngImgByName("ef_tao");
            return null;
        }
    }

}
