using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    
/**
 * 玩家行为的实现类 封装了玩家的一些基本动作
 * 
 * @author user
 * 
 */
public class PlayerAction : IPlayerAction {
	// 人物模型
	protected AbstractPlayer player;

	// 构造器
	public PlayerAction(AbstractPlayer p) {
		this.player = p;
	}

	/**
	 * 玩家加血 -- 调用加血触发事件
	 */
	
	public override void addHP(int num) {
		player.getState().curHP += num;
		if (player.getState().curHP > player.getInfo().maxHP) {
			player.getState().curHP = player.getInfo().maxHP;
		}
		// 调用加血触发
		player.getTrigger().afterAddHP();
	}

	/**
	 * 装载装备
	 */
	public void loadEquipmentCard(AbstractCard c) {
		AbstractEquipmentCard ceq = (AbstractEquipmentCard) c;
		ceq.load(player);
		//触发
		player.getTrigger().afterLoadEquipmentCard();
	}

	/**
	 * 玩家扣血 -- 调用扣血触发事件
	 * 
	 * @param 扣血数量
	 * @param 凶手
	 */
    ////@Override
	public void loseHP(int num, AbstractPlayer murderer) {
		int hp = player.getState().getCurHP();
		hp -= num;
		player.getState().setCurHP(hp);
		ViewManagement.getInstance().printMsg(
				player.getInfo().getName() + "受到" + num + "点伤害");
		player.refreshView();
		// TODO 如果血量不足，则开始求桃
		hp:
		while(player.getState().getCurHP() <= 0) {
			// 先求自己
			if (player.getRequest().requestTao()) {
				player.getAction().taoSave(player);
				if(player.getState().getCurHP()>0){
					return;
				}else{
					continue;
				}
			}
			// 再求其他人
			List<AbstractPlayer> list = player.getFunction().getAllPlayers();
			for (int i = 0; i < list.size(); i++) {
				// 因为有卡死bug，暂时不问凶手求桃
				// 经研究为swing中的多线程问题 2013-4-5已解决
				// if(list.get(i)==murderer)continue;
				if (list.get(i).getRequest().requestTao()) {
					player.getAction().taoSave(player);
					if(player.getState().getCurHP()>0)break hp;
				}
			}
			player.getAction().dead(murderer);
			return;
		}

		// 调用触发事件
		this.player.getTrigger().afterLoseHP(murderer);
		player.refreshView();
		if (murderer != null)
			murderer.refreshView();
	}

    ////@Override
	public void loseHandCard(int num) {
		// TODO Auto-generated method stub

	}

    ////@Override
	public void magic() {
		// TODO Auto-generated method stub

	}

	/**
	 * 玩家动作 -- 杀 参数p为被杀者！ player才是出杀者 2013-3-27曾因混淆出过bug
	 */
    ////@Override
	public bool sha(AbstractPlayer p) {
		bool flag = false;
		if (!p.getRequest().requestShan()) {
			p.getAction().loseHP(1 + player.getState().getExtDamage(), player);
			flag = true;
		}
		// 开关
		player.getState().setUsedSha(true);
		// 调用触发事件
		player.getTrigger().afterSha();
		return flag;
	}

    ////@Override
	public void shan() {
		// TODO Auto-generated method stub

	}

	/**
	 * 桃 加1点血
	 */
    ////@Override
	public void tao() {
		player.getAction().addHP(1);
		//调用触发
		player.getTrigger().afterAddHP();
	}

	/**
	 * 卸载装备
	 */
    ////@Override
	public void unloadEquipmentCard(AbstractCard c) {
		AbstractEquipmentCard aec = (AbstractEquipmentCard) c;
		//触发已经在武器卸载中调用
		aec.unload(player);
	}

	/**
	 * 将指定的牌添加到手牌中
	 */
    ////@Override
	public void addCardToHandCard(AbstractCard c) {
		ViewManagement.getInstance().printMsg(
				player.getInfo().getName() + "获得了" + c.ToString());
		player.getState().getCardList().Add(c);
		//触发
		player.getTrigger().afterGetHandCard();
	}

	/**
	 * 牌堆中摸一张
	 */
    ////@Override
	public void addOneCardFromList() {

		player.getState().getCardList().Add(
				ModuleManagement.getInstance().getOneCard());
		//触发
		player.getTrigger().afterGetHandCard();
	}

