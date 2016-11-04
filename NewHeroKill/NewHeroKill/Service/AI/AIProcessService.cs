using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Threading;

namespace NewHeroKill.Service.AI
{
    /// <summary>
    /// AI������
    /// 
    /// @author user
    /// 
    /// </summary>
    public class AIProcessService
    {
        internal AbstractPlayer p;
        internal NewHeroKill.Service.UsableCardCheckService check = new NewHeroKill.Service.UsableCardCheckService();
        /// <summary>
        /// ������ ����һ������ģ�� </summary>
        /// <param name="p"> </param>
        public AIProcessService(AbstractPlayer p)
        {
            this.p = p;
        }

        // �غϿ�ʼ
        public virtual void stage_begin()
        {
            p.SetStageNum(EStageState.STAGE_BEGIN);
        }

        // �ж��׶�
        public virtual void stage_check()
        {
            p.SetStageNum(EStageState.STAGE_CHECK);
        }

        // ���ƽ׶�
        public virtual void stage_addCards()
        {
            p.SetStageNum(EStageState.STAGE_ADDCARDS);
            p.GetAction().AddOneCardFromList();
            p.GetAction().AddOneCardFromList();
            p.Panel.refresh();
        }

        /// <summary>
        ///  ���ƽ׶�
        ///  ���ȡ1�����õ����ƣ�����Ƿ����ã�����������һ��
        ///  �ж��Ƶ�ʹ��ÿĿ�����ͣ������Ҫѡ��ģ�����һ����ѡ��Ҽ��ϣ����ü��Ϸǿգ������ѡһ����
        ///  TODO
        /// </summary>
        public virtual void stage_useCards()
        {
            p.SetStageNum(EStageState.STAGE_USECARDS);

            Thread.Sleep(1500);

            //���Խ׶� Ŀ����ʱ����Ϊ�¼�
            //List<AbstractPlayer> list = new ArrayList<AbstractPlayer>();
            //����AIĿ���⺯��
            /*List<AbstractPlayer> list = AITargetCheckService.getEnableTargets(player, c)
			
            list.add(p.getNextPlayer());*/
            //��ȡ1�ſ��õ���
            IList<AbstractCard> listA = check.getAvailableCard(p.GetState().GetCardList(), p);
            AbstractCard c = null;
            if (listA.Count > 0)
            {
                int index = (new Random()).Next(listA.Count);
                c = listA[index];
                //listA.get(index).use(p, list);
                //p.getState().getCardList().remove(listA.get(index));
                IList<AbstractPlayer> listTargets = AITargetCheckService.getEnableTargets(p, c);
                if (listTargets.Count == 0)
                {
                    return;
                }
                IList<AbstractPlayer> listArgs = new List<AbstractPlayer>();
                listArgs.Add(listTargets[(new Random()).Next(listTargets.Count)]);
                c.Use(p, listArgs);
            }
        }

        // ���ƽ׶�
        public virtual void stage_throwCrads()
        {

            Thread.Sleep(500);
            p.SetStageNum(EStageState.STAGE_THROWCRADS);
            Console.WriteLine(p.GetState().GetId().ToString() + p.GetInfo().GetName() + "����");
            while (p.GetState().GetCardList().Count > p.GetState().GetCurHP())
            {
                p.GetState().GetCardList()[0].throwIt(p);
            }
            p.Panel.refresh();

        }

        // �غϽ���
        public virtual void stage_end()
        {
            p.SetStageNum(EStageState.STAGE_END);
            //ViewManagement.getInstance().printMsg(p.getState().getId().toString()+p.getInfo().getName()+"����");
            Console.WriteLine(p.GetState().GetId().ToString() + p.GetInfo().GetName() + "����");
        }

    }

}