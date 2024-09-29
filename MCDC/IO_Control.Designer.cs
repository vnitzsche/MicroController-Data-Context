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
            this.ButtonReadConfiguration = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonScanController = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxAvailablePorts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonConnectMicrocontroller = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxBaudRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LabelPort = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelBaudrate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TabControlIO = new System.Windows.Forms.TabControl();
            this.TabPageDI = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelDI = new System.Windows.Forms.TableLayoutPanel();
            this.tabPageDO = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelDO = new System.Windows.Forms.TableLayoutPanel();
            this.TabPageAI = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelAI = new System.Windows.Forms.TableLayoutPanel();
            this.TabPageAO = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelAO = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFileConfig = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.TabControlIO.SuspendLayout();
            this.TabPageDI.SuspendLayout();
            this.tabPageDO.SuspendLayout();
            this.TabPageAI.SuspendLayout();
            this.TabPageAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.Controls.Add(this.ButtonReadConfiguration);
            this.guna2Panel1.Controls.Add(this.ButtonScanController);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1366, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ButtonReadConfiguration
            // 
            this.ButtonReadConfiguration.CheckedState.Parent = this.ButtonReadConfiguration;
            this.ButtonReadConfiguration.CustomImages.Parent = this.ButtonReadConfiguration;
            this.ButtonReadConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonReadConfiguration.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReadConfiguration.ForeColor = System.Drawing.Color.White;
            this.ButtonReadConfiguration.HoverState.Parent = this.ButtonReadConfiguration;
            this.ButtonReadConfiguration.Location = new System.Drawing.Point(180, 0);
            this.ButtonReadConfiguration.Name = "ButtonReadConfiguration";
            this.ButtonReadConfiguration.ShadowDecoration.Parent = this.ButtonReadConfiguration;
            this.ButtonReadConfiguration.Size = new System.Drawing.Size(180, 100);
            this.ButtonReadConfiguration.TabIndex = 1;
            this.ButtonReadConfiguration.Text = "Read Configuration";
            this.ButtonReadConfiguration.Click += new System.EventHandler(this.ButtonReadConfiguration_Click);
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
            this.ComboBoxAvailablePorts.Location = new System.Drawing.Point(6, 51);
            this.ComboBoxAvailablePorts.Name = "ComboBoxAvailablePorts";
            this.ComboBoxAvailablePorts.ShadowDecoration.Parent = this.ComboBoxAvailablePorts;
            this.ComboBoxAvailablePorts.Size = new System.Drawing.Size(111, 36);
            this.ComboBoxAvailablePorts.TabIndex = 1;
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
            this.ButtonConnectMicrocontroller.Location = new System.Drawing.Point(0, 96);
            this.ButtonConnectMicrocontroller.Name = "ButtonConnectMicrocontroller";
            this.ButtonConnectMicrocontroller.ShadowDecoration.Parent = this.ButtonConnectMicrocontroller;
            this.ButtonConnectMicrocontroller.Size = new System.Drawing.Size(241, 42);
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
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 97);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(123, 51);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.ShadowDecoration.Parent = this.ComboBoxBaudRate;
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(112, 36);
            this.ComboBoxBaudRate.StartIndex = 7;
            this.ComboBoxBaudRate.TabIndex = 2;
            // 
            // LabelPort
            // 
            this.LabelPort.BackColor = System.Drawing.Color.Transparent;
            this.LabelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPort.Location = new System.Drawing.Point(6, 6);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(111, 39);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "Port";
            this.LabelPort.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBaudrate
            // 
            this.LabelBaudrate.BackColor = System.Drawing.Color.Transparent;
            this.LabelBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaudrate.Location = new System.Drawing.Point(123, 6);
            this.LabelBaudrate.Name = "LabelBaudrate";
            this.LabelBaudrate.Size = new System.Drawing.Size(112, 39);
            this.LabelBaudrate.TabIndex = 4;
            this.LabelBaudrate.Text = "Baudrate";
            this.LabelBaudrate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Controls.Add(this.ButtonConnectMicrocontroller);
            this.guna2Panel2.Location = new System.Drawing.Point(1113, 106);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(241, 138);
            this.guna2Panel2.TabIndex = 6;
            // 
            // TabControlIO
            // 
            this.TabControlIO.Controls.Add(this.TabPageDI);
            this.TabControlIO.Controls.Add(this.tabPageDO);
            this.TabControlIO.Controls.Add(this.TabPageAI);
            this.TabControlIO.Controls.Add(this.TabPageAO);
            this.TabControlIO.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabControlIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlIO.Location = new System.Drawing.Point(0, 100);
            this.TabControlIO.Name = "TabControlIO";
            this.TabControlIO.SelectedIndex = 0;
            this.TabControlIO.Size = new System.Drawing.Size(780, 774);
            this.TabControlIO.TabIndex = 8;
            // 
            // TabPageDI
            // 
            this.TabPageDI.Controls.Add(this.TableLayoutPanelDI);
            this.TabPageDI.Location = new System.Drawing.Point(4, 33);
            this.TabPageDI.Name = "TabPageDI";
            this.TabPageDI.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDI.Size = new System.Drawing.Size(772, 737);
            this.TabPageDI.TabIndex = 0;
            this.TabPageDI.Text = "Digital Inputs";
            this.TabPageDI.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelDI
            // 
            this.TableLayoutPanelDI.AllowDrop = true;
            this.TableLayoutPanelDI.AutoSize = true;
            this.TableLayoutPanelDI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelDI.ColumnCount = 6;
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelDI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 541F));
            this.TableLayoutPanelDI.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanelDI.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelDI.Name = "TableLayoutPanelDI";
            this.TableLayoutPanelDI.RowCount = 1;
            this.TableLayoutPanelDI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanelDI.Size = new System.Drawing.Size(766, 36);
            this.TableLayoutPanelDI.TabIndex = 0;
            // 
            // tabPageDO
            // 
            this.tabPageDO.Controls.Add(this.TableLayoutPanelDO);
            this.tabPageDO.Location = new System.Drawing.Point(4, 33);
            this.tabPageDO.Name = "tabPageDO";
            this.tabPageDO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDO.Size = new System.Drawing.Size(772, 737);
            this.tabPageDO.TabIndex = 1;
            this.tabPageDO.Text = "Digital Outputs";
            this.tabPageDO.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelDO
            // 
            this.TableLayoutPanelDO.AllowDrop = true;
            this.TableLayoutPanelDO.AutoSize = true;
            this.TableLayoutPanelDO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelDO.ColumnCount = 6;
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelDO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 541F));
            this.TableLayoutPanelDO.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanelDO.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelDO.Name = "TableLayoutPanelDO";
            this.TableLayoutPanelDO.RowCount = 1;
            this.TableLayoutPanelDO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanelDO.Size = new System.Drawing.Size(766, 36);
            this.TableLayoutPanelDO.TabIndex = 2;
            // 
            // TabPageAI
            // 
            this.TabPageAI.Controls.Add(this.TableLayoutPanelAI);
            this.TabPageAI.Location = new System.Drawing.Point(4, 33);
            this.TabPageAI.Name = "TabPageAI";
            this.TabPageAI.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAI.Size = new System.Drawing.Size(772, 737);
            this.TabPageAI.TabIndex = 2;
            this.TabPageAI.Text = "Analog Inputs";
            this.TabPageAI.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelAI
            // 
            this.TableLayoutPanelAI.AllowDrop = true;
            this.TableLayoutPanelAI.AutoSize = true;
            this.TableLayoutPanelAI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelAI.ColumnCount = 6;
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 541F));
            this.TableLayoutPanelAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanelAI.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelAI.Name = "TableLayoutPanelAI";
            this.TableLayoutPanelAI.RowCount = 1;
            this.TableLayoutPanelAI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanelAI.Size = new System.Drawing.Size(766, 36);
            this.TableLayoutPanelAI.TabIndex = 1;
            // 
            // TabPageAO
            // 
            this.TabPageAO.Controls.Add(this.TableLayoutPanelAO);
            this.TabPageAO.Location = new System.Drawing.Point(4, 33);
            this.TabPageAO.Name = "TabPageAO";
            this.TabPageAO.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAO.Size = new System.Drawing.Size(772, 737);
            this.TabPageAO.TabIndex = 3;
            this.TabPageAO.Text = "Analog Outputs";
            this.TabPageAO.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelAO
            // 
            this.TableLayoutPanelAO.AllowDrop = true;
            this.TableLayoutPanelAO.AutoSize = true;
            this.TableLayoutPanelAO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelAO.ColumnCount = 6;
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelAO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 541F));
            this.TableLayoutPanelAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanelAO.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelAO.Name = "TableLayoutPanelAO";
            this.TableLayoutPanelAO.RowCount = 1;
            this.TableLayoutPanelAO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanelAO.Size = new System.Drawing.Size(766, 36);
            this.TableLayoutPanelAO.TabIndex = 1;
            // 
            // OpenFileConfig
            // 
            this.OpenFileConfig.FileName = " OpenFileConfig";
            // 
            // IO_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 874);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.TabControlIO);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "IO_Control";
            this.Text = "IO_Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IO_Control_FormClosing);
            this.Load += new System.EventHandler(this.IO_Control_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.TabControlIO.ResumeLayout(false);
            this.TabPageDI.ResumeLayout(false);
            this.TabPageDI.PerformLayout();
            this.tabPageDO.ResumeLayout(false);
            this.tabPageDO.PerformLayout();
            this.TabPageAI.ResumeLayout(false);
            this.TabPageAI.PerformLayout();
            this.TabPageAO.ResumeLayout(false);
            this.TabPageAO.PerformLayout();
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
        private System.Windows.Forms.TabControl TabControlIO;
        private System.Windows.Forms.TabPage TabPageDI;
        private System.Windows.Forms.TabPage tabPageDO;
        private System.Windows.Forms.TabPage TabPageAI;
        private System.Windows.Forms.TabPage TabPageAO;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelDI;
        private Guna.UI2.WinForms.Guna2Button ButtonReadConfiguration;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelDO;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelAI;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelAO;
        private System.Windows.Forms.OpenFileDialog OpenFileConfig;
    }
}