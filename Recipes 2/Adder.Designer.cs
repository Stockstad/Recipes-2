namespace Recipes_2
{
    partial class Adder
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
            this.AddedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.IngredientName = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.Property = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RecipeNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // AddedList
            // 
            this.AddedList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AddedList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddedList.FormattingEnabled = true;
            this.AddedList.ItemHeight = 23;
            this.AddedList.Location = new System.Drawing.Point(13, 11);
            this.AddedList.Name = "AddedList";
            this.AddedList.Size = new System.Drawing.Size(547, 257);
            this.AddedList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(700, 53);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(112, 34);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // IngredientName
            // 
            this.IngredientName.Location = new System.Drawing.Point(138, 282);
            this.IngredientName.Name = "IngredientName";
            this.IngredientName.Size = new System.Drawing.Size(150, 31);
            this.IngredientName.TabIndex = 5;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(138, 346);
            this.Amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(150, 31);
            this.Amount.TabIndex = 6;
            // 
            // Property
            // 
            this.Property.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Property.FormattingEnabled = true;
            this.Property.Items.AddRange(new object[] {
            "Gram",
            "Litre",
            "Amount"});
            this.Property.Location = new System.Drawing.Point(138, 314);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(150, 31);
            this.Property.TabIndex = 7;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(294, 282);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 34);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(412, 282);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(112, 34);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(566, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recipe Name:";
            // 
            // RecipeNameBox
            // 
            this.RecipeNameBox.Location = new System.Drawing.Point(700, 16);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(150, 31);
            this.RecipeNameBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(294, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 92);
            this.label5.TabIndex = 12;
            this.label5.Text = "When adding ingredients, please be consistent with\r\nthe use of the property. Do n" +
    "ot under any circumstances\r\nuse the same ingredients but different properties ov" +
    "er \r\nmany recipes.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Location = new System.Drawing.Point(700, 93);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(112, 34);
            this.BackToMenuBtn.TabIndex = 13;
            this.BackToMenuBtn.Text = "Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(867, 414);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RecipeNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Property);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.IngredientName);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddedList);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Adder";
            this.Text = "Adder";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox AddedList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CreateBtn;
        private TextBox IngredientName;
        private NumericUpDown Amount;
        private ComboBox Property;
        private Button AddBtn;
        private Button RemoveBtn;
        private Label label4;
        private TextBox RecipeNameBox;
        private Label label5;
        private Button BackToMenuBtn;
    }
}