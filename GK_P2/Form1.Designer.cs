namespace GK_P2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.heightMapPBox = new System.Windows.Forms.PictureBox();
            this.disturbanceHeightMapChangeButton = new System.Windows.Forms.Button();
            this.disturbanceHeightMapRB = new System.Windows.Forms.RadioButton();
            this.disturbanceNoneRB = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sphereRadiusUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.sphereRadiusChangeButton = new System.Windows.Forms.Button();
            this.sphericaLVectorRB = new System.Windows.Forms.RadioButton();
            this.constLVectorRB = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.normalMapPBox = new System.Windows.Forms.PictureBox();
            this.normalMapChangeButton = new System.Windows.Forms.Button();
            this.normalVectorNormalMapRB = new System.Windows.Forms.RadioButton();
            this.normalVectorConstRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ocPBox2 = new System.Windows.Forms.PictureBox();
            this.ocTextureButton = new System.Windows.Forms.Button();
            this.ocConstButton = new System.Windows.Forms.Button();
            this.ocPBox = new System.Windows.Forms.PictureBox();
            this.ocTextureRB = new System.Windows.Forms.RadioButton();
            this.ocConstRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lightSourceColorReflectorsRB = new System.Windows.Forms.RadioButton();
            this.lightSourceConstColorRB = new System.Windows.Forms.RadioButton();
            this.lightColorPbox = new System.Windows.Forms.PictureBox();
            this.soLightButton = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.sphereTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapPBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereRadiusUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalMapPBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocPBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocPBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightColorPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(607, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edycja";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.heightMapPBox);
            this.groupBox6.Controls.Add(this.disturbanceHeightMapChangeButton);
            this.groupBox6.Controls.Add(this.disturbanceHeightMapRB);
            this.groupBox6.Controls.Add(this.disturbanceNoneRB);
            this.groupBox6.Location = new System.Drawing.Point(4, 455);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 100);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Zaburzenie";
            // 
            // heightMapPBox
            // 
            this.heightMapPBox.Location = new System.Drawing.Point(29, 62);
            this.heightMapPBox.Name = "heightMapPBox";
            this.heightMapPBox.Size = new System.Drawing.Size(65, 29);
            this.heightMapPBox.TabIndex = 8;
            this.heightMapPBox.TabStop = false;
            // 
            // disturbanceHeightMapChangeButton
            // 
            this.disturbanceHeightMapChangeButton.Location = new System.Drawing.Point(122, 71);
            this.disturbanceHeightMapChangeButton.Name = "disturbanceHeightMapChangeButton";
            this.disturbanceHeightMapChangeButton.Size = new System.Drawing.Size(45, 20);
            this.disturbanceHeightMapChangeButton.TabIndex = 7;
            this.disturbanceHeightMapChangeButton.Text = "Zmień";
            this.disturbanceHeightMapChangeButton.UseVisualStyleBackColor = true;
            this.disturbanceHeightMapChangeButton.Click += new System.EventHandler(this.disturbanceHeightMapChangeButton_Click);
            // 
            // disturbanceHeightMapRB
            // 
            this.disturbanceHeightMapRB.AutoSize = true;
            this.disturbanceHeightMapRB.Checked = true;
            this.disturbanceHeightMapRB.Location = new System.Drawing.Point(5, 42);
            this.disturbanceHeightMapRB.Name = "disturbanceHeightMapRB";
            this.disturbanceHeightMapRB.Size = new System.Drawing.Size(125, 17);
            this.disturbanceHeightMapRB.TabIndex = 6;
            this.disturbanceHeightMapRB.TabStop = true;
            this.disturbanceHeightMapRB.Text = "z tekstury HeightMap";
            this.disturbanceHeightMapRB.UseVisualStyleBackColor = true;
            this.disturbanceHeightMapRB.CheckedChanged += new System.EventHandler(this.disturbanceHeightMapRB_CheckedChanged);
            // 
            // disturbanceNoneRB
            // 
            this.disturbanceNoneRB.AutoSize = true;
            this.disturbanceNoneRB.Location = new System.Drawing.Point(6, 19);
            this.disturbanceNoneRB.Name = "disturbanceNoneRB";
            this.disturbanceNoneRB.Size = new System.Drawing.Size(88, 17);
            this.disturbanceNoneRB.TabIndex = 2;
            this.disturbanceNoneRB.Text = "brak  [0, 0, 0]";
            this.disturbanceNoneRB.UseVisualStyleBackColor = true;
            this.disturbanceNoneRB.CheckedChanged += new System.EventHandler(this.disturbanceNoneRB_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sphereRadiusUpDown);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.labell);
            this.groupBox5.Controls.Add(this.sphereRadiusChangeButton);
            this.groupBox5.Controls.Add(this.sphericaLVectorRB);
            this.groupBox5.Controls.Add(this.constLVectorRB);
            this.groupBox5.Location = new System.Drawing.Point(4, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 124);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wektor do źródła światła";
            // 
            // sphereRadiusUpDown
            // 
            this.sphereRadiusUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sphereRadiusUpDown.Location = new System.Drawing.Point(29, 98);
            this.sphereRadiusUpDown.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.sphereRadiusUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sphereRadiusUpDown.Name = "sphereRadiusUpDown";
            this.sphereRadiusUpDown.Size = new System.Drawing.Size(46, 20);
            this.sphereRadiusUpDown.TabIndex = 9;
            this.sphereRadiusUpDown.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "R = ";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(26, 53);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(98, 39);
            this.labell.TabIndex = 7;
            this.labell.Text = "światło animowane\r\npo sferze\r\no promieniu R";
            // 
            // sphereRadiusChangeButton
            // 
            this.sphereRadiusChangeButton.Location = new System.Drawing.Point(122, 99);
            this.sphereRadiusChangeButton.Name = "sphereRadiusChangeButton";
            this.sphereRadiusChangeButton.Size = new System.Drawing.Size(45, 20);
            this.sphereRadiusChangeButton.TabIndex = 6;
            this.sphereRadiusChangeButton.Text = "Zmień";
            this.sphereRadiusChangeButton.UseVisualStyleBackColor = true;
            this.sphereRadiusChangeButton.Click += new System.EventHandler(this.sphereRadiusChangeButton_Click);
            // 
            // sphericaLVectorRB
            // 
            this.sphericaLVectorRB.AutoSize = true;
            this.sphericaLVectorRB.Location = new System.Drawing.Point(5, 53);
            this.sphericaLVectorRB.Name = "sphericaLVectorRB";
            this.sphericaLVectorRB.Size = new System.Drawing.Size(14, 13);
            this.sphericaLVectorRB.TabIndex = 5;
            this.sphericaLVectorRB.UseVisualStyleBackColor = true;
            this.sphericaLVectorRB.CheckedChanged += new System.EventHandler(this.sphericaLVectorRB_CheckedChanged);
            // 
            // constLVectorRB
            // 
            this.constLVectorRB.AutoSize = true;
            this.constLVectorRB.Checked = true;
            this.constLVectorRB.Location = new System.Drawing.Point(5, 30);
            this.constLVectorRB.Name = "constLVectorRB";
            this.constLVectorRB.Size = new System.Drawing.Size(87, 17);
            this.constLVectorRB.TabIndex = 1;
            this.constLVectorRB.TabStop = true;
            this.constLVectorRB.Text = "stały [0, 0, 1]";
            this.constLVectorRB.UseVisualStyleBackColor = true;
            this.constLVectorRB.CheckedChanged += new System.EventHandler(this.constLVectorRB_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.normalMapPBox);
            this.groupBox4.Controls.Add(this.normalMapChangeButton);
            this.groupBox4.Controls.Add(this.normalVectorNormalMapRB);
            this.groupBox4.Controls.Add(this.normalVectorConstRB);
            this.groupBox4.Location = new System.Drawing.Point(4, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 127);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "N - wektor normalny przed zaburzeniem";
            // 
            // normalMapPBox
            // 
            this.normalMapPBox.Location = new System.Drawing.Point(29, 90);
            this.normalMapPBox.Name = "normalMapPBox";
            this.normalMapPBox.Size = new System.Drawing.Size(65, 29);
            this.normalMapPBox.TabIndex = 9;
            this.normalMapPBox.TabStop = false;
            // 
            // normalMapChangeButton
            // 
            this.normalMapChangeButton.Location = new System.Drawing.Point(122, 101);
            this.normalMapChangeButton.Name = "normalMapChangeButton";
            this.normalMapChangeButton.Size = new System.Drawing.Size(45, 20);
            this.normalMapChangeButton.TabIndex = 6;
            this.normalMapChangeButton.Text = "Zmień";
            this.normalMapChangeButton.UseVisualStyleBackColor = true;
            this.normalMapChangeButton.Click += new System.EventHandler(this.normalMapChangeButton_Click);
            // 
            // normalVectorNormalMapRB
            // 
            this.normalVectorNormalMapRB.AutoSize = true;
            this.normalVectorNormalMapRB.Checked = true;
            this.normalVectorNormalMapRB.Location = new System.Drawing.Point(6, 62);
            this.normalVectorNormalMapRB.Name = "normalVectorNormalMapRB";
            this.normalVectorNormalMapRB.Size = new System.Drawing.Size(127, 17);
            this.normalVectorNormalMapRB.TabIndex = 5;
            this.normalVectorNormalMapRB.TabStop = true;
            this.normalVectorNormalMapRB.Text = "z tekstury NormalMap";
            this.normalVectorNormalMapRB.UseVisualStyleBackColor = true;
            this.normalVectorNormalMapRB.CheckedChanged += new System.EventHandler(this.normalVectorNormalMapRB_CheckedChanged);
            // 
            // normalVectorConstRB
            // 
            this.normalVectorConstRB.AutoSize = true;
            this.normalVectorConstRB.Location = new System.Drawing.Point(7, 39);
            this.normalVectorConstRB.Name = "normalVectorConstRB";
            this.normalVectorConstRB.Size = new System.Drawing.Size(87, 17);
            this.normalVectorConstRB.TabIndex = 1;
            this.normalVectorConstRB.Text = "stały [0, 0, 1]";
            this.normalVectorConstRB.UseVisualStyleBackColor = true;
            this.normalVectorConstRB.CheckedChanged += new System.EventHandler(this.normalVectorConstRB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ocPBox2);
            this.groupBox3.Controls.Add(this.ocTextureButton);
            this.groupBox3.Controls.Add(this.ocConstButton);
            this.groupBox3.Controls.Add(this.ocPBox);
            this.groupBox3.Controls.Add(this.ocTextureRB);
            this.groupBox3.Controls.Add(this.ocConstRB);
            this.groupBox3.Location = new System.Drawing.Point(3, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor obiektu";
            // 
            // ocPBox2
            // 
            this.ocPBox2.Location = new System.Drawing.Point(65, 37);
            this.ocPBox2.Name = "ocPBox2";
            this.ocPBox2.Size = new System.Drawing.Size(60, 27);
            this.ocPBox2.TabIndex = 9;
            this.ocPBox2.TabStop = false;
            // 
            // ocTextureButton
            // 
            this.ocTextureButton.Location = new System.Drawing.Point(123, 42);
            this.ocTextureButton.Name = "ocTextureButton";
            this.ocTextureButton.Size = new System.Drawing.Size(45, 20);
            this.ocTextureButton.TabIndex = 4;
            this.ocTextureButton.Text = "Zmień";
            this.ocTextureButton.UseVisualStyleBackColor = true;
            this.ocTextureButton.Click += new System.EventHandler(this.ocTextureButton_Click);
            // 
            // ocConstButton
            // 
            this.ocConstButton.Location = new System.Drawing.Point(123, 19);
            this.ocConstButton.Name = "ocConstButton";
            this.ocConstButton.Size = new System.Drawing.Size(45, 20);
            this.ocConstButton.TabIndex = 3;
            this.ocConstButton.Text = "Zmień";
            this.ocConstButton.UseVisualStyleBackColor = true;
            this.ocConstButton.Click += new System.EventHandler(this.ocConstChangeButton_Click);
            // 
            // ocPBox
            // 
            this.ocPBox.BackColor = System.Drawing.Color.White;
            this.ocPBox.Location = new System.Drawing.Point(65, 19);
            this.ocPBox.Name = "ocPBox";
            this.ocPBox.Size = new System.Drawing.Size(52, 17);
            this.ocPBox.TabIndex = 2;
            this.ocPBox.TabStop = false;
            // 
            // ocTextureRB
            // 
            this.ocTextureRB.AutoSize = true;
            this.ocTextureRB.Checked = true;
            this.ocTextureRB.Location = new System.Drawing.Point(7, 44);
            this.ocTextureRB.Name = "ocTextureRB";
            this.ocTextureRB.Size = new System.Drawing.Size(63, 17);
            this.ocTextureRB.TabIndex = 1;
            this.ocTextureRB.TabStop = true;
            this.ocTextureRB.Text = "tekstura";
            this.ocTextureRB.UseVisualStyleBackColor = true;
            this.ocTextureRB.CheckedChanged += new System.EventHandler(this.ocTextureRB_CheckedChanged);
            // 
            // ocConstRB
            // 
            this.ocConstRB.AutoSize = true;
            this.ocConstRB.Location = new System.Drawing.Point(7, 20);
            this.ocConstRB.Name = "ocConstRB";
            this.ocConstRB.Size = new System.Drawing.Size(48, 17);
            this.ocConstRB.TabIndex = 0;
            this.ocConstRB.Text = "stały";
            this.ocConstRB.UseVisualStyleBackColor = true;
            this.ocConstRB.CheckedChanged += new System.EventHandler(this.ocConstRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lightSourceColorReflectorsRB);
            this.groupBox2.Controls.Add(this.lightSourceConstColorRB);
            this.groupBox2.Controls.Add(this.lightColorPbox);
            this.groupBox2.Controls.Add(this.soLightButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolor źródła światła";
            // 
            // lightSourceColorReflectorsRB
            // 
            this.lightSourceColorReflectorsRB.AutoSize = true;
            this.lightSourceColorReflectorsRB.Checked = true;
            this.lightSourceColorReflectorsRB.Location = new System.Drawing.Point(6, 59);
            this.lightSourceColorReflectorsRB.Name = "lightSourceColorReflectorsRB";
            this.lightSourceColorReflectorsRB.Size = new System.Drawing.Size(85, 17);
            this.lightSourceColorReflectorsRB.TabIndex = 4;
            this.lightSourceColorReflectorsRB.TabStop = true;
            this.lightSourceColorReflectorsRB.Text = "z reflektorów";
            this.lightSourceColorReflectorsRB.UseVisualStyleBackColor = true;
            this.lightSourceColorReflectorsRB.CheckedChanged += new System.EventHandler(this.lightSourceColorReflectorsRB_CheckedChanged);
            // 
            // lightSourceConstColorRB
            // 
            this.lightSourceConstColorRB.AutoSize = true;
            this.lightSourceConstColorRB.Location = new System.Drawing.Point(6, 19);
            this.lightSourceConstColorRB.Name = "lightSourceConstColorRB";
            this.lightSourceConstColorRB.Size = new System.Drawing.Size(48, 17);
            this.lightSourceConstColorRB.TabIndex = 3;
            this.lightSourceConstColorRB.Text = "stały";
            this.lightSourceConstColorRB.UseVisualStyleBackColor = true;
            this.lightSourceConstColorRB.CheckedChanged += new System.EventHandler(this.lightSourceConstColorRB_CheckedChanged);
            // 
            // lightColorPbox
            // 
            this.lightColorPbox.BackColor = System.Drawing.Color.White;
            this.lightColorPbox.Location = new System.Drawing.Point(65, 19);
            this.lightColorPbox.Name = "lightColorPbox";
            this.lightColorPbox.Size = new System.Drawing.Size(52, 21);
            this.lightColorPbox.TabIndex = 1;
            this.lightColorPbox.TabStop = false;
            // 
            // soLightButton
            // 
            this.soLightButton.Location = new System.Drawing.Point(123, 17);
            this.soLightButton.Name = "soLightButton";
            this.soLightButton.Size = new System.Drawing.Size(45, 20);
            this.soLightButton.TabIndex = 2;
            this.soLightButton.Text = "Zmień";
            this.soLightButton.UseVisualStyleBackColor = true;
            this.soLightButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // pBox
            // 
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(3, 3);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(598, 555);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseDown);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            // 
            // sphereTimer
            // 
            this.sphereTimer.Tick += new System.EventHandler(this.countCirclePoint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Wypełniacz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapPBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereRadiusUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalMapPBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocPBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocPBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightColorPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button soLightButton;
        private System.Windows.Forms.PictureBox lightColorPbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ocTextureButton;
        private System.Windows.Forms.Button ocConstButton;
        private System.Windows.Forms.PictureBox ocPBox;
        private System.Windows.Forms.RadioButton ocTextureRB;
        private System.Windows.Forms.RadioButton ocConstRB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button disturbanceHeightMapChangeButton;
        private System.Windows.Forms.RadioButton disturbanceHeightMapRB;
        private System.Windows.Forms.RadioButton disturbanceNoneRB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown sphereRadiusUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Button sphereRadiusChangeButton;
        private System.Windows.Forms.RadioButton sphericaLVectorRB;
        private System.Windows.Forms.RadioButton constLVectorRB;
        private System.Windows.Forms.Button normalMapChangeButton;
        private System.Windows.Forms.RadioButton normalVectorNormalMapRB;
        private System.Windows.Forms.RadioButton normalVectorConstRB;
        private System.Windows.Forms.Timer sphereTimer;
        private System.Windows.Forms.PictureBox heightMapPBox;
        private System.Windows.Forms.PictureBox normalMapPBox;
        private System.Windows.Forms.PictureBox ocPBox2;
        private System.Windows.Forms.RadioButton lightSourceColorReflectorsRB;
        private System.Windows.Forms.RadioButton lightSourceConstColorRB;
    }
}

