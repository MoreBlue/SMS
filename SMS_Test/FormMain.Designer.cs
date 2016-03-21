namespace SMS_Test
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.checkBoxTiming = new System.Windows.Forms.CheckBox();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.checkBoxAddTimeSpan = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 177);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(73, 11);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(280, 21);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "13409000960";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(73, 35);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(280, 110);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "您的SS账号邀请码/验证码为：【123】";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "收信号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "短信内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "发送时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "多个收信号码之间请用逗号隔开";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "要求不超过500个字";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(73, 150);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 21);
            this.dtp.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "不打钩则默认立即发送";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(93, 177);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 4;
            this.btnGetReport.Text = "接收报告";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(3, 206);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(546, 299);
            this.txtResult.TabIndex = 5;
            // 
            // checkBoxTiming
            // 
            this.checkBoxTiming.AutoSize = true;
            this.checkBoxTiming.Location = new System.Drawing.Point(280, 154);
            this.checkBoxTiming.Name = "checkBoxTiming";
            this.checkBoxTiming.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTiming.TabIndex = 11;
            this.checkBoxTiming.Text = "定时发送";
            this.checkBoxTiming.UseVisualStyleBackColor = true;
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Location = new System.Drawing.Point(174, 177);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(75, 23);
            this.btnGetBalance.TabIndex = 12;
            this.btnGetBalance.Text = "查询余额";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // checkBoxAddTimeSpan
            // 
            this.checkBoxAddTimeSpan.AutoSize = true;
            this.checkBoxAddTimeSpan.Location = new System.Drawing.Point(359, 129);
            this.checkBoxAddTimeSpan.Name = "checkBoxAddTimeSpan";
            this.checkBoxAddTimeSpan.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAddTimeSpan.TabIndex = 13;
            this.checkBoxAddTimeSpan.Text = "是否追加时间";
            this.checkBoxAddTimeSpan.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 509);
            this.Controls.Add(this.checkBoxAddTimeSpan);
            this.Controls.Add(this.btnGetBalance);
            this.Controls.Add(this.checkBoxTiming);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "短信服务测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox checkBoxTiming;
        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.CheckBox checkBoxAddTimeSpan;
    }
}

