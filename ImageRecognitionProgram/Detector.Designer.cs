using System.Drawing;

namespace ImageIdentifier
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel16 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel17 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel18 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Templates");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Results");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel19 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel20 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel21 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel22 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel23 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel24 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel25 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel26 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel27 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel28 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel29 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel30 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.chrtRGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabControl();
            this.pgXML = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataAttribs = new System.Windows.Forms.DataGridView();
            this.Attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlTree = new System.Windows.Forms.TreeView();
            this.pgImages = new System.Windows.Forms.TabPage();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picEdges = new System.Windows.Forms.PictureBox();
            this.picBinary = new System.Windows.Forms.PictureBox();
            this.picHeatmap = new System.Windows.Forms.PictureBox();
            this.picLines = new System.Windows.Forms.PictureBox();
            this.picSaliency = new System.Windows.Forms.PictureBox();
            this.lblHeatmap = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblEdges = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.lblSaliency = new System.Windows.Forms.Label();
            this.pgColour = new System.Windows.Forms.TabPage();
            this.tabColour = new System.Windows.Forms.TabControl();
            this.pgHSV = new System.Windows.Forms.TabPage();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblAverageCol = new System.Windows.Forms.Label();
            this.picColour = new System.Windows.Forms.PictureBox();
            this.lblBoxVal = new System.Windows.Forms.Label();
            this.lblBoxSat = new System.Windows.Forms.Label();
            this.lblBoxHue = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblHue = new System.Windows.Forms.Label();
            this.boxReference = new System.Windows.Forms.PictureBox();
            this.triangleVal = new System.Windows.Forms.PictureBox();
            this.triangleSat = new System.Windows.Forms.PictureBox();
            this.boxSaturation = new System.Windows.Forms.PictureBox();
            this.boxValue = new System.Windows.Forms.PictureBox();
            this.triangleHue = new System.Windows.Forms.PictureBox();
            this.boxHue = new System.Windows.Forms.PictureBox();
            this.pgBar = new System.Windows.Forms.TabPage();
            this.pgRGBHisto = new System.Windows.Forms.TabPage();
            this.chrtRGBHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pgRHisto = new System.Windows.Forms.TabPage();
            this.chrtRHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pgGHisto = new System.Windows.Forms.TabPage();
            this.chrtGHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pgBHisto = new System.Windows.Forms.TabPage();
            this.chrtBHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboHint = new System.Windows.Forms.ComboBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chkboxAdv = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRGB)).BeginInit();
            this.tabAdvanced.SuspendLayout();
            this.pgXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttribs)).BeginInit();
            this.pgImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaliency)).BeginInit();
            this.pgColour.SuspendLayout();
            this.tabColour.SuspendLayout();
            this.pgHSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHue)).BeginInit();
            this.pgBar.SuspendLayout();
            this.pgRGBHisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRGBHisto)).BeginInit();
            this.pgRHisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRHisto)).BeginInit();
            this.pgGHisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGHisto)).BeginInit();
            this.pgBHisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtBHisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(147, 12);
            this.btnAnalyse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(124, 55);
            this.btnAnalyse.TabIndex = 1;
            this.btnAnalyse.Text = "Go";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // chrtRGB
            // 
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX.Minimum = 0D;
            customLabel16.Text = "Red";
            customLabel17.Text = "Green";
            customLabel18.Text = "Blue";
            chartArea6.AxisY.CustomLabels.Add(customLabel16);
            chartArea6.AxisY.CustomLabels.Add(customLabel17);
            chartArea6.AxisY.CustomLabels.Add(customLabel18);
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.BackColor = System.Drawing.Color.White;
            chartArea6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea6.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea6.Name = "ChartArea1";
            this.chrtRGB.ChartAreas.Add(chartArea6);
            this.chrtRGB.Location = new System.Drawing.Point(4, 5);
            this.chrtRGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrtRGB.Name = "chrtRGB";
            this.chrtRGB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.Name = "RGB Values";
            this.chrtRGB.Series.Add(series6);
            this.chrtRGB.Size = new System.Drawing.Size(674, 674);
            this.chrtRGB.TabIndex = 23;
            this.chrtRGB.Text = "Chart";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(14, 12);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(124, 55);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(280, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 55);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.pgXML);
            this.tabAdvanced.Controls.Add(this.pgImages);
            this.tabAdvanced.Controls.Add(this.pgColour);
            this.tabAdvanced.Location = new System.Drawing.Point(1010, 12);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.SelectedIndex = 0;
            this.tabAdvanced.Size = new System.Drawing.Size(712, 777);
            this.tabAdvanced.TabIndex = 7;
            // 
            // pgXML
            // 
            this.pgXML.Controls.Add(this.btnClose);
            this.pgXML.Controls.Add(this.btnForget);
            this.pgXML.Controls.Add(this.btnClearSearch);
            this.pgXML.Controls.Add(this.lblSearch);
            this.pgXML.Controls.Add(this.boxSearch);
            this.pgXML.Controls.Add(this.btnCollapse);
            this.pgXML.Controls.Add(this.btnRestore);
            this.pgXML.Controls.Add(this.btnBackup);
            this.pgXML.Controls.Add(this.btnGraph);
            this.pgXML.Controls.Add(this.btnDelete);
            this.pgXML.Controls.Add(this.btnCreate);
            this.pgXML.Controls.Add(this.btnExpand);
            this.pgXML.Controls.Add(this.btnFile);
            this.pgXML.Controls.Add(this.btnRefresh);
            this.pgXML.Controls.Add(this.btnUpdate);
            this.pgXML.Controls.Add(this.dataAttribs);
            this.pgXML.Controls.Add(this.xmlTree);
            this.pgXML.Location = new System.Drawing.Point(4, 29);
            this.pgXML.Name = "pgXML";
            this.pgXML.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pgXML.Size = new System.Drawing.Size(704, 744);
            this.pgXML.TabIndex = 1;
            this.pgXML.Text = "XML Tree";
            this.pgXML.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(543, 692);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 35);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(388, 692);
            this.btnForget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(146, 35);
            this.btnForget.TabIndex = 42;
            this.btnForget.Text = "Forget All";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Enabled = false;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(290, 11);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(90, 43);
            this.btnClearSearch.TabIndex = 9;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(4, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(95, 29);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Text = "Search:";
            // 
            // boxSearch
            // 
            this.boxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSearch.Location = new System.Drawing.Point(110, 14);
            this.boxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(172, 35);
            this.boxSearch.TabIndex = 8;
            this.boxSearch.TextChanged += new System.EventHandler(this.boxSearch_TextChanged);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(543, 558);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(146, 35);
            this.btnCollapse.TabIndex = 17;
            this.btnCollapse.Text = "Collapse Tree";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(543, 648);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(146, 35);
            this.btnRestore.TabIndex = 21;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(388, 648);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(146, 35);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(388, 603);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(146, 35);
            this.btnGraph.TabIndex = 18;
            this.btnGraph.Text = "Edit Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(543, 469);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(388, 469);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(146, 35);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(388, 557);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(146, 35);
            this.btnExpand.TabIndex = 15;
            this.btnExpand.Text = "Expand Tree";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(543, 603);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(146, 35);
            this.btnFile.TabIndex = 19;
            this.btnFile.Text = "View Raw";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(543, 512);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 35);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(388, 512);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataAttribs
            // 
            this.dataAttribs.AllowUserToAddRows = false;
            this.dataAttribs.AllowUserToDeleteRows = false;
            this.dataAttribs.AllowUserToResizeColumns = false;
            this.dataAttribs.AllowUserToResizeRows = false;
            this.dataAttribs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAttribs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attributes,
            this.Values});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAttribs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataAttribs.Location = new System.Drawing.Point(390, 11);
            this.dataAttribs.Name = "dataAttribs";
            this.dataAttribs.RowHeadersVisible = false;
            this.dataAttribs.RowTemplate.Height = 28;
            this.dataAttribs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataAttribs.Size = new System.Drawing.Size(308, 442);
            this.dataAttribs.TabIndex = 1;
            // 
            // Attributes
            // 
            this.Attributes.HeaderText = "Attributes";
            this.Attributes.Name = "Attributes";
            this.Attributes.ReadOnly = true;
            this.Attributes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Attributes.Width = 75;
            // 
            // Values
            // 
            this.Values.HeaderText = "Values";
            this.Values.Name = "Values";
            this.Values.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Values.Width = 125;
            // 
            // xmlTree
            // 
            this.xmlTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlTree.Location = new System.Drawing.Point(6, 62);
            this.xmlTree.Name = "xmlTree";
            treeNode3.Name = "Templates";
            treeNode3.Text = "Templates";
            treeNode4.Name = "Results";
            treeNode4.Text = "Results";
            this.xmlTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.xmlTree.Size = new System.Drawing.Size(374, 664);
            this.xmlTree.TabIndex = 10;
            this.xmlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTree_AfterSelect);
            // 
            // pgImages
            // 
            this.pgImages.Controls.Add(this.picOriginal);
            this.pgImages.Controls.Add(this.picEdges);
            this.pgImages.Controls.Add(this.picBinary);
            this.pgImages.Controls.Add(this.picHeatmap);
            this.pgImages.Controls.Add(this.picLines);
            this.pgImages.Controls.Add(this.picSaliency);
            this.pgImages.Controls.Add(this.lblHeatmap);
            this.pgImages.Controls.Add(this.lblOriginal);
            this.pgImages.Controls.Add(this.lblEdges);
            this.pgImages.Controls.Add(this.lblBinary);
            this.pgImages.Controls.Add(this.lblOrientation);
            this.pgImages.Controls.Add(this.lblSaliency);
            this.pgImages.Location = new System.Drawing.Point(4, 29);
            this.pgImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgImages.Name = "pgImages";
            this.pgImages.Size = new System.Drawing.Size(704, 744);
            this.pgImages.TabIndex = 3;
            this.pgImages.Text = "Processing Maps";
            this.pgImages.UseVisualStyleBackColor = true;
            // 
            // picOriginal
            // 
            this.picOriginal.Enabled = false;
            this.picOriginal.Image = ((System.Drawing.Image)(resources.GetObject("picOriginal.Image")));
            this.picOriginal.InitialImage = ((System.Drawing.Image)(resources.GetObject("picOriginal.InitialImage")));
            this.picOriginal.Location = new System.Drawing.Point(6, 35);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(340, 211);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginal.TabIndex = 18;
            this.picOriginal.TabStop = false;
            this.picOriginal.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // picEdges
            // 
            this.picEdges.Enabled = false;
            this.picEdges.Image = ((System.Drawing.Image)(resources.GetObject("picEdges.Image")));
            this.picEdges.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEdges.InitialImage")));
            this.picEdges.Location = new System.Drawing.Point(6, 521);
            this.picEdges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEdges.Name = "picEdges";
            this.picEdges.Size = new System.Drawing.Size(340, 211);
            this.picEdges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdges.TabIndex = 17;
            this.picEdges.TabStop = false;
            this.picEdges.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // picBinary
            // 
            this.picBinary.Enabled = false;
            this.picBinary.Image = ((System.Drawing.Image)(resources.GetObject("picBinary.Image")));
            this.picBinary.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBinary.InitialImage")));
            this.picBinary.Location = new System.Drawing.Point(356, 278);
            this.picBinary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBinary.Name = "picBinary";
            this.picBinary.Size = new System.Drawing.Size(340, 211);
            this.picBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBinary.TabIndex = 16;
            this.picBinary.TabStop = false;
            this.picBinary.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // picHeatmap
            // 
            this.picHeatmap.Enabled = false;
            this.picHeatmap.Image = ((System.Drawing.Image)(resources.GetObject("picHeatmap.Image")));
            this.picHeatmap.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHeatmap.InitialImage")));
            this.picHeatmap.Location = new System.Drawing.Point(6, 275);
            this.picHeatmap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHeatmap.Name = "picHeatmap";
            this.picHeatmap.Size = new System.Drawing.Size(340, 211);
            this.picHeatmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeatmap.TabIndex = 15;
            this.picHeatmap.TabStop = false;
            this.picHeatmap.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // picLines
            // 
            this.picLines.Enabled = false;
            this.picLines.Image = ((System.Drawing.Image)(resources.GetObject("picLines.Image")));
            this.picLines.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLines.InitialImage")));
            this.picLines.Location = new System.Drawing.Point(356, 521);
            this.picLines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLines.Name = "picLines";
            this.picLines.Size = new System.Drawing.Size(340, 211);
            this.picLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLines.TabIndex = 14;
            this.picLines.TabStop = false;
            this.picLines.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // picSaliency
            // 
            this.picSaliency.Enabled = false;
            this.picSaliency.Image = ((System.Drawing.Image)(resources.GetObject("picSaliency.Image")));
            this.picSaliency.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSaliency.InitialImage")));
            this.picSaliency.Location = new System.Drawing.Point(356, 35);
            this.picSaliency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSaliency.Name = "picSaliency";
            this.picSaliency.Size = new System.Drawing.Size(340, 211);
            this.picSaliency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaliency.TabIndex = 13;
            this.picSaliency.TabStop = false;
            this.picSaliency.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // lblHeatmap
            // 
            this.lblHeatmap.AutoSize = true;
            this.lblHeatmap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatmap.Location = new System.Drawing.Point(124, 251);
            this.lblHeatmap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeatmap.Name = "lblHeatmap";
            this.lblHeatmap.Size = new System.Drawing.Size(91, 25);
            this.lblHeatmap.TabIndex = 12;
            this.lblHeatmap.Text = "Heatmap";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(102, 6);
            this.lblOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(138, 25);
            this.lblOriginal.TabIndex = 11;
            this.lblOriginal.Text = "Original Image";
            // 
            // lblEdges
            // 
            this.lblEdges.AutoSize = true;
            this.lblEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdges.Location = new System.Drawing.Point(102, 491);
            this.lblEdges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdges.Name = "lblEdges";
            this.lblEdges.Size = new System.Drawing.Size(151, 25);
            this.lblEdges.TabIndex = 8;
            this.lblEdges.Text = "Detected Edges";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.Location = new System.Drawing.Point(462, 251);
            this.lblBinary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(126, 25);
            this.lblBinary.TabIndex = 7;
            this.lblBinary.Text = "Binary Image";
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrientation.Location = new System.Drawing.Point(448, 491);
            this.lblOrientation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(159, 25);
            this.lblOrientation.TabIndex = 6;
            this.lblOrientation.Text = "Orientation Lines";
            // 
            // lblSaliency
            // 
            this.lblSaliency.AutoSize = true;
            this.lblSaliency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaliency.Location = new System.Drawing.Point(462, 6);
            this.lblSaliency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaliency.Name = "lblSaliency";
            this.lblSaliency.Size = new System.Drawing.Size(131, 25);
            this.lblSaliency.TabIndex = 5;
            this.lblSaliency.Text = "Saliency Map";
            // 
            // pgColour
            // 
            this.pgColour.Controls.Add(this.tabColour);
            this.pgColour.Location = new System.Drawing.Point(4, 29);
            this.pgColour.Name = "pgColour";
            this.pgColour.Size = new System.Drawing.Size(704, 744);
            this.pgColour.TabIndex = 2;
            this.pgColour.Text = "Colour Data";
            this.pgColour.UseVisualStyleBackColor = true;
            // 
            // tabColour
            // 
            this.tabColour.Controls.Add(this.pgHSV);
            this.tabColour.Controls.Add(this.pgBar);
            this.tabColour.Controls.Add(this.pgRGBHisto);
            this.tabColour.Controls.Add(this.pgRHisto);
            this.tabColour.Controls.Add(this.pgGHisto);
            this.tabColour.Controls.Add(this.pgBHisto);
            this.tabColour.Location = new System.Drawing.Point(4, 5);
            this.tabColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabColour.Name = "tabColour";
            this.tabColour.SelectedIndex = 0;
            this.tabColour.Size = new System.Drawing.Size(694, 728);
            this.tabColour.TabIndex = 22;
            // 
            // pgHSV
            // 
            this.pgHSV.Controls.Add(this.lblColour);
            this.pgHSV.Controls.Add(this.lblAverageCol);
            this.pgHSV.Controls.Add(this.picColour);
            this.pgHSV.Controls.Add(this.lblBoxVal);
            this.pgHSV.Controls.Add(this.lblBoxSat);
            this.pgHSV.Controls.Add(this.lblBoxHue);
            this.pgHSV.Controls.Add(this.lblValue);
            this.pgHSV.Controls.Add(this.lblSat);
            this.pgHSV.Controls.Add(this.lblHue);
            this.pgHSV.Controls.Add(this.boxReference);
            this.pgHSV.Controls.Add(this.triangleVal);
            this.pgHSV.Controls.Add(this.triangleSat);
            this.pgHSV.Controls.Add(this.boxSaturation);
            this.pgHSV.Controls.Add(this.boxValue);
            this.pgHSV.Controls.Add(this.triangleHue);
            this.pgHSV.Controls.Add(this.boxHue);
            this.pgHSV.Location = new System.Drawing.Point(4, 29);
            this.pgHSV.Name = "pgHSV";
            this.pgHSV.Size = new System.Drawing.Size(686, 695);
            this.pgHSV.TabIndex = 5;
            this.pgHSV.Text = "HSV Sliders";
            this.pgHSV.UseVisualStyleBackColor = true;
            // 
            // lblColour
            // 
            this.lblColour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(28, 468);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(616, 140);
            this.lblColour.TabIndex = 22;
            this.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageCol
            // 
            this.lblAverageCol.AutoSize = true;
            this.lblAverageCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageCol.Location = new System.Drawing.Point(16, 360);
            this.lblAverageCol.Name = "lblAverageCol";
            this.lblAverageCol.Size = new System.Drawing.Size(220, 32);
            this.lblAverageCol.TabIndex = 21;
            this.lblAverageCol.Text = "Average Colour:";
            // 
            // picColour
            // 
            this.picColour.Location = new System.Drawing.Point(22, 411);
            this.picColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picColour.Name = "picColour";
            this.picColour.Size = new System.Drawing.Size(630, 265);
            this.picColour.TabIndex = 20;
            this.picColour.TabStop = false;
            // 
            // lblBoxVal
            // 
            this.lblBoxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxVal.Location = new System.Drawing.Point(104, 251);
            this.lblBoxVal.Name = "lblBoxVal";
            this.lblBoxVal.Size = new System.Drawing.Size(70, 32);
            this.lblBoxVal.TabIndex = 19;
            this.lblBoxVal.Text = "100";
            this.lblBoxVal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBoxSat
            // 
            this.lblBoxSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxSat.Location = new System.Drawing.Point(104, 165);
            this.lblBoxSat.Name = "lblBoxSat";
            this.lblBoxSat.Size = new System.Drawing.Size(70, 32);
            this.lblBoxSat.TabIndex = 18;
            this.lblBoxSat.Text = "100";
            this.lblBoxSat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBoxHue
            // 
            this.lblBoxHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxHue.Location = new System.Drawing.Point(104, 77);
            this.lblBoxHue.Name = "lblBoxHue";
            this.lblBoxHue.Size = new System.Drawing.Size(70, 32);
            this.lblBoxHue.TabIndex = 17;
            this.lblBoxHue.Text = "360";
            this.lblBoxHue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(16, 251);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(57, 32);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Val";
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(16, 165);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(58, 32);
            this.lblSat.TabIndex = 4;
            this.lblSat.Text = "Sat";
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHue.Location = new System.Drawing.Point(16, 77);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(67, 32);
            this.lblHue.TabIndex = 3;
            this.lblHue.Text = "Hue";
            // 
            // boxReference
            // 
            this.boxReference.Location = new System.Drawing.Point(212, 31);
            this.boxReference.Name = "boxReference";
            this.boxReference.Size = new System.Drawing.Size(422, 9);
            this.boxReference.TabIndex = 13;
            this.boxReference.TabStop = false;
            // 
            // triangleVal
            // 
            this.triangleVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangleVal.Image = ((System.Drawing.Image)(resources.GetObject("triangleVal.Image")));
            this.triangleVal.Location = new System.Drawing.Point(210, 292);
            this.triangleVal.Name = "triangleVal";
            this.triangleVal.Size = new System.Drawing.Size(40, 40);
            this.triangleVal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangleVal.TabIndex = 12;
            this.triangleVal.TabStop = false;
            // 
            // triangleSat
            // 
            this.triangleSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangleSat.Image = ((System.Drawing.Image)(resources.GetObject("triangleSat.Image")));
            this.triangleSat.Location = new System.Drawing.Point(212, 203);
            this.triangleSat.Name = "triangleSat";
            this.triangleSat.Size = new System.Drawing.Size(40, 40);
            this.triangleSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangleSat.TabIndex = 11;
            this.triangleSat.TabStop = false;
            // 
            // boxSaturation
            // 
            this.boxSaturation.BackColor = System.Drawing.Color.Gray;
            this.boxSaturation.Location = new System.Drawing.Point(231, 155);
            this.boxSaturation.Name = "boxSaturation";
            this.boxSaturation.Size = new System.Drawing.Size(422, 46);
            this.boxSaturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxSaturation.TabIndex = 10;
            this.boxSaturation.TabStop = false;
            // 
            // boxValue
            // 
            this.boxValue.BackColor = System.Drawing.Color.Gray;
            this.boxValue.Image = ((System.Drawing.Image)(resources.GetObject("boxValue.Image")));
            this.boxValue.Location = new System.Drawing.Point(231, 246);
            this.boxValue.Name = "boxValue";
            this.boxValue.Size = new System.Drawing.Size(422, 46);
            this.boxValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxValue.TabIndex = 9;
            this.boxValue.TabStop = false;
            // 
            // triangleHue
            // 
            this.triangleHue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangleHue.Image = ((System.Drawing.Image)(resources.GetObject("triangleHue.Image")));
            this.triangleHue.Location = new System.Drawing.Point(212, 112);
            this.triangleHue.Name = "triangleHue";
            this.triangleHue.Size = new System.Drawing.Size(40, 40);
            this.triangleHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangleHue.TabIndex = 1;
            this.triangleHue.TabStop = false;
            // 
            // boxHue
            // 
            this.boxHue.Image = ((System.Drawing.Image)(resources.GetObject("boxHue.Image")));
            this.boxHue.Location = new System.Drawing.Point(222, 48);
            this.boxHue.Name = "boxHue";
            this.boxHue.Size = new System.Drawing.Size(440, 82);
            this.boxHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxHue.TabIndex = 6;
            this.boxHue.TabStop = false;
            // 
            // pgBar
            // 
            this.pgBar.Controls.Add(this.chrtRGB);
            this.pgBar.Location = new System.Drawing.Point(4, 29);
            this.pgBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgBar.Name = "pgBar";
            this.pgBar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgBar.Size = new System.Drawing.Size(686, 695);
            this.pgBar.TabIndex = 0;
            this.pgBar.Text = "RGB Bars";
            this.pgBar.UseVisualStyleBackColor = true;
            // 
            // pgRGBHisto
            // 
            this.pgRGBHisto.Controls.Add(this.chrtRGBHisto);
            this.pgRGBHisto.Location = new System.Drawing.Point(4, 29);
            this.pgRGBHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgRGBHisto.Name = "pgRGBHisto";
            this.pgRGBHisto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgRGBHisto.Size = new System.Drawing.Size(686, 695);
            this.pgRGBHisto.TabIndex = 1;
            this.pgRGBHisto.Text = "RGB Histogram";
            this.pgRGBHisto.UseVisualStyleBackColor = true;
            // 
            // chrtRGBHisto
            // 
            chartArea7.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.AxisX.Minimum = 0D;
            customLabel19.Text = "Red";
            customLabel20.Text = "Green";
            customLabel21.Text = "Blue";
            chartArea7.AxisY.CustomLabels.Add(customLabel19);
            chartArea7.AxisY.CustomLabels.Add(customLabel20);
            chartArea7.AxisY.CustomLabels.Add(customLabel21);
            chartArea7.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.BackColor = System.Drawing.Color.White;
            chartArea7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea7.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea7.Name = "ChartArea1";
            this.chrtRGBHisto.ChartAreas.Add(chartArea7);
            this.chrtRGBHisto.Location = new System.Drawing.Point(4, 5);
            this.chrtRGBHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrtRGBHisto.Name = "chrtRGBHisto";
            this.chrtRGBHisto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series7.Name = "RGB Values";
            this.chrtRGBHisto.Series.Add(series7);
            this.chrtRGBHisto.Size = new System.Drawing.Size(674, 674);
            this.chrtRGBHisto.TabIndex = 25;
            this.chrtRGBHisto.Text = "Chart";
            // 
            // pgRHisto
            // 
            this.pgRHisto.Controls.Add(this.chrtRHisto);
            this.pgRHisto.Location = new System.Drawing.Point(4, 29);
            this.pgRHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgRHisto.Name = "pgRHisto";
            this.pgRHisto.Size = new System.Drawing.Size(686, 695);
            this.pgRHisto.TabIndex = 2;
            this.pgRHisto.Text = "R Histogram";
            this.pgRHisto.UseVisualStyleBackColor = true;
            // 
            // chrtRHisto
            // 
            chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.AxisX.Minimum = 0D;
            customLabel22.Text = "Red";
            customLabel23.Text = "Green";
            customLabel24.Text = "Blue";
            chartArea8.AxisY.CustomLabels.Add(customLabel22);
            chartArea8.AxisY.CustomLabels.Add(customLabel23);
            chartArea8.AxisY.CustomLabels.Add(customLabel24);
            chartArea8.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.BackColor = System.Drawing.Color.White;
            chartArea8.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea8.Name = "ChartArea1";
            this.chrtRHisto.ChartAreas.Add(chartArea8);
            this.chrtRHisto.Location = new System.Drawing.Point(4, 5);
            this.chrtRHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrtRHisto.Name = "chrtRHisto";
            this.chrtRHisto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.Color = System.Drawing.Color.Red;
            series8.Name = "RGB Values";
            this.chrtRHisto.Series.Add(series8);
            this.chrtRHisto.Size = new System.Drawing.Size(674, 678);
            this.chrtRHisto.TabIndex = 24;
            this.chrtRHisto.Text = "Chart";
            // 
            // pgGHisto
            // 
            this.pgGHisto.Controls.Add(this.chrtGHisto);
            this.pgGHisto.Location = new System.Drawing.Point(4, 29);
            this.pgGHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgGHisto.Name = "pgGHisto";
            this.pgGHisto.Size = new System.Drawing.Size(686, 695);
            this.pgGHisto.TabIndex = 3;
            this.pgGHisto.Text = "G Histogram";
            this.pgGHisto.UseVisualStyleBackColor = true;
            // 
            // chrtGHisto
            // 
            chartArea9.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisX.Minimum = 0D;
            customLabel25.Text = "Red";
            customLabel26.Text = "Green";
            customLabel27.Text = "Blue";
            chartArea9.AxisY.CustomLabels.Add(customLabel25);
            chartArea9.AxisY.CustomLabels.Add(customLabel26);
            chartArea9.AxisY.CustomLabels.Add(customLabel27);
            chartArea9.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea9.Name = "ChartArea1";
            this.chrtGHisto.ChartAreas.Add(chartArea9);
            this.chrtGHisto.Location = new System.Drawing.Point(4, 5);
            this.chrtGHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrtGHisto.Name = "chrtGHisto";
            this.chrtGHisto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series9.Name = "RGB Values";
            this.chrtGHisto.Series.Add(series9);
            this.chrtGHisto.Size = new System.Drawing.Size(674, 678);
            this.chrtGHisto.TabIndex = 24;
            this.chrtGHisto.Text = "Chart";
            // 
            // pgBHisto
            // 
            this.pgBHisto.Controls.Add(this.chrtBHisto);
            this.pgBHisto.Location = new System.Drawing.Point(4, 29);
            this.pgBHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgBHisto.Name = "pgBHisto";
            this.pgBHisto.Size = new System.Drawing.Size(686, 695);
            this.pgBHisto.TabIndex = 4;
            this.pgBHisto.Text = "B Histogram";
            this.pgBHisto.UseVisualStyleBackColor = true;
            // 
            // chrtBHisto
            // 
            chartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.AxisX.Minimum = 0D;
            customLabel28.Text = "Red";
            customLabel29.Text = "Green";
            customLabel30.Text = "Blue";
            chartArea10.AxisY.CustomLabels.Add(customLabel28);
            chartArea10.AxisY.CustomLabels.Add(customLabel29);
            chartArea10.AxisY.CustomLabels.Add(customLabel30);
            chartArea10.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea10.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea10.Name = "ChartArea1";
            this.chrtBHisto.ChartAreas.Add(chartArea10);
            this.chrtBHisto.Location = new System.Drawing.Point(4, 5);
            this.chrtBHisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrtBHisto.Name = "chrtBHisto";
            this.chrtBHisto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.Color = System.Drawing.Color.Blue;
            series10.Name = "RGB Values";
            this.chrtBHisto.Series.Add(series10);
            this.chrtBHisto.Size = new System.Drawing.Size(674, 678);
            this.chrtBHisto.TabIndex = 24;
            this.chrtBHisto.Text = "Chart";
            // 
            // comboHint
            // 
            this.comboHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHint.FormattingEnabled = true;
            this.comboHint.Items.AddRange(new object[] {
            "[Automatic]",
            "Vehicle",
            "Animal",
            "Structure",
            "Object",
            "Food"});
            this.comboHint.Location = new System.Drawing.Point(842, 22);
            this.comboHint.Name = "comboHint";
            this.comboHint.Size = new System.Drawing.Size(158, 28);
            this.comboHint.TabIndex = 6;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(748, 26);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(87, 20);
            this.lblHint.TabIndex = 31;
            this.lblHint.Text = "Image Hint";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHelp.Location = new System.Drawing.Point(546, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 55);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // chkboxAdv
            // 
            this.chkboxAdv.AutoSize = true;
            this.chkboxAdv.Location = new System.Drawing.Point(609, 25);
            this.chkboxAdv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkboxAdv.Name = "chkboxAdv";
            this.chkboxAdv.Size = new System.Drawing.Size(106, 24);
            this.chkboxAdv.TabIndex = 5;
            this.chkboxAdv.Text = "Advanced";
            this.chkboxAdv.UseVisualStyleBackColor = true;
            this.chkboxAdv.CheckedChanged += new System.EventHandler(this.boxAdv_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(414, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picMain
            // 
            this.picMain.AllowDrop = true;
            this.picMain.BackColor = System.Drawing.Color.Transparent;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(14, 77);
            this.picMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(988, 706);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            this.picMain.Tag = "Extracted Foreground";
            this.picMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.picMain_DragDrop);
            this.picMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.picMain_DragEnter);
            this.picMain.DoubleClick += new System.EventHandler(this.ShowImage);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 794);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkboxAdv);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.comboHint);
            this.Controls.Add(this.tabAdvanced);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.btnAnalyse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Recognition Tool";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRGB)).EndInit();
            this.tabAdvanced.ResumeLayout(false);
            this.pgXML.ResumeLayout(false);
            this.pgXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttribs)).EndInit();
            this.pgImages.ResumeLayout(false);
            this.pgImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaliency)).EndInit();
            this.pgColour.ResumeLayout(false);
            this.tabColour.ResumeLayout(false);
            this.pgHSV.ResumeLayout(false);
            this.pgHSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHue)).EndInit();
            this.pgBar.ResumeLayout(false);
            this.pgRGBHisto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRGBHisto)).EndInit();
            this.pgRHisto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRHisto)).EndInit();
            this.pgGHisto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtGHisto)).EndInit();
            this.pgBHisto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtBHisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRGB;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabAdvanced;
        private System.Windows.Forms.TabPage pgXML;
        private System.Windows.Forms.TabPage pgColour;
        private System.Windows.Forms.DataGridView dataAttribs;
        private System.Windows.Forms.TreeView xmlTree;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.ComboBox comboHint;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TabPage pgImages;
        private System.Windows.Forms.TabControl tabColour;
        private System.Windows.Forms.TabPage pgBar;
        private System.Windows.Forms.TabPage pgRGBHisto;
        private System.Windows.Forms.TabPage pgRHisto;
        private System.Windows.Forms.TabPage pgGHisto;
        private System.Windows.Forms.TabPage pgBHisto;
        private System.Windows.Forms.Label lblOrientation;
        private System.Windows.Forms.Label lblSaliency;
        private System.Windows.Forms.Label lblEdges;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRHisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGHisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtBHisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRGBHisto;
        private System.Windows.Forms.CheckBox chkboxAdv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage pgHSV;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.PictureBox triangleHue;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.PictureBox boxHue;
        private System.Windows.Forms.PictureBox boxValue;
        private System.Windows.Forms.PictureBox boxSaturation;
        private System.Windows.Forms.PictureBox triangleVal;
        private System.Windows.Forms.PictureBox triangleSat;
        private System.Windows.Forms.PictureBox boxReference;
        private System.Windows.Forms.Label lblBoxVal;
        private System.Windows.Forms.Label lblBoxSat;
        private System.Windows.Forms.Label lblBoxHue;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Label lblAverageCol;
        private System.Windows.Forms.PictureBox picColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label lblHeatmap;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.PictureBox picSaliency;
        private System.Windows.Forms.PictureBox picLines;
        private System.Windows.Forms.PictureBox picEdges;
        private System.Windows.Forms.PictureBox picBinary;
        private System.Windows.Forms.PictureBox picHeatmap;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnForget;
    }
}

