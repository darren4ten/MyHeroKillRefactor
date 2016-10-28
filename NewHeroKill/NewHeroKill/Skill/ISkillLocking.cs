using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Skill
{
    /// <summary>
    /// 锁定技能
    /// </summary>
    public interface ISkillLocking
    {
        /// <summary>
        /// 获取名称
        /// </summary>
        /// <returns></returns>
        String GetName();
    }
}
