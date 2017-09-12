namespace CarsApplication
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.DataGrid1 = new System.Windows.Forms.DataGridView();
			this.panel = new System.Windows.Forms.Panel();
			this.comboPrice = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboVehicle = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboReused = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.comboBrand = new System.Windows.Forms.ComboBox();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.comboFuel = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboEngine = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboModel = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RecentFilesListBox = new System.Windows.Forms.ListBox();
			this.RecentFilesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeView = new System.Windows.Forms.TreeView();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeRootDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadDataFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.showDiagrammsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
			this.panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.RecentFilesMenuStrip.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.dataGridMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGrid1
			// 
			this.DataGrid1.AllowUserToAddRows = false;
			this.DataGrid1.AllowUserToResizeRows = false;
			this.DataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGrid1.BackgroundColor = System.Drawing.Color.Azure;
			this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGrid1.Location = new System.Drawing.Point(235, 0);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ReadOnly = true;
			this.DataGrid1.Size = new System.Drawing.Size(720, 611);
			this.DataGrid1.TabIndex = 11;
			this.DataGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid1_KeyDown);
			this.DataGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid1_MouseClick);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel.Controls.Add(this.comboPrice);
			this.panel.Controls.Add(this.label7);
			this.panel.Controls.Add(this.comboVehicle);
			this.panel.Controls.Add(this.label6);
			this.panel.Controls.Add(this.comboReused);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.ClearBtn);
			this.panel.Controls.Add(this.comboBrand);
			this.panel.Controls.Add(this.SearchBtn);
			this.panel.Controls.Add(this.comboFuel);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.comboEngine);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.comboModel);
			this.panel.Controls.Add(this.label2);
			this.panel.Controls.Add(this.label1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(229, 611);
			this.panel.TabIndex = 12;
			// 
			// comboPrice
			// 
			this.comboPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPrice.FormattingEnabled = true;
			this.comboPrice.Items.AddRange(new object[] {
            "4000 - 10000",
            "10000 - 25000",
            "25000 - 50000",
            "50000 - 100000",
            "100000 - 250000",
            "250000 - 400000",
            " "});
			this.comboPrice.Location = new System.Drawing.Point(92, 215);
			this.comboPrice.Name = "comboPrice";
			this.comboPrice.Size = new System.Drawing.Size(121, 21);
			this.comboPrice.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 218);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Price";
			// 
			// comboVehicle
			// 
			this.comboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVehicle.FormattingEnabled = true;
			this.comboVehicle.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Off Road",
            "Pick-up",
            "Coupe",
            "Cabriolet",
            "Combi",
            "Hatchback",
            " "});
			this.comboVehicle.Location = new System.Drawing.Point(92, 183);
			this.comboVehicle.Name = "comboVehicle";
			this.comboVehicle.Size = new System.Drawing.Size(121, 21);
			this.comboVehicle.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Vehicle Type";
			// 
			// comboReused
			// 
			this.comboReused.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboReused.FormattingEnabled = true;
			this.comboReused.Items.AddRange(new object[] {
            "Yes",
            "No",
            " "});
			this.comboReused.Location = new System.Drawing.Point(92, 152);
			this.comboReused.Name = "comboReused";
			this.comboReused.Size = new System.Drawing.Size(121, 21);
			this.comboReused.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Reused";
			// 
			// ClearBtn
			// 
			this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ClearBtn.Location = new System.Drawing.Point(101, 560);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(57, 23);
			this.ClearBtn.TabIndex = 10;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// comboBrand
			// 
			this.comboBrand.BackColor = System.Drawing.SystemColors.Window;
			this.comboBrand.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBrand.FormattingEnabled = true;
			this.comboBrand.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi",
            "BMW",
            "Citroen",
            "Fiat",
            "Ford",
            "Jaguar",
            "Jeep",
            "Lancia",
            "Maseratti",
            "Nissan",
            "Opel",
            "Peugeot",
            "Seat",
            "Skoda",
            " "});
			this.comboBrand.Location = new System.Drawing.Point(92, 22);
			this.comboBrand.Name = "comboBrand";
			this.comboBrand.Size = new System.Drawing.Size(121, 21);
			this.comboBrand.TabIndex = 0;
			this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.comboBrand_SelectedIndexChanged);
			// 
			// SearchBtn
			// 
			this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SearchBtn.Location = new System.Drawing.Point(165, 560);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(57, 23);
			this.SearchBtn.TabIndex = 9;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// comboFuel
			// 
			this.comboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFuel.FormattingEnabled = true;
			this.comboFuel.Items.AddRange(new object[] {
            "Diesel",
            "Petrol",
            "Gas",
            " "});
			this.comboFuel.Location = new System.Drawing.Point(92, 119);
			this.comboFuel.Name = "comboFuel";
			this.comboFuel.Size = new System.Drawing.Size(121, 21);
			this.comboFuel.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Fuel Type";
			// 
			// comboEngine
			// 
			this.comboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEngine.FormattingEnabled = true;
			this.comboEngine.Items.AddRange(new object[] {
            "1200 - 1400",
            "1400 - 1600",
            "1600 - 1800",
            "1800 - 2000",
            "2000 - 2500",
            "2500 - 3500",
            "3500 - 5000",
            " "});
			this.comboEngine.Location = new System.Drawing.Point(92, 87);
			this.comboEngine.Name = "comboEngine";
			this.comboEngine.Size = new System.Drawing.Size(121, 21);
			this.comboEngine.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Engine Capacity";
			// 
			// comboModel
			// 
			this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModel.FormattingEnabled = true;
			this.comboModel.Location = new System.Drawing.Point(92, 54);
			this.comboModel.Name = "comboModel";
			this.comboModel.Size = new System.Drawing.Size(121, 21);
			this.comboModel.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Model";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Brand";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Controls.Add(this.RecentFilesListBox);
			this.panel1.Controls.Add(this.treeView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(955, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(229, 611);
			this.panel1.TabIndex = 13;
			// 
			// RecentFilesListBox
			// 
			this.RecentFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RecentFilesListBox.ContextMenuStrip = this.RecentFilesMenuStrip;
			this.RecentFilesListBox.FormattingEnabled = true;
			this.RecentFilesListBox.Items.AddRange(new object[] {
            "Recent Files"});
			this.RecentFilesListBox.Location = new System.Drawing.Point(0, 334);
			this.RecentFilesListBox.Name = "RecentFilesListBox";
			this.RecentFilesListBox.Size = new System.Drawing.Size(229, 277);
			this.RecentFilesListBox.TabIndex = 1;
			this.RecentFilesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RecentFilesListBox_MouseDoubleClick);
			// 
			// RecentFilesMenuStrip
			// 
			this.RecentFilesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.RecentFilesMenuStrip.Name = "listboxMenuStrip";
			this.RecentFilesMenuStrip.Size = new System.Drawing.Size(193, 48);
			this.RecentFilesMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.RecentFilesMenuStrip_Opening);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.clearAllToolStripMenuItem.Text = "Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// treeView
			// 
			this.treeView.AllowDrop = true;
			this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView.ContextMenuStrip = this.contextMenuStrip2;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(229, 338);
			this.treeView.TabIndex = 0;
			this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
			this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.delToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.changeRootDirectoryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(236, 164);
			this.contextMenuStrip2.Opened += new System.EventHandler(this.contextMenuStrip2_Opened);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// delToolStripMenuItem
			// 
			this.delToolStripMenuItem.Name = "delToolStripMenuItem";
			this.delToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.delToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.delToolStripMenuItem.Text = "Delete";
			this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// changeRootDirectoryToolStripMenuItem
			// 
			this.changeRootDirectoryToolStripMenuItem.Name = "changeRootDirectoryToolStripMenuItem";
			this.changeRootDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.changeRootDirectoryToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.changeRootDirectoryToolStripMenuItem.Text = "Change Root Directory";
			this.changeRootDirectoryToolStripMenuItem.Click += new System.EventHandler(this.changeRootDirectoryToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 6);
			// 
			// sendEmailToolStripMenuItem
			// 
			this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
			this.sendEmailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.sendEmailToolStripMenuItem.Text = "Send e-mail";
			this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
			// 
			// dataGridMenuStrip
			// 
			this.dataGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.refreshToolStripMenuItem1,
            this.showDiagrammsToolStripMenuItem});
			this.dataGridMenuStrip.Name = "dataGridMenuStrip";
			this.dataGridMenuStrip.Size = new System.Drawing.Size(199, 136);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// modifyToolStripMenuItem
			// 
			this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.loadDataFromFileToolStripMenuItem});
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.modifyToolStripMenuItem.Text = "Modify";
			// 
			// newEntryToolStripMenuItem
			// 
			this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
			this.newEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.newEntryToolStripMenuItem.Text = "New Entry";
			this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// loadDataFromFileToolStripMenuItem
			// 
			this.loadDataFromFileToolStripMenuItem.Name = "loadDataFromFileToolStripMenuItem";
			this.loadDataFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.loadDataFromFileToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.loadDataFromFileToolStripMenuItem.Text = "Load Data From File";
			this.loadDataFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadDataFromFileToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem1
			// 
			this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
			this.refreshToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
			this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
			this.refreshToolStripMenuItem1.Text = "Refresh";
			this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
			// 
			// showDiagrammsToolStripMenuItem
			// 
			this.showDiagrammsToolStripMenuItem.Name = "showDiagrammsToolStripMenuItem";
			this.showDiagrammsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.showDiagrammsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.showDiagrammsToolStripMenuItem.Text = "Show Diagrams";
			this.showDiagrammsToolStripMenuItem.Click += new System.EventHandler(this.showDiagrammsToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 611);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.DataGrid1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Cars Index";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.RecentFilesMenuStrip.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.dataGridMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboReused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox comboFuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboEngine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ListBox RecentFilesListBox;
        private System.Windows.Forms.ContextMenuStrip RecentFilesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeRootDirectoryToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip dataGridMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem loadDataFromFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showDiagrammsToolStripMenuItem;
	}
}

