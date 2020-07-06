namespace BigHomework
{
    partial class UPM_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPM_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Memberid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.TextBox();
            this.BirthPlace = new System.Windows.Forms.TextBox();
            this.Idcard = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入成员id：";
            // 
            // Memberid
            // 
            this.Memberid.Location = new System.Drawing.Point(164, 31);
            this.Memberid.Name = "Memberid";
            this.Memberid.Size = new System.Drawing.Size(198, 25);
            this.Memberid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(441, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "成员姓名：";
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(164, 110);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(125, 25);
            this.MemberName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(340, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别：";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Male.Location = new System.Drawing.Point(441, 113);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(49, 23);
            this.Male.TabIndex = 6;
            this.Male.TabStop = true;
            this.Male.Text = "男";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Female.Location = new System.Drawing.Point(540, 111);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(49, 23);
            this.Female.TabIndex = 7;
            this.Female.TabStop = true;
            this.Female.Text = "女";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "字  辈：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(340, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "出生日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(37, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "出 生 地：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(340, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "身份证号：";
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(164, 183);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(100, 25);
            this.Generation.TabIndex = 12;
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(456, 189);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(133, 25);
            this.Birth.TabIndex = 13;
            // 
            // BirthPlace
            // 
            this.BirthPlace.Location = new System.Drawing.Point(164, 249);
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Size = new System.Drawing.Size(150, 25);
            this.BirthPlace.TabIndex = 14;
            // 
            // Idcard
            // 
            this.Idcard.Location = new System.Drawing.Point(456, 249);
            this.Idcard.Name = "Idcard";
            this.Idcard.Size = new System.Drawing.Size(133, 25);
            this.Idcard.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(211, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(403, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UPM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 428);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Idcard);
            this.Controls.Add(this.BirthPlace);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Memberid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UPM_Form";
            this.Text = "修改成员信息";
            this.Load += new System.EventHandler(this.UPM_Form_Load);
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
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Generation;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.TextBox BirthPlace;
        private System.Windows.Forms.TextBox Idcard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}