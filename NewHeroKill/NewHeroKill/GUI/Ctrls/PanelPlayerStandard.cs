using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelPlayerStandard : UserControl
    {
        private PanelHead panelHead1;
        private PanelSkills panelSkills1;
        private PanelHandCards panelHandCards1;

        public PanelPlayerStandard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelHead1 = new NewHeroKill.GUI.Ctrls.PanelHead();
            this.panelHandCards1 = new NewHeroKill.GUI.Ctrls.PanelHandCards();
            this.panelSkills1 = new NewHeroKill.GUI.Ctrls.PanelSkills();
            this.SuspendLayout();
            // 
            // panelHead1
            // 
            this.panelHead1.Location = new System.Drawing.Point(3, 7);
            this.panelHead1.Name = "panelHead1";
            this.panelHead1.Size = new System.Drawing.Size(105, 132);
            this.panelHead1.TabIndex = 0;
            // 
            // panelHandCards1
            // 
            this.panelHandCards1.BackColor = System.Drawing.Color.Transparent;
            this.panelHandCards1.Location = new System.Drawing.Point(105, 22);
            this.panelHandCards1.Name = "panelHandCards1";
            this.panelHandCards1.Size = new System.Drawing.Size(586, 108);
            this.panelHandCards1.TabIndex = 1;
            // 
            // panelSkills1
            // 
            this.panelSkills1.Location = new System.Drawing.Point(697, 18);
            this.panelSkills1.Name = "panelSkills1";
            this.panelSkills1.Size = new System.Drawing.Size(90, 111);
            this.panelSkills1.TabIndex = 2;
            // 
            // PanelPlayerStandard
            // 
            this.Controls.Add(this.panelSkills1);
            this.Controls.Add(this.panelHandCards1);
            this.Controls.Add(this.panelHead1);
            this.Name = "PanelPlayerStandard";
            this.Size = new System.Drawing.Size(800, 150);
            this.ResumeLayout(false);

        }
    }
}