	/**
	 * 删除指定序列的手牌
	 */
    ////@Override
	public void removeCard(int index) {
		player.getState().getCardList().Remove(index);
		// 丢失手牌触发
		player.getTrigger().afterLoseHandCard();
	}

	/**
	 * 删除指定的某张牌
	 */
	public void removeCard(AbstractCard c) {
		player.getState().getCardList().Remove(c);
		// 丢失手牌触发
		player.getTrigger().afterLoseHandCard();
	}

	/**
	 * 人物死亡
	 */
    ////@Override
	public void dead(AbstractPlayer murderer) {
		// 全局列表中删除
		ModuleManagement.getInstance().getPlayerList().remove(player);
		// 设置死亡状态
		player.getState().setDead(true);
		player.getState().setCurHP(0);
		// 删除手牌
		for (AbstractCard c : player.getState().getCardList()) {
			c.gc();
		}
		player.getState().getCardList().Clear();
		// 上下家重置
		player.getFunction().getLastPlayer().setNextPlayer(
				player.getNextPlayer());
		//检测该人物死亡是否终止游戏
		if(player.getState().getId() == EIdentity.ZHUGONG){
			if(getFanZei()>0){
				Frame_Main.me.gameOver(GameOver.FANZEI_WIN);
			}else{
				Frame_Main.me.gameOver(GameOver.NEIJIAN_WIN);
			}
			return;
		}
		if(player.getState().getId() == EIdentity.FANZEI || player.getState().getId() == EIdentity.NEIJIAN){
			int alive = getFanZeiOrNeiJian();
			Console.WriteLine("反贼或内奸还剩："+alive+"个");
			if(alive==0){
				//Frame_Main.me.gameOver(GameOver.ZHUGONG_WIN);
				return;
			}
		}
		// 死亡触发事件
		player.getTrigger().afterDead();
		//死亡后的奖惩
		if (murderer != null) {
			// 如果死亡者是反贼 凶手获得3张牌
			if (player.getState().getId() == EIdentity.FANZEI) {
				for (int i = 0; i < 3; i++) {
					murderer.getAction().addOneCardFromList();
				}
			}
			//主公误杀忠臣则掉光所有牌
			if(player.getState().getId() == EIdentity.ZHONGCHEN &&
					murderer.getState().getId()==EIdentity.ZHUGONG){
				murderer.getState().getCardList().Clear();
				murderer.getState().getEquipment().removeALL();
				AISpeakService.sayFuckBoss(player);
			}
			player.refreshView();
			murderer.refreshView();
		}
		//如果在回合中死亡，直接跳出回合，下家开始
		if(player.getStageNum()!= IPlayer.STAGE_END){
			Console.WriteLine("dead"+Thread.CurrentThread.Name);
			player.getNextPlayer().process();
		}
	}

	private int getFanZeiOrNeiJian(){
		int alive = 0;
		for (AbstractPlayer p : ModuleManagement.getInstance().getPlayerList()) {
			if(p.getState().getId()==EIdentity.FANZEI || p.getState().getId() == EIdentity.NEIJIAN){
				alive++;
			}
		}
		return alive;
	}
	
	private int getFanZei(){
		int alive = 0;
		for (AbstractPlayer p : ModuleManagement.getInstance().getPlayerList()) {
			if(p.getState().getId()==EIdentity.FANZEI){
				alive++;
			}
		}
		return alive;
	}
	/**
	 * 桃-救人
	 */
    ////@Override
	public void taoSave(AbstractPlayer p) {
		player.getAction().tao();
		//触发
		player.getTrigger().afterAddHP();
	}

    ////@Override
	public void shaWithEquipment() {
		// TODO Auto-generated method stub

	}

    ////@Override
	public void shaWithSkill() {
		// TODO Auto-generated method stub

	}

	/**
	 * 处理判定牌 默认什么都不做返回
	 */
    ////@Override
	public AbstractCard dealWithCheckCard(AbstractCard c) {
		return c;
	}

	/**
	 * 决斗 如果目标出杀，则返回true
	 */
    ////@Override
	public bool jueDou(AbstractPlayer p) {
		if (p.getRequest().requestSha()) {
			return true;
		} else {
			p.getAction().loseHP(1 + player.getState().getExtDamage(), player);
			return false;
		}
	}

	/**
	 * 是否回避杀
	 */
	//@Override
	public bool avoidSha(AbstractPlayer murder, Card_Sha card) {
		return false;
	}

}

}
