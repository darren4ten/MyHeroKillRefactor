using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerProcess
    {
        void start();
        void stage_begin();
        void stage_check();
        void stage_addCards();
        void stage_useCards();
        void stage_throwCrads();
        void stage_end();
        void setSkilling(bool b);
        bool isSkilling();
        void setCanUseCard(bool canAddCard);
    }

}
