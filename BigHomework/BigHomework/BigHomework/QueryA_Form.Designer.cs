﻿namespace BigHomework
{
    partial class QueryA_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Mapid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthPlace = new System.Windows.Forms.TextBox();
            this.Generation = new System.Windows.Forms.TextBox();
            this.Idcard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入族谱id：";
            // 
            // Mapid
            // 
            this.Mapid.Location = new System.Drawing.Point(178, 48);
            this.Mapid.Name = "Mapid";
            this.Mapid.Size = new System.Drawing.Size(100, 25);
            this.Mapid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 47);
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
            this.label2.Location = new System.Drawing.Point(54, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "祖先姓名：";
            // 
            // AName
            // 
            this.AName.Location = new System.Drawing.Point(178, 141);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(100, 25);
            this.AName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别：";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(479, 144);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(43, 19);
            this.Male.TabIndex = 6;
            this.Male.TabStop = true;
            this.Male.Text = "男";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(567, 142);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(43, 19);
            this.Female.TabIndex = 7;
            this.Female.TabStop = true;
            this.Female.Text = "女";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "出生日期：";
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(178, 217);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(100, 25);
            this.Birth.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "出生地：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "字辈：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "身份证号：";
            // 
            // BirthPlace
            // 
            this.BirthPlace.Location = new System.Drawing.Point(479, 227);
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Size = new System.Drawing.Size(100, 25);
            this.BirthPlace.TabIndex = 14;
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(178, 289);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(100, 25);
            this.Generation.TabIndex = 15;
            // 
            // Idcard
            // 
            this.Idcard.Location = new System.Drawing.Point(479, 297);
            this.Idcard.Name = "Idcard";
            this.Idcard.Size = new System.Drawing.Size(100, 25);
            this.Idcard.TabIndex = 16;
            // 
            // QueryA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Idcard);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.BirthPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mapid);
            this.Controls.Add(this.label1);
            this.Name = "QueryA_Form";
            this.Text = "QueryA_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mapid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BirthPlace;
        private System.Windows.Forms.TextBox Generation;
        private System.Windows.Forms.TextBox Idcard;
    }
}