using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGDI.Ctrls
{
    public class PanelEquipments:UserControl
    {
        private Label lblWeapon;
        private PictureBox picWeapon;
        private PictureBox picEquipment;
        private Label lblEquipment;
        private PictureBox picDefenseHose;
        private Label lblDefenseHose;
        private PictureBox picAttackHose;
        private Label lblAttackHose;

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
            this.picEquipment = new System.Windows.Forms.PictureBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.picDefenseHose = new System.Windows.Forms.PictureBox();
            this.lblDefenseHose = new System.Windows.Forms.Label();
            this.picAttackHose = new System.Windows.Forms.PictureBox();
            this.lblAttackHose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEquipmentsBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefenseHose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttackHose)).BeginInit();
            this.SuspendLayout();
            // 
            // picEquipmentsBg
            // 
            this.picEquipmentsBg.BackgroundImage = global::TestGDI.Properties.Resources.bg_eq;
            this.picEquipmentsBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEquipmentsBg.Location = new System.Drawing.Point(1, 3);
            this.picEquipmentsBg.Name = "picEquipmentsBg";
            this.picEquipmentsBg.Size = new System.Drawing.Size(130, 130);
            this.picEquipmentsBg.TabIndex = 0;
            this.picEquipmentsBg.TabStop = false;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.BackColor = System.Drawing.Color.Black;
            this.lblWeapon.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeapon.ForeColor = System.Drawing.Color.White;
            this.lblWeapon.Location = new System.Drawing.Point(50, 15);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(63, 14);
            this.lblWeapon.TabIndex = 1;
            this.lblWeapon.Text = "K 芦叶枪";
            // 
            // picWeapon
            // 
            this.picWeapon.BackgroundImage = global::TestGDI.Properties.Resources.color_hongxin;
            this.picWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWeapon.Location = new System.Drawing.Point(32, 13);
            this.picWeapon.Name = "picWeapon";
            this.picWeapon.Size = new System.Drawing.Size(16, 16);
            this.picWeapon.TabIndex = 2;
            this.picWeapon.TabStop = false;
            // 
            // picEquipment
            // 
            this.picEquipment.BackgroundImage = global::TestGDI.Properties.Resources.color_hongxin;
            this.picEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEquipment.Location = new System.Drawing.Point(32, 44);
            this.picEquipment.Name = "picEquipment";
            this.picEquipment.Size = new System.Drawing.Size(16, 16);
            this.picEquipment.TabIndex = 4;
            this.picEquipment.TabStop = false;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.BackColor = System.Drawing.Color.Black;
            this.lblEquipment.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEquipment.ForeColor = System.Drawing.Color.White;
            this.lblEquipment.Location = new System.Drawing.Point(50, 46);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(63, 14);
            this.lblEquipment.TabIndex = 3;
            this.lblEquipment.Text = "K 芦叶枪";
            // 
            // picDefenseHose
            // 
            this.picDefenseHose.BackgroundImage = global::TestGDI.Properties.Resources.color_hongxin;
            this.picDefenseHose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDefenseHose.Location = new System.Drawing.Point(32, 73);
            this.picDefenseHose.Name = "picDefenseHose";
            this.picDefenseHose.Size = new System.Drawing.Size(16, 16);
            this.picDefenseHose.TabIndex = 6;
            this.picDefenseHose.TabStop = false;
            // 
            // lblDefenseHose
            // 
            this.lblDefenseHose.AutoSize = true;
            this.lblDefenseHose.BackColor = System.Drawing.Color.Black;
            this.lblDefenseHose.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDefenseHose.ForeColor = System.Drawing.Color.White;
            this.lblDefenseHose.Location = new System.Drawing.Point(50, 75);
            this.lblDefenseHose.Name = "lblDefenseHose";
            this.lblDefenseHose.Size = new System.Drawing.Size(63, 14);
            this.lblDefenseHose.TabIndex = 5;
            this.lblDefenseHose.Text = "K 芦叶枪";
            // 
            // picAttackHose
            // 
            this.picAttackHose.BackgroundImage = global::TestGDI.Properties.Resources.color_hongxin;
            this.picAttackHose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAttackHose.Location = new System.Drawing.Point(33, 106);
            this.picAttackHose.Name = "picAttackHose";
            this.picAttackHose.Size = new System.Drawing.Size(16, 16);
            this.picAttackHose.TabIndex = 8;
            this.picAttackHose.TabStop = false;
            // 
            // lblAttackHose
            // 
            this.lblAttackHose.AutoSize = true;
            this.lblAttackHose.BackColor = System.Drawing.Color.Black;
            this.lblAttackHose.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAttackHose.ForeColor = System.Drawing.Color.White;
            this.lblAttackHose.Location = new System.Drawing.Point(51, 108);
            this.lblAttackHose.Name = "lblAttackHose";
            this.lblAttackHose.Size = new System.Drawing.Size(63, 14);
            this.lblAttackHose.TabIndex = 7;
            this.lblAttackHose.Text = "K 芦叶枪";
            // 
            // PanelEquipments
            // 
            this.Controls.Add(this.picAttackHose);
            this.Controls.Add(this.lblAttackHose);
            this.Controls.Add(this.picDefenseHose);
            this.Controls.Add(this.lblDefenseHose);
            this.Controls.Add(this.picEquipment);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.picWeapon);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.picEquipmentsBg);
            this.Name = "PanelEquipments";
            this.Size = new System.Drawing.Size(133, 135);
            ((System.ComponentModel.ISupportInitialize)(this.picEquipmentsBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefenseHose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttackHose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
