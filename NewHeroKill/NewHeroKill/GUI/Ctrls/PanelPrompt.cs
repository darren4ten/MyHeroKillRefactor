using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelPrompt : UserControl
    {
        private Label lblPromptMsg;
    
        public PanelPrompt()
        {

        }

        private void InitializeComponent()
        {
            this.lblPromptMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPromptMsg
            // 
            this.lblPromptMsg.AutoSize = true;
            this.lblPromptMsg.Location = new System.Drawing.Point(23, 15);
            this.lblPromptMsg.Name = "lblPromptMsg";
            this.lblPromptMsg.Size = new System.Drawing.Size(41, 12);
            this.lblPromptMsg.TabIndex = 0;
            this.lblPromptMsg.Text = "label1";
            // 
            // PanelPrompt
            // 
            this.Controls.Add(this.lblPromptMsg);
            this.Name = "PanelPrompt";
            this.Size = new System.Drawing.Size(490, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
