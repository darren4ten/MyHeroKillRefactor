using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player
{
    public interface IPlayerRequest
    {
        /// <summary>
        /// 询问是否打出一张手牌
        /// </summary>
        /// <returns></returns>
        bool RequestOneCard();

        /// <summary>
        /// 询问是否出杀
        /// </summary>
        /// <returns></returns>
        bool RequestSha();

        /// <summary>
        /// 询问是否出闪
        /// </summary>
        /// <returns></returns>
        bool RequestShan();

        /// <summary>
        /// 询问是否出桃
        /// </summary>
        /// <returns></returns>
        bool RequestYao();

        /// <summary>
        /// 询问是否出无懈
        /// </summary>
        /// <returns></returns>
        bool RequestWuXie();

        /// <summary>
        /// 获取当前响应牌型
        /// </summary>
        /// <returns></returns>
        int GetCurType();

        /// <summary>
        /// 设置当前响应牌型
        /// </summary>
        /// <param name="curType"></param>
        void SetCurType(int curType);

        /// <summary>
        /// 清空状态
        /// </summary>
        void Clear();
    }
}
