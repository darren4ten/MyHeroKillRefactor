using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewHeroKill.GUI.Ctrls;

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
        //������
        public Form MainForm { get; set; }


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


        // ��Ϣ���
        public PanelPrompt PromptMsg { get; set; }
        // �������
        public PanelMessage ChatMsg { get; set; }
        // ��ʾ��Ϣ
        public PanelMessage TipMsg { get; set; }

        /// <summary>
        /// ֪ͨ�������ˢ��
        /// </summary>
        public virtual void refreshAll()
        {
            PromptMsg.Refresh();
            ChatMsg.Refresh();
            TipMsg.Refresh();
        }

        /// <summary>
        /// ��ӡ��Ϣ
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
        /// ������Ϣ׷��
        /// 
        /// @return
        /// </summary>
        public virtual void printChatMsg(string msg)
        {
            //// msgChat.append("��AI��Ȩ��������ȥ�����˸��˵ã��᲻���氡"+"\n");
            //msgChat.append(msg + "\n");
            //msgChat.CaretPosition = msgChat.Text.length();
        }

        /// <summary>
        /// ս����Ϣ��ʾ ս����ϢĬ��ͬʱ����Ϣ������
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

        public void UpdateUI(Action action)
        {
            MainForm.Invoke(new MethodInvoker(action));
        }

    }

}