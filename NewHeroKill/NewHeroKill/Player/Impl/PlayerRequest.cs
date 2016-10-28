using NewHeroKill.Card;
using NewHeroKill.Data.Const;
using NewHeroKill.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewHeroKill.Player.Impl
{
    /// <summary>
    /// 玩家响应实现类 封装了玩家响应请求出某种牌的行为
    /// </summary>
    public class PlayerRequest : IPlayerRequest
    {
        // 人物模型
        AbstractPlayer player;
        //当前需要响应的牌型
        int curType;
        // 构造器
        public PlayerRequest(AbstractPlayer p)
        {
            this.player = p;
        }

        /// <summary>
        ///  询问是否出杀
        /// </summary>
        /// <returns></returns>
        public bool RequestSha()
        {
            //player.getState().setRequest(true);
            player.SetRequest(true, Const_Game.SHA);
            player.RefreshView();
            List<AbstractCard> listSha = hasCard(Const_Game.SHA);
            if (CheckHasCardByType(Const_Game.SHA) | checkHasCardByTypeWithSkill(Const_Game.SHA))
            {
                if (player.GetState().IsAI())
                {
                    Sleep(1000);
                    if (listSha.Count() < 1)
                    {
                        //player.getState().setRequest(false);
                        Clear();
                        return false;
                    }
                    else
                    {
                        listSha.ElementAt(0).requestUse(player, null);
                        //player.getState().setRequest(false);
                        Clear();
                        return true;
                    }
                }
                else
                {
                    return waitPlayerDo(listSha, Const_Game.SHA);
                }
            }
            Thread.Sleep(1000);
            //player.getState().setRequest(false);
            Clear();
            player.GetState().SetRes(0);
            //synchronized (player.getProcess()) {
            //    while (!player.getState().isRequest) {
            //        player.getProcess().notify();
            //        break;
            //    }
            //}
            return false;
        }

        /// <summary>
        /// 询问是否出闪
        /// </summary>
        /// <returns></returns>
        public bool requestShan()
        {
            //player.getState().setRequest(true);
            player.SetRequest(true, Const_Game.SHAN);
            player.RefreshView();
            // 玩家手中所有的闪
            List<AbstractCard> listShan = hasCard(Const_Game.SHAN);
            // 如果有闪则分AI和玩家情况处理，没有则直接返回false
            if (CheckHasCardByType(Const_Game.SHAN)
                    | checkHasCardByTypeWithSkill(Const_Game.SHAN))
            {
                // 如果是AI，则有就出
                if (player.GetState().IsAI())
                {
                    Sleep(1000);
                    if (listShan.isEmpty())
                    {
                        //player.getState().setRequest(false);
                        Clear();
                        return false;
                    }
                    else
                    {
                        listShan.get(0).requestUse(player, null);
                        //player.getState().setRequest(false);
                        Clear();
                        return true;
                    }
                }
                else
                {
                    return waitPlayerDo(listShan, Const_Game.SHAN);
                }
            }
            Sleep(1000);
            //player.getState().setRequest(false);
            Clear();
            player.GetState().SetRes(0);
            //synchronized (player.GetProcess()) {
            //    while (!player.GetState().isRequest) {
            //        player.GetProcess().notify();
            //        break;
            //    }
            //}
            return false;
        }

        /// <summary>
        /// 询问是否出桃
        /// </summary>
        /// <returns></returns>
        public bool RequestTao()
        {
            //player.getState().setRequest(true);
            player.SetRequest(true, Const_Game.TAO);
            List<AbstractCard> listTao = hasCard(Const_Game.TAO);
            if (CheckHasCardByType(Const_Game.TAO) | checkHasCardByTypeWithSkill(Const_Game.TAO))
            {
                if (player.GetState().IsAI())
                {
                    Sleep(1000);
                    if (listTao.Count() < 0)
                    {
                        Clear();
                        return false;
                    }
                    else
                    {
                        listTao.ElementAt(0).requestUse(player, null);
                        Clear();
                        return true;
                    }
                }
                else
                {
                    return waitPlayerDo(listTao, Const_Game.TAO);
                }
            }
            //player.getState().setRequest(false);
            Clear();
            player.GetState().SetRes(0);
            //synchronized (player.getProcess()) {
            //    while (!player.getState().isRequest) {
            //        player.getProcess().notify();
            //        break;
            //    }
            //}
            return false;
        }

        /// <summary>
        /// 询问是否出无懈可击
        /// </summary>
        /// <returns></returns>
        public bool RequestWuXie()
        {
            //player.getState().setRequest(true);
            player.SetRequest(true, Const_Game.WUXIEKEJI);
            List<AbstractCard> listWuXie = hasCard(Const_Game.WUXIEKEJI);
            if (!listWuXie.Count() < 0)
            {
                if (player.GetState().IsAI())
                {
                    Sleep(1000);
                    //player.getState().setRequest(false);
                    Clear();
                    return listWuXie.ElementAt(0).requestUse(player, null);
                }
                else
                {
                    return waitPlayerDo(listWuXie, Const_Game.WUXIEKEJI);
                }
            }
            //player.getState().setRequest(false);
            Clear();
            player.GetState().SetRes(0);
            //synchronized (player.getProcess()) {
            //    while (!player.getState().isRequest) {
            //        player.getProcess().notify();
            //        break;
            //    }
            //}
            return false;
        }

        /// <summary>
        /// 检测手牌中是否有某种牌的集合
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<AbstractCard> hasCard(int type)
        {
            List<AbstractCard> list = new List<AbstractCard>();
            // 遍历手牌 获得所有闪
            for (int i = 0; i < player.GetState().GetCardList().Count(); i++)
            {
                // 如果是闪则添加到集合中
                if (player.GetState().GetCardList().ElementAt(i).GetType() == type)
                {
                    list.Add(player.GetState().GetCardList().ElementAt(i));
                }
            }
            return list;
        }

        /// <summary>
        /// 等待玩家响应
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        private bool waitPlayerDo(List<AbstractCard> list, int type)
        {

            // 如果是玩家，则开放选择，并提示出牌
            //player.getState().setRequest(true);
            player.SetRequest(true, type);
            //final Panel_Control pc = (Panel_Control) player.getPanel();
            //// 测试停止当前线程
            //// Thread.currentThread().interrupt();
            Console.WriteLine("等待玩家选择：" + "当前线程——"
                        + Thread.CurrentThread.Name);

            //SwingUtilities.invokeLater(new Runnable() {
            //    @Override
            //    public void run() {
            //        Panel_HandCards ph = pc.getHand();
            //        ph.unableToUseCard();
            //        ph.remindToUse(type);
            //        ph.disableClick();
            //        ph.enableOKAndCancel();
            //        ph.setTargetCheck(false);
            //        if (type == Const_Game.WUXIEKEJI) {
            //            ViewManagement.getInstance().getPrompt().show_Message(
            //                    "是否发动无懈可击");
            //        } else {
            //            ViewManagement.getInstance().getPrompt().show_RemindToUse(
            //                    type, 1);
            //        }
            //    }
            //});
            int res;
            while (true)
            {
                res = player.GetState().getRes();
                if (res == type)
                {
                    player.GetState().SetRes(0);
                    bool b = false;
                    //if (!pc.getHand().getSelectedList().isEmpty()) {
                    //    AbstractCard c = pc.getHand().getSelectedList().get(0)
                    //            .getCard();
                    //    b = c.requestUse(player, null);
                    //}
                    //ViewManagement.getInstance().getPrompt().clear();
                    ////player.getState().setRequest(false);
                    //clear();
                    //synchronized (player.getProcess()) {
                    //    while (!player.getState().isRequest()) {
                    //        player.getProcess().notify();
                    //        break;
                    //    }
                    //}
                    return b;
                }
                if (res == Const_Game.CANCEL)
                {
                    //// 清空提示出牌的消息并返回
                    //ViewManagement.getInstance().getPrompt().clear();
                    break;
                }
                if (res == Const_Game.SKILL)
                {
                    //synchronized (this) {
                    //    try {
                    //        this.wait();
                    //    } catch (InterruptedException e) {
                    //        e.printStackTrace();
                    //    }
                    //}
                }
                if (res == Const_Game.REDO)
                {
                    //SwingUtilities.invokeLater(new Runnable() {
                    //    @Override
                    //    public void run() {
                    //        pc.getHand().unableToUseCard();
                    //        pc.getHand().remindToUse(type);
                    //        if (type == Const_Game.WUXIEKEJI) {
                    //            ViewManagement.getInstance().getPrompt()
                    //                    .show_Message("是否发动无懈可击");
                    //        } else {
                    //            ViewManagement.getInstance().getPrompt()
                    //                    .show_RemindToUse(type, 1);
                    //        }
                    //    }
                    //});
                    player.GetState().SetRes(0);
                    //player.getState().setRequest(true);
                    player.SetRequest(true, type);
                    continue;
                }
            }
            //player.getState().setRequest(false);
            Clear();
            player.GetState().SetRessetRes(0);
            //synchronized (player.getProcess()) {
            //    while (!player.getState().isRequest) {
            //        player.getProcess().notify();
            //        break;
            //    }
            //}
            return false;
        }

        private void Sleep(int n)
        {
            Thread.Sleep(n);
        }

        /// <summary>
        /// 检测是否拥有满足某种类型条件的牌
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool CheckHasCardByType(int type)
        {
            List<AbstractCard> list = hasCard(type);
            return list.Count() > 0;
        }

        /// <summary>
        /// 检测是否有变牌技能
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool checkHasCardByTypeWithSkill(int type)
        {
            bool hasChangCradSkill = false;
            foreach (ISkill skill in player.GetState().GetSkill())
            {
                if (skill is ISkillChangeCard)
                {
                    ISkillChangeCard cc = (ISkillChangeCard)skill;
                    if (cc.GetResultType() == type)
                    {
                        hasChangCradSkill = true;
                        break;
                    }
                }
            }
            return hasChangCradSkill;
        }

        /// <summary>
        /// 清空响应状态
        /// </summary>
        public void Clear()
        {
            player.GetState().SetRequest(false);
            curType = 0;
        }

        public int GetCurType()
        {
            return curType;
        }

        public void SetCurType(int curType)
        {
            this.curType = curType;
        }


    }
}
