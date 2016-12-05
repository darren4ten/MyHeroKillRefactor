using NewHeroKill.Data.Const;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Changed
{
    public class ComboSha : IComboCard
    {
        List<AbstractCard> realCardList;
        public ComboSha(List<AbstractCard> list)
        {
            this.realCardList = list;
        }


        public int GetCardType()
        {
            return Const_Game.SHA;
        }


        public List<AbstractCard> getRealCards()
        {
            return realCardList;
        }


        public void use(AbstractPlayer p, AbstractPlayer toP)
        {
        }



        public List<AbstractCard> GetRealCards()
        {
            throw new NotImplementedException();
        }

        public void Use(AbstractPlayer p, AbstractPlayer toP)
        {
            throw new NotImplementedException();
        }
    }

}
