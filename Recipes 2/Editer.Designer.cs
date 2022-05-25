namespace Recipes_2
{
    partial class Editor
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
            this.EditList = new System.Windows.Forms.ListBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PropertyBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddNewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditList
            // 
            this.EditList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EditList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EditList.FormattingEnabled = true;
            this.EditList.ItemHeight = 23;
            this.EditList.Location = new System.Drawing.Point(12, 12);
            this.EditList.Name = "EditList";
            this.EditList.Size = new System.Drawing.Size(547, 326);
            this.EditList.TabIndex = 0;
            this.EditList.SelectedIndexChanged += new System.EventHandler(this.EditList_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(571, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(150, 31);
            this.NameBox.TabIndex = 1;
            // 
            // PropertyBox
            // 
            this.PropertyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropertyBox.FormattingEnabled = true;
            this.PropertyBox.Items.AddRange(new object[] {
            "Gram",
            "Litre",
            "Amount"});
            this.PropertyBox.Location = new System.Drawing.Point(571, 49);
            this.PropertyBox.Name = "PropertyBox";
            this.PropertyBox.Size = new System.Drawing.Size(150, 31);
            this.PropertyBox.TabIndex = 8;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(571, 86);
            this.ValueBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(150, 31);
            this.ValueBox.TabIndex = 9;
            // 
            // EditBtn
            // 
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditBtn.Location = new System.Drawing.Point(571, 123);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(150, 34);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "Edit Selected";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveBtn.Location = new System.Drawing.Point(18, 357);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 34);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackBtn.Location = new System.Drawing.Point(148, 357);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(112, 34);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddNewBtn.Location = new System.Drawing.Point(571, 163);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(150, 34);
            this.AddNewBtn.TabIndex = 13;
            this.AddNewBtn.Text = "Add New";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.PropertyBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EditList);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.Text = "Editer";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox EditList;
        private TextBox NameBox;
        private ComboBox PropertyBox;
        private NumericUpDown ValueBox;
        private Button EditBtn;
        private Button SaveBtn;
        private Button BackBtn;
        private Button AddNewBtn;
    }
}