using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Emoji.Control {
    public partial class MenuTab : UserControl {
        public MenuTab(Size s, int margin, Color c, string text) {
            InitializeComponent();
            Size = new Size(s.Width - margin, s.Height - margin / 2);
            Margin = new Padding(margin / 2, margin / 4, margin / 2, margin / 4);
            BackColor = c;
            textLabel.Text = text;
            textLabel.Location = new Point((Width - textLabel.Width) / 2, (Height - textLabel.Height) / 2);
            Utils.smoothBorder(this, 10);
        }
    }
}
