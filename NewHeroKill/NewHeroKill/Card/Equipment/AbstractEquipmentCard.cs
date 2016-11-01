using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Equipment
{
    public abstract class AbstractEquipmentCard : AbstractCard, IEquipmentCard
    {
        //攻击距离加成
        protected int attDistance = 0;
        //防御距离加成
        protected int defDistance = 0;
        //装备类型
        protected EEquipmentType equipmentType;

        public AbstractEquipmentCard()
        {
            //super();
        }


        public AbstractEquipmentCard(int id, int number, ECardColorTypes color)
            : base(id, number, color)
        {

            //数据初始化
            Init();
        }

        /// <summary>
        /// 重写Use
        /// </summary>
        /// <param name="p"></param>
        /// <param name="players"></param>
        public override void Use(AbstractPlayer p, List<AbstractPlayer> players)
        {
            //清空战场
            ModuleManagement.getInstance().getBattle().clear();
            //当前出牌区域清空
            p.GetState().GetUsedCard().Clear();
            //手牌中删除
            p.GetState().GetCardList().Remove(this);
            //装载
            p.GetAction().LoadEquipmentCard(this);
            //使用者手牌刷新
            p.RefreshView();
        }

        /// <summary>
        /// 初始化数据 
        /// </summary>
        protected void Init()
        {

        }

        /// <summary>
        /// 装载到玩家上
        /// </summary>
        /// <param name="p"></param>
        public override void Load(AbstractPlayer p)
        {
            //ViewManagement.getInstance().printBattleMsg(p.GetInfo().GetName()+"装载"+GetName());
            //根据不同类型对应不同位置
            //如果已有装备，先卸载再装载
            AbstractEquipmentCard old;
            switch (equipmentType)
            {
                case EEquipmentType.WUQI:
                    old = p.GetState().GetEquipment().GetWeapons();
                    if (old != null)
                    {
                        old.Unload(p);
                    }
                    p.GetState().GetEquipment().SetWeapons(this);
                    break;
                case EEquipmentType.FANGJU:
                    old = p.GetState().GetEquipment().GetArmor();
                    if (old != null)
                    {
                        old.Unload(p);
                    }
                    p.GetState().GetEquipment().SetArmor(this);
                    break;
                case EEquipmentType._MA:
                    old = p.GetState().GetEquipment().getAttHorse();
                    if (old != null)
                    {
                        old.Unload(p);
                    }
                    p.GetState().GetEquipment().SetAttHorse(this);
                    break;
                case EEquipmentType.MA:
                    old = p.GetState().GetEquipment().getDefHorse();
                    if (old != null)
                    {
                        old.Unload(p);
                    }
                    p.GetState().GetEquipment().SetDefHorse(this);
                    break;
            }
            p.GetState().AttChange(attDistance);
            p.GetState().DefChange(defDistance);
        }

        /// <summary>
        /// 从玩家卸载
        /// </summary>
        /// <param name="p"></param>
        public override void Unload(AbstractPlayer p)
        {
            switch (equipmentType)
            {
                case EEquipmentType.WUQI:
                    p.GetState().GetEquipment().SetWeapons(null);
                    break;
                case EEquipmentType.FANGJU:
                    p.GetState().GetEquipment().SetArmor(null);
                    break;
                case EEquipmentType._MA:
                    p.GetState().GetEquipment().SetAttHorse(null);
                    break;
                case EEquipmentType.MA:
                    p.GetState().GetEquipment().SetDefHorse(null);
                    break;
            }
            this.throwIt(p);
            //调用卸载触发
            p.GetTrigger().AfterUnloadEquipmentCard();
            p.RefreshView();
        }

        /**
         * 目标检测
         */
        /*
     @Override
     public void targetCheck(Panel_HandCards ph) {
         List<Panel_Player> list = ph.getMain().getPlayers();
         for (Panel_Player pp : list) {
			
                 pp.disableToUse();
			
         }
     }*/
        public int GetAttDistance()
        {
            return attDistance;
        }
        public int GetDefDistance()
        {
            return defDistance;
        }
        public EEquipmentType GetEquipmentType()
        {
            return equipmentType;
        }

        public void SetAttDistance(int attDistance)
        {
            this.attDistance = attDistance;
        }
        public void SetDefDistance(int defDistance)
        {
            this.defDistance = defDistance;
        }
        public void SetEquipmentType(EEquipmentType equipmentType)
        {
            this.equipmentType = equipmentType;
        }

        public override void BeginInit()
        {

        }

    }

}
