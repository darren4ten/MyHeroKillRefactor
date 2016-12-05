using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelPlayerOther : UserControl
    {
        private PanelHead panelHead1;
    
        public PanelPlayerOther()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelHead1 = new NewHeroKill.GUI.Ctrls.PanelHead();
            this.SuspendLayout();
            // 
            // panelHead1
            // 
            this.panelHead1.Location = new System.Drawing.Point(-2, 1);
            this.panelHead1.Name = "panelHead1";
            this.panelHead1.Size = new System.Drawing.Size(102, 124);
            this.panelHead1.TabIndex = 0;
            // 
            // PanelPlayerOther
            // 
            this.Controls.Add(this.panelHead1);
            this.Name = "PanelPlayerOther";
            this.Size = new System.Drawing.Size(103, 127);
            this.ResumeLayout(false);

        }
    }
}
