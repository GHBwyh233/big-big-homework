namespace BigHomework
{
    partial class FindPwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPwdForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pwd1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pwd2 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入用户名：";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(148, 60);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(135, 25);
            this.Username.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Cornsilk;
            this.btn1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(104, 107);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 32);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "找回密码";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入邮箱验证：";
            this.label2.Visible = false;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(148, 172);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(135, 25);
            this.Email.TabIndex = 4;
            this.Email.Visible = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Cornsilk;
            this.btn2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(104, 232);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(104, 29);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "验证";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "请输入新密码：";
            this.label3.Visible = false;
            // 
            // Pwd1
            // 
            this.Pwd1.Location = new System.Drawing.Point(148, 296);
            this.Pwd1.Name = "Pwd1";
            this.Pwd1.Size = new System.Drawing.Size(100, 25);
            this.Pwd1.TabIndex = 7;
            this.Pwd1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "确认密码：";
            this.label4.Visible = false;
            // 
            // Pwd2
            // 
            this.Pwd2.Location = new System.Drawing.Point(148, 355);
            this.Pwd2.Name = "Pwd2";
            this.Pwd2.Size = new System.Drawing.Size(100, 25);
            this.Pwd2.TabIndex = 9;
            this.Pwd2.Visible = false;
            this.Pwd2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Cornsilk;
            this.btn3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(87, 407);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 33);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "确定";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(228, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FindPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.Pwd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pwd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindPwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找回密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pwd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pwd2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button1;
    }
}