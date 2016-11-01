using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card.Kit
{
    public abstract class AbstractKitCard : AbstractCard {
	// 是否被无懈
	protected bool isWuXie;
	// 玩家控制栏，与UI的连接点
	protected GameObject pc;

	/*
	 * 目标集合 主要是防止出现多线程操作时候，作为参数的玩家列表被强制final后可能引发一些问题，所以临时建立一个集合来存储 也可能是我多虑了
	 */
	protected List<AbstractPlayer> targetPlayers;

	public AbstractKitCard(int id, int number, ECardColorTypes color) :base(id, number, color){
		
	}

	public AbstractKitCard() {
	}
/// <summary>
/// 锦囊使用前的初始化
/// </summary>
	protected void InitKit() {
		isWuXie = false;
	}

	
	public override void Use(AbstractPlayer p, List<AbstractPlayer> players) {
		base.Use(p, players);
		if (!p.GetState().IsAI())
			pc = (Panel_Control) p.getPanel();
		targetPlayers = new List<AbstractPlayer>(players);
		InitKit();
	}

/// <summary>
/// 询问无懈可击
/// 无懈可击的实现方法： 锦囊牌中都有一个bool值表示是否被无懈 这个方法用来询问场上是否有无懈，如果打出无懈则将bool值取反
/// 锦囊最终将在子类具体实现时候根据bool值判定是否发动效果</summary>
/// <param name="p"></param>
/// <param name="players"></param>
	public void AskWuXieKeJi(AbstractPlayer p, List<AbstractPlayer> players) {
		if (HasWuxiekejiInBattle()) {
			p.RefreshView();
			Console.WriteLine("场上有无懈");
			// 询问无懈
			List<AbstractPlayer> askPlayers = ModuleManagement.getInstance()
					.getPlayerList();
			for (int i = 0; i < askPlayers.Count(); i++) {
				// 如果有人出无懈
				if (askPlayers.ElementAt(i).GetRequest().RequestWuXie()) {
					isWuXie = true;
					break;
				}
			}
		}
	}

	/*
	 * 场上是否有无懈存在
	 */
	protected bool HasWuxiekejiInBattle() {
		foreach (AbstractPlayer p in ModuleManagement.getInstance().getPlayerList()) {
			if (p.HasCard(Const_Game.WUXIEKEJI))
				return true;
		}
		return false;
	}

	/// <summary>
	/// 锦囊类的绘制 大部分可以使用这个模板 有些例外的需要重写，如闪电、无懈等
	/// </summary>
	/// <param name="AbstractPlayer"></param>
	protected void DrawEffect( AbstractPlayer p,
			List<AbstractPlayer> players) {
		//有目标的锦囊
		if (targetType == ETargetType.SELECT) {
			 AbstractPlayer tmp = players.ElementAt(0);
            //ViewManagement.getInstance().printBattleMsg(
            //        p.getInfo().getName() + "对" + tmp.getInfo().getName()
            //                + "使用了" + this.toString());
            //SwingUtilities.invokeLater(new Runnable() {
            //    @Override
            //    public void run() {
            //        if (getEffectImage() != null)
            //            PaintService.drawEffectImage(getEffectImage(), p);
            //        PaintService.drawLine(p, tmp);
            //    }
            //});
			//无目标的锦囊
		}else{
            //ViewManagement.getInstance().printBattleMsg(p.getInfo().getName()+"使用了"+getName());
            //SwingUtilities.invokeLater(new Runnable() {
            //    @Override
            //    public void run() {
            //        if(getEffectImage()!=null)PaintService.drawEffectImage(getEffectImage(), p);
            //        PaintService.clearAfter(1000);
            //    }
            //});
		
		}
	}
}
}
