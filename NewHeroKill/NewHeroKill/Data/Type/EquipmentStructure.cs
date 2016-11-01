using NewHeroKill.Card.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Data.Type
{
    /**
   * 自定义的数据结构
   * 装备结构
   * --武器
   * --防具
   * --加1马
   * --减1马
   * @author user
   *
   */
    public class EquipmentStructure
    {
        AbstractEquipmentCard weapons;
        AbstractEquipmentCard armor;
        AbstractEquipmentCard attHorse;
        AbstractEquipmentCard defHorse;

        public EquipmentStructure()
        {

        }

        /**
         * 回合初始化所有装备
         */
        public void InitAll()
        {
            if (weapons != null) weapons.BeginInit();
            if (armor != null) armor.BeginInit();
        }

        /**
         * 是否有武器
         */
        public bool HasWeapons()
        {
            return weapons != null;
        }
        /**
         * 是否有码
         */
        public bool HasHorse()
        {
            return attHorse != null || defHorse != null;
        }

        /**
         * 删除所有装备
         */
        public void RemoveALL()
        {
            weapons = null;
            armor = null;
            attHorse = null;
            defHorse = null;
        }

        /**
         * 是否没有装备
         */
        public bool IsEmpty()
        {
            return weapons == null && armor == null && attHorse == null && defHorse == null;
        }


        public AbstractEquipmentCard GetWeapons()
        {
            return weapons;
        }


        public AbstractEquipmentCard GetArmor()
        {
            return armor;
        }

        public void SetArmor(AbstractEquipmentCard armor)
        {
            this.armor = armor;
        }

        public AbstractEquipmentCard getAttHorse()
        {
            return attHorse;
        }

        public void SetAttHorse(AbstractEquipmentCard attHorse)
        {
            this.attHorse = attHorse;
        }

        public AbstractEquipmentCard getDefHorse()
        {
            return defHorse;
        }

        public void SetDefHorse(AbstractEquipmentCard defHorse)
        {
            this.defHorse = defHorse;
        }

        public void SetWeapons(AbstractEquipmentCard weapons)
        {
            this.weapons = weapons;
        }


    }
}
