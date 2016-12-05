using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewHeroKill.GUI.Ctrls;

namespace NewHeroKill.Service
{




    /// <summary>
    /// 视图管理类 包含游戏组件的刷新等操作
    /// 
    /// @author user
    /// 
    /// </summary>
    public class ViewManagement
    {
        //主窗口
        public Form MainForm { get; set; }


        // 单例构造
        private static ViewManagement instance;

        private ViewManagement()
        {
        }

        public static ViewManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewManagement();
                }
                return instance;
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        public static void reset()
        {
            instance = new ViewManagement();
        }


        // 消息面板
        public PanelPrompt PromptMsg { get; set; }
        // 聊天面板
        public PanelMessage ChatMsg { get; set; }
        // 提示信息
        public PanelMessage TipMsg { get; set; }

        /// <summary>
        /// 通知所有组件刷新
        /// </summary>
        public virtual void refreshAll()
        {
            PromptMsg.Refresh();
            ChatMsg.Refresh();
            TipMsg.Refresh();
        }

        /// <summary>
        /// 打印消息
        /// </summary>
        public virtual void printMsg(string str)
        {
            this.UpdateUI(() =>
            {
                //TipMsg.Controls.Find()
            });
            // printBattleMsg(str);
        }

        /// <summary>
        /// 聊天信息追加
        /// 
        /// @return
        /// </summary>
        public virtual void printChatMsg(string msg)
        {
            //// msgChat.append("【AI孙权】道：我去你妈了个彼得！会不会玩啊"+"\n");
            //msgChat.append(msg + "\n");
            //msgChat.CaretPosition = msgChat.Text.length();
        }

        /// <summary>
        /// 战场信息显示 战场信息默认同时在消息面板出现
        /// 
        /// @return
        /// </summary>
        public virtual void printBattleMsg(string str)
        {
            //message.addMessage(str);
            //message.repaint();
            printMsg(str);
        }

        /// <summary>
        /// 询问玩家是否发动技能
        /// 
        /// @return
        /// </summary>
        //JAVA TO C# CONVERTER WARNING: 'final' parameters are not allowed in .NET:
        //ORIGINAL LINE: public void ask(final AbstractPlayer player, final String skillName)
        public virtual void ask(AbstractPlayer player, string skillName)
        {
            //JAVA TO C# CONVERTER TODO TASK: Anonymous inner classes are not converted to C# if the base type is not defined in the code being converted:
            //			javax.swing.SwingUtilities.invokeLater(new Runnable()
            //		{
            //			@Override public void run()
            //			{
            //				Panel_Control pc = (Panel_Control) player.getPanel();
            //				Panel_HandCards ph = pc.getHand();
            //				ViewManagement.getInstance().getPrompt().show_Message("是否发动" +skillName);
            //				ph.unableToUseCard();
            //				ph.enableOKAndCancel();
            //
            //			}
            //		});
        }

        public void UpdateUI(Action action)
        {
            MainForm.Invoke(new MethodInvoker(action));
        }

    }

}