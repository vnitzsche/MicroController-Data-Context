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
            this.ComboBoxAvailablePorts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonConnectMicrocontroller = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ComboBoxBaudRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LabelPort = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelBaudrate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
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
            // ComboBoxAvailablePorts
            // 
            this.ComboBoxAvailablePorts.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxAvailablePorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxAvailablePorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxAvailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAvailablePorts.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxAvailablePorts.FocusedState.Parent = this.ComboBoxAvailablePorts;
            this.ComboBoxAvailablePorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxAvailablePorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxAvailablePorts.FormattingEnabled = true;
            this.ComboBoxAvailablePorts.HoverState.Parent = this.ComboBoxAvailablePorts;
            this.ComboBoxAvailablePorts.ItemHeight = 30;
            this.ComboBoxAvailablePorts.ItemsAppearance.Parent = this.ComboBoxAvailablePorts;
            this.ComboBoxAvailablePorts.Location = new System.Drawing.Point(3, 54);
            this.ComboBoxAvailablePorts.Name = "ComboBoxAvailablePorts";
            this.ComboBoxAvailablePorts.ShadowDecoration.Parent = this.ComboBoxAvailablePorts;
            this.ComboBoxAvailablePorts.Size = new System.Drawing.Size(111, 36);
            this.ComboBoxAvailablePorts.TabIndex = 1;
            this.ComboBoxAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAvailablePorts_SelectedIndexChanged);
            // 
            // ButtonConnectMicrocontroller
            // 
            this.ButtonConnectMicrocontroller.CheckedState.Parent = this.ButtonConnectMicrocontroller;
            this.ButtonConnectMicrocontroller.CustomImages.Parent = this.ButtonConnectMicrocontroller;
            this.ButtonConnectMicrocontroller.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonConnectMicrocontroller.FillColor = System.Drawing.Color.Teal;
            this.ButtonConnectMicrocontroller.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnectMicrocontroller.ForeColor = System.Drawing.Color.White;
            this.ButtonConnectMicrocontroller.HoverState.Parent = this.ButtonConnectMicrocontroller;
            this.ButtonConnectMicrocontroller.Location = new System.Drawing.Point(0, 103);
            this.ButtonConnectMicrocontroller.Name = "ButtonConnectMicrocontroller";
            this.ButtonConnectMicrocontroller.ShadowDecoration.Parent = this.ButtonConnectMicrocontroller;
            this.ButtonConnectMicrocontroller.Size = new System.Drawing.Size(234, 74);
            this.ButtonConnectMicrocontroller.TabIndex = 3;
            this.ButtonConnectMicrocontroller.Text = "Connect";
            this.ButtonConnectMicrocontroller.Click += new System.EventHandler(this.ButtonConnectMicrocontroller_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxAvailablePorts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelBaudrate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 103);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Controls.Add(this.ButtonConnectMicrocontroller);
            this.guna2Panel2.Location = new System.Drawing.Point(1120, 106);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(234, 177);
            this.guna2Panel2.TabIndex = 6;
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxBaudRate.FocusedState.Parent = this.ComboBoxBaudRate;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.HoverState.Parent = this.ComboBoxBaudRate;
            this.ComboBoxBaudRate.ItemHeight = 30;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400",
            "250000"});
            this.ComboBoxBaudRate.ItemsAppearance.Parent = this.ComboBoxBaudRate;
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(120, 54);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.ShadowDecoration.Parent = this.ComboBoxBaudRate;
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(111, 36);
            this.ComboBoxBaudRate.StartIndex = 7;
            this.ComboBoxBaudRate.TabIndex = 2;
            // 
            // LabelPort
            // 
            this.LabelPort.BackColor = System.Drawing.Color.Transparent;
            this.LabelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPort.Location = new System.Drawing.Point(3, 3);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(47, 31);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "Port";
            this.LabelPort.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBaudrate
            // 
            this.LabelBaudrate.BackColor = System.Drawing.Color.Transparent;
            this.LabelBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaudrate.Location = new System.Drawing.Point(120, 3);
            this.LabelBaudrate.Name = "LabelBaudrate";
            this.LabelBaudrate.Size = new System.Drawing.Size(100, 31);
            this.LabelBaudrate.TabIndex = 4;
            this.LabelBaudrate.Text = "Baudrate";
            this.LabelBaudrate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IO_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 874);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "IO_Control";
            this.Text = "IO_Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IO_Control_FormClosing);
            this.Load += new System.EventHandler(this.IO_Control_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ButtonScanController;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxAvailablePorts;
        private Guna.UI2.WinForms.Guna2Button ButtonConnectMicrocontroller;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxBaudRate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelPort;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelBaudrate;
    }
}