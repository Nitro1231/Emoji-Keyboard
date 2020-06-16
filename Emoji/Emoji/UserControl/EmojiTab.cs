using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Emoji.Control {
    public partial class EmojiTab : UserControl {

        Color g1, g2;
        private bool isSelected = false;

        [Category("Value"), DefaultValue(false)]
        public bool Value {
            get { return isSelected; }
            set {
                isSelected = value;
                selectedPanel.Refresh();
            }
        }

        public EmojiTab(Size s, Color g1, Color g2, Image img) {
            InitializeComponent();
            this.g1 = g1;
            this.g2 = g2;
            Size = s;
            selectedPanel.Size = new Size((int)(Width * 0.6), (int)(Height * 0.1));
            selectedPanel.Location = new Point((Width - selectedPanel.Width) / 2, (int)(Height * 0.9) - selectedPanel.Height / 2);
            Utils.smoothBorder(selectedPanel, selectedPanel.Height);
        }

        private void EmojiTab_Load(object sender, EventArgs e) {
            
        }

        private void selectedPanel_Paint(object sender, PaintEventArgs e) {
            if (isSelected) {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, selectedPanel.Width, selectedPanel.Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, g1, g2, 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
    }
}
