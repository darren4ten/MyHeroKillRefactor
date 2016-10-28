using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    /// <summary>
    /// 装备牌
    /// </summary>
    public interface IEquipmentCard
    {
        /// <summary>
        /// 装载
        /// </summary>
        /// <param name="p"></param>
        void Load(AbstractPlayer p);

        /// <summary>
        /// 卸载
        /// </summary>
        /// <param name="p"></param>
        void Unload(AbstractPlayer p);

        /// <summary>
        /// 获取攻击距离
        /// </summary>
        /// <returns></returns>
        int GetAttDistance();

       /// <summary>
        /// 获取防御距离
       /// </summary>
       /// <returns></returns>
        int GetDefDistance();

        /// <summary>
        /// 获取装备类型
        /// </summary>
        /// <returns></returns>
        EEquipmentType GetEquipmentType();

        /// <summary>
        /// 回合初始化
        /// </summary>
        void BeginInit();
    }
}
