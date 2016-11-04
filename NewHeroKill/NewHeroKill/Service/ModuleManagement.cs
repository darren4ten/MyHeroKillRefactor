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
    /// 数据模型管理类 使用单例构造 
    /// 用作一个全局变量集合管理器 我也不知道这样做科学否 
    /// 有前辈说一个设计良好的系统是不应该出现全局类的
    /// 确实，这样会打破面向对象思想的封装性
    /// 但我还是这么做了，原因无他，就是感觉方便
    /// 
    /// @author user
    /// 
    /// </summary>
    public class ModuleManagement
    {
        // 单例构造
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
        /// 重置
        /// </summary>
        public static void reset()
        {
            instance = new ModuleManagement();
        }

        /*
         * 发牌游标
         */
        internal int index = 0;
        /*
         * 所有玩家列表
         */
        internal IList<AbstractPlayer> playerList = new List<AbstractPlayer>();
        /*
         * 牌堆集合
         */
        internal IList<AbstractCard> cardList = new List<AbstractCard>(org.wangfuyuan.sgs.util.CardUtil.createCards());
        /*
         * 弃牌堆集合
         */
        internal IList<AbstractCard> gcList = new List<AbstractCard>();
        /*
         * 战场面板的引用
         */
        internal Panel_Battlefield battle = Panel_Battlefield.Instance;

        /*
         * 目标对象
         */
        internal Target target;

        /*
         * 构造器 初始化玩家集合
         */
        private ModuleManagement()
        {
            init();
            createCharacter();
        }

        /// <summary>
        /// 初始化
        /// 
        /// TODO
        /// </summary>
        private void init()
        {

        }

        /// <summary>
        /// 抽取身份
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
        /// AI就位
        /// </summary>
        private void setAI()
        {
            for (int i = 1; i <= 4; i++)
            {
                playerList[i].GetState().SetAI(true);
            }
        }

        /// <summary>
        /// 创建人物
        /// </summary>
        public virtual void createCharacter()
        {
            playerList = Panel_Select.list;
            // 设置上下家关系
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
                // 初始给4张牌
                List<AbstractCard> list = new List<AbstractCard>();
                for (int j = 0; j < 4; j++)
                {
                    list.Add(OneCard);
                    // System.out.println(list.get(j).getName());
                }
                playerList[i].GetState().SetCardList(list);
            }
            // 设置身份
            setId();
            // 设置AI
            setAI();
            // 测试给牌
            testSet();
        }

        /// <summary>
        /// 测试 给牌
        /// </summary>
        private void testSet()
        {
            playerList[4].GetState().GetCardList().Add(CardFactory.newCard(1, 1, Colors.HEITAO, Const_Game.WUXIEKEJI));
            // 根据配置 添加测试用牌
            IList<AbstractCard> list = org.wangfuyuan.sgs.util.CardUtil.createTestCards();
            for (int i = 0; i < list.Count; i++)
            {
                playerList[0].GetState().GetCardList().Add(list[i]);
            }
        }

        /// <summary>
        /// 牌堆中取一张牌
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
                 * System.out.println("一轮牌用完：当前牌堆数量：" + cardList.size()); }
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
        /// 翻出一张判定牌
        /// 
        /// @return
        /// </summary>
        public virtual AbstractCard showOneCheckCard()
        {
            // 翻出一张
            AbstractCard check = OneCard;
            // 显示
            ViewManagement.Instance.printBattleMsg("判定牌为：" + check.ToString());
            ModuleManagement.Instance.Battle.addOneCard(check);

            // 牌堆中删除此
            cardList.Remove(check);
            // 刷新
            // ModuleManagement.getInstance().getBattle().refresh();
            AbstractCard check2 = check;
            // 询问所有人处理判定
            for (int i = 0; i < playerList.Count; i++)
            {
                check2 = playerList[i].GetAction().DealWithCheckCard(check2);
            }
            // 返回最后的判定
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