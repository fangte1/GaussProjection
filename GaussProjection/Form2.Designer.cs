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
            this._radio_zoning_1_5 = new System.Windows.Forms.RadioButton();
            this._radio_zoning_3 = new System.Windows.Forms.RadioButton();
            this._radio_zoning_6 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._txt_org_b_d = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this._txt_org_l_m = new System.Windows.Forms.TextBox();
            this._txt_org_l_f = new System.Windows.Forms.TextBox();
            this._txt_org_l_d = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this._txt_org_b_m = new System.Windows.Forms.TextBox();
            this._txt_org_b_f = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this._btnSetOrgin = new System.Windows.Forms.Button();
            this._btnAddPoint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtLogs = new System.Windows.Forms.RichTextBox();
            this.TestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).BeginInit();
            this.SuspendLayout();
            // 
            // _radio_zoning_1_5
            // 
            this._radio_zoning_1_5.AutoSize = true;
            this._radio_zoning_1_5.Location = new System.Drawing.Point(141, 18);
            this._radio_zoning_1_5.Name = "_radio_zoning_1_5";
            this._radio_zoning_1_5.Size = new System.Drawing.Size(65, 16);
            this._radio_zoning_1_5.TabIndex = 2;
            this._radio_zoning_1_5.Text = "1.5°带";
            this._radio_zoning_1_5.UseVisualStyleBackColor = true;
            // 
            // _radio_zoning_3
            // 
            this._radio_zoning_3.AutoSize = true;
            this._radio_zoning_3.Location = new System.Drawing.Point(88, 18);
            this._radio_zoning_3.Name = "_radio_zoning_3";
            this._radio_zoning_3.Size = new System.Drawing.Size(53, 16);
            this._radio_zoning_3.TabIndex = 1;
            this._radio_zoning_3.Text = "3°带";
            this._radio_zoning_3.UseVisualStyleBackColor = true;
            // 
            // _radio_zoning_6
            // 
            this._radio_zoning_6.AutoSize = true;
            this._radio_zoning_6.Checked = true;
            this._radio_zoning_6.Location = new System.Drawing.Point(35, 18);
            this._radio_zoning_6.Name = "_radio_zoning_6";
            this._radio_zoning_6.Size = new System.Drawing.Size(53, 16);
            this._radio_zoning_6.TabIndex = 0;
            this._radio_zoning_6.TabStop = true;
            this._radio_zoning_6.Text = "6°带";
            this._radio_zoning_6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._radio_zoning_1_5);
            this.groupBox4.Controls.Add(this._radio_zoning_3);
            this.groupBox4.Controls.Add(this._radio_zoning_6);
            this.groupBox4.Location = new System.Drawing.Point(11, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(214, 41);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分带";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._txt_org_b_d);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this._txt_org_l_m);
            this.groupBox5.Controls.Add(this._txt_org_l_f);
            this.groupBox5.Controls.Add(this._txt_org_l_d);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this._txt_org_b_m);
            this.groupBox5.Controls.Add(this._txt_org_b_f);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(11, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 89);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GPS坐标";
            // 
            // _txt_org_b_d
            // 
            this._txt_org_b_d.Location = new System.Drawing.Point(46, 49);
            this._txt_org_b_d.Name = "_txt_org_b_d";
            this._txt_org_b_d.Size = new System.Drawing.Size(52, 21);
            this._txt_org_b_d.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "秒";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "分";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(103, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "度";
            // 
            // _txt_org_l_m
            // 
            this._txt_org_l_m.Location = new System.Drawing.Point(208, 25);
            this._txt_org_l_m.Name = "_txt_org_l_m";
            this._txt_org_l_m.Size = new System.Drawing.Size(66, 21);
            this._txt_org_l_m.TabIndex = 5;
            this._txt_org_l_m.Text = "0";
            // 
            // _txt_org_l_f
            // 
            this._txt_org_l_f.Location = new System.Drawing.Point(126, 25);
            this._txt_org_l_f.Name = "_txt_org_l_f";
            this._txt_org_l_f.Size = new System.Drawing.Size(52, 21);
            this._txt_org_l_f.TabIndex = 4;
            this._txt_org_l_f.Text = "0";
            // 
            // _txt_org_l_d
            // 
            this._txt_org_l_d.Location = new System.Drawing.Point(46, 25);
            this._txt_org_l_d.Name = "_txt_org_l_d";
            this._txt_org_l_d.Size = new System.Drawing.Size(52, 21);
            this._txt_org_l_d.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(278, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "秒";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "分";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(103, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "度";
            // 
            // _txt_org_b_m
            // 
            this._txt_org_b_m.Location = new System.Drawing.Point(208, 49);
            this._txt_org_b_m.Name = "_txt_org_b_m";
            this._txt_org_b_m.Size = new System.Drawing.Size(66, 21);
            this._txt_org_b_m.TabIndex = 8;
            this._txt_org_b_m.Text = "0";
            // 
            // _txt_org_b_f
            // 
            this._txt_org_b_f.Location = new System.Drawing.Point(126, 49);
            this._txt_org_b_f.Name = "_txt_org_b_f";
            this._txt_org_b_f.Size = new System.Drawing.Size(52, 21);
            this._txt_org_b_f.TabIndex = 7;
            this._txt_org_b_f.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 3;
            this.label21.Text = "经度：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "纬度：";
            // 
            // _btnSetOrgin
            // 
            this._btnSetOrgin.Location = new System.Drawing.Point(29, 168);
            this._btnSetOrgin.Name = "_btnSetOrgin";
            this._btnSetOrgin.Size = new System.Drawing.Size(104, 33);
            this._btnSetOrgin.TabIndex = 9;
            this._btnSetOrgin.Text = "初始化坐标";
            this._btnSetOrgin.UseVisualStyleBackColor = true;
            this._btnSetOrgin.Click += new System.EventHandler(this.btnSetOrgin_Click);
            // 
            // _btnAddPoint
            // 
            this._btnAddPoint.Location = new System.Drawing.Point(181, 168);
            this._btnAddPoint.Name = "_btnAddPoint";
            this._btnAddPoint.Size = new System.Drawing.Size(104, 33);
            this._btnAddPoint.TabIndex = 10;
            this._btnAddPoint.Text = "增加坐标";
            this._btnAddPoint.UseVisualStyleBackColor = true;
            this._btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._txtLogs);
            this.groupBox1.Location = new System.Drawing.Point(11, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 246);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日志";
            // 
            // _txtLogs
            // 
            this._txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._txtLogs.ForeColor = System.Drawing.Color.Red;
            this._txtLogs.Location = new System.Drawing.Point(6, 18);
            this._txtLogs.Name = "_txtLogs";
            this._txtLogs.ReadOnly = true;
            this._txtLogs.Size = new System.Drawing.Size(290, 217);
            this._txtLogs.TabIndex = 20;
            this._txtLogs.Text = "";
            // 
            // TestChart
            // 
            this.TestChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestChart.Location = new System.Drawing.Point(317, 11);
            this.TestChart.Name = "TestChart";
            this.TestChart.Size = new System.Drawing.Size(597, 457);
            this.TestChart.TabIndex = 24;
            this.TestChart.Text = "TestChart";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 474);
            this.Controls.Add(this.TestChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this._btnAddPoint);
            this.Controls.Add(this._btnSetOrgin);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPS坐标转平面坐标";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton _radio_zoning_1_5;
        private System.Windows.Forms.RadioButton _radio_zoning_3;
        private System.Windows.Forms.RadioButton _radio_zoning_6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox _txt_org_l_m;
        private System.Windows.Forms.TextBox _txt_org_l_f;
        private System.Windows.Forms.TextBox _txt_org_l_d;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox _txt_org_b_m;
        private System.Windows.Forms.TextBox _txt_org_b_f;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox _txt_org_b_d;
        private System.Windows.Forms.Button _btnSetOrgin;
        private System.Windows.Forms.Button _btnAddPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox _txtLogs;
        private System.Windows.Forms.DataVisualization.Charting.Chart TestChart;
    }
}