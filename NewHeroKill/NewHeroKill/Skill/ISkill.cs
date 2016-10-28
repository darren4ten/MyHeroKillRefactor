using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Skill
{
    public interface ISkill
    {
        /// <summary>
        /// 技能初始化
        /// </summary>
        void Init();

        /// <summary>
        /// 技能使用允许
        /// </summary>
        /// <returns></returns>
        bool IsEnableUse();

        /// <summary>
        /// 获取技能名称
        /// </summary>
        /// <returns></returns>
        String GetName();
    }

}
