namespace Emoji.Control {
    partial class EmojiTab {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // selectedPanel
            // 
            this.selectedPanel.Location = new System.Drawing.Point(43, 137);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(80, 10);
            this.selectedPanel.TabIndex = 0;
            this.selectedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedPanel_Paint);
            // 
            // EmojiTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmojiTab";
            this.Load += new System.EventHandler(this.EmojiTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectedPanel;
    }
}
