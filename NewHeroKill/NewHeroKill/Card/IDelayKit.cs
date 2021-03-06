﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    public interface IDelayKit
    {
        /// <summary>
        /// 发动技能
        /// </summary>
        void DoKit();

        /// <summary>
        /// 获取锦囊类型
        /// </summary>
        /// <returns></returns>
        int GetKitCardType();

        /// <summary>
        /// 获取面板显示字符
        /// </summary>
        /// <returns></returns>
        String GetShowNameInPanel();
    }
}
