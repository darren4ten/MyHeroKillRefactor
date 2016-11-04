using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGDI.Ctrls
{
    public class PanelHPAndCardNum : UserControl
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public PanelHPAndCardNum()
        {
            InitializeComponent();
            PaintTransparent();
          
        }
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TestGDI.Properties.Resources.bg_card;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(122, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TestGDI.Properties.Resources.hp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelHPAndCardNum
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PanelHPAndCardNum";
            this.Size = new System.Drawing.Size(150, 28);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

       

        public void PaintTransparent()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Bitmap b = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            //pictureBox1.BackColor = Color.FromArgb(80, 0, 0, 0);
            this.BackgroundImage = b;
        }

     


    }

}
