namespace BigHomework
{
    partial class LoM_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoM_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Memberid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthPlace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入成员id：";
            // 
            // Memberid
            // 
            this.Memberid.Location = new System.Drawing.Point(182, 42);
            this.Memberid.Name = "Memberid";
            this.Memberid.Size = new System.Drawing.Size(148, 25);
            this.Memberid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(136, 128);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(100, 25);
            this.MemberName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别：";
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(403, 128);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(100, 25);
            this.Sex.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "出生日期：";
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(136, 203);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(100, 25);
            this.Birth.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "出生地：";
            // 
            // BirthPlace
            // 
            this.BirthPlace.Location = new System.Drawing.Point(403, 203);
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Size = new System.Drawing.Size(100, 25);
            this.BirthPlace.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "字辈：";
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(136, 283);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(100, 25);
            this.Generation.TabIndex = 12;
            // 
            // LoM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 523);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Memberid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoM_Form";
            this.Text = "查询成员基本信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Memberid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthPlace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Generation;
    }
}