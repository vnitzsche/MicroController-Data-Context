namespace MCDC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelHome = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2Button();
            this.PanelPageControls = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonIOcontrol = new Guna.UI2.WinForms.Guna2Button();
            this.PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelHome.SuspendLayout();
            this.PanelPageControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelHome.Controls.Add(this.PanelBottom);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.ShadowDecoration.Parent = this.PanelHome;
            this.PanelHome.Size = new System.Drawing.Size(1236, 865);
            this.PanelHome.TabIndex = 0;
            // 
            // ButtonHome
            // 
            this.ButtonHome.CheckedState.Parent = this.ButtonHome;
            this.ButtonHome.CustomImages.Parent = this.ButtonHome;
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.White;
            this.ButtonHome.HoverState.Parent = this.ButtonHome;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.ShadowDecoration.Parent = this.ButtonHome;
            this.ButtonHome.Size = new System.Drawing.Size(190, 60);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // PanelPageControls
            // 
            this.PanelPageControls.Controls.Add(this.ButtonIOcontrol);
            this.PanelPageControls.Controls.Add(this.guna2Button1);
            this.PanelPageControls.Controls.Add(this.ButtonHome);
            this.PanelPageControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPageControls.Location = new System.Drawing.Point(0, 0);
            this.PanelPageControls.Name = "PanelPageControls";
            this.PanelPageControls.ShadowDecoration.Parent = this.PanelPageControls;
            this.PanelPageControls.Size = new System.Drawing.Size(1236, 60);
            this.PanelPageControls.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(190, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(190, 60);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Home";
            // 
            // ButtonIOcontrol
            // 
            this.ButtonIOcontrol.CheckedState.Parent = this.ButtonIOcontrol;
            this.ButtonIOcontrol.CustomImages.Parent = this.ButtonIOcontrol;
            this.ButtonIOcontrol.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonIOcontrol.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIOcontrol.ForeColor = System.Drawing.Color.White;
            this.ButtonIOcontrol.HoverState.Parent = this.ButtonIOcontrol;
            this.ButtonIOcontrol.Location = new System.Drawing.Point(1046, 0);
            this.ButtonIOcontrol.Name = "ButtonIOcontrol";
            this.ButtonIOcontrol.ShadowDecoration.Parent = this.ButtonIOcontrol;
            this.ButtonIOcontrol.Size = new System.Drawing.Size(190, 60);
            this.ButtonIOcontrol.TabIndex = 2;
            this.ButtonIOcontrol.Text = "I/O-Control";
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 765);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.ShadowDecoration.Parent = this.PanelBottom;
            this.PanelBottom.Size = new System.Drawing.Size(1236, 100);
            this.PanelBottom.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1236, 865);
            this.Controls.Add(this.PanelPageControls);
            this.Controls.Add(this.PanelHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelHome.ResumeLayout(false);
            this.PanelPageControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelHome;
        private Guna.UI2.WinForms.Guna2Button ButtonHome;
        private Guna.UI2.WinForms.Guna2Panel PanelPageControls;
        private Guna.UI2.WinForms.Guna2Button ButtonIOcontrol;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel PanelBottom;
    }
}

