using NewHeroKill.Player;
using System.Collections.Generic;

namespace NewHeroKill.Service
{




    /// <summary>
    /// ��ͼ������ ������Ϸ�����ˢ�µȲ���
    /// 
    /// @author user
    /// 
    /// </summary>
    public class ViewManagement
    {

        // ��������
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
        /// ����
        /// </summary>
        public static void reset()
        {
            instance = new ViewManagement();
        }

        // ��ˢ���������
        internal IList<IRefreshble> refreshList = new List<IRefreshble>();
        // ��Ϣ���
        internal javax.swing.JTextArea msg;
        // �������
        internal javax.swing.JTextArea msgChat;
        // ��ʾ��Ϣ
        internal Panel_Prompt prompt;
        // ս����Ϣ���
        internal Panel_Message message;

        /// <summary>
        /// ֪ͨ�������ˢ��
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
            //					// System.out.println(i+"ˢ��");
            //				}
            //				printChatMsg("refresh!");
            //			}
            //		});
        }

        /// <summary>
        /// ��ӡ��Ϣ
        /// </summary>
        public virtual void printMsg(string str)
        {
            msg.append(str + "\n");
            msg.CaretPosition = msg.Text.length();
            // printBattleMsg(str);
        }

        /// <summary>
        /// ������Ϣ׷��
        /// 
        /// @return
        /// </summary>
        public virtual void printChatMsg(string msg)
        {
            // msgChat.append("��AI��Ȩ��������ȥ�����˸��˵ã��᲻���氡"+"\n");
            msgChat.append(msg + "\n");
            msgChat.CaretPosition = msgChat.Text.length();
        }

        /// <summary>
        /// ս����Ϣ��ʾ ս����ϢĬ��ͬʱ����Ϣ������
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
        /// ѯ������Ƿ񷢶�����
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
            //				ViewManagement.getInstance().getPrompt().show_Message("�Ƿ񷢶�" +skillName);
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