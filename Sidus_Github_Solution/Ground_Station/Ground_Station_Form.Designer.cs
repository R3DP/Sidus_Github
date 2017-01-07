﻿namespace Ground_Station
{
    partial class Ground_Station
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
            this.bwUdpSniffer = new System.ComponentModel.BackgroundWorker();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.pnlHeartBeat = new System.Windows.Forms.Panel();
            this.pnlBottomPanel = new System.Windows.Forms.Panel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.prbMainProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.ssMainLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMainLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMainLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMainLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDisplayRefresh = new System.Windows.Forms.Timer(this.components);
            this.colorDialog_Graph = new System.Windows.Forms.ColorDialog();
            this.pnlContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDataAnalysis = new System.Windows.Forms.TableLayoutPanel();
            this.lvDataAnalysis = new System.Windows.Forms.ListView();
            this.columnVariableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDataAnalysis = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_GraphSelectBackColor = new System.Windows.Forms.Button();
            this.tbGraphBackColor = new System.Windows.Forms.TextBox();
            this.button_GraphSelectColor = new System.Windows.Forms.Button();
            this.tbGraphLineColor = new System.Windows.Forms.TextBox();
            this.numericUpDown_hScale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_vScale = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_RemoveGraph = new System.Windows.Forms.Button();
            this.button_InsertGraph = new System.Windows.Forms.Button();
            this.button_GraphSetDefault = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_trackBarGraphHor = new System.Windows.Forms.TextBox();
            this.trackBar_hOffset = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_trackBarGraphVer = new System.Windows.Forms.TextBox();
            this.trackBar_vOffset = new System.Windows.Forms.TrackBar();
            this.pnlTopPanel.SuspendLayout();
            this.pnlBottomPanel.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pnlContentPanel.SuspendLayout();
            this.tableLayoutContent.SuspendLayout();
            this.tableLayoutPanelDataAnalysis.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vScale)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hOffset)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // bwUdpSniffer
            // 
            this.bwUdpSniffer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUdpSniffer_DoWork);
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.Controls.Add(this.pnlHeartBeat);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(1284, 10);
            this.pnlTopPanel.TabIndex = 0;
            // 
            // pnlHeartBeat
            // 
            this.pnlHeartBeat.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlHeartBeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeartBeat.Location = new System.Drawing.Point(0, 0);
            this.pnlHeartBeat.Name = "pnlHeartBeat";
            this.pnlHeartBeat.Size = new System.Drawing.Size(1284, 10);
            this.pnlHeartBeat.TabIndex = 0;
            // 
            // pnlBottomPanel
            // 
            this.pnlBottomPanel.Controls.Add(this.ssMain);
            this.pnlBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPanel.Location = new System.Drawing.Point(0, 710);
            this.pnlBottomPanel.Name = "pnlBottomPanel";
            this.pnlBottomPanel.Size = new System.Drawing.Size(1284, 32);
            this.pnlBottomPanel.TabIndex = 1;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prbMainProgress,
            this.ssMainLabel1,
            this.ssMainLabel2,
            this.ssMainLabel3,
            this.ssMainLabel4});
            this.ssMain.Location = new System.Drawing.Point(0, 10);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1284, 22);
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "statusStrip1";
            // 
            // prbMainProgress
            // 
            this.prbMainProgress.Name = "prbMainProgress";
            this.prbMainProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // ssMainLabel1
            // 
            this.ssMainLabel1.Name = "ssMainLabel1";
            this.ssMainLabel1.Size = new System.Drawing.Size(92, 17);
            this.ssMainLabel1.Text = "IP: ???.???.???.???";
            // 
            // ssMainLabel2
            // 
            this.ssMainLabel2.Name = "ssMainLabel2";
            this.ssMainLabel2.Size = new System.Drawing.Size(59, 17);
            this.ssMainLabel2.Text = "Port#:????";
            // 
            // ssMainLabel3
            // 
            this.ssMainLabel3.Name = "ssMainLabel3";
            this.ssMainLabel3.Size = new System.Drawing.Size(88, 17);
            this.ssMainLabel3.Text = "Not Connected";
            // 
            // ssMainLabel4
            // 
            this.ssMainLabel4.Name = "ssMainLabel4";
            this.ssMainLabel4.Size = new System.Drawing.Size(123, 17);
            this.ssMainLabel4.Text = "Client IP:???.???.???.???";
            // 
            // timerDisplayRefresh
            // 
            this.timerDisplayRefresh.Interval = 20;
            this.timerDisplayRefresh.Tick += new System.EventHandler(this.timerDisplayRefresh_Tick);
            // 
            // pnlContentPanel
            // 
            this.pnlContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContentPanel.Controls.Add(this.tableLayoutContent);
            this.pnlContentPanel.Location = new System.Drawing.Point(0, 12);
            this.pnlContentPanel.Name = "pnlContentPanel";
            this.pnlContentPanel.Size = new System.Drawing.Size(1284, 705);
            this.pnlContentPanel.TabIndex = 2;
            // 
            // tableLayoutContent
            // 
            this.tableLayoutContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContent.ColumnCount = 1;
            this.tableLayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContent.Controls.Add(this.tableLayoutPanelDataAnalysis, 0, 0);
            this.tableLayoutContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutContent.Name = "tableLayoutContent";
            this.tableLayoutContent.RowCount = 1;
            this.tableLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutContent.Size = new System.Drawing.Size(1347, 702);
            this.tableLayoutContent.TabIndex = 0;
            // 
            // tableLayoutPanelDataAnalysis
            // 
            this.tableLayoutPanelDataAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDataAnalysis.ColumnCount = 2;
            this.tableLayoutPanelDataAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanelDataAnalysis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanelDataAnalysis.Controls.Add(this.lvDataAnalysis, 0, 0);
            this.tableLayoutPanelDataAnalysis.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelDataAnalysis.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDataAnalysis.Name = "tableLayoutPanelDataAnalysis";
            this.tableLayoutPanelDataAnalysis.RowCount = 1;
            this.tableLayoutPanelDataAnalysis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDataAnalysis.Size = new System.Drawing.Size(1341, 525);
            this.tableLayoutPanelDataAnalysis.TabIndex = 1;
            // 
            // lvDataAnalysis
            // 
            this.lvDataAnalysis.CheckBoxes = true;
            this.lvDataAnalysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVariableName,
            this.columnValue});
            this.lvDataAnalysis.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvDataAnalysis.FullRowSelect = true;
            this.lvDataAnalysis.Location = new System.Drawing.Point(3, 3);
            this.lvDataAnalysis.Name = "lvDataAnalysis";
            this.lvDataAnalysis.Size = new System.Drawing.Size(367, 519);
            this.lvDataAnalysis.TabIndex = 0;
            this.lvDataAnalysis.UseCompatibleStateImageBehavior = false;
            this.lvDataAnalysis.View = System.Windows.Forms.View.Details;
            // 
            // columnVariableName
            // 
            this.columnVariableName.Text = "Variable Name";
            this.columnVariableName.Width = 224;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnValue.Width = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pnlDataAnalysis, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(376, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.27723F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.722772F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 519);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnlDataAnalysis
            // 
            this.pnlDataAnalysis.Location = new System.Drawing.Point(3, 3);
            this.pnlDataAnalysis.Name = "pnlDataAnalysis";
            this.pnlDataAnalysis.Size = new System.Drawing.Size(848, 406);
            this.pnlDataAnalysis.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.642302F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.3577F));
            this.tableLayoutPanel3.Controls.Add(this.button_GraphSelectBackColor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbGraphBackColor, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_GraphSelectColor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbGraphLineColor, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_hScale, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_vScale, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 449);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(848, 66);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // button_GraphSelectBackColor
            // 
            this.button_GraphSelectBackColor.Location = new System.Drawing.Point(3, 3);
            this.button_GraphSelectBackColor.Name = "button_GraphSelectBackColor";
            this.button_GraphSelectBackColor.Size = new System.Drawing.Size(103, 27);
            this.button_GraphSelectBackColor.TabIndex = 20;
            this.button_GraphSelectBackColor.Text = "Select Back Color";
            this.button_GraphSelectBackColor.UseVisualStyleBackColor = true;
            // 
            // tbGraphBackColor
            // 
            this.tbGraphBackColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbGraphBackColor.Enabled = false;
            this.tbGraphBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGraphBackColor.Location = new System.Drawing.Point(112, 3);
            this.tbGraphBackColor.Name = "tbGraphBackColor";
            this.tbGraphBackColor.ReadOnly = true;
            this.tbGraphBackColor.Size = new System.Drawing.Size(29, 26);
            this.tbGraphBackColor.TabIndex = 16;
            // 
            // button_GraphSelectColor
            // 
            this.button_GraphSelectColor.Location = new System.Drawing.Point(3, 36);
            this.button_GraphSelectColor.Name = "button_GraphSelectColor";
            this.button_GraphSelectColor.Size = new System.Drawing.Size(103, 27);
            this.button_GraphSelectColor.TabIndex = 19;
            this.button_GraphSelectColor.Text = "Select Pen Color";
            this.button_GraphSelectColor.UseVisualStyleBackColor = true;
            // 
            // tbGraphLineColor
            // 
            this.tbGraphLineColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbGraphLineColor.Enabled = false;
            this.tbGraphLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGraphLineColor.Location = new System.Drawing.Point(112, 36);
            this.tbGraphLineColor.Name = "tbGraphLineColor";
            this.tbGraphLineColor.ReadOnly = true;
            this.tbGraphLineColor.Size = new System.Drawing.Size(29, 26);
            this.tbGraphLineColor.TabIndex = 17;
            // 
            // numericUpDown_hScale
            // 
            this.numericUpDown_hScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_hScale.DecimalPlaces = 1;
            this.numericUpDown_hScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_hScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_hScale.Location = new System.Drawing.Point(208, 3);
            this.numericUpDown_hScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_hScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_hScale.Name = "numericUpDown_hScale";
            this.numericUpDown_hScale.Size = new System.Drawing.Size(55, 26);
            this.numericUpDown_hScale.TabIndex = 21;
            this.numericUpDown_hScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(147, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "H. Scale:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(147, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "V. Scale:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_vScale
            // 
            this.numericUpDown_vScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_vScale.DecimalPlaces = 1;
            this.numericUpDown_vScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_vScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_vScale.Location = new System.Drawing.Point(208, 36);
            this.numericUpDown_vScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_vScale.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_vScale.Name = "numericUpDown_vScale";
            this.numericUpDown_vScale.Size = new System.Drawing.Size(55, 26);
            this.numericUpDown_vScale.TabIndex = 24;
            this.numericUpDown_vScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel5.Controls.Add(this.button_RemoveGraph, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_InsertGraph, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_GraphSetDefault, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(576, 27);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // button_RemoveGraph
            // 
            this.button_RemoveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RemoveGraph.Location = new System.Drawing.Point(341, 3);
            this.button_RemoveGraph.Name = "button_RemoveGraph";
            this.button_RemoveGraph.Size = new System.Drawing.Size(232, 21);
            this.button_RemoveGraph.TabIndex = 13;
            this.button_RemoveGraph.Text = "Remove";
            this.button_RemoveGraph.UseVisualStyleBackColor = true;
            // 
            // button_InsertGraph
            // 
            this.button_InsertGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_InsertGraph.Location = new System.Drawing.Point(107, 3);
            this.button_InsertGraph.Name = "button_InsertGraph";
            this.button_InsertGraph.Size = new System.Drawing.Size(228, 21);
            this.button_InsertGraph.TabIndex = 12;
            this.button_InsertGraph.Text = "Insert";
            this.button_InsertGraph.UseVisualStyleBackColor = true;
            // 
            // button_GraphSetDefault
            // 
            this.button_GraphSetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_GraphSetDefault.Location = new System.Drawing.Point(3, 3);
            this.button_GraphSetDefault.Name = "button_GraphSetDefault";
            this.button_GraphSetDefault.Size = new System.Drawing.Size(98, 21);
            this.button_GraphSetDefault.TabIndex = 11;
            this.button_GraphSetDefault.Text = "Set Default";
            this.button_GraphSetDefault.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.51887F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.481132F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_trackBarGraphHor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.trackBar_hOffset, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(848, 28);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // textBox_trackBarGraphHor
            // 
            this.textBox_trackBarGraphHor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_trackBarGraphHor.Location = new System.Drawing.Point(812, 3);
            this.textBox_trackBarGraphHor.Name = "textBox_trackBarGraphHor";
            this.textBox_trackBarGraphHor.Size = new System.Drawing.Size(33, 20);
            this.textBox_trackBarGraphHor.TabIndex = 13;
            this.textBox_trackBarGraphHor.Text = "0";
            this.textBox_trackBarGraphHor.TextChanged += new System.EventHandler(this.textBox_trackBarGraphHor_TextChanged);
            // 
            // trackBar_hOffset
            // 
            this.trackBar_hOffset.Location = new System.Drawing.Point(3, 3);
            this.trackBar_hOffset.Maximum = 400;
            this.trackBar_hOffset.Minimum = -400;
            this.trackBar_hOffset.Name = "trackBar_hOffset";
            this.trackBar_hOffset.Size = new System.Drawing.Size(789, 22);
            this.trackBar_hOffset.TabIndex = 6;
            this.trackBar_hOffset.Scroll += new System.EventHandler(this.trackBar_hOffset_Scroll);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.textBox_trackBarGraphVer, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.trackBar_vOffset, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(857, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(45, 406);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // textBox_trackBarGraphVer
            // 
            this.textBox_trackBarGraphVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_trackBarGraphVer.Location = new System.Drawing.Point(3, 385);
            this.textBox_trackBarGraphVer.Name = "textBox_trackBarGraphVer";
            this.textBox_trackBarGraphVer.Size = new System.Drawing.Size(35, 20);
            this.textBox_trackBarGraphVer.TabIndex = 12;
            this.textBox_trackBarGraphVer.Text = "0";
            this.textBox_trackBarGraphVer.TextChanged += new System.EventHandler(this.textBox_trackBarGraphVer_TextChanged);
            // 
            // trackBar_vOffset
            // 
            this.trackBar_vOffset.Location = new System.Drawing.Point(3, 3);
            this.trackBar_vOffset.Maximum = 600;
            this.trackBar_vOffset.Minimum = -600;
            this.trackBar_vOffset.Name = "trackBar_vOffset";
            this.trackBar_vOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_vOffset.Size = new System.Drawing.Size(39, 376);
            this.trackBar_vOffset.TabIndex = 7;
            this.trackBar_vOffset.Scroll += new System.EventHandler(this.trackBar_vOffset_Scroll);
            // 
            // Ground_Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 742);
            this.Controls.Add(this.pnlContentPanel);
            this.Controls.Add(this.pnlBottomPanel);
            this.Controls.Add(this.pnlTopPanel);
            this.Name = "Ground_Station";
            this.Text = "Ground Station v0.1";
            this.Load += new System.EventHandler(this.Ground_Station_Load);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlBottomPanel.ResumeLayout(false);
            this.pnlBottomPanel.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pnlContentPanel.ResumeLayout(false);
            this.tableLayoutContent.ResumeLayout(false);
            this.tableLayoutPanelDataAnalysis.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vScale)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hOffset)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwUdpSniffer;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Panel pnlBottomPanel;
        private System.Windows.Forms.Panel pnlHeartBeat;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel ssMainLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ssMainLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ssMainLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssMainLabel4;
        private System.Windows.Forms.ToolStripProgressBar prbMainProgress;
        private System.Windows.Forms.Timer timerDisplayRefresh;
        private System.Windows.Forms.ColorDialog colorDialog_Graph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContent;
        private System.Windows.Forms.TrackBar trackBar_hOffset;
        private System.Windows.Forms.TextBox textBox_trackBarGraphHor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_GraphSetDefault;
        private System.Windows.Forms.Button button_InsertGraph;
        private System.Windows.Forms.Button button_RemoveGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numericUpDown_vScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_hScale;
        private System.Windows.Forms.TextBox tbGraphLineColor;
        private System.Windows.Forms.Button button_GraphSelectColor;
        private System.Windows.Forms.TextBox tbGraphBackColor;
        private System.Windows.Forms.Button button_GraphSelectBackColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pnlDataAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.ColumnHeader columnVariableName;
        private System.Windows.Forms.ListView lvDataAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDataAnalysis;
        private System.Windows.Forms.Panel pnlContentPanel;
        private System.Windows.Forms.TrackBar trackBar_vOffset;
        private System.Windows.Forms.TextBox textBox_trackBarGraphVer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

