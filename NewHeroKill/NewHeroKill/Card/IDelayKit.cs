using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    public interface IDelayKit
    {
        //发动技能
        void DoKit();

        //获取锦囊类型
        int GetKitCardType();

        //获取面板显示字符
        String GetShowNameInPanel();
    }
}
