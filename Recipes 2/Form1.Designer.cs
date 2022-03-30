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
            this.ChangeLogLabel = new System.Windows.Forms.Label();
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
            this.AddBtn.Location = new System.Drawing.Point(180, 350);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(144, 41);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChangeLogLabel
            // 
            this.ChangeLogLabel.AutoSize = true;
            this.ChangeLogLabel.Location = new System.Drawing.Point(615, 12);
            this.ChangeLogLabel.Name = "ChangeLogLabel";
            this.ChangeLogLabel.Size = new System.Drawing.Size(260, 161);
            this.ChangeLogLabel.TabIndex = 3;
            this.ChangeLogLabel.Text = "Welcome to Recipes 2! \r\nThe new and improved vers-\r\n ion of the not-so-popular\r\nr" +
    "ecipe handler.\r\n   In this version, you can\r\nexpect to encounter endless \r\nbugs " +
    "and the sorts. Welcome!\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.ChangeLogLabel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.RecipesList);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Recipes 2";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox RecipesList;
        private Button ShowBtn;
        private Button AddBtn;
        private Label ChangeLogLabel;
    }
}