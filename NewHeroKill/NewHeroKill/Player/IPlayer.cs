using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayer
    {	
        /// <summary>
        /// 载入技能
        /// </summary>
        /// <param name="name"></param>
        void LoadSkills(String name);

        /// <summary>
        /// 执行回合
        /// </summary>
        void Process();

        /// <summary>
        /// 刷新关联的面板
        /// </summary>
        void RefreshView();
    }
}
