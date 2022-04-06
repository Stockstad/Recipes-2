namespace Recipes_2
{
    partial class ShoppingList
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
            this.ShoppingShowList = new System.Windows.Forms.ListBox();
            this.CreateListBtn = new System.Windows.Forms.Button();
            this.dayBox = new System.Windows.Forms.NumericUpDown();
            this.mealBox = new System.Windows.Forms.NumericUpDown();
            this.NeededList = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShoppingShowList
            // 
            this.ShoppingShowList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ShoppingShowList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ShoppingShowList.FormattingEnabled = true;
            this.ShoppingShowList.ItemHeight = 23;
            this.ShoppingShowList.Location = new System.Drawing.Point(12, 39);
            this.ShoppingShowList.Name = "ShoppingShowList";
            this.ShoppingShowList.Size = new System.Drawing.Size(419, 280);
            this.ShoppingShowList.TabIndex = 0;
            // 
            // CreateListBtn
            // 
            this.CreateListBtn.Location = new System.Drawing.Point(715, 356);
            this.CreateListBtn.Name = "CreateListBtn";
            this.CreateListBtn.Size = new System.Drawing.Size(135, 46);
            this.CreateListBtn.TabIndex = 1;
            this.CreateListBtn.Text = "Generate";
            this.CreateListBtn.UseVisualStyleBackColor = true;
            this.CreateListBtn.Click += new System.EventHandler(this.CreateListBtn_Click);
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(12, 371);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(180, 31);
            this.dayBox.TabIndex = 2;
            // 
            // mealBox
            // 
            this.mealBox.Location = new System.Drawing.Point(12, 325);
            this.mealBox.Name = "mealBox";
            this.mealBox.Size = new System.Drawing.Size(180, 31);
            this.mealBox.TabIndex = 3;
            // 
            // NeededList
            // 
            this.NeededList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NeededList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.NeededList.FormattingEnabled = true;
            this.NeededList.ItemHeight = 23;
            this.NeededList.Location = new System.Drawing.Point(453, 39);
            this.NeededList.Name = "NeededList";
            this.NeededList.Size = new System.Drawing.Size(397, 280);
            this.NeededList.TabIndex = 4;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(561, 356);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(135, 46);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Meals Per Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(198, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Needed ingredients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(453, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your meals for the week:";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(265, 421);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(135, 31);
            this.SendBtn.TabIndex = 10;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(12, 421);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(180, 31);
            this.MailBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(198, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mail";
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NeededList);
            this.Controls.Add(this.mealBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.CreateListBtn);
            this.Controls.Add(this.ShoppingShowList);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ShoppingList";
            this.Text = "ShoppingList";
            this.Load += new System.EventHandler(this.ShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ShoppingShowList;
        private Button CreateListBtn;
        private NumericUpDown dayBox;
        private NumericUpDown mealBox;
        private ListBox NeededList;
        private Button BackBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SendBtn;
        private TextBox MailBox;
        private Label label5;
    }
}