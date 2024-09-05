namespace XF1205_Insulation
{
    partial class TestRecordForm
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
            btnGenerateReport = new Button();
            groupBox1 = new GroupBox();
            txtLabHumidity = new TextBox();
            txtLabTemp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtProductPrepareTime = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtTestId = new TextBox();
            txtSampleId = new TextBox();
            lblTestId = new Label();
            lblSampleId = new Label();
            groupBox3 = new GroupBox();
            txtTestAccord = new TextBox();
            label7 = new Label();
            txtOperator = new TextBox();
            label6 = new Label();
            txtTestDate = new TextBox();
            label5 = new Label();
            txtRptNo = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            txtApparatusCheckDate = new TextBox();
            label15 = new Label();
            txtApparatusId = new TextBox();
            label9 = new Label();
            txtApparatusName = new TextBox();
            label8 = new Label();
            groupBox5 = new GroupBox();
            txtMinValue = new TextBox();
            label16 = new Label();
            txtPos3Value = new TextBox();
            label14 = new Label();
            txtPos5Value = new TextBox();
            label13 = new Label();
            txtPos2Value = new TextBox();
            label12 = new Label();
            txtPos4Value = new TextBox();
            label11 = new Label();
            txtPos1Value = new TextBox();
            label10 = new Label();
            groupBox6 = new GroupBox();
            rdoRefuse = new RadioButton();
            rdoPass = new RadioButton();
            txtRefuseValue = new TextBox();
            btnCloseForm = new Button();
            btnClearInput = new Button();
            groupBox7 = new GroupBox();
            txtMemo = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(520, 560);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(87, 36);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "生成报告";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLabHumidity);
            groupBox1.Controls.Add(txtLabTemp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 88);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "环境信息";
            // 
            // txtLabHumidity
            // 
            txtLabHumidity.Location = new Point(347, 36);
            txtLabHumidity.Name = "txtLabHumidity";
            txtLabHumidity.Size = new Size(80, 23);
            txtLabHumidity.TabIndex = 10;
            txtLabHumidity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLabTemp
            // 
            txtLabTemp.Location = new Point(126, 36);
            txtLabTemp.Name = "txtLabTemp";
            txtLabTemp.Size = new Size(74, 23);
            txtLabTemp.TabIndex = 8;
            txtLabTemp.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 39);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 9;
            label2.Text = "实验室湿度(%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 8;
            label1.Text = "实验室温度(℃):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtProductPrepareTime);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(lblProductName);
            groupBox2.Controls.Add(txtTestId);
            groupBox2.Controls.Add(txtSampleId);
            groupBox2.Controls.Add(lblTestId);
            groupBox2.Controls.Add(lblSampleId);
            groupBox2.Location = new Point(12, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 146);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "样品信息";
            // 
            // txtProductPrepareTime
            // 
            txtProductPrepareTime.Location = new Point(94, 98);
            txtProductPrepareTime.Name = "txtProductPrepareTime";
            txtProductPrepareTime.Size = new Size(333, 23);
            txtProductPrepareTime.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 12;
            label3.Text = "养护时间:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(94, 29);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(333, 23);
            txtProductName.TabIndex = 11;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(29, 32);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(59, 17);
            lblProductName.TabIndex = 10;
            lblProductName.Text = "产品名称:";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(318, 63);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(109, 23);
            txtTestId.TabIndex = 9;
            // 
            // txtSampleId
            // 
            txtSampleId.Location = new Point(94, 63);
            txtSampleId.Name = "txtSampleId";
            txtSampleId.Size = new Size(106, 23);
            txtSampleId.TabIndex = 8;
            txtSampleId.Leave += txtSampleId_Leave;
            // 
            // lblTestId
            // 
            lblTestId.AutoSize = true;
            lblTestId.Location = new Point(241, 66);
            lblTestId.Name = "lblTestId";
            lblTestId.Size = new Size(71, 17);
            lblTestId.TabIndex = 7;
            lblTestId.Text = "样品标识号:";
            // 
            // lblSampleId
            // 
            lblSampleId.AutoSize = true;
            lblSampleId.Location = new Point(29, 66);
            lblSampleId.Name = "lblSampleId";
            lblSampleId.Size = new Size(59, 17);
            lblSampleId.TabIndex = 6;
            lblSampleId.Text = "样品编号:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTestAccord);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtOperator);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTestDate);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtRptNo);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(475, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(240, 183);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "试验信息";
            // 
            // txtTestAccord
            // 
            txtTestAccord.Location = new Point(96, 72);
            txtTestAccord.Name = "txtTestAccord";
            txtTestAccord.Size = new Size(123, 23);
            txtTestAccord.TabIndex = 23;
            txtTestAccord.Text = "XF 1025-2014";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 75);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 22;
            label7.Text = "检验标准:";
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(96, 144);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(123, 23);
            txtOperator.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 147);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 18;
            label6.Text = "试验人员:";
            // 
            // txtTestDate
            // 
            txtTestDate.Location = new Point(96, 108);
            txtTestDate.Name = "txtTestDate";
            txtTestDate.Size = new Size(123, 23);
            txtTestDate.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 111);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 16;
            label5.Text = "试验日期:";
            // 
            // txtRptNo
            // 
            txtRptNo.Location = new Point(96, 36);
            txtRptNo.Name = "txtRptNo";
            txtRptNo.Size = new Size(123, 23);
            txtRptNo.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 39);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 14;
            label4.Text = "报告编号:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtApparatusCheckDate);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtApparatusId);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtApparatusName);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(12, 270);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 112);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "设备信息";
            // 
            // txtApparatusCheckDate
            // 
            txtApparatusCheckDate.Location = new Point(94, 68);
            txtApparatusCheckDate.Name = "txtApparatusCheckDate";
            txtApparatusCheckDate.Size = new Size(333, 23);
            txtApparatusCheckDate.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 71);
            label15.Name = "label15";
            label15.Size = new Size(59, 17);
            label15.TabIndex = 26;
            label15.Text = "检定日期:";
            // 
            // txtApparatusId
            // 
            txtApparatusId.Location = new Point(318, 31);
            txtApparatusId.Name = "txtApparatusId";
            txtApparatusId.Size = new Size(109, 23);
            txtApparatusId.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(253, 34);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 16;
            label9.Text = "设备编号:";
            // 
            // txtApparatusName
            // 
            txtApparatusName.Location = new Point(94, 31);
            txtApparatusName.Name = "txtApparatusName";
            txtApparatusName.Size = new Size(150, 23);
            txtApparatusName.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 34);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 24;
            label8.Text = "设备名称:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtMinValue);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(txtPos3Value);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtPos5Value);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(txtPos2Value);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(txtPos4Value);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(txtPos1Value);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(475, 208);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(240, 258);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "测试值";
            // 
            // txtMinValue
            // 
            txtMinValue.Location = new Point(105, 213);
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new Size(114, 23);
            txtMinValue.TabIndex = 23;
            txtMinValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 216);
            label16.Name = "label16";
            label16.Size = new Size(77, 17);
            label16.TabIndex = 24;
            label16.Text = "最小值(MΩ):";
            // 
            // txtPos3Value
            // 
            txtPos3Value.Location = new Point(105, 108);
            txtPos3Value.Name = "txtPos3Value";
            txtPos3Value.Size = new Size(114, 23);
            txtPos3Value.TabIndex = 21;
            txtPos3Value.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 111);
            label14.Name = "label14";
            label14.Size = new Size(72, 17);
            label14.TabIndex = 22;
            label14.Text = "点位3(MΩ):";
            // 
            // txtPos5Value
            // 
            txtPos5Value.Location = new Point(105, 177);
            txtPos5Value.Name = "txtPos5Value";
            txtPos5Value.Size = new Size(114, 23);
            txtPos5Value.TabIndex = 19;
            txtPos5Value.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 180);
            label13.Name = "label13";
            label13.Size = new Size(72, 17);
            label13.TabIndex = 20;
            label13.Text = "点位5(MΩ):";
            // 
            // txtPos2Value
            // 
            txtPos2Value.Location = new Point(105, 72);
            txtPos2Value.Name = "txtPos2Value";
            txtPos2Value.Size = new Size(114, 23);
            txtPos2Value.TabIndex = 17;
            txtPos2Value.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 75);
            label12.Name = "label12";
            label12.Size = new Size(72, 17);
            label12.TabIndex = 18;
            label12.Text = "点位2(MΩ):";
            // 
            // txtPos4Value
            // 
            txtPos4Value.Location = new Point(105, 144);
            txtPos4Value.Name = "txtPos4Value";
            txtPos4Value.Size = new Size(114, 23);
            txtPos4Value.TabIndex = 15;
            txtPos4Value.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 147);
            label11.Name = "label11";
            label11.Size = new Size(72, 17);
            label11.TabIndex = 16;
            label11.Text = "点位4(MΩ):";
            // 
            // txtPos1Value
            // 
            txtPos1Value.Location = new Point(105, 39);
            txtPos1Value.Name = "txtPos1Value";
            txtPos1Value.Size = new Size(114, 23);
            txtPos1Value.TabIndex = 14;
            txtPos1Value.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 42);
            label10.Name = "label10";
            label10.Size = new Size(72, 17);
            label10.TabIndex = 14;
            label10.Text = "点位1(MΩ):";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdoRefuse);
            groupBox6.Controls.Add(rdoPass);
            groupBox6.Controls.Add(txtRefuseValue);
            groupBox6.Location = new Point(12, 393);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(441, 73);
            groupBox6.TabIndex = 26;
            groupBox6.TabStop = false;
            groupBox6.Text = "试验结论";
            // 
            // rdoRefuse
            // 
            rdoRefuse.AutoSize = true;
            rdoRefuse.Location = new Point(126, 29);
            rdoRefuse.Name = "rdoRefuse";
            rdoRefuse.Size = new Size(140, 21);
            rdoRefuse.TabIndex = 27;
            rdoRefuse.TabStop = true;
            rdoRefuse.Text = "不符合要求,补充说明:";
            rdoRefuse.UseVisualStyleBackColor = true;
            // 
            // rdoPass
            // 
            rdoPass.AutoSize = true;
            rdoPass.Location = new Point(29, 28);
            rdoPass.Name = "rdoPass";
            rdoPass.Size = new Size(74, 21);
            rdoPass.TabIndex = 26;
            rdoPass.TabStop = true;
            rdoPass.Text = "符合要求";
            rdoPass.UseVisualStyleBackColor = true;
            // 
            // txtRefuseValue
            // 
            txtRefuseValue.Location = new Point(272, 28);
            txtRefuseValue.Name = "txtRefuseValue";
            txtRefuseValue.Size = new Size(155, 23);
            txtRefuseValue.TabIndex = 25;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(628, 560);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(87, 36);
            btnCloseForm.TabIndex = 27;
            btnCloseForm.Text = "关闭";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // btnClearInput
            // 
            btnClearInput.Location = new Point(13, 560);
            btnClearInput.Name = "btnClearInput";
            btnClearInput.Size = new Size(87, 36);
            btnClearInput.TabIndex = 28;
            btnClearInput.Text = "重置输入";
            btnClearInput.UseVisualStyleBackColor = true;
            btnClearInput.Click += btnClearInput_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtMemo);
            groupBox7.Location = new Point(13, 478);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(702, 64);
            groupBox7.TabIndex = 29;
            groupBox7.TabStop = false;
            groupBox7.Text = "备注";
            // 
            // txtMemo
            // 
            txtMemo.Location = new Point(28, 25);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(655, 23);
            txtMemo.TabIndex = 0;
            // 
            // TestRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 608);
            Controls.Add(groupBox7);
            Controls.Add(btnClearInput);
            Controls.Add(btnCloseForm);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGenerateReport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TestRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "试验记录";
            TopMost = true;
            Load += TestRecordForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGenerateReport;
        private GroupBox groupBox1;
        private TextBox txtLabTemp;
        private TextBox txtLabHumidity;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtTestId;
        private TextBox txtSampleId;
        private Label lblTestId;
        private Label lblSampleId;
        private TextBox txtProductPrepareTime;
        private GroupBox groupBox3;
        private TextBox txtOperator;
        private Label label6;
        private TextBox txtTestDate;
        private Label label5;
        private TextBox txtRptNo;
        private Label label4;
        private TextBox txtTestAccord;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox txtApparatusId;
        private Label label9;
        private TextBox txtApparatusName;
        private Label label8;
        private GroupBox groupBox5;
        private Label label10;
        private TextBox txtMinValue;
        private Label label16;
        private TextBox txtPos3Value;
        private Label label14;
        private TextBox txtPos5Value;
        private Label label13;
        private TextBox txtPos2Value;
        private Label label12;
        private TextBox txtPos4Value;
        private Label label11;
        private TextBox txtPos1Value;
        private GroupBox groupBox6;
        private TextBox txtRefuseValue;
        private Button btnCloseForm;
        private Button btnClearInput;
        private RadioButton rdoRefuse;
        private RadioButton rdoPass;
        private GroupBox groupBox7;
        private TextBox txtMemo;
        private TextBox txtApparatusCheckDate;
        private Label label15;
    }
}