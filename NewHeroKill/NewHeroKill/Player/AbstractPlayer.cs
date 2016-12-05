using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Player.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewHeroKill.Player
{
    public abstract class AbstractPlayer : IPlayer
    {
        // 玩家信息
        protected PlayerInfo info;

        // 玩家状态
        protected PlayerState state;

        // 玩家回合动作类
        protected IPlayerProcess process;

        // 玩家行为
        protected IPlayerAction action;

        // 玩家响应请求
        protected IPlayerRequest request;

        // 玩家触发
        protected IPlayerTrigger trigger;

        // 玩家的功能函数类
        protected IPlayerFunction function;

        // 下家的引用
        protected AbstractPlayer nextPlayer;

        //// AI控制器
        //protected AIProcessService AIsvr;

        // 弃牌控制(是否在自己回合)
        protected bool isSkip = true;

        // 所处回合阶段
        protected EStageState stageNum = EStageState.STAGE_END;

        // 关联的显示面板
        protected GameObject panel;

        /// <summary>
        /// 构造
        /// </summary>
        public AbstractPlayer()
        {
            info = new PlayerInfo();
            Initial();
        }

        /// <summary>
        /// 初始化状态
        /// </summary>
        protected void Initial()
        {
            state = new PlayerState(info);
            action = new PlayerAction(this);
            request = new PlayerRequest(this);
            trigger = new PlayerTrigger(this);
            //process = new PlayerProcess(this);
            function = new PlayerFunction(this);
            //AIsvr = new AIProcessService(this);
        }

        public void Process()
        {
            /*// 如果是AI，则调用AI服务类的process
            if (this.getState().isAI()) {
                AIsvr.start();
                return;
            }*/
            //ViewManagement.getInstance().refreshAll();
            process.Start();
        }

        /// <summary>
        /// 抽象方法 载入技能
        /// </summary>
        /// <param name="name"></param>
        public abstract void LoadSkills(String name);


        /// <summary>
        /// 刷新面板
        /// </summary>
        public void RefreshView()
        {
            //getPanel().refresh();
        }

        /// <summary>
        /// 整理刷新手牌
        /// </summary>
        public void UpdateCards()
        {
            //Panel_Control pc = (Panel_Control) getPanel();
            //Panel_HandCards ph = pc.getHand();
            //ph.updateCards();
            //ph.carding();
        }

        /// <summary>
        /// 等待选择
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public AbstractCard ToSelectCard(List<AbstractCard> list)
        {
            if (GetState().IsAI())
            {
                int n = new Random().Next(list.Count());
                return list.ElementAt(n);
            }
            else
            {
                GetState().SetSelectCard(null);
                while (GetState().GetSelectCard() == null)
                {

                }
                return GetState().GetSelectCard();
            }
        }

        /// <summary>
        /// 是否拥有某种牌
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool HasCard(int type)
        {
            for (int i = 0; i < GetState().GetCardList().Count(); i++)
            {
                if (GetState().GetCardList().ElementAt(i).GetType() == type) return true;
            }
            return false;
        }

        /// <summary>
        /// 获取同势力人物集合
        /// </summary>
        /// <returns></returns>
        public List<AbstractPlayer> GetSameCountryPlayers()
        {
            List<AbstractPlayer> result = new List<AbstractPlayer>();
            AbstractPlayer p = GetNextPlayer();
            while (p != this)
            {
                if (p.GetInfo().GetCountry() == GetInfo().GetCountry())
                {
                    result.Add(p);
                }
                p = p.GetNextPlayer();
            }
            return result;
        }

        /// <summary>
        /// 设置是否处于请求响应状态
        /// 牌型为type
        /// </summary>
        /// <param name="isRequest"></param>
        /// <param name="type"></param>
        public void SetRequest(bool isRequest, int type)
        {
            GetState().SetRequest(isRequest);
            GetRequest().SetCurType(type);
        }

        //-----------------------------------
        public PlayerInfo GetInfo()
        {
            return info;
        }

        public void SetInfo(PlayerInfo info)
        {
            this.info = info;
        }

        public PlayerState GetState()
        {
            return state;
        }

        public void SetState(PlayerState state)
        {
            this.state = state;
        }

        public IPlayerAction GetAction()
        {
            return action;
        }

        public void SetAction(IPlayerAction action)
        {
            this.action = action;
        }

        public IPlayerRequest GetRequest()
        {
            return request;
        }

        public void SetRequest(IPlayerRequest request)
        {
            this.request = request;
        }

        public IPlayerTrigger GetTrigger()
        {
            return trigger;
        }

        public void SetTrigger(IPlayerTrigger trigger)
        {
            this.trigger = trigger;
        }

        public AbstractPlayer GetNextPlayer()
        {
            return nextPlayer;
        }

        public void SetNextPlayer(AbstractPlayer nextPlayer)
        {
            this.nextPlayer = nextPlayer;
        }

        public bool IsSkip()
        {
            return isSkip;
        }

        public void SetSkip(bool isSkip)
        {
            this.isSkip = isSkip;
        }

        //public IRefreshble getPanel()
        //{
        //    return panel;
        //}

        //public void setPanel(RefreshbleIF panel)
        //{
        //    this.panel = panel;
        //}

        public IPlayerProcess GetProcess()
        {
            return process;
        }

        public void SetProcess(PlayerProcess process)
        {
            this.process = process;
        }

        public EStageState GetStageNum()
        {
            return stageNum;
        }

        public void SetStageNum(EStageState stageNum)
        {
            this.stageNum = stageNum;
        }

        public IPlayerFunction GetFunction()
        {
            return function;
        }

        public void SetFunction(IPlayerFunction function)
        {
            this.function = function;
        }

    }
}
