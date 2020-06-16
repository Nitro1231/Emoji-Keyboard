using Emoji.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emoji {
    public partial class Popup : Form {
        public Popup() {
            InitializeComponent();
        }

        private void Popup_Load(object sender, EventArgs e) {
            Size menuSize = new Size(topPanel.Width / 4, topPanel.Height);
            EmojiTab recentTabBtn = new EmojiTab(menuSize, Color.FromArgb(255, 205, 165), Color.FromArgb(238, 77, 95), null);
            EmojiTab emojiTabBtn = new EmojiTab(menuSize, Color.FromArgb(255, 152, 151), Color.FromArgb(246, 80, 160), null);
            EmojiTab GIFsTabBtn = new EmojiTab(menuSize, Color.FromArgb(255, 108, 171), Color.FromArgb(115, 102, 255), null);
            EmojiTab settingTabBtn = new EmojiTab(menuSize, Color.FromArgb(182, 94, 186), Color.FromArgb(46, 141, 225), null);
            recentTabBtn.Value = true;
            emojiTabBtn.Value = true;
            GIFsTabBtn.Value = true;
            settingTabBtn.Value = true;
            topPanel.Controls.Add(recentTabBtn);
            topPanel.Controls.Add(emojiTabBtn);
            topPanel.Controls.Add(GIFsTabBtn);
            topPanel.Controls.Add(settingTabBtn);


            Size emojiSize = new Size(50, 50);
            EmojiTab recent1 = new EmojiTab(emojiSize, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), null);
            EmojiTab recent2 = new EmojiTab(emojiSize, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), null);
            EmojiTab recent3 = new EmojiTab(emojiSize, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), null);
            EmojiTab recent4 = new EmojiTab(emojiSize, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), null);
            recent1.Value = true;
            recent2.Value = true;
            recent3.Value = true;
            recent4.Value = true;
            mainPanel.Controls.Add(recent1);
            mainPanel.Controls.Add(recent2);
            mainPanel.Controls.Add(recent3);
            mainPanel.Controls.Add(recent4);
        }

        private void Popup_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(90, 130, 230), Color.FromArgb(55, 210, 220), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }

        private void label1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
