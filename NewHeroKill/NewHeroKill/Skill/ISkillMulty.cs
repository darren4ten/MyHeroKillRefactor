using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Skill
{
    /// <summary>
    /// 技能类多重效果的接口
    /// 主要针对一个类中出现多个技能实现的情况
    /// 比如郭嘉的两个技能，都是写在触发类中的
    /// </summary>
    public interface ISkillMulty
    {
        //获取技能名称列表
        List<String> GetNameList();
    }
}
