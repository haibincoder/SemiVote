namespace toupiao
{
    partial class Form1
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
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.pic_code = new System.Windows.Forms.PictureBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_code)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(115, 104);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(173, 28);
            this.tb_phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "手机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "验证码";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(115, 230);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(173, 28);
            this.tb_code.TabIndex = 3;
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_TextChanged);
            // 
            // pic_code
            // 
            this.pic_code.Location = new System.Drawing.Point(115, 164);
            this.pic_code.Name = "pic_code";
            this.pic_code.Size = new System.Drawing.Size(100, 50);
            this.pic_code.TabIndex = 4;
            this.pic_code.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(115, 288);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(139, 42);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "投票";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "验证码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "公司号";
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(115, 47);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(173, 28);
            this.tb_company.TabIndex = 7;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(27, 355);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 18);
            this.lbl_result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 406);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pic_code);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_phone);
            this.Name = "Form1";
            this.Text = "投票";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.PictureBox pic_code;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.Label lbl_result;
    }
}

