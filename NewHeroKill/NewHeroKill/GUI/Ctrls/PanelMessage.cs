using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    /// <summary>
    /// 系统信息输出框
    /// </summary>
    public class PanelMessage : UserControl
    {
        private RichTextBox rtxtMessage;
    
        public PanelMessage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(0, 3);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(137, 134);
            this.rtxtMessage.TabIndex = 0;
            this.rtxtMessage.Text = "";
            // 
            // PanelMessage
            // 
            this.Controls.Add(this.rtxtMessage);
            this.Name = "PanelMessage";
            this.Size = new System.Drawing.Size(140, 140);
            this.ResumeLayout(false);

        }
    }
}
