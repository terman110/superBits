namespace superBits
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.paintPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paintPane
            // 
            this.paintPanel.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.paintPanel, "paintPanel");
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaintEvent);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.paintPanel);
            this.Name = "mainForm";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;

    }
}

