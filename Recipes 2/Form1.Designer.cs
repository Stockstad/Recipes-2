namespace Recipes_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipesList = new System.Windows.Forms.ListBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.shopListBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipesList
            // 
            this.RecipesList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.RecipesList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RecipesList.FormattingEnabled = true;
            this.RecipesList.ItemHeight = 23;
            this.RecipesList.Location = new System.Drawing.Point(13, 12);
            this.RecipesList.Name = "RecipesList";
            this.RecipesList.Size = new System.Drawing.Size(596, 326);
            this.RecipesList.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowBtn.Location = new System.Drawing.Point(15, 350);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(144, 41);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(724, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(144, 41);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add Recipe";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // shopListBtn
            // 
            this.shopListBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shopListBtn.Location = new System.Drawing.Point(724, 59);
            this.shopListBtn.Name = "shopListBtn";
            this.shopListBtn.Size = new System.Drawing.Size(144, 41);
            this.shopListBtn.TabIndex = 5;
            this.shopListBtn.Text = "Shopping List";
            this.shopListBtn.UseVisualStyleBackColor = true;
            this.shopListBtn.Click += new System.EventHandler(this.shopListBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditBtn.Location = new System.Drawing.Point(724, 106);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(144, 41);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Edit Recipe";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.shopListBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.RecipesList);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Recipes 2";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox RecipesList;
        private Button ShowBtn;
        private Button AddBtn;
        private Button shopListBtn;
        private Button EditBtn;
    }
}