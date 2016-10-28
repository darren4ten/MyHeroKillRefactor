using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Data.Type;
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
    public  class PlayerState
    {
        //玩家的身份
	protected EIdentity id ;
	//当前血量
	protected int curHP;
	//是否死亡
	protected bool isDead;
	//手牌集合
	protected List<AbstractCard> cardList ;
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
	protected int attDistance ;
	//防御距离
	protected int defDistance ;
	//主动技能
	protected List<SkillIF> skill;
	//锁定技能
	protected List<LockingSkillIF> lockingSkill;
	//额外伤害值
	protected int extDamage;
	//是否出过杀
	protected bool usedSha ;
	//是否处于响应他人状态
	protected bool isRequest;
	//响应他人的结果
	protected int res;
	//当进入选牌时候，选择的牌
	protected AbstractCard selectCard;
	/**
	 * 构造
	 * @param info
	 */
	public PlayerState(P_Info info){
		cardList = new List<AbstractCard>();
		equipment = new EquipmentStructure();
        checkedCardList = new List<AbstractCard>();
        usedCard = new List<AbstractCard>();
        skill = new List<SkillIF>();
        lockingSkill = new List<LockingSkillIF>();
		attDistance = 1;
		defDistance = 0;
		extDamage = 0;
		curHP = info.getMaxHP();
        immuneCards = new List<int>(info.getImmuneCard());
	}

	
	/**
	 * 回合开始前的一些状态清空
	 */
	public void reset(){
		
	}
	/**
	 * 是否中某个延迟锦囊
	 * @param type
	 * @return
	 */
	public bool hasDelayKit(int type){
		for (AbstractCard c : checkedCardList) {
			DelayKitIF d = (DelayKitIF) c;
			if(d.getKitCardType() == type){
				return true;
			}
		}
		return false;
	}
	public void attChange(int n){
		attDistance += n;
	}
	
	public void defChange(int n){
		defDistance+=n;
	}
	public List<AbstractCard> getCardList() {
		return cardList;
	}

	public void setCardList(List<AbstractCard> cardList) {
		this.cardList = cardList;
	}

	

	public EquipmentStructure getEquipment() {
		return equipment;
	}

	public void setEquipment(EquipmentStructure equipment) {
		this.equipment = equipment;
	}

	public List<AbstractCard> getCheckedCardList() {
		return checkedCardList;
	}

	public void setCheckedCardList(List<AbstractCard> checkedCardList) {
		this.checkedCardList = checkedCardList;
	}

	public int getAttDistance() {
		return attDistance;
	}

	public void setAttDistance(int attDistance) {
		this.attDistance = attDistance;
	}

	public int getDefDistance() {
		return defDistance;
	}

	public void setDefDistance(int defDistance) {
		this.defDistance = defDistance;
	}

	public bool isUsedSha() {
		return usedSha;
	}

	public void setUsedSha(bool usedSha) {
		this.usedSha = usedSha;
	}

	public EIdentity getId() {
		return id;
	}

	public void setId(EIdentity id) {
		this.id = id;
	}

	public int getCurHP() {
		return curHP;
	}

	public void setCurHP(int curHP) {
		this.curHP = curHP;
	}

	public List<AbstractCard> getUsedCard() {
		return usedCard;
	}

	public void setUsedCrad(List<AbstractCard> usedCard) {
		this.usedCard = usedCard;
	}

	public bool isAI() {
		return isAI;
	}

	public void setAI(bool isAI) {
		this.isAI = isAI;
	}



	public bool isDead() {
		return isDead;
	}

	public void setDead(bool isDead) {
		this.isDead = isDead;
	}

	public void setUsedCard(List<AbstractCard> usedCard) {
		this.usedCard = usedCard;
	}

	public int getRes() {
		return res;
	}

	

	public List<SkillIF> getSkill() {
		return skill;
	}

	public void setSkill(List<SkillIF> skill) {
		this.skill = skill;
	}

	public List<LockingSkillIF> getLockingSkill() {
		return lockingSkill;
	}

	public void setLockingSkill(List<LockingSkillIF> lockingSkill) {
		this.lockingSkill = lockingSkill;
	}

	public void setRes(int res) {
		this.res = res;
	}

	public bool isRequest() {
		return isRequest;
	}

	public void setRequest(bool isRequest) {
		this.isRequest = isRequest;
	}
	
	public int getExtDamage() {
		return extDamage;
	}

	public void setExtDamage(int extDamage) {
		this.extDamage = extDamage;
	}

	public AbstractCard getSelectCard() {
		return selectCard;
	}

	public void setSelectCard(AbstractCard selectCard) {
		this.selectCard = selectCard;
	}

	public List<int> getImmuneCards() {
		return immuneCards;
	}

	public void setImmuneCards(List<int> immuneCards) {
		this.immuneCards = immuneCards;
	}
    }
}
