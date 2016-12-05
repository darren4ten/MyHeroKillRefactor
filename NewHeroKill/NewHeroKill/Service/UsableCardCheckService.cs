using NewHeroKill.Card;
using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System.Collections.Generic;
using System.Linq;

namespace NewHeroKill.Service
{




    /// <summary>
    /// 检测可用牌 
    /// 根据玩家状态和手牌 返回一组可用的手牌集合 
    /// AI和玩家都将以返回的这组手牌集合为参考进行操作
    /// 
    /// @author user
    /// 
    /// </summary>
    public class UsableCardCheckService
    {
        public UsableCardCheckService()
        {

        }

        ///// <summary>
        ///// 返回可用牌集合
        ///// </summary>
        //public virtual IList<AbstractCard> getAvailableCard(IList<AbstractCard> list, AbstractPlayer p)
        //{
        //    IList<AbstractCard> list2 = new List<AbstractCard>(list);
        //    // 根据玩家的阶段判定
        //    switch (p.GetStageNum())
        //    {
        //        case EStageState.STAGE_BEGIN:
        //            break;
        //        case EStageState.STAGE_CHECK:
        //            break;
        //        case EStageState.STAGE_ADDCARDS:
        //            break;
        //        case EStageState.STAGE_USECARDS:
        //            // 剔除闪
        //            removeAllCardsByType(list2, Const_Game.SHAN);
        //            // 如果满血则剔除桃
        //            if (p.GetFunction().IsFullHP())
        //            {
        //                removeAllCardsByType(list2, Const_Game.TAO);
        //            }
        //            //根据开关剔除杀
        //            if (p.GetState().IsUsedSha())
        //            {
        //                removeAllCardsByType(list2, Const_Game.SHA);
        //            }
        //            break;
        //        case EStageState.STAGE_THROWCRADS:
        //            if (p.GetState().GetCardList().Count <= p.GetState().GetCurHP())
        //            {
        //                list2.Clear();
        //            }
        //            break;
        //        case EStageState.STAGE_END:
        //            list2.Clear();
        //            break;
        //    }
        //    return list2;
        //}

        ///// <summary>
        /////  剔除列表中的某种牌型
        ///// </summary>
        ///// <param name="list"></param>
        ///// <param name="type"></param>
        //private void removeAllCardsByType(IList<AbstractCard> list, ETargetType type)
        //{
        //    List<AbstractCard> listType = new List<AbstractCard>();
        //    // 获得所有满足剔除条件的牌
        //    foreach (AbstractCard c in list)
        //    {
        //        if (c.GetTargetType() == type)
        //        {
        //            listType.Add(c);
        //        }
        //    }
        //    // 剔除指定类型的所有
        //    //JAVA TO C# CONVERTER TODO TASK: There is no .NET equivalent to the java.util.Collection 'removeAll' method:
        //    list.ToList().RemoveAll(p => listType.Any(t => t.GetTargetType() == p.GetTargetType()));

        //}

    }

}