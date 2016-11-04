using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGDI.Ctrls
{
    public class PanelBattlefiled : UserControl
    {
        //已经出过的牌
        public List<Object> CardsHandout = new List<object>();
        //当前正在展示的牌
        public List<object> CardsOnShowing = new List<object>();

        public PanelBattlefiled()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PanelBattlefiled
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "PanelBattlefiled";
            this.Size = new System.Drawing.Size(600, 230);
            this.ResumeLayout(false);

        }
    }
}
