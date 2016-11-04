using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGDI.Ctrls
{
    public class PanelHead : UserControl
    {
        private PictureBox picHP;
        private PictureBox picCards;
        private PictureBox picHero;

        private PictureBox picPlayerImg;
        public PanelHead()
        {
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.picPlayerImg = new System.Windows.Forms.PictureBox();
            this.picHP = new System.Windows.Forms.PictureBox();
            this.picCards = new System.Windows.Forms.PictureBox();
            this.picHero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayerImg
            // 
            this.picPlayerImg.Location = new System.Drawing.Point(0, 0);
            this.picPlayerImg.Name = "picPlayerImg";
            this.picPlayerImg.Size = new System.Drawing.Size(130, 137);
            this.picPlayerImg.TabIndex = 0;
            this.picPlayerImg.TabStop = false;
            // 
            // picHP
            // 
            this.picHP.BackgroundImage = global::TestGDI.Properties.Resources.hp;
            this.picHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHP.Location = new System.Drawing.Point(1, 110);
            this.picHP.Name = "picHP";
            this.picHP.Size = new System.Drawing.Size(26, 27);
            this.picHP.TabIndex = 1;
            this.picHP.TabStop = false;
            // 
            // picCards
            // 
            this.picCards.BackgroundImage = global::TestGDI.Properties.Resources.bg_card;
            this.picCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCards.Location = new System.Drawing.Point(104, 110);
            this.picCards.Name = "picCards";
            this.picCards.Size = new System.Drawing.Size(26, 27);
            this.picCards.TabIndex = 2;
            this.picCards.TabStop = false;
            // 
            // picHero
            // 
            this.picHero.BackgroundImage = global::TestGDI.Properties.Resources.P_liubei;
            this.picHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHero.Location = new System.Drawing.Point(18, 3);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(100, 134);
            this.picHero.TabIndex = 3;
            this.picHero.TabStop = false;
            // 
            // PanelHead
            // 
            this.Controls.Add(this.picCards);
            this.Controls.Add(this.picHP);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.picPlayerImg);
            this.Name = "PanelHead";
            this.Size = new System.Drawing.Size(143, 140);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);

        }

        public void PaintTransparent()
        {
            picHP.Visible = false;
            picCards.Visible = false;
            Bitmap b = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
            picHP.Visible = true;
            picCards.Visible = true;
            //pictureBox1.BackColor = Color.FromArgb(80, 0, 0, 0);
            this.BackgroundImage = b;
        }
    }
}
