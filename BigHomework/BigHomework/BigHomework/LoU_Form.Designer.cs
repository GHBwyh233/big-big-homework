namespace BigHomework
{
    partial class LoU_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoU_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MapName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PerLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入用户名：";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(131, 27);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(216, 25);
            this.Username.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "成员姓名：";
            // 
            // Username1
            // 
            this.Username1.Location = new System.Drawing.Point(131, 111);
            this.Username1.Name = "Username1";
            this.Username1.Size = new System.Drawing.Size(147, 25);
            this.Username1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "所属族谱：";
            // 
            // MapName
            // 
            this.MapName.Location = new System.Drawing.Point(509, 111);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(125, 25);
            this.MapName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "电话：";
            // 
            // Tele
            // 
            this.Tele.Location = new System.Drawing.Point(131, 183);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(147, 25);
            this.Tele.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "邮箱：";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(509, 183);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(125, 25);
            this.Email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "权限：";
            // 
            // PerLevel
            // 
            this.PerLevel.Location = new System.Drawing.Point(131, 264);
            this.PerLevel.Name = "PerLevel";
            this.PerLevel.Size = new System.Drawing.Size(147, 25);
            this.PerLevel.TabIndex = 12;
            this.PerLevel.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // LoU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MapName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoU_Form";
            this.Text = "查询用户信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MapName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PerLevel;
    }
}