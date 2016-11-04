using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGDI.Ctrls
{
    public class PanelHandCards : UserControl
    {
        private Panel panelCardsInHand;
        private Button btnCancel;
        private Button button1;
        private Button btnHandout;

        public PanelHandCards()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 更新确定，取消，棋牌按钮
        /// </summary>
        public void UpdateControlButtons()
        {

        }

        private void InitializeComponent()
        {
            this.panelCardsInHand = new System.Windows.Forms.Panel();
            this.btnHandout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCardsInHand
            // 
            this.panelCardsInHand.BackColor = System.Drawing.Color.Transparent;
            this.panelCardsInHand.Location = new System.Drawing.Point(3, 28);
            this.panelCardsInHand.Name = "panelCardsInHand";
            this.panelCardsInHand.Size = new System.Drawing.Size(499, 100);
            this.panelCardsInHand.TabIndex = 0;
            // 
            // btnHandout
            // 
            this.btnHandout.BackColor = System.Drawing.Color.Transparent;
            this.btnHandout.BackgroundImage = global::TestGDI.Properties.Resources.bok;
            this.btnHandout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHandout.FlatAppearance.BorderSize = 0;
            this.btnHandout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandout.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHandout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHandout.Location = new System.Drawing.Point(509, 31);
            this.btnHandout.Name = "btnHandout";
            this.btnHandout.Size = new System.Drawing.Size(75, 23);
            this.btnHandout.TabIndex = 1;
            this.btnHandout.Text = "确 定";
            this.btnHandout.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::TestGDI.Properties.Resources.bok;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Location = new System.Drawing.Point(508, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TestGDI.Properties.Resources.bok;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(508, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "弃 牌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PanelHandCards
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHandout);
            this.Controls.Add(this.panelCardsInHand);
            this.Name = "PanelHandCards";
            this.Size = new System.Drawing.Size(600, 140);
            this.ResumeLayout(false);

        }
    }
}
