namespace BigHomework
{
    partial class AddF_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddF_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.MapName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Introduce = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Precepts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "族谱姓名：";
            // 
            // MapName
            // 
            this.MapName.Location = new System.Drawing.Point(101, 25);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(115, 25);
            this.MapName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "族谱姓氏：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(404, 25);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(119, 25);
            this.Surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "字辈词串：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(101, 101);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(422, 25);
            this.Generation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "家训：";
            // 
            // Introduce
            // 
            this.Introduce.Location = new System.Drawing.Point(101, 179);
            this.Introduce.Name = "Introduce";
            this.Introduce.Size = new System.Drawing.Size(422, 74);
            this.Introduce.TabIndex = 7;
            this.Introduce.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "创建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "简介：";
            // 
            // Precepts
            // 
            this.Precepts.Location = new System.Drawing.Point(101, 303);
            this.Precepts.Name = "Precepts";
            this.Precepts.Size = new System.Drawing.Size(422, 161);
            this.Precepts.TabIndex = 10;
            this.Precepts.Text = "";
            // 
            // AddF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 555);
            this.Controls.Add(this.Precepts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Introduce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddF_Form";
            this.Text = "创建族谱";
            this.Load += new System.EventHandler(this.AddF_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MapName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Generation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Introduce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Precepts;
    }
}