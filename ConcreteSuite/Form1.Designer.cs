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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSlabSqFt = new System.Windows.Forms.CheckBox();
			this.chkSlabSpillage = new System.Windows.Forms.CheckBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkCircleYardage = new System.Windows.Forms.CheckBox();
			this.chkCircleSqFt = new System.Windows.Forms.CheckBox();
			this.btnClearCircleTextbox = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.chkCircleSpillage = new System.Windows.Forms.CheckBox();
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnClearRebarTextbox = new System.Windows.Forms.Button();
			this.label25 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tbRebarCenters = new System.Windows.Forms.TextBox();
			this.tbRebarNeeded = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.btnCalculateRebar = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.tbRebarSqFeet = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.tbConcreteStandsNeeded = new System.Windows.Forms.TextBox();
			this.tbConcreteStand = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnCalculateStands = new System.Windows.Forms.Button();
			this.label24 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label26 = new System.Windows.Forms.Label();
			this.tbSelectedYards = new System.Windows.Forms.TextBox();
			this.listBoxCubicYards = new System.Windows.Forms.ListBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.listBoxSqFt = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.concreteListView = new System.Windows.Forms.ListView();
			this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FormFactorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DimensionsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SquareFeetColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CubicYardageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabPage2.SuspendLayout();
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkSlabSqFt);
			this.groupBox1.Controls.Add(this.chkSlabSpillage);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.btnClearSlabTextbox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbSlabSqFt);
			this.groupBox1.Controls.Add(this.tbSlabCubicYardage);
			this.groupBox1.Controls.Add(this.btnSlabCalculate);
			this.groupBox1.Controls.Add(this.tbSlabThickness);
			this.groupBox1.Controls.Add(this.tbSlabWidth);
			this.groupBox1.Controls.Add(this.tbSlabLength);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(10, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(212, 233);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Slab";
			// 
			// chkSlabSqFt
			// 
			this.chkSlabSqFt.AutoSize = true;
			this.chkSlabSqFt.Location = new System.Drawing.Point(14, 121);
			this.chkSlabSqFt.Name = "chkSlabSqFt";
			this.chkSlabSqFt.Size = new System.Drawing.Size(134, 17);
			this.chkSlabSqFt.TabIndex = 12;
			this.chkSlabSqFt.Text = "Send square feet to list";
			this.chkSlabSqFt.UseVisualStyleBackColor = true;
			// 
			// chkSlabSpillage
			// 
			this.chkSlabSpillage.AutoSize = true;
			this.chkSlabSpillage.Location = new System.Drawing.Point(14, 102);
			this.chkSlabSpillage.Name = "chkSlabSpillage";
			this.chkSlabSpillage.Size = new System.Drawing.Size(45, 17);
			this.chkSlabSpillage.TabIndex = 11;
			this.chkSlabSpillage.Text = "Add";
			this.chkSlabSpillage.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "15",
            "20",
            "25"});
			this.comboBox2.Location = new System.Drawing.Point(63, 98);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(40, 21);
			this.comboBox2.TabIndex = 9;
			this.comboBox2.Text = "10";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(109, 103);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 13);
			this.label16.TabIndex = 8;
			this.label16.Text = "% for spillage";
			// 
			// btnClearSlabTextbox
			// 
			this.btnClearSlabTextbox.Location = new System.Drawing.Point(11, 143);
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
			this.label14.Location = new System.Drawing.Point(8, 207);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(68, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Square Feet:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 181);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Cubic Yardage:";
			// 
			// tbSlabSqFt
			// 
			this.tbSlabSqFt.Location = new System.Drawing.Point(94, 204);
			this.tbSlabSqFt.Name = "tbSlabSqFt";
			this.tbSlabSqFt.ReadOnly = true;
			this.tbSlabSqFt.Size = new System.Drawing.Size(61, 20);
			this.tbSlabSqFt.TabIndex = 5;
			// 
			// tbSlabCubicYardage
			// 
			this.tbSlabCubicYardage.Location = new System.Drawing.Point(94, 178);
			this.tbSlabCubicYardage.Name = "tbSlabCubicYardage";
			this.tbSlabCubicYardage.ReadOnly = true;
			this.tbSlabCubicYardage.Size = new System.Drawing.Size(61, 20);
			this.tbSlabCubicYardage.TabIndex = 5;
			// 
			// btnSlabCalculate
			// 
			this.btnSlabCalculate.Location = new System.Drawing.Point(85, 143);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkCircleYardage);
			this.groupBox2.Controls.Add(this.chkCircleSqFt);
			this.groupBox2.Controls.Add(this.btnClearCircleTextbox);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.chkCircleSpillage);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.tbCircleSqFt);
			this.groupBox2.Controls.Add(this.tbCircleCubicYardage);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.btnCircleCalculate);
			this.groupBox2.Controls.Add(this.tbCircleThickness);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.tbCircleRadius);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(228, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 233);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Circle";
			// 
			// chkCircleYardage
			// 
			this.chkCircleYardage.AutoSize = true;
			this.chkCircleYardage.Location = new System.Drawing.Point(12, 117);
			this.chkCircleYardage.Name = "chkCircleYardage";
			this.chkCircleYardage.Size = new System.Drawing.Size(119, 17);
			this.chkCircleYardage.TabIndex = 13;
			this.chkCircleYardage.Text = "Send yardage to list";
			this.chkCircleYardage.UseVisualStyleBackColor = true;
			// 
			// chkCircleSqFt
			// 
			this.chkCircleSqFt.AutoSize = true;
			this.chkCircleSqFt.Location = new System.Drawing.Point(12, 94);
			this.chkCircleSqFt.Name = "chkCircleSqFt";
			this.chkCircleSqFt.Size = new System.Drawing.Size(134, 17);
			this.chkCircleSqFt.TabIndex = 12;
			this.chkCircleSqFt.Text = "Send square feet to list";
			this.chkCircleSqFt.UseVisualStyleBackColor = true;
			// 
			// btnClearCircleTextbox
			// 
			this.btnClearCircleTextbox.Location = new System.Drawing.Point(12, 143);
			this.btnClearCircleTextbox.Name = "btnClearCircleTextbox";
			this.btnClearCircleTextbox.Size = new System.Drawing.Size(70, 25);
			this.btnClearCircleTextbox.TabIndex = 11;
			this.btnClearCircleTextbox.Text = "Clear";
			this.btnClearCircleTextbox.UseVisualStyleBackColor = true;
			this.btnClearCircleTextbox.Click += new System.EventHandler(this.btnClearCircleTextbox_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(104, 72);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(70, 13);
			this.label20.TabIndex = 10;
			this.label20.Text = "% for Spillage";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "15",
            "20",
            "25"});
			this.comboBox3.Location = new System.Drawing.Point(58, 67);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(40, 21);
			this.comboBox3.TabIndex = 8;
			this.comboBox3.Text = "10";
			// 
			// chkCircleSpillage
			// 
			this.chkCircleSpillage.AutoSize = true;
			this.chkCircleSpillage.Location = new System.Drawing.Point(12, 71);
			this.chkCircleSpillage.Name = "chkCircleSpillage";
			this.chkCircleSpillage.Size = new System.Drawing.Size(45, 17);
			this.chkCircleSpillage.TabIndex = 7;
			this.chkCircleSpillage.Text = "Add";
			this.chkCircleSpillage.UseVisualStyleBackColor = true;
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
			this.tbCircleSqFt.Location = new System.Drawing.Point(92, 203);
			this.tbCircleSqFt.Name = "tbCircleSqFt";
			this.tbCircleSqFt.ReadOnly = true;
			this.tbCircleSqFt.Size = new System.Drawing.Size(61, 20);
			this.tbCircleSqFt.TabIndex = 3;
			// 
			// tbCircleCubicYardage
			// 
			this.tbCircleCubicYardage.Location = new System.Drawing.Point(92, 177);
			this.tbCircleCubicYardage.Name = "tbCircleCubicYardage";
			this.tbCircleCubicYardage.ReadOnly = true;
			this.tbCircleCubicYardage.Size = new System.Drawing.Size(61, 20);
			this.tbCircleCubicYardage.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 202);
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
			this.btnCircleCalculate.Location = new System.Drawing.Point(90, 143);
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
			this.label11.Location = new System.Drawing.Point(6, 180);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnClearRebarTextbox);
			this.groupBox3.Controls.Add(this.label25);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.tbRebarCenters);
			this.groupBox3.Controls.Add(this.tbRebarNeeded);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.btnCalculateRebar);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.tbRebarSqFeet);
			this.groupBox3.Location = new System.Drawing.Point(6, 34);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(237, 137);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Rebar";
			// 
			// btnClearRebarTextbox
			// 
			this.btnClearRebarTextbox.Location = new System.Drawing.Point(40, 73);
			this.btnClearRebarTextbox.Name = "btnClearRebarTextbox";
			this.btnClearRebarTextbox.Size = new System.Drawing.Size(70, 25);
			this.btnClearRebarTextbox.TabIndex = 4;
			this.btnClearRebarTextbox.Text = "Clear";
			this.btnClearRebarTextbox.UseVisualStyleBackColor = true;
			this.btnClearRebarTextbox.Click += new System.EventHandler(this.button6_Click);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(191, 107);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(25, 13);
			this.label25.TabIndex = 7;
			this.label25.Text = "feet";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(191, 50);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 13);
			this.label21.TabIndex = 7;
			this.label21.Text = "inches";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 50);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(46, 13);
			this.label19.TabIndex = 6;
			this.label19.Text = "Centers:";
			// 
			// tbRebarCenters
			// 
			this.tbRebarCenters.Location = new System.Drawing.Point(102, 47);
			this.tbRebarCenters.Name = "tbRebarCenters";
			this.tbRebarCenters.Size = new System.Drawing.Size(83, 20);
			this.tbRebarCenters.TabIndex = 1;
			// 
			// tbRebarNeeded
			// 
			this.tbRebarNeeded.Location = new System.Drawing.Point(101, 104);
			this.tbRebarNeeded.Name = "tbRebarNeeded";
			this.tbRebarNeeded.ReadOnly = true;
			this.tbRebarNeeded.Size = new System.Drawing.Size(83, 20);
			this.tbRebarNeeded.TabIndex = 3;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(5, 107);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(78, 13);
			this.label18.TabIndex = 3;
			this.label18.Text = "Rebar needed:";
			// 
			// btnCalculateRebar
			// 
			this.btnCalculateRebar.Location = new System.Drawing.Point(116, 73);
			this.btnCalculateRebar.Name = "btnCalculateRebar";
			this.btnCalculateRebar.Size = new System.Drawing.Size(70, 25);
			this.btnCalculateRebar.TabIndex = 2;
			this.btnCalculateRebar.Text = "Calculate";
			this.btnCalculateRebar.UseVisualStyleBackColor = true;
			this.btnCalculateRebar.Click += new System.EventHandler(this.button5_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 22);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 13);
			this.label17.TabIndex = 1;
			this.label17.Text = "Square feet:";
			// 
			// tbRebarSqFeet
			// 
			this.tbRebarSqFeet.Location = new System.Drawing.Point(102, 19);
			this.tbRebarSqFeet.Name = "tbRebarSqFeet";
			this.tbRebarSqFeet.Size = new System.Drawing.Size(83, 20);
			this.tbRebarSqFeet.TabIndex = 0;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(7, 57);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(82, 13);
			this.label22.TabIndex = 3;
			this.label22.Text = "Stands needed:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(7, 32);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(76, 13);
			this.label23.TabIndex = 3;
			this.label23.Text = "Stand centers:";
			// 
			// tbConcreteStandsNeeded
			// 
			this.tbConcreteStandsNeeded.Location = new System.Drawing.Point(103, 54);
			this.tbConcreteStandsNeeded.Name = "tbConcreteStandsNeeded";
			this.tbConcreteStandsNeeded.ReadOnly = true;
			this.tbConcreteStandsNeeded.Size = new System.Drawing.Size(83, 20);
			this.tbConcreteStandsNeeded.TabIndex = 0;
			// 
			// tbConcreteStand
			// 
			this.tbConcreteStand.Location = new System.Drawing.Point(103, 29);
			this.tbConcreteStand.Name = "tbConcreteStand";
			this.tbConcreteStand.Size = new System.Drawing.Size(83, 20);
			this.tbConcreteStand.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnCalculateStands);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.tbConcreteStandsNeeded);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Controls.Add(this.tbConcreteStand);
			this.groupBox4.Location = new System.Drawing.Point(6, 193);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(237, 122);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Concrete Stands";
			// 
			// btnCalculateStands
			// 
			this.btnCalculateStands.Location = new System.Drawing.Point(116, 80);
			this.btnCalculateStands.Name = "btnCalculateStands";
			this.btnCalculateStands.Size = new System.Drawing.Size(70, 25);
			this.btnCalculateStands.TabIndex = 8;
			this.btnCalculateStands.Text = "Calculate";
			this.btnCalculateStands.UseVisualStyleBackColor = true;
			this.btnCalculateStands.Click += new System.EventHandler(this.button7_Click);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(192, 36);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(38, 13);
			this.label24.TabIndex = 7;
			this.label24.Text = "inches";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 33);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(471, 433);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(463, 407);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Concrete";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label26);
			this.groupBox6.Controls.Add(this.tbSelectedYards);
			this.groupBox6.Controls.Add(this.listBoxCubicYards);
			this.groupBox6.Location = new System.Drawing.Point(228, 245);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(212, 156);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Cubic Yards";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(9, 133);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 13);
			this.label26.TabIndex = 2;
			this.label26.Text = "Selected yards:";
			// 
			// tbSelectedYards
			// 
			this.tbSelectedYards.Location = new System.Drawing.Point(90, 130);
			this.tbSelectedYards.Name = "tbSelectedYards";
			this.tbSelectedYards.ReadOnly = true;
			this.tbSelectedYards.Size = new System.Drawing.Size(83, 20);
			this.tbSelectedYards.TabIndex = 1;
			// 
			// listBoxCubicYards
			// 
			this.listBoxCubicYards.FormattingEnabled = true;
			this.listBoxCubicYards.Location = new System.Drawing.Point(9, 19);
			this.listBoxCubicYards.Name = "listBoxCubicYards";
			this.listBoxCubicYards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxCubicYards.Size = new System.Drawing.Size(165, 95);
			this.listBoxCubicYards.TabIndex = 0;
			this.listBoxCubicYards.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.checkBox4);
			this.groupBox5.Controls.Add(this.listBoxSqFt);
			this.groupBox5.Location = new System.Drawing.Point(10, 245);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(212, 156);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Square Feet";
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(11, 133);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(163, 17);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Text = "Export *selected* square feet";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// listBoxSqFt
			// 
			this.listBoxSqFt.FormattingEnabled = true;
			this.listBoxSqFt.Location = new System.Drawing.Point(12, 19);
			this.listBoxSqFt.Name = "listBoxSqFt";
			this.listBoxSqFt.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxSqFt.Size = new System.Drawing.Size(143, 108);
			this.listBoxSqFt.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(463, 407);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Materials";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// concreteListView
			// 
			this.concreteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.FormFactorColumnHeader,
            this.DimensionsColumnHeader,
            this.SquareFeetColumnHeader,
            this.CubicYardageColumnHeader});
			listViewGroup1.Header = "ListViewGroup";
			listViewGroup1.Name = "listViewGroup1";
			this.concreteListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
			this.concreteListView.Location = new System.Drawing.Point(485, 128);
			this.concreteListView.Name = "concreteListView";
			this.concreteListView.Size = new System.Drawing.Size(373, 334);
			this.concreteListView.TabIndex = 6;
			this.concreteListView.UseCompatibleStateImageBehavior = false;
			this.concreteListView.View = System.Windows.Forms.View.Details;
			// 
			// IdColumnHeader
			// 
			this.IdColumnHeader.Text = "ID";
			this.IdColumnHeader.Width = 34;
			// 
			// FormFactorColumnHeader
			// 
			this.FormFactorColumnHeader.Text = "Form Factor";
			this.FormFactorColumnHeader.Width = 75;
			// 
			// DimensionsColumnHeader
			// 
			this.DimensionsColumnHeader.Text = "Dimensions";
			this.DimensionsColumnHeader.Width = 72;
			// 
			// SquareFeetColumnHeader
			// 
			this.SquareFeetColumnHeader.Text = "Square Feet";
			this.SquareFeetColumnHeader.Width = 73;
			// 
			// CubicYardageColumnHeader
			// 
			this.CubicYardageColumnHeader.Text = "Cubic Yardage";
			this.CubicYardageColumnHeader.Width = 88;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 500);
			this.Controls.Add(this.concreteListView);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "ConcreteSuite";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSlabThickness;
        private System.Windows.Forms.TextBox tbSlabWidth;
        private System.Windows.Forms.TextBox tbSlabLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chkSlabSpillage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox chkCircleSpillage;
        private System.Windows.Forms.Button btnClearCircleTextbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxSqFt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkSlabSqFt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkCircleSqFt;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnCalculateRebar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbRebarSqFeet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRebarNeeded;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRebarCenters;
        private System.Windows.Forms.Button btnClearRebarTextbox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbConcreteStandsNeeded;
        private System.Windows.Forms.TextBox tbConcreteStand;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCalculateStands;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbSelectedYards;
        private System.Windows.Forms.ListBox listBoxCubicYards;
        private System.Windows.Forms.CheckBox chkCircleYardage;
        private System.Windows.Forms.ListView concreteListView;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
        private System.Windows.Forms.ColumnHeader FormFactorColumnHeader;
        private System.Windows.Forms.ColumnHeader DimensionsColumnHeader;
        private System.Windows.Forms.ColumnHeader SquareFeetColumnHeader;
		private System.Windows.Forms.ColumnHeader CubicYardageColumnHeader;



    }
}

