namespace BigHomework
{
    partial class LoF_Form
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
            this.MapName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Introduce = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Precepts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入族谱id：";
            // 
            // Mapid
            // 
            this.Mapid.Location = new System.Drawing.Point(164, 21);
            this.Mapid.Name = "Mapid";
            this.Mapid.Size = new System.Drawing.Size(194, 25);
            this.Mapid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 24);
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
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "族谱姓名：";
            // 
            // MapName
            // 
            this.MapName.Location = new System.Drawing.Point(109, 95);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(102, 25);
            this.MapName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "族谱姓氏：";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(413, 95);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(115, 25);
            this.Surname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "字辈词串：";
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(109, 166);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(419, 25);
            this.Generation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "族谱简介：";
            // 
            // Introduce
            // 
            this.Introduce.Location = new System.Drawing.Point(109, 237);
            this.Introduce.Name = "Introduce";
            this.Introduce.Size = new System.Drawing.Size(419, 110);
            this.Introduce.TabIndex = 10;
            this.Introduce.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "家训：";
            // 
            // Precepts
            // 
            this.Precepts.Location = new System.Drawing.Point(109, 410);
            this.Precepts.Name = "Precepts";
            this.Precepts.Size = new System.Drawing.Size(419, 146);
            this.Precepts.TabIndex = 12;
            this.Precepts.Text = "";
            // 
            // LoF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 650);
            this.Controls.Add(this.Precepts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Introduce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MapName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mapid);
            this.Controls.Add(this.label1);
            this.Name = "LoF_Form";
            this.Text = "查询族谱基本信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mapid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MapName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Generation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Introduce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Precepts;
    }
}