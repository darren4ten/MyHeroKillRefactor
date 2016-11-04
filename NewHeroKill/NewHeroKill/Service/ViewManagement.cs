using NewHeroKill.Player;
using System.Collections.Generic;

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

        // 可刷新组件集合
        internal IList<IRefreshble> refreshList = new List<IRefreshble>();
        // 消息面板
        internal javax.swing.JTextArea msg;
        // 聊天面板
        internal javax.swing.JTextArea msgChat;
        // 提示信息
        internal Panel_Prompt prompt;
        // 战场消息面板
        internal Panel_Message message;

        /// <summary>
        /// 通知所有组件刷新
        /// </summary>
        public virtual void refreshAll()
        {
            //JAVA TO C# CONVERTER TODO TASK: Anonymous inner classes are not converted to C# if the base type is not defined in the code being converted:
            //			javax.swing.SwingUtilities.invokeLater(new Runnable()
            //		{
            //
            //			@Override public void run()
            //			{
            //				for (int i = 0; i < refreshList.size(); i++)
            //				{
            //					refreshList.get(i).refresh();
            //					// System.out.println(i+"刷新");
            //				}
            //				printChatMsg("refresh!");
            //			}
            //		});
        }

        /// <summary>
        /// 打印消息
        /// </summary>
        public virtual void printMsg(string str)
        {
            msg.append(str + "\n");
            msg.CaretPosition = msg.Text.length();
            // printBattleMsg(str);
        }

        /// <summary>
        /// 聊天信息追加
        /// 
        /// @return
        /// </summary>
        public virtual void printChatMsg(string msg)
        {
            // msgChat.append("【AI孙权】道：我去你妈了个彼得！会不会玩啊"+"\n");
            msgChat.append(msg + "\n");
            msgChat.CaretPosition = msgChat.Text.length();
        }

        /// <summary>
        /// 战场信息显示 战场信息默认同时在消息面板出现
        /// 
        /// @return
        /// </summary>
        public virtual void printBattleMsg(string str)
        {
            message.addMessage(str);
            message.repaint();
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

        public virtual IList<IRefreshble> RefreshList
        {
            get
            {
                return refreshList;
            }
        }

        public virtual javax.swing.JTextArea Msg
        {
            get
            {
                return msg;
            }
            set
            {
                this.msg = value;
            }
        }


        public virtual javax.swing.JTextArea MsgChat
        {
            set
            {
                this.msgChat = value;
            }
        }

        public virtual Panel_Prompt Prompt
        {
            get
            {
                return prompt;
            }
            set
            {
                this.prompt = value;
            }
        }


        public virtual Panel_Message Message
        {
            set
            {
                this.message = value;
            }
        }

    }

}