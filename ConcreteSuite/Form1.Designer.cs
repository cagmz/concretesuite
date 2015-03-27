namespace ConcreteSuite
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			this.label1 = new System.Windows.Forms.Label();
			this.gbSlab = new System.Windows.Forms.GroupBox();
			this.cBSlabSpillage = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnClearSlabTextbox = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbSlabSqFt = new System.Windows.Forms.TextBox();
			this.tbSlabCubicYardage = new System.Windows.Forms.TextBox();
			this.btnSlabCalculate = new System.Windows.Forms.Button();
			this.tbSlabThickness = new System.Windows.Forms.TextBox();
			this.tbSlabWidth = new System.Windows.Forms.TextBox();
			this.tbSlabLength = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbCircle = new System.Windows.Forms.GroupBox();
			this.btnClearCircleTextbox = new System.Windows.Forms.Button();
			this.cBCircleSpillage = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbCircleSqFt = new System.Windows.Forms.TextBox();
			this.tbCircleCubicYardage = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnCircleCalculate = new System.Windows.Forms.Button();
			this.tbCircleThickness = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbCircleRadius = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.gBMaterialSpacing = new System.Windows.Forms.GroupBox();
			this.tbConcreteStand = new System.Windows.Forms.TextBox();
			this.tbRebarCenters = new System.Windows.Forms.TextBox();
			this.lblRebarSpacing = new System.Windows.Forms.Label();
			this.lblStandCenters = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.tbTotalRebarNeeded = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.tbTotalStandsNeeded = new System.Windows.Forms.TextBox();
			this.concreteListView = new System.Windows.Forms.ListView();
			this.gbSlab.SuspendLayout();
			this.gbCircle.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.gBMaterialSpacing.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Concrete Type:";
			// 
			// gbSlab
			// 
			this.gbSlab.Controls.Add(this.cBSlabSpillage);
			this.gbSlab.Controls.Add(this.label16);
			this.gbSlab.Controls.Add(this.btnClearSlabTextbox);
			this.gbSlab.Controls.Add(this.label10);
			this.gbSlab.Controls.Add(this.label9);
			this.gbSlab.Controls.Add(this.label8);
			this.gbSlab.Controls.Add(this.label14);
			this.gbSlab.Controls.Add(this.label7);
			this.gbSlab.Controls.Add(this.tbSlabSqFt);
			this.gbSlab.Controls.Add(this.tbSlabCubicYardage);
			this.gbSlab.Controls.Add(this.btnSlabCalculate);
			this.gbSlab.Controls.Add(this.tbSlabThickness);
			this.gbSlab.Controls.Add(this.tbSlabWidth);
			this.gbSlab.Controls.Add(this.tbSlabLength);
			this.gbSlab.Controls.Add(this.label4);
			this.gbSlab.Controls.Add(this.label3);
			this.gbSlab.Controls.Add(this.label2);
			this.gbSlab.Location = new System.Drawing.Point(10, 6);
			this.gbSlab.Name = "gbSlab";
			this.gbSlab.Size = new System.Drawing.Size(212, 233);
			this.gbSlab.TabIndex = 2;
			this.gbSlab.TabStop = false;
			this.gbSlab.Text = "Slab";
			// 
			// cBSlabSpillage
			// 
			this.cBSlabSpillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBSlabSpillage.FormattingEnabled = true;
			this.cBSlabSpillage.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15"});
			this.cBSlabSpillage.Location = new System.Drawing.Point(94, 99);
			this.cBSlabSpillage.Name = "cBSlabSpillage";
			this.cBSlabSpillage.Size = new System.Drawing.Size(61, 21);
			this.cBSlabSpillage.TabIndex = 9;
			this.cBSlabSpillage.SelectedIndexChanged += new System.EventHandler(this.cBSlabSpillage_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 102);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(164, 13);
			this.label16.TabIndex = 8;
			this.label16.Text = "Spillage Percent:                       %";
			// 
			// btnClearSlabTextbox
			// 
			this.btnClearSlabTextbox.Location = new System.Drawing.Point(13, 131);
			this.btnClearSlabTextbox.Name = "btnClearSlabTextbox";
			this.btnClearSlabTextbox.Size = new System.Drawing.Size(70, 25);
			this.btnClearSlabTextbox.TabIndex = 7;
			this.btnClearSlabTextbox.Text = "Clear";
			this.btnClearSlabTextbox.UseVisualStyleBackColor = true;
			this.btnClearSlabTextbox.Click += new System.EventHandler(this.btnClearSlabTextbox_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(159, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "feet";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(159, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "feet";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(159, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "inches";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(10, 195);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(68, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Square Feet:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Cubic Yardage:";
			// 
			// tbSlabSqFt
			// 
			this.tbSlabSqFt.Location = new System.Drawing.Point(96, 192);
			this.tbSlabSqFt.Name = "tbSlabSqFt";
			this.tbSlabSqFt.ReadOnly = true;
			this.tbSlabSqFt.Size = new System.Drawing.Size(61, 20);
			this.tbSlabSqFt.TabIndex = 5;
			// 
			// tbSlabCubicYardage
			// 
			this.tbSlabCubicYardage.Location = new System.Drawing.Point(96, 166);
			this.tbSlabCubicYardage.Name = "tbSlabCubicYardage";
			this.tbSlabCubicYardage.ReadOnly = true;
			this.tbSlabCubicYardage.Size = new System.Drawing.Size(61, 20);
			this.tbSlabCubicYardage.TabIndex = 5;
			// 
			// btnSlabCalculate
			// 
			this.btnSlabCalculate.Location = new System.Drawing.Point(93, 131);
			this.btnSlabCalculate.Name = "btnSlabCalculate";
			this.btnSlabCalculate.Size = new System.Drawing.Size(70, 25);
			this.btnSlabCalculate.TabIndex = 4;
			this.btnSlabCalculate.Text = "Calculate";
			this.btnSlabCalculate.UseVisualStyleBackColor = true;
			this.btnSlabCalculate.Click += new System.EventHandler(this.btnSlabCalculate_Click);
			// 
			// tbSlabThickness
			// 
			this.tbSlabThickness.Location = new System.Drawing.Point(94, 73);
			this.tbSlabThickness.Name = "tbSlabThickness";
			this.tbSlabThickness.Size = new System.Drawing.Size(61, 20);
			this.tbSlabThickness.TabIndex = 3;
			// 
			// tbSlabWidth
			// 
			this.tbSlabWidth.Location = new System.Drawing.Point(94, 43);
			this.tbSlabWidth.Name = "tbSlabWidth";
			this.tbSlabWidth.Size = new System.Drawing.Size(61, 20);
			this.tbSlabWidth.TabIndex = 2;
			// 
			// tbSlabLength
			// 
			this.tbSlabLength.Location = new System.Drawing.Point(94, 17);
			this.tbSlabLength.Name = "tbSlabLength";
			this.tbSlabLength.Size = new System.Drawing.Size(61, 20);
			this.tbSlabLength.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Thickness:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Length:";
			// 
			// gbCircle
			// 
			this.gbCircle.Controls.Add(this.btnClearCircleTextbox);
			this.gbCircle.Controls.Add(this.cBCircleSpillage);
			this.gbCircle.Controls.Add(this.label12);
			this.gbCircle.Controls.Add(this.tbCircleSqFt);
			this.gbCircle.Controls.Add(this.tbCircleCubicYardage);
			this.gbCircle.Controls.Add(this.label15);
			this.gbCircle.Controls.Add(this.label13);
			this.gbCircle.Controls.Add(this.btnCircleCalculate);
			this.gbCircle.Controls.Add(this.tbCircleThickness);
			this.gbCircle.Controls.Add(this.label11);
			this.gbCircle.Controls.Add(this.tbCircleRadius);
			this.gbCircle.Controls.Add(this.label6);
			this.gbCircle.Controls.Add(this.label5);
			this.gbCircle.Controls.Add(this.label20);
			this.gbCircle.Location = new System.Drawing.Point(228, 6);
			this.gbCircle.Name = "gbCircle";
			this.gbCircle.Size = new System.Drawing.Size(212, 233);
			this.gbCircle.TabIndex = 2;
			this.gbCircle.TabStop = false;
			this.gbCircle.Text = "Circle";
			// 
			// btnClearCircleTextbox
			// 
			this.btnClearCircleTextbox.Location = new System.Drawing.Point(10, 102);
			this.btnClearCircleTextbox.Name = "btnClearCircleTextbox";
			this.btnClearCircleTextbox.Size = new System.Drawing.Size(70, 25);
			this.btnClearCircleTextbox.TabIndex = 11;
			this.btnClearCircleTextbox.Text = "Clear";
			this.btnClearCircleTextbox.UseVisualStyleBackColor = true;
			this.btnClearCircleTextbox.Click += new System.EventHandler(this.btnClearCircleTextbox_Click);
			// 
			// cBCircleSpillage
			// 
			this.cBCircleSpillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBCircleSpillage.FormattingEnabled = true;
			this.cBCircleSpillage.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15"});
			this.cBCircleSpillage.Location = new System.Drawing.Point(92, 70);
			this.cBCircleSpillage.Name = "cBCircleSpillage";
			this.cBCircleSpillage.Size = new System.Drawing.Size(61, 21);
			this.cBCircleSpillage.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(157, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(25, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "feet";
			// 
			// tbCircleSqFt
			// 
			this.tbCircleSqFt.Location = new System.Drawing.Point(95, 166);
			this.tbCircleSqFt.Name = "tbCircleSqFt";
			this.tbCircleSqFt.ReadOnly = true;
			this.tbCircleSqFt.Size = new System.Drawing.Size(61, 20);
			this.tbCircleSqFt.TabIndex = 3;
			// 
			// tbCircleCubicYardage
			// 
			this.tbCircleCubicYardage.Location = new System.Drawing.Point(95, 140);
			this.tbCircleCubicYardage.Name = "tbCircleCubicYardage";
			this.tbCircleCubicYardage.ReadOnly = true;
			this.tbCircleCubicYardage.Size = new System.Drawing.Size(61, 20);
			this.tbCircleCubicYardage.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(9, 165);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "Square Feet:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(157, 46);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 5;
			this.label13.Text = "inches";
			// 
			// btnCircleCalculate
			// 
			this.btnCircleCalculate.Location = new System.Drawing.Point(88, 102);
			this.btnCircleCalculate.Name = "btnCircleCalculate";
			this.btnCircleCalculate.Size = new System.Drawing.Size(70, 25);
			this.btnCircleCalculate.TabIndex = 3;
			this.btnCircleCalculate.Text = "Calculate";
			this.btnCircleCalculate.UseVisualStyleBackColor = true;
			this.btnCircleCalculate.Click += new System.EventHandler(this.btnCircleCalculate_Click);
			// 
			// tbCircleThickness
			// 
			this.tbCircleThickness.Location = new System.Drawing.Point(92, 39);
			this.tbCircleThickness.Name = "tbCircleThickness";
			this.tbCircleThickness.Size = new System.Drawing.Size(61, 20);
			this.tbCircleThickness.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 143);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Cubic Yardage:";
			// 
			// tbCircleRadius
			// 
			this.tbCircleRadius.Location = new System.Drawing.Point(92, 13);
			this.tbCircleRadius.Name = "tbCircleRadius";
			this.tbCircleRadius.Size = new System.Drawing.Size(61, 20);
			this.tbCircleRadius.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Radius:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Thickness:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 73);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(164, 13);
			this.label20.TabIndex = 10;
			this.label20.Text = "Spillage Percent                        %";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Slab",
            "Circle"});
			this.comboBox1.Location = new System.Drawing.Point(100, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(89, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(12, 33);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(471, 433);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.gBMaterialSpacing);
			this.tabPage1.Controls.Add(this.gbSlab);
			this.tabPage1.Controls.Add(this.gbCircle);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(463, 407);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Concrete";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// gBMaterialSpacing
			// 
			this.gBMaterialSpacing.Controls.Add(this.tbConcreteStand);
			this.gBMaterialSpacing.Controls.Add(this.tbRebarCenters);
			this.gBMaterialSpacing.Controls.Add(this.lblRebarSpacing);
			this.gBMaterialSpacing.Controls.Add(this.lblStandCenters);
			this.gBMaterialSpacing.Location = new System.Drawing.Point(14, 246);
			this.gBMaterialSpacing.Name = "gBMaterialSpacing";
			this.gBMaterialSpacing.Size = new System.Drawing.Size(208, 139);
			this.gBMaterialSpacing.TabIndex = 3;
			this.gBMaterialSpacing.TabStop = false;
			this.gBMaterialSpacing.Text = "Material Spacing";
			// 
			// tbConcreteStand
			// 
			this.tbConcreteStand.Location = new System.Drawing.Point(85, 60);
			this.tbConcreteStand.Name = "tbConcreteStand";
			this.tbConcreteStand.Size = new System.Drawing.Size(61, 20);
			this.tbConcreteStand.TabIndex = 0;
			this.tbConcreteStand.TextChanged += new System.EventHandler(this.tbConcreteStand_TextChanged);
			// 
			// tbRebarCenters
			// 
			this.tbRebarCenters.Location = new System.Drawing.Point(85, 30);
			this.tbRebarCenters.Name = "tbRebarCenters";
			this.tbRebarCenters.Size = new System.Drawing.Size(61, 20);
			this.tbRebarCenters.TabIndex = 1;
			this.tbRebarCenters.TextChanged += new System.EventHandler(this.tbRebarCenters_TextChanged);
			// 
			// lblRebarSpacing
			// 
			this.lblRebarSpacing.AutoSize = true;
			this.lblRebarSpacing.Location = new System.Drawing.Point(6, 33);
			this.lblRebarSpacing.Name = "lblRebarSpacing";
			this.lblRebarSpacing.Size = new System.Drawing.Size(179, 13);
			this.lblRebarSpacing.TabIndex = 6;
			this.lblRebarSpacing.Text = "Rebar spacing:                       inches";
			// 
			// lblStandCenters
			// 
			this.lblStandCenters.AutoSize = true;
			this.lblStandCenters.Location = new System.Drawing.Point(6, 63);
			this.lblStandCenters.Name = "lblStandCenters";
			this.lblStandCenters.Size = new System.Drawing.Size(179, 13);
			this.lblStandCenters.TabIndex = 3;
			this.lblStandCenters.Text = "Stand centers:                        inches";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(643, 453);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(25, 13);
			this.label25.TabIndex = 7;
			this.label25.Text = "feet";
			// 
			// tbTotalRebarNeeded
			// 
			this.tbTotalRebarNeeded.Location = new System.Drawing.Point(578, 450);
			this.tbTotalRebarNeeded.Name = "tbTotalRebarNeeded";
			this.tbTotalRebarNeeded.ReadOnly = true;
			this.tbTotalRebarNeeded.Size = new System.Drawing.Size(61, 20);
			this.tbTotalRebarNeeded.TabIndex = 3;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(489, 453);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(78, 13);
			this.label18.TabIndex = 3;
			this.label18.Text = "Rebar needed:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(685, 453);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(82, 13);
			this.label22.TabIndex = 3;
			this.label22.Text = "Stands needed:";
			// 
			// tbTotalStandsNeeded
			// 
			this.tbTotalStandsNeeded.Location = new System.Drawing.Point(773, 446);
			this.tbTotalStandsNeeded.Name = "tbTotalStandsNeeded";
			this.tbTotalStandsNeeded.ReadOnly = true;
			this.tbTotalStandsNeeded.Size = new System.Drawing.Size(64, 20);
			this.tbTotalStandsNeeded.TabIndex = 0;
			// 
			// concreteListView
			// 
			listViewGroup1.Header = "ListViewGroup";
			listViewGroup1.Name = "listViewGroup1";
			this.concreteListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
			this.concreteListView.Location = new System.Drawing.Point(489, 185);
			this.concreteListView.Name = "concreteListView";
			this.concreteListView.ShowGroups = false;
			this.concreteListView.Size = new System.Drawing.Size(460, 255);
			this.concreteListView.TabIndex = 6;
			this.concreteListView.UseCompatibleStateImageBehavior = false;
			this.concreteListView.View = System.Windows.Forms.View.Details;
			this.concreteListView.SelectedIndexChanged += new System.EventHandler(this.concreteListView_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 500);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.tbTotalStandsNeeded);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.tbTotalRebarNeeded);
			this.Controls.Add(this.concreteListView);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "ConcreteSuite";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbSlab.ResumeLayout(false);
			this.gbSlab.PerformLayout();
			this.gbCircle.ResumeLayout(false);
			this.gbCircle.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.gBMaterialSpacing.ResumeLayout(false);
			this.gBMaterialSpacing.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSlab;
        private System.Windows.Forms.TextBox tbSlabThickness;
        private System.Windows.Forms.TextBox tbSlabWidth;
        private System.Windows.Forms.TextBox tbSlabLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCircle;
        private System.Windows.Forms.TextBox tbCircleThickness;
        private System.Windows.Forms.TextBox tbCircleRadius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSlabCalculate;
        private System.Windows.Forms.Button btnCircleCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSlabCubicYardage;
        private System.Windows.Forms.TextBox tbCircleCubicYardage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbCircleSqFt;
        private System.Windows.Forms.TextBox tbSlabSqFt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClearSlabTextbox;
		private System.Windows.Forms.ComboBox cBSlabSpillage;
        private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cBCircleSpillage;
		private System.Windows.Forms.Button btnClearCircleTextbox;
        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ListView concreteListView;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label lblRebarSpacing;
		private System.Windows.Forms.TextBox tbRebarCenters;
		private System.Windows.Forms.TextBox tbTotalRebarNeeded;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label lblStandCenters;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox tbTotalStandsNeeded;
		private System.Windows.Forms.TextBox tbConcreteStand;
		private System.Windows.Forms.GroupBox gBMaterialSpacing;



    }
}

