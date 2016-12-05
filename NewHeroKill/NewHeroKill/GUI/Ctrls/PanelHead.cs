using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelHead : UserControl
    {
        private PictureBox picHP;
        private PictureBox picCards;
        private Label lblLife;
        private Label lblCardNumber;
        private PanelEquipments panelEquipments1;
        private Button btnPlayerImg;
    
        public PanelHead()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblLife = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.picCards = new System.Windows.Forms.PictureBox();
            this.picHP = new System.Windows.Forms.PictureBox();
            this.btnPlayerImg = new System.Windows.Forms.Button();
            this.panelEquipments1 = new NewHeroKill.GUI.Ctrls.PanelEquipments();
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.BackColor = System.Drawing.Color.Transparent;
            this.lblLife.Location = new System.Drawing.Point(3, 108);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(11, 12);
            this.lblLife.TabIndex = 3;
            this.lblLife.Text = "5";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNumber.Location = new System.Drawing.Point(88, 109);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(11, 12);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "6";
            // 
            // picCards
            // 
            this.picCards.BackColor = System.Drawing.Color.Transparent;
            this.picCards.BackgroundImage = global::NewHeroKill.Properties.Resources.bg_card;
            this.picCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCards.Location = new System.Drawing.Point(83, 105);
            this.picCards.Name = "picCards";
            this.picCards.Size = new System.Drawing.Size(20, 20);
            this.picCards.TabIndex = 2;
            this.picCards.TabStop = false;
            // 
            // picHP
            // 
            this.picHP.BackColor = System.Drawing.Color.Transparent;
            this.picHP.BackgroundImage = global::NewHeroKill.Properties.Resources.hp;
            this.picHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHP.Location = new System.Drawing.Point(0, 105);
            this.picHP.Name = "picHP";
            this.picHP.Size = new System.Drawing.Size(20, 20);
            this.picHP.TabIndex = 1;
            this.picHP.TabStop = false;
            // 
            // btnPlayerImg
            // 
            this.btnPlayerImg.BackgroundImage = global::NewHeroKill.Properties.Resources.bg_card;
            this.btnPlayerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerImg.Location = new System.Drawing.Point(1, 0);
            this.btnPlayerImg.Name = "btnPlayerImg";
            this.btnPlayerImg.Size = new System.Drawing.Size(100, 130);
            this.btnPlayerImg.TabIndex = 0;
            this.btnPlayerImg.UseVisualStyleBackColor = true;
            // 
            // panelEquipments1
            // 
            this.panelEquipments1.Location = new System.Drawing.Point(10, 52);
            this.panelEquipments1.Name = "panelEquipments1";
            this.panelEquipments1.Size = new System.Drawing.Size(82, 74);
            this.panelEquipments1.TabIndex = 5;
            // 
            // PanelHead
            // 
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.panelEquipments1);
            this.Controls.Add(this.picCards);
            this.Controls.Add(this.picHP);
            this.Controls.Add(this.btnPlayerImg);
            this.Name = "PanelHead";
            this.Size = new System.Drawing.Size(105, 132);
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //public void PaintTransparent()
        //{
        //    picHP.Visible = false;
        //    picCards.Visible = false;
        //    //lblCardNum.Visible = false;
        //    //lblLife.Visible = false;
        //    Bitmap b = new Bitmap(this.Width, this.Height);
        //    this.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

        
        //    picHP.Visible = true;
        //    picCards.Visible = true;
        //    //pictureBox1.BackColor = Color.FromArgb(80, 0, 0, 0);
        //    this.BackgroundImage = b;
        //}

    }
}
