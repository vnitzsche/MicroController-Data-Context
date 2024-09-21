namespace MCDC
{
    partial class IO_Control
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonScanController = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.Controls.Add(this.ButtonScanController);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1366, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ButtonScanController
            // 
            this.ButtonScanController.CheckedState.Parent = this.ButtonScanController;
            this.ButtonScanController.CustomImages.Parent = this.ButtonScanController;
            this.ButtonScanController.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonScanController.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonScanController.ForeColor = System.Drawing.Color.White;
            this.ButtonScanController.HoverState.Parent = this.ButtonScanController;
            this.ButtonScanController.Location = new System.Drawing.Point(0, 0);
            this.ButtonScanController.Name = "ButtonScanController";
            this.ButtonScanController.ShadowDecoration.Parent = this.ButtonScanController;
            this.ButtonScanController.Size = new System.Drawing.Size(180, 100);
            this.ButtonScanController.TabIndex = 0;
            this.ButtonScanController.Text = "Scan for Controllers";
            this.ButtonScanController.Click += new System.EventHandler(this.ButtonScanController_Click);
            // 
            // IO_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 874);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "IO_Control";
            this.Text = "IO_Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IO_Control_FormClosing);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ButtonScanController;
    }
}