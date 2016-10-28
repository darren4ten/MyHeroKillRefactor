using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayer
    {	
        //载入技能
        void LoadSkills(String name);
        //执行回合
        void Process();
        //刷新关联的面板
        void RefreshView();
    }
}
