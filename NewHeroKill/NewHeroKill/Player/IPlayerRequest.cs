using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerRequest
    {
        //询问是否打出一张手牌
        bool RequestOneCard();

        //询问是否出杀
        bool RequestSha();

        //询问是否出闪
        bool RequestShan();

        //询问是否出桃
        bool RequestYao();

        //询问是否出无懈
        bool RequestWuXie();

        //获取当前响应牌型
        int GetCurType();

        //设置当前响应牌型
        void SetCurType(int curType);

        //清空状态
        void Clear();
    }
}
