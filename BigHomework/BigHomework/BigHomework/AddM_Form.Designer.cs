namespace BigHomework
{
    partial class AddM_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddM_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.RadioButton();
            this.F = new System.Windows.Forms.RadioButton();
            this.Generation = new System.Windows.Forms.TextBox();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.BirthPlace = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "字辈：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "出生地：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "父亲姓名：";
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(120, 20);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(100, 25);
            this.MemberName.TabIndex = 6;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(389, 35);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(43, 19);
            this.M.TabIndex = 7;
            this.M.TabStop = true;
            this.M.Text = "男";
            this.M.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(519, 35);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(43, 19);
            this.F.TabIndex = 8;
            this.F.TabStop = true;
            this.F.Text = "女";
            this.F.UseVisualStyleBackColor = true;
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(120, 125);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(100, 25);
            this.Generation.TabIndex = 9;
            // 
            // BirthDay
            // 
            this.BirthDay.CustomFormat = "xxxx-xx-xx";
            this.BirthDay.Location = new System.Drawing.Point(396, 121);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(200, 25);
            this.BirthDay.TabIndex = 10;
            // 
            // BirthPlace
            // 
            this.BirthPlace.Location = new System.Drawing.Point(120, 261);
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Size = new System.Drawing.Size(100, 25);
            this.BirthPlace.TabIndex = 11;
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(413, 261);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(100, 25);
            this.FatherName.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.BirthPlace);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.F);
            this.Controls.Add(this.M);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddM_Form";
            this.Text = "添加成员";
            this.Load += new System.EventHandler(this.AddM_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.TextBox Generation;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.TextBox BirthPlace;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.Button button1;
    }
}