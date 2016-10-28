using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Data.Type;
using NewHeroKill.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    /// <summary>
    /// 玩家状态类
    ///封装游戏时玩家的各项数据
    /// </summary>
    public class PlayerState
    {
        //玩家的身份
        protected EIdentity id;
        //当前血量
        protected int curHP;
        //是否死亡
        protected bool isDead;
        //手牌集合
        protected List<AbstractCard> cardList;
        //免疫牌
        protected List<int> immuneCards;
        //是否为AI
        protected bool isAI;
        //装备集合
        protected EquipmentStructure equipment;
        //所中的判定牌集合
        protected List<AbstractCard> checkedCardList;
        //回合中当前打出的牌
        protected List<AbstractCard> usedCard;
        //攻击距离
        protected int attDistance;
        //防御距离
        protected int defDistance;
        //主动技能
        protected List<ISkill> skill;
        //锁定技能
        protected List<ISkillLocking> lockingSkill;
        //额外伤害值
        protected int extDamage;
        //是否出过杀
        protected bool usedSha;
        //是否处于响应他人状态
        protected bool isRequest;
        //响应他人的结果
        protected int res;
        //当进入选牌时候，选择的牌
        protected AbstractCard selectCard;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="info"></param>
        public PlayerState(PlayerInfo info)
        {
            cardList = new List<AbstractCard>();
            equipment = new EquipmentStructure();
            checkedCardList = new List<AbstractCard>();
            usedCard = new List<AbstractCard>();
            skill = new List<ISkill>();
            lockingSkill = new List<ISkillLocking>();
            attDistance = 1;
            defDistance = 0;
            extDamage = 0;
            curHP = info.GetMaxHP();
            immuneCards = new List<int>(info.GetImmuneCard());
        }


        /// <summary>
        /// 回合开始前的一些状态清空
        /// </summary>
        public void Reset()
        {

        }
      
        /// <summary>
        /// 是否中某个延迟锦囊
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool HasDelayKit(int type){
		foreach (AbstractCard c in  checkedCardList) {
            IDelayKit d = (IDelayKit)c;
			if(d.GetKitCardType() == type){
				return true;
			}
		}
		return false;
	}
        public void AttChange(int n)
        {
            attDistance += n;
        }

        public void DefChange(int n)
        {
            defDistance += n;
        }
        public List<AbstractCard> GetCardList()
        {
            return cardList;
        }

        public void SetCardList(List<AbstractCard> cardList)
        {
            this.cardList = cardList;
        }



        public EquipmentStructure GetEquipment()
        {
            return equipment;
        }

        public void SetEquipment(EquipmentStructure equipment)
        {
            this.equipment = equipment;
        }

        public List<AbstractCard> GetCheckedCardList()
        {
            return checkedCardList;
        }

        public void SetCheckedCardList(List<AbstractCard> checkedCardList)
        {
            this.checkedCardList = checkedCardList;
        }

        public int GetAttDistance()
        {
            return attDistance;
        }

        public void SetAttDistance(int attDistance)
        {
            this.attDistance = attDistance;
        }

        public int GetDefDistance()
        {
            return defDistance;
        }

        public void SetDefDistance(int defDistance)
        {
            this.defDistance = defDistance;
        }

        public bool IsUsedSha()
        {
            return usedSha;
        }

        public void SetUsedSha(bool usedSha)
        {
            this.usedSha = usedSha;
        }

        public EIdentity GetId()
        {
            return id;
        }

        public void SetId(EIdentity id)
        {
            this.id = id;
        }

        public int GetCurHP()
        {
            return curHP;
        }

        public void SetCurHP(int curHP)
        {
            this.curHP = curHP;
        }

        public List<AbstractCard> GetUsedCard()
        {
            return usedCard;
        }

        public void SetUsedCrad(List<AbstractCard> usedCard)
        {
            this.usedCard = usedCard;
        }

        public bool IsAI()
        {
            return isAI;
        }

        public void SetAI(bool isAI)
        {
            this.isAI = isAI;
        }



        public bool IsDead()
        {
            return isDead;
        }

        public void SetDead(bool isDead)
        {
            this.isDead = isDead;
        }

        public void SetUsedCard(List<AbstractCard> usedCard)
        {
            this.usedCard = usedCard;
        }

        public int getRes()
        {
            return res;
        }



        public List<ISkill> GetSkill()
        {
            return skill;
        }

        public void SetSkill(List<ISkill> skill)
        {
            this.skill = skill;
        }

        public List<ISkillLocking> GetLockingSkill()
        {
            return lockingSkill;
        }

        public void SetLockingSkill(List<ISkillLocking> lockingSkill)
        {
            this.lockingSkill = lockingSkill;
        }

        public void SetRes(int res)
        {
            this.res = res;
        }

        public bool IsRequest()
        {
            return isRequest;
        }

        public void SetRequest(bool isRequest)
        {
            this.isRequest = isRequest;
        }

        public int GetExtDamage()
        {
            return extDamage;
        }

        public void SetExtDamage(int extDamage)
        {
            this.extDamage = extDamage;
        }

        public AbstractCard GetSelectCard()
        {
            return selectCard;
        }

        public void SetSelectCard(AbstractCard selectCard)
        {
            this.selectCard = selectCard;
        }

        public List<int> GetImmuneCards()
        {
            return immuneCards;
        }

        public void SetImmuneCards(List<int> immuneCards)
        {
            this.immuneCards = immuneCards;
        }
    }
}
