using NewHeroKill.Player;
using NewHeroKill.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKillPure.Skill.Process
{
    public class ZuijiuSkill : ISkill, IPlayerProcess
    {
        private AbstractPlayer player;
        public ZuijiuSkill(AbstractPlayer player)
        {
            this.player = player;
        }
        public void Start()
        {
        }

        public void Stage_begin()
        {
        }

        public void Stage_check()
        {
        }

        public void Stage_addCards()
        {
            //AI操作
            if (player.GetState().IsAI())
            {
                if (player.GetInfo().GetName() == "")
                {

                }
            }
        }

        public void Stage_useCards()
        {
        }

        public void Stage_throwCrads()
        {
        }

        public void Stage_end()
        {
        }

        public void SetSkilling(bool b)
        {
        }

        public bool IsSkilling()
        {
            return false;
        }

        public void SetCanUseCard(bool canAddCard)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool IsEnableUse()
        {
            return false;
        }

        public string GetName()
        {
            return "醉酒";
        }
    }
}
