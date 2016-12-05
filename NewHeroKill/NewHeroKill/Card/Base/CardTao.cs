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
    public class CardTao : AbstractCard
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
        public new void Use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            base.Use(p, players);

        }


        protected new void DrawEffect(AbstractPlayer p, List<AbstractPlayer> players)
        {

        }


    }

}
