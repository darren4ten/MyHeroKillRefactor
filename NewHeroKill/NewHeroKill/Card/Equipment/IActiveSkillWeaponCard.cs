using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Equipment
{
    /// <summary>
    /// 激活技能
    /// </summary>
    public interface IActiveSkillWeaponCard
    {
        //点击使用技能
        bool OnClick_open(GameObject ph);
        //点击关闭
        bool OnClick_close(GameObject ph);
        //开启
        void Enable();
        //关闭
        void Disable();
    }

}
