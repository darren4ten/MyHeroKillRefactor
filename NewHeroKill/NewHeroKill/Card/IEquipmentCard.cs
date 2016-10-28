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
        //装载
        void Load(AbstractPlayer p);
        //卸载
        void Unload(AbstractPlayer p);
        //获取攻击距离
        int GetAttDistance();
        //获取防御距离
        int GetDefDistance();
        //获取类型
        EEquipmentType GetEquipmentType();
        //回合初始化
        void BeginInit();
    }
}
