using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Data.Enums
{
    /// <summary>
    /// 6阶段状态常量
    /// 用以表示玩家处于哪个阶段
    /// </summary>
    public enum EStageState
    {
        STAGE_BEGIN = 1,
        STAGE_CHECK = 2,
        STAGE_ADDCARDS = 3,
        STAGE_USECARDS = 4,
        STAGE_THROWCRADS = 5,
        STAGE_END = 6
    }
}
