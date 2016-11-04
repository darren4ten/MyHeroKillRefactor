using NewHeroKill.Card;
using NewHeroKill.Data.Const;
using NewHeroKill.Data.Enums;
using NewHeroKill.Data.Type;
using NewHeroKill.Player;
using System.Collections.Generic;
using System.Linq;

namespace NewHeroKill.Service
{



    /// <summary>
    /// ����ģ�͹����� ʹ�õ������� 
    /// ����һ��ȫ�ֱ������Ϲ����� ��Ҳ��֪����������ѧ�� 
    /// ��ǰ��˵һ��������õ�ϵͳ�ǲ�Ӧ�ó���ȫ�����
    /// ȷʵ������������������˼��ķ�װ��
    /// ���һ�����ô���ˣ�ԭ�����������Ǹо�����
    /// 
    /// @author user
    /// 
    /// </summary>
    public class ModuleManagement
    {
        // ��������
        private static ModuleManagement instance;

        public static ModuleManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModuleManagement();
                }
                return instance;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public static void reset()
        {
            instance = new ModuleManagement();
        }

        /*
         * �����α�
         */
        internal int index = 0;
        /*
         * ��������б�
         */
        internal IList<AbstractPlayer> playerList = new List<AbstractPlayer>();
        /*
         * �ƶѼ���
         */
        internal IList<AbstractCard> cardList = new List<AbstractCard>(org.wangfuyuan.sgs.util.CardUtil.createCards());
        /*
         * ���ƶѼ���
         */
        internal IList<AbstractCard> gcList = new List<AbstractCard>();
        /*
         * ս����������
         */
        internal Panel_Battlefield battle = Panel_Battlefield.Instance;

        /*
         * Ŀ�����
         */
        internal Target target;

        /*
         * ������ ��ʼ����Ҽ���
         */
        private ModuleManagement()
        {
            init();
            createCharacter();
        }

        /// <summary>
        /// ��ʼ��
        /// 
        /// TODO
        /// </summary>
        private void init()
        {

        }

        /// <summary>
        /// ��ȡ���
        /// 
        /// </summary>
        private void setId()
        {
            playerList[0].GetState().SetId(EIdentity.ZHUGONG);
            playerList[1].GetState().SetId(EIdentity.ZHUGONG);

            playerList[2].GetState().SetId(EIdentity.NEIJIAN);
            playerList[3].GetState().SetId(EIdentity.FANZEI);
            playerList[4].GetState().SetId(EIdentity.FANZEI);
        }

        /// <summary>
        /// AI��λ
        /// </summary>
        private void setAI()
        {
            for (int i = 1; i <= 4; i++)
            {
                playerList[i].GetState().SetAI(true);
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual void createCharacter()
        {
            playerList = Panel_Select.list;
            // �������¼ҹ�ϵ
            for (int i = 0; i < playerList.Count; i++)
            {
                if (i < 4)
                {
                    playerList[i].NextPlayer = playerList[i + 1];
                }
                else
                {
                    playerList[i].NextPlayer = playerList[0];
                }
                // ��ʼ��4����
                List<AbstractCard> list = new List<AbstractCard>();
                for (int j = 0; j < 4; j++)
                {
                    list.Add(OneCard);
                    // System.out.println(list.get(j).getName());
                }
                playerList[i].GetState().SetCardList(list);
            }
            // �������
            setId();
            // ����AI
            setAI();
            // ���Ը���
            testSet();
        }

        /// <summary>
        /// ���� ����
        /// </summary>
        private void testSet()
        {
            playerList[4].GetState().GetCardList().Add(CardFactory.newCard(1, 1, Colors.HEITAO, Const_Game.WUXIEKEJI));
            // �������� ��Ӳ�������
            IList<AbstractCard> list = org.wangfuyuan.sgs.util.CardUtil.createTestCards();
            for (int i = 0; i < list.Count; i++)
            {
                playerList[0].GetState().GetCardList().Add(list[i]);
            }
        }

        /// <summary>
        /// �ƶ���ȡһ����
        /// 
        /// @return
        /// </summary>
        public virtual AbstractCard OneCard
        {
            get
            {
                AbstractCard c = cardList[0];
                /*
                 * index++; if (index >= cardList.size()) { index = 0;
                 * System.out.println("һ�������꣺��ǰ�ƶ�������" + cardList.size()); }
                 */
                cardList.Remove(c);
                if (cardList.Count == 0)
                {
                    List<AbstractCard> newCards = new List<AbstractCard>();
                    foreach (AbstractCard card in gcList)
                    {
                        newCards.Add(card);
                        cardList.Add(card);
                    }

                    gcList.Clear();
                }
                return c;
            }
        }

        /// <summary>
        /// ����һ���ж���
        /// 
        /// @return
        /// </summary>
        public virtual AbstractCard showOneCheckCard()
        {
            // ����һ��
            AbstractCard check = OneCard;
            // ��ʾ
            ViewManagement.Instance.printBattleMsg("�ж���Ϊ��" + check.ToString());
            ModuleManagement.Instance.Battle.addOneCard(check);

            // �ƶ���ɾ����
            cardList.Remove(check);
            // ˢ��
            // ModuleManagement.getInstance().getBattle().refresh();
            AbstractCard check2 = check;
            // ѯ�������˴����ж�
            for (int i = 0; i < playerList.Count; i++)
            {
                check2 = playerList[i].GetAction().DealWithCheckCard(check2);
            }
            // ���������ж�
            return check2;
        }

        public virtual int Index
        {
            get
            {
                return index;
            }
            set
            {
                this.index = value;
            }
        }


        public virtual IList<AbstractCard> CardList
        {
            get
            {
                return cardList;
            }
            set
            {
                this.cardList = value;
            }
        }


        public virtual Panel_Battlefield Battle
        {
            get
            {
                return battle;
            }
            set
            {
                this.battle = value;
            }
        }


        public virtual IList<AbstractPlayer> PlayerList
        {
            get
            {
                return playerList;
            }
            set
            {
                this.playerList = value;
            }
        }

        public virtual Target Target
        {
            get
            {
                return target;
            }
            set
            {
                this.target = value;
            }
        }



        public virtual IList<AbstractCard> GcList
        {
            get
            {
                return gcList;
            }
            set
            {
                this.gcList = value;
            }
        }


    }

}