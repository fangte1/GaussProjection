namespace GaussProjection
{
    partial class Form2
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
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_org_b_d = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_org_l_m = new System.Windows.Forms.TextBox();
            this.txt_org_l_f = new System.Windows.Forms.TextBox();
            this.txt_org_l_d = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_org_b_m = new System.Windows.Forms.TextBox();
            this.txt_org_b_f = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_setorg = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPoints = new System.Windows.Forms.RichTextBox();
            this.TestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_InitData = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(141, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(56, 17);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.Text = "1.5°带";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(88, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "3°带";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "6°带";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(11, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(214, 44);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分带";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_org_b_d);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txt_org_l_m);
            this.groupBox5.Controls.Add(this.txt_org_l_f);
            this.groupBox5.Controls.Add(this.txt_org_l_d);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txt_org_b_m);
            this.groupBox5.Controls.Add(this.txt_org_b_f);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(11, 71);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 96);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GPS坐标";
            // 
            // txt_org_b_d
            // 
            this.txt_org_b_d.Location = new System.Drawing.Point(46, 53);
            this.txt_org_b_d.Name = "txt_org_b_d";
            this.txt_org_b_d.Size = new System.Drawing.Size(52, 20);
            this.txt_org_b_d.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "秒";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "分";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(103, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "度";
            // 
            // txt_org_l_m
            // 
            this.txt_org_l_m.Location = new System.Drawing.Point(208, 27);
            this.txt_org_l_m.Name = "txt_org_l_m";
            this.txt_org_l_m.Size = new System.Drawing.Size(66, 20);
            this.txt_org_l_m.TabIndex = 15;
            this.txt_org_l_m.Text = "0";
            // 
            // txt_org_l_f
            // 
            this.txt_org_l_f.Location = new System.Drawing.Point(126, 27);
            this.txt_org_l_f.Name = "txt_org_l_f";
            this.txt_org_l_f.Size = new System.Drawing.Size(52, 20);
            this.txt_org_l_f.TabIndex = 14;
            this.txt_org_l_f.Text = "0";
            // 
            // txt_org_l_d
            // 
            this.txt_org_l_d.Location = new System.Drawing.Point(46, 27);
            this.txt_org_l_d.Name = "txt_org_l_d";
            this.txt_org_l_d.Size = new System.Drawing.Size(52, 20);
            this.txt_org_l_d.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(278, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "秒";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "分";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(103, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "度";
            // 
            // txt_org_b_m
            // 
            this.txt_org_b_m.Location = new System.Drawing.Point(208, 53);
            this.txt_org_b_m.Name = "txt_org_b_m";
            this.txt_org_b_m.Size = new System.Drawing.Size(66, 20);
            this.txt_org_b_m.TabIndex = 5;
            this.txt_org_b_m.Text = "0";
            // 
            // txt_org_b_f
            // 
            this.txt_org_b_f.Location = new System.Drawing.Point(126, 53);
            this.txt_org_b_f.Name = "txt_org_b_f";
            this.txt_org_b_f.Size = new System.Drawing.Size(52, 20);
            this.txt_org_b_f.TabIndex = 4;
            this.txt_org_b_f.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "经度：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "纬度：";
            // 
            // btn_setorg
            // 
            this.btn_setorg.Location = new System.Drawing.Point(121, 182);
            this.btn_setorg.Name = "btn_setorg";
            this.btn_setorg.Size = new System.Drawing.Size(93, 36);
            this.btn_setorg.TabIndex = 4;
            this.btn_setorg.Text = "设置原点";
            this.btn_setorg.UseVisualStyleBackColor = true;
            this.btn_setorg.Click += new System.EventHandler(this.btn_setorg_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(223, 182);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(88, 36);
            this.btnAddPoint.TabIndex = 4;
            this.btnAddPoint.Text = "增加坐标";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPoints);
            this.groupBox1.Location = new System.Drawing.Point(11, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 266);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日志";
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPoints.ForeColor = System.Drawing.Color.Red;
            this.txtPoints.Location = new System.Drawing.Point(6, 19);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(290, 235);
            this.txtPoints.TabIndex = 20;
            this.txtPoints.Text = "";
            // 
            // TestChart
            // 
            this.TestChart.Location = new System.Drawing.Point(317, 12);
            this.TestChart.Name = "TestChart";
            this.TestChart.Size = new System.Drawing.Size(597, 495);
            this.TestChart.TabIndex = 24;
            this.TestChart.Text = "TestChart";
            // 
            // btn_InitData
            // 
            this.btn_InitData.Location = new System.Drawing.Point(11, 182);
            this.btn_InitData.Name = "btn_InitData";
            this.btn_InitData.Size = new System.Drawing.Size(98, 36);
            this.btn_InitData.TabIndex = 4;
            this.btn_InitData.Text = "初始测试数据";
            this.btn_InitData.UseVisualStyleBackColor = true;
            this.btn_InitData.Click += new System.EventHandler(this.btn_InitData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.TestChart);
            this.Controls.Add(this.btn_setorg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btn_InitData);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "GPS坐标转平面坐标";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_org_l_m;
        private System.Windows.Forms.TextBox txt_org_l_f;
        private System.Windows.Forms.TextBox txt_org_l_d;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_org_b_m;
        private System.Windows.Forms.TextBox txt_org_b_f;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_org_b_d;
        private System.Windows.Forms.Button btn_setorg;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtPoints;
        private System.Windows.Forms.DataVisualization.Charting.Chart TestChart;
        private System.Windows.Forms.Button btn_InitData;
    }
}