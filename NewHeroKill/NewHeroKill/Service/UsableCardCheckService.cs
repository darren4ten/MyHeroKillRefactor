using NewHeroKill.Card;
using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System.Collections.Generic;
using System.Linq;

namespace NewHeroKill.Service
{




    /// <summary>
    /// �������� 
    /// �������״̬������ ����һ����õ����Ƽ��� 
    /// AI����Ҷ����Է��ص��������Ƽ���Ϊ�ο����в���
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
        ///// ���ؿ����Ƽ���
        ///// </summary>
        //public virtual IList<AbstractCard> getAvailableCard(IList<AbstractCard> list, AbstractPlayer p)
        //{
        //    IList<AbstractCard> list2 = new List<AbstractCard>(list);
        //    // ������ҵĽ׶��ж�
        //    switch (p.GetStageNum())
        //    {
        //        case EStageState.STAGE_BEGIN:
        //            break;
        //        case EStageState.STAGE_CHECK:
        //            break;
        //        case EStageState.STAGE_ADDCARDS:
        //            break;
        //        case EStageState.STAGE_USECARDS:
        //            // �޳���
        //            removeAllCardsByType(list2, Const_Game.SHAN);
        //            // �����Ѫ���޳���
        //            if (p.GetFunction().IsFullHP())
        //            {
        //                removeAllCardsByType(list2, Const_Game.TAO);
        //            }
        //            //���ݿ����޳�ɱ
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
        /////  �޳��б��е�ĳ������
        ///// </summary>
        ///// <param name="list"></param>
        ///// <param name="type"></param>
        //private void removeAllCardsByType(IList<AbstractCard> list, ETargetType type)
        //{
        //    List<AbstractCard> listType = new List<AbstractCard>();
        //    // ������������޳���������
        //    foreach (AbstractCard c in list)
        //    {
        //        if (c.GetTargetType() == type)
        //        {
        //            listType.Add(c);
        //        }
        //    }
        //    // �޳�ָ�����͵�����
        //    //JAVA TO C# CONVERTER TODO TASK: There is no .NET equivalent to the java.util.Collection 'removeAll' method:
        //    list.ToList().RemoveAll(p => listType.Any(t => t.GetTargetType() == p.GetTargetType()));

        //}

    }

}