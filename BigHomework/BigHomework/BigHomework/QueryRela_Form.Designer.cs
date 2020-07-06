namespace BigHomework
{
    partial class QueryRela_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryRela_Form));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Memberid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.Sex,
            this.Generation,
            this.Birth,
            this.Relation,
            this.Idcard});
            this.dgv.Location = new System.Drawing.Point(1, 180);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(800, 272);
            this.dgv.TabIndex = 0;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "姓名";
            this.MemberName.MinimumWidth = 6;
            this.MemberName.Name = "MemberName";
            this.MemberName.Width = 125;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 125;
            // 
            // Generation
            // 
            this.Generation.HeaderText = "字辈";
            this.Generation.MinimumWidth = 6;
            this.Generation.Name = "Generation";
            this.Generation.Width = 125;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "出生日期";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Width = 125;
            // 
            // Relation
            // 
            this.Relation.HeaderText = "关系";
            this.Relation.MinimumWidth = 6;
            this.Relation.Name = "Relation";
            this.Relation.Width = 125;
            // 
            // Idcard
            // 
            this.Idcard.HeaderText = "身份证号";
            this.Idcard.MinimumWidth = 6;
            this.Idcard.Name = "Idcard";
            this.Idcard.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入成员id：";
            // 
            // Memberid
            // 
            this.Memberid.Location = new System.Drawing.Point(166, 86);
            this.Memberid.Name = "Memberid";
            this.Memberid.Size = new System.Drawing.Size(181, 25);
            this.Memberid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(436, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QueryRela_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Memberid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "QueryRela_Form";
            this.Text = "查询亲戚";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Memberid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcard;
    }
}