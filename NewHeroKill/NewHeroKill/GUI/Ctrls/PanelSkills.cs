using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelSkills : UserControl
    {
        private Button btnSkill2;
        private Button btnSkill3;
        private Button btnSkill4;
        private Button btnSkill1;
    
        public PanelSkills()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnSkill1 = new System.Windows.Forms.Button();
            this.btnSkill2 = new System.Windows.Forms.Button();
            this.btnSkill3 = new System.Windows.Forms.Button();
            this.btnSkill4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSkill1
            // 
            this.btnSkill1.BackgroundImage = global::NewHeroKill.Properties.Resources.bok;
            this.btnSkill1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkill1.FlatAppearance.BorderSize = 0;
            this.btnSkill1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkill1.Location = new System.Drawing.Point(3, 3);
            this.btnSkill1.Name = "btnSkill1";
            this.btnSkill1.Size = new System.Drawing.Size(85, 24);
            this.btnSkill1.TabIndex = 0;
            this.btnSkill1.UseVisualStyleBackColor = true;
            // 
            // btnSkill2
            // 
            this.btnSkill2.BackgroundImage = global::NewHeroKill.Properties.Resources.bok;
            this.btnSkill2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkill2.FlatAppearance.BorderSize = 0;
            this.btnSkill2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkill2.Location = new System.Drawing.Point(3, 30);
            this.btnSkill2.Name = "btnSkill2";
            this.btnSkill2.Size = new System.Drawing.Size(85, 24);
            this.btnSkill2.TabIndex = 1;
            this.btnSkill2.UseVisualStyleBackColor = true;
            // 
            // btnSkill3
            // 
            this.btnSkill3.BackgroundImage = global::NewHeroKill.Properties.Resources.bok;
            this.btnSkill3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkill3.FlatAppearance.BorderSize = 0;
            this.btnSkill3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkill3.Location = new System.Drawing.Point(3, 56);
            this.btnSkill3.Name = "btnSkill3";
            this.btnSkill3.Size = new System.Drawing.Size(85, 24);
            this.btnSkill3.TabIndex = 2;
            this.btnSkill3.UseVisualStyleBackColor = true;
            // 
            // btnSkill4
            // 
            this.btnSkill4.BackgroundImage = global::NewHeroKill.Properties.Resources.bok;
            this.btnSkill4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkill4.FlatAppearance.BorderSize = 0;
            this.btnSkill4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkill4.Location = new System.Drawing.Point(3, 83);
            this.btnSkill4.Name = "btnSkill4";
            this.btnSkill4.Size = new System.Drawing.Size(85, 24);
            this.btnSkill4.TabIndex = 3;
            this.btnSkill4.UseVisualStyleBackColor = true;
            // 
            // PanelSkills
            // 
            this.Controls.Add(this.btnSkill4);
            this.Controls.Add(this.btnSkill3);
            this.Controls.Add(this.btnSkill2);
            this.Controls.Add(this.btnSkill1);
            this.Name = "PanelSkills";
            this.Size = new System.Drawing.Size(90, 111);
            this.ResumeLayout(false);

        }
    }
}
