using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewHeroKill.GUI.Ctrls
{
    public class PanelCard : UserControl
    {

        private Label lblCardNumber;
        private PictureBox picBoxCardColorType;
        private Button btnCardBg;
        public string CardColorType { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }

        public PanelCard()
        {
            InitializeComponent();
        }

        public PanelCard(string CardColorType, string CardNumber, string CardType)
        {
            InitializeComponent();
            InitCardPanel(CardColorType, CardNumber, CardType);
        }

        private void InitCardPanel(string CardColorType, string CardNumber, string CardType)
        {
            this.CardType = CardType;
            this.CardNumber = CardNumber;
            this.CardColorType = CardColorType;
            UpdatePanel();

        }

        private void UpdatePanel()
        {
            //背景图片
            btnCardBg.BackgroundImage = NewHeroKill.Properties.Resources.P_liubei;
            //花色
            if (this.CardColorType == "红桃")
            {
                picBoxCardColorType.BackgroundImage = NewHeroKill.Properties.Resources.color_hongxin1;
            }
            else if (this.CardColorType == "黑桃")
            {
                picBoxCardColorType.BackgroundImage = NewHeroKill.Properties.Resources.color_heitao;
            }
            else if (this.CardColorType == "梅花")
            {
                picBoxCardColorType.BackgroundImage = NewHeroKill.Properties.Resources.color_meihua;
            }
            else if (this.CardColorType == "方块")
            {
                picBoxCardColorType.BackgroundImage = NewHeroKill.Properties.Resources.color_fangkuai;
            }
            else
            {
                picBoxCardColorType.BackgroundImage = NewHeroKill.Properties.Resources.P_liubei;
            }
            //数字
            lblCardNumber.Text = this.CardNumber;
            this.Refresh();
        }

        private void InitializeComponent()
        {
            this.btnCardBg = new System.Windows.Forms.Button();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.picBoxCardColorType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardColorType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCardBg
            // 
            this.btnCardBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCardBg.FlatAppearance.BorderSize = 0;
            this.btnCardBg.Location = new System.Drawing.Point(3, 2);
            this.btnCardBg.Name = "btnCardBg";
            this.btnCardBg.Size = new System.Drawing.Size(80, 100);
            this.btnCardBg.TabIndex = 0;
            this.btnCardBg.UseVisualStyleBackColor = true;
            this.btnCardBg.Click += new System.EventHandler(this.btnCardBg_Click);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCardNumber.Location = new System.Drawing.Point(15, 31);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(26, 16);
            this.lblCardNumber.TabIndex = 2;
            this.lblCardNumber.Text = "lb";
            this.lblCardNumber.Click += new System.EventHandler(this.picBoxCardColorType_Click);
            // 
            // picBoxCardColorType
            // 
            this.picBoxCardColorType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxCardColorType.Location = new System.Drawing.Point(16, 12);
            this.picBoxCardColorType.Name = "picBoxCardColorType";
            this.picBoxCardColorType.Size = new System.Drawing.Size(16, 16);
            this.picBoxCardColorType.TabIndex = 3;
            this.picBoxCardColorType.TabStop = false;
            this.picBoxCardColorType.Click += new System.EventHandler(this.picBoxCardColorType_Click);
            // 
            // PanelCard
            // 
            this.Controls.Add(this.picBoxCardColorType);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.btnCardBg);
            this.Name = "PanelCard";
            this.Size = new System.Drawing.Size(83, 105);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardColorType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCardBg_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void picBoxCardColorType_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

    }
}
