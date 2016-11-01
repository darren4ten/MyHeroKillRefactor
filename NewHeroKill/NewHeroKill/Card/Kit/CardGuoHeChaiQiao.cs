using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Kit
{
  public class CardGuoHeChaiQiao : AbstractKitCard , IEffectCard{

	Panel_SelectCard ps;

	public CardGuoHeChaiQiao() {

	}

/// <summary>
///  重写use 在目标玩家的所有牌中选择一张 删除
/// </summary>
/// <param name="AbstractPlayer"></param>
	public override void Use( AbstractPlayer p, List<AbstractPlayer> players) {
		base.Use(p, players);
		// 触发技能
		p.GetTrigger().AfterMagic();

		// 如果无懈，则return
		AskWuXieKeJi(p, players);
		if (isWuXie) {
            //ViewManagement.getInstance().printBattleMsg(GetName() + "无效");
            //ViewManagement.getInstance().refreshAll();
			return;
		}
		if (p.GetState().IsAI()) {
			AbstractPlayer target = players.ElementAt(0);
			if(target.GetState().GetCardList().Count()>0){
				AbstractCard c = target.GetState().GetCardList().ElementAt(0);
				target.GetAction().RemoveCard(c);
				c.Gc();
                //ModuleManagement.getInstance().getBattle().addOneCard(c);
				p.RefreshView();
				target.RefreshView();
			}
		
		} else {
			// pc = (Panel_Control)p.getPanel();
			ps = new Panel_SelectCard(p, targetPlayers.ElementAt(0),
					Panel_SelectCard.CHAI);
            //// 显示选择面板等待处理
            //try {
            //    SwingUtilities.invokeAndWait(run);
            //} catch (InterruptedException e) {
            //    e.printStackTrace();
            //} catch (InvocationTargetException e) {
            //    e.printStackTrace();
            //}
		}
	}
	
      /// <summary>
      /// 重写目标检测
      /// </summary>
      /// <param name="ph"></param>
	public override void TargetCheck(Panel_HandCards ph) {
		// 遍历 检测
		List<Panel_Player> list = ph.getMain().getPlayers();
		for (int i = 0; i < list.size(); i++) {
			Panel_Player pp = list.get(i);
			// 如果无手牌或者装备牌
			if (pp.getPlayer().getState().getCardList().isEmpty()
					&& pp.getPlayer().getState().getEquipment().isEmpty()) {
				pp.disableToUse();
				continue;
			}
			pp.enableToUse();
		}
	}
	
	
    //Runnable run = new Runnable() {

    //    @Override
    //    public void run() {
    //        pc.getPlayer().refreshView();
    //        pc.getMain().add(ps, 0);
    //        pc.getHand().unableToUseCard();
    //        ps.setLocation(200, pc.getMain().getHeight() / 9);
    //        pc.getMain().validate();
    //    }
    //};
}

}
