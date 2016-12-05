using NewHeroKill.Card;
using NewHeroKill.Data.Enums;
using NewHeroKill.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    public class PlayerProcess : IPlayerProcess
    {
        protected AbstractPlayer player;
        //protected AIProcessService AIProcess;
        protected bool isSkilling;
        protected bool canUseCard = true;
        public PlayerProcess(AbstractPlayer p)
        {
            this.player = p;
            //AIProcess = new AIProcessService(player);
        }

        /// <summary>
        /// 进入
        /// </summary>
        public void Start()
        {
            Init();
            Stage_begin();
            Stage_check();
            Stage_addCards();
            Stage_useCards();
            Stage_throwCrads();
            Stage_end();

            Thread.Sleep(500);

            Pass();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            player.SetSkip(false);
            player.GetState().SetExtDamage(0);
            player.GetState().SetUsedSha(false);
            player.GetState().GetEquipment().InitAll();
            // 技能初始化
            List<ISkill> skills = player.GetState().GetSkill();
            if (skills.Count() > 0)
            {
                for (int i = 0; i < skills.Count(); i++)
                {
                    skills.ElementAt(i).Init();
                }
            }
        }
        // 回合开始
        public void Stage_begin()
        {
            player.SetStageNum(EStageState.STAGE_BEGIN);
            //ModuleManagement.getInstance().getBattle().clear();
            //ViewManagement.getInstance().printMsg(player.getInfo().getName() + "开始");
            player.RefreshView();
        }

        // 判定阶段
        public void Stage_check()
        {
            player.SetStageNum(EStageState.STAGE_CHECK);
            //ViewManagement.getInstance().printMsg(player.getInfo().getName() + "判定");
            //获取判定牌集合
            List<AbstractCard> list = new List<AbstractCard>();
            for (int i = 0; i < player.GetState().GetCheckedCardList().Count(); i++)
            {
                list.Add(player.GetState().GetCheckedCardList().ElementAt(i));
            }
            for (int i = 0; i < list.Count(); i++)
            {
                IDelayKit d = (IDelayKit)list.ElementAt(i);
                d.DoKit();
                //System.out.println(player.toString()+","+player.getState().getCheckedCardList().get(i).toString());


                Thread.Sleep(1000);
            }
        }

        // 摸牌阶段
        public void Stage_addCards()
        {
            player.SetStageNum(EStageState.STAGE_ADDCARDS);
            //ViewManagement.getInstance().printMsg(player.getInfo().getName() + "摸牌");
            ///*System.out.println(player.getState().getId().toString()
            //        + player.getInfo().getName() + "摸牌");*/
            ////绘制动画
            ///*SwingUtilities.invokeLater(new Runnable() {

            //    @Override
            //    public void run() {
            //        PaintService.drawGetCards(player, 2);
            //    }
            //});*/
            player.GetAction().AddOneCardFromList();
            player.GetAction().AddOneCardFromList();

            player.RefreshView();
        }

        // 出牌阶段
        public void Stage_useCards()
        {
            if (!canUseCard)
            {
                canUseCard = true;
                return;
            }
            if (player.GetState().IsAI())
            {
                //AIProcess.stage_useCards();
                return;
            }
            player.SetStageNum(EStageState.STAGE_USECARDS);
            player.RefreshView();
            //ViewManagement.getInstance().printMsg( player.getInfo().getName() + "出牌");


            while (!player.IsSkip())
            {
                //// 当按下确定时候
                //if (player.getState().getRes() == Const_Game.OK) {
                //    Panel_Control pc = (Panel_Control) player.getPanel();
                //    Panel_HandCards ph = pc.getHand();
                //    Thread t = new Thread(new Command_UseCard(ph), "出牌线程");
                //    t.start();
                //    player.getState().setRes(0);

                //}
                //// 如果发动技能，暂停当前线程，等技能施放完毕，再继续
                //if (player.getState().getRes() == Const_Game.SKILL) {
                //    Thread t = new Thread((Runnable) player.getState().getSkill()
                //            .get(0));
                //    t.start();
                //    player.getState().setRes(0);
                //    synchronized (this) {
                //        try {
                //            this.wait();
                //        } catch (InterruptedException e) {
                //            // TODO Auto-generated catch block
                //            e.printStackTrace();
                //        }
                //    }
                //}
                //// 其他中断
                //if (isSkilling||player.getState().isRequest) {
                //    synchronized (this) {
                //        try {
                //            this.wait();
                //        } catch (InterruptedException e) {
                //            // TODO Auto-generated catch block
                //            e.printStackTrace();
                //        }
                //    }
                //}
                ////游戏结束
                //if(Frame_Main.isGameOver){
                //    //pass();
                //    break;
                //}
            }
        }

        // 弃牌阶段
        public void Stage_throwCrads()
        {
            if (player.GetState().IsAI())
            {
                //AIProcess.stage_throwCrads();
                return;
            }
            //Panel_Control pc = (Panel_Control)player.getPanel();
            player.SetStageNum(EStageState.STAGE_THROWCRADS);
            //ViewManagement.getInstance().printMsg(player.getInfo().getName() + "弃牌");
            /*System.out.println(player.getState().getId().toString()
                    + player.getInfo().getName() + "弃牌");*/
            player.RefreshView();
            // 检测是否需要弃牌
            if (player.GetState().GetCardList().Count() <= player.GetState()
                    .GetCurHP())
                return;
            //ViewManagement.getInstance().getPrompt().show_RemindToThrow(
            //        player.getState().GetCardList().Count()
            //                - player.getState().GetCurHP());
            //pc.getHand().setSelectLimit(
            //        player.getState().GetCardList().Count()
            //                - player.getState().GetCurHP());
            while (true)
            {
                /*pc.getHand().setSelectLimit(
                        player.getState().getCardList().size()
                                - player.getState().getCurHP());*/
                //if (player.getState().getRes() == Const_Game.OK)
                //{

                //    //new Thread(new Command_ThrowCards(pc.getHand())).start();


                //    player.getState().SetRes(0);
                //}
                if (player.GetState().GetCardList().Count() > player.GetState()
                        .GetCurHP())
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            //ViewManagement.getInstance().getPrompt().clear();
            Thread.Sleep(500);
        }

        // 回合结束
        public void Stage_end()
        {

            player.SetStageNum(EStageState.STAGE_END);
            //ViewManagement.getInstance().printMsg(player.getInfo().getName() + "结束");

        }
        //下家开始
        private void Pass()
        {
            //if(Frame_Main.isGameOver){
            //    return;
            //}
            Console.WriteLine(player.GetInfo().GetName() + "pass");
            Thread.Sleep(800);
            //ViewManagement.getInstance().refreshAll();
            player.GetNextPlayer().Process();
        }

        public bool IsSkilling()
        {
            return isSkilling;
        }

        public void SetSkilling(bool isSkilling)
        {
            this.isSkilling = isSkilling;
        }

        public bool IsCanUseCard()
        {
            return canUseCard;
        }

        public void SetCanUseCard(bool canUseCard)
        {
            this.canUseCard = canUseCard;
        }


    }
}
