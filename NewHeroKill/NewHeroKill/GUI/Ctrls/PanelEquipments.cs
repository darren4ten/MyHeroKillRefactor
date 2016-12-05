using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelEquipments : UserControl
    {
        private Label lblWeapon;
        private PictureBox picWeapon;

        private PictureBox picEquipmentsBg;

        public PanelEquipments()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.picEquipmentsBg = new System.Windows.Forms.PictureBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.picWeapon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEquipmentsBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // picEquipmentsBg
            // 
            this.picEquipmentsBg.BackgroundImage = global::NewHeroKill.Properties.Resources.bg_eq;
            this.picEquipmentsBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEquipmentsBg.Location = new System.Drawing.Point(1, 3);
            this.picEquipmentsBg.Name = "picEquipmentsBg";
            this.picEquipmentsBg.Size = new System.Drawing.Size(80, 70);
            this.picEquipmentsBg.TabIndex = 0;
            this.picEquipmentsBg.TabStop = false;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.BackColor = System.Drawing.Color.Black;
            this.lblWeapon.Font = new System.Drawing.Font("宋体", 8F);
            this.lblWeapon.ForeColor = System.Drawing.Color.White;
            this.lblWeapon.Location = new System.Drawing.Point(29, 6);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(50, 11);
            this.lblWeapon.TabIndex = 1;
            this.lblWeapon.Text = "K 芦叶枪";
            // 
            // picWeapon
            // 
            this.picWeapon.BackgroundImage = global::NewHeroKill.Properties.Resources.color_hongxin;
            this.picWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWeapon.Location = new System.Drawing.Point(18, 5);
            this.picWeapon.Name = "picWeapon";
            this.picWeapon.Size = new System.Drawing.Size(12, 12);
            this.picWeapon.TabIndex = 2;
            this.picWeapon.TabStop = false;
            // 
            // PanelEquipments
            // 
            this.Controls.Add(this.picWeapon);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.picEquipmentsBg);
            this.Name = "PanelEquipments";
            this.Size = new System.Drawing.Size(82, 74);
            ((System.ComponentModel.ISupportInitialize)(this.picEquipmentsBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
