using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerProcess
    {
        void Start();
        void Stage_begin();
        void Stage_check();
        void Stage_addCards();
        void Stage_useCards();
        void Stage_throwCrads();
        void Stage_end();
        void SetSkilling(bool b);
        bool IsSkilling();
        void SetCanUseCard(bool canAddCard);
    }

}
