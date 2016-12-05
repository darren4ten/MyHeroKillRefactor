using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelMain : UserControl
    {
        private PanelPlayerOther panelPlayerOther1;
        private PanelPlayerOther panelPlayerOther2;
        private PanelPlayerOther panelPlayerOther3;
        private PanelBattlefiled panelBattlefiled1;
        private PanelMessage panelMessage1;
        private PanelMessage panelMessage2;
        private PanelPlayerStandard panelPlayerStandard1;
    
        public PanelMain()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelBattlefiled1 = new NewHeroKill.GUI.Ctrls.PanelBattlefiled();
            this.panelPlayerOther3 = new NewHeroKill.GUI.Ctrls.PanelPlayerOther();
            this.panelPlayerOther2 = new NewHeroKill.GUI.Ctrls.PanelPlayerOther();
            this.panelPlayerOther1 = new NewHeroKill.GUI.Ctrls.PanelPlayerOther();
            this.panelPlayerStandard1 = new NewHeroKill.GUI.Ctrls.PanelPlayerStandard();
            this.panelMessage1 = new NewHeroKill.GUI.Ctrls.PanelMessage();
            this.panelMessage2 = new NewHeroKill.GUI.Ctrls.PanelMessage();
            this.SuspendLayout();
            // 
            // panelBattlefiled1
            // 
            this.panelBattlefiled1.BackColor = System.Drawing.Color.Transparent;
            this.panelBattlefiled1.Location = new System.Drawing.Point(116, 133);
            this.panelBattlefiled1.Name = "panelBattlefiled1";
            this.panelBattlefiled1.Size = new System.Drawing.Size(534, 190);
            this.panelBattlefiled1.TabIndex = 4;
            // 
            // panelPlayerOther3
            // 
            this.panelPlayerOther3.Location = new System.Drawing.Point(330, 1);
            this.panelPlayerOther3.Name = "panelPlayerOther3";
            this.panelPlayerOther3.Size = new System.Drawing.Size(103, 127);
            this.panelPlayerOther3.TabIndex = 3;
            // 
            // panelPlayerOther2
            // 
            this.panelPlayerOther2.Location = new System.Drawing.Point(666, 170);
            this.panelPlayerOther2.Name = "panelPlayerOther2";
            this.panelPlayerOther2.Size = new System.Drawing.Size(103, 127);
            this.panelPlayerOther2.TabIndex = 2;
            // 
            // panelPlayerOther1
            // 
            this.panelPlayerOther1.Location = new System.Drawing.Point(2, 170);
            this.panelPlayerOther1.Name = "panelPlayerOther1";
            this.panelPlayerOther1.Size = new System.Drawing.Size(103, 127);
            this.panelPlayerOther1.TabIndex = 1;
            // 
            // panelPlayerStandard1
            // 
            this.panelPlayerStandard1.Location = new System.Drawing.Point(-3, 311);
            this.panelPlayerStandard1.Name = "panelPlayerStandard1";
            this.panelPlayerStandard1.Size = new System.Drawing.Size(800, 130);
            this.panelPlayerStandard1.TabIndex = 0;
            // 
            // panelMessage1
            // 
            this.panelMessage1.Location = new System.Drawing.Point(12, 13);
            this.panelMessage1.Name = "panelMessage1";
            this.panelMessage1.Size = new System.Drawing.Size(140, 140);
            this.panelMessage1.TabIndex = 5;
            // 
            // panelMessage2
            // 
            this.panelMessage2.Location = new System.Drawing.Point(629, 5);
            this.panelMessage2.Name = "panelMessage2";
            this.panelMessage2.Size = new System.Drawing.Size(140, 140);
            this.panelMessage2.TabIndex = 6;
            // 
            // PanelMain
            // 
            this.Controls.Add(this.panelMessage2);
            this.Controls.Add(this.panelMessage1);
            this.Controls.Add(this.panelBattlefiled1);
            this.Controls.Add(this.panelPlayerOther3);
            this.Controls.Add(this.panelPlayerOther2);
            this.Controls.Add(this.panelPlayerOther1);
            this.Controls.Add(this.panelPlayerStandard1);
            this.Name = "PanelMain";
            this.Size = new System.Drawing.Size(784, 440);
            this.ResumeLayout(false);

        }

    }
}
