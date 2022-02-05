namespace Assignment1
{
    partial class MainForm
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
            this.gbAnimalSpec = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listSpecies = new System.Windows.Forms.ListBox();
            this.gbSpeciesSpec = new System.Windows.Forms.GroupBox();
            this.lblSpeciesSpec = new System.Windows.Forms.Label();
            this.tbSpeciesSpec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAnimalCatSpec = new System.Windows.Forms.GroupBox();
            this.lblAnimalSpec2 = new System.Windows.Forms.Label();
            this.lblAnimalSpec = new System.Windows.Forms.Label();
            this.tbAnimalSpec1 = new System.Windows.Forms.TextBox();
            this.tbAnimalSpec2 = new System.Windows.Forms.TextBox();
            this.listCategoryType = new System.Windows.Forms.ListBox();
            this.gbGenderType = new System.Windows.Forms.GroupBox();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rtbAddAnimal = new System.Windows.Forms.RichTextBox();
            this.gbAnimalSpec.SuspendLayout();
            this.gbSpeciesSpec.SuspendLayout();
            this.gbAnimalCatSpec.SuspendLayout();
            this.gbGenderType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnimalSpec
            // 
            this.gbAnimalSpec.Controls.Add(this.btnAddAnimal);
            this.gbAnimalSpec.Controls.Add(this.checkBox1);
            this.gbAnimalSpec.Controls.Add(this.label10);
            this.gbAnimalSpec.Controls.Add(this.listSpecies);
            this.gbAnimalSpec.Controls.Add(this.gbSpeciesSpec);
            this.gbAnimalSpec.Controls.Add(this.label9);
            this.gbAnimalSpec.Controls.Add(this.gbAnimalCatSpec);
            this.gbAnimalSpec.Controls.Add(this.listCategoryType);
            this.gbAnimalSpec.Controls.Add(this.gbGenderType);
            this.gbAnimalSpec.Controls.Add(this.tbName);
            this.gbAnimalSpec.Controls.Add(this.tbAge);
            this.gbAnimalSpec.Controls.Add(this.label6);
            this.gbAnimalSpec.Controls.Add(this.label5);
            this.gbAnimalSpec.ForeColor = System.Drawing.Color.Green;
            this.gbAnimalSpec.Location = new System.Drawing.Point(29, 10);
            this.gbAnimalSpec.Name = "gbAnimalSpec";
            this.gbAnimalSpec.Size = new System.Drawing.Size(827, 343);
            this.gbAnimalSpec.TabIndex = 0;
            this.gbAnimalSpec.TabStop = false;
            this.gbAnimalSpec.Text = "Animal Specifications";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.ForeColor = System.Drawing.Color.Black;
            this.btnAddAnimal.Location = new System.Drawing.Point(450, 251);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(168, 37);
            this.btnAddAnimal.TabIndex = 23;
            this.btnAddAnimal.Text = "Add this animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(451, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "List all species";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(508, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Species";
            // 
            // listSpecies
            // 
            this.listSpecies.FormattingEnabled = true;
            this.listSpecies.Location = new System.Drawing.Point(447, 35);
            this.listSpecies.Name = "listSpecies";
            this.listSpecies.Size = new System.Drawing.Size(172, 147);
            this.listSpecies.TabIndex = 20;
            this.listSpecies.SelectedIndexChanged += new System.EventHandler(this.listSpecies_SelectedIndexChanged);
            // 
            // gbSpeciesSpec
            // 
            this.gbSpeciesSpec.Controls.Add(this.lblSpeciesSpec);
            this.gbSpeciesSpec.Controls.Add(this.tbSpeciesSpec);
            this.gbSpeciesSpec.Location = new System.Drawing.Point(240, 205);
            this.gbSpeciesSpec.Name = "gbSpeciesSpec";
            this.gbSpeciesSpec.Size = new System.Drawing.Size(172, 97);
            this.gbSpeciesSpec.TabIndex = 19;
            this.gbSpeciesSpec.TabStop = false;
            // 
            // lblSpeciesSpec
            // 
            this.lblSpeciesSpec.AutoSize = true;
            this.lblSpeciesSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpeciesSpec.Location = new System.Drawing.Point(10, 26);
            this.lblSpeciesSpec.Name = "lblSpeciesSpec";
            this.lblSpeciesSpec.Size = new System.Drawing.Size(0, 13);
            this.lblSpeciesSpec.TabIndex = 15;
            // 
            // tbSpeciesSpec
            // 
            this.tbSpeciesSpec.Location = new System.Drawing.Point(99, 26);
            this.tbSpeciesSpec.Name = "tbSpeciesSpec";
            this.tbSpeciesSpec.Size = new System.Drawing.Size(67, 20);
            this.tbSpeciesSpec.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(279, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Category Type";
            // 
            // gbAnimalCatSpec
            // 
            this.gbAnimalCatSpec.Controls.Add(this.lblAnimalSpec2);
            this.gbAnimalCatSpec.Controls.Add(this.lblAnimalSpec);
            this.gbAnimalCatSpec.Controls.Add(this.tbAnimalSpec1);
            this.gbAnimalCatSpec.Controls.Add(this.tbAnimalSpec2);
            this.gbAnimalCatSpec.Location = new System.Drawing.Point(8, 205);
            this.gbAnimalCatSpec.Name = "gbAnimalCatSpec";
            this.gbAnimalCatSpec.Size = new System.Drawing.Size(172, 97);
            this.gbAnimalCatSpec.TabIndex = 17;
            this.gbAnimalCatSpec.TabStop = false;
            // 
            // lblAnimalSpec2
            // 
            this.lblAnimalSpec2.AutoSize = true;
            this.lblAnimalSpec2.ForeColor = System.Drawing.Color.Black;
            this.lblAnimalSpec2.Location = new System.Drawing.Point(10, 48);
            this.lblAnimalSpec2.Name = "lblAnimalSpec2";
            this.lblAnimalSpec2.Size = new System.Drawing.Size(0, 13);
            this.lblAnimalSpec2.TabIndex = 16;
            this.lblAnimalSpec2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnimalSpec
            // 
            this.lblAnimalSpec.AutoSize = true;
            this.lblAnimalSpec.ForeColor = System.Drawing.Color.Black;
            this.lblAnimalSpec.Location = new System.Drawing.Point(10, 26);
            this.lblAnimalSpec.Name = "lblAnimalSpec";
            this.lblAnimalSpec.Size = new System.Drawing.Size(0, 13);
            this.lblAnimalSpec.TabIndex = 15;
            // 
            // tbAnimalSpec1
            // 
            this.tbAnimalSpec1.Location = new System.Drawing.Point(137, 19);
            this.tbAnimalSpec1.Name = "tbAnimalSpec1";
            this.tbAnimalSpec1.Size = new System.Drawing.Size(35, 20);
            this.tbAnimalSpec1.TabIndex = 3;
            // 
            // tbAnimalSpec2
            // 
            this.tbAnimalSpec2.Location = new System.Drawing.Point(137, 45);
            this.tbAnimalSpec2.Name = "tbAnimalSpec2";
            this.tbAnimalSpec2.Size = new System.Drawing.Size(35, 20);
            this.tbAnimalSpec2.TabIndex = 2;
            // 
            // listCategoryType
            // 
            this.listCategoryType.FormattingEnabled = true;
            this.listCategoryType.Location = new System.Drawing.Point(240, 35);
            this.listCategoryType.Name = "listCategoryType";
            this.listCategoryType.Size = new System.Drawing.Size(172, 147);
            this.listCategoryType.TabIndex = 16;
            this.listCategoryType.SelectedIndexChanged += new System.EventHandler(this.listCategoryType_SelectedIndexChanged);
            // 
            // gbGenderType
            // 
            this.gbGenderType.Controls.Add(this.lbGender);
            this.gbGenderType.Location = new System.Drawing.Point(6, 86);
            this.gbGenderType.Name = "gbGenderType";
            this.gbGenderType.Size = new System.Drawing.Size(174, 93);
            this.gbGenderType.TabIndex = 15;
            this.gbGenderType.TabStop = false;
            this.gbGenderType.Text = "GenderType";
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.Location = new System.Drawing.Point(21, 19);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(146, 56);
            this.lbGender.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(46, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(134, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaxNumOfGuests_Validating);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(145, 51);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(35, 20);
            this.tbAge.TabIndex = 2;
            this.tbAge.Validating += new System.ComponentModel.CancelEventHandler(this.tbCostPerPerson_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbAddAnimal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(29, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of registered animals";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(336, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID     Name          Age     GenderType     Special charactristics";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(311, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 173);
            this.listBox1.TabIndex = 22;
            // 
            // rtbAddAnimal
            // 
            this.rtbAddAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.rtbAddAnimal.Enabled = false;
            this.rtbAddAnimal.Location = new System.Drawing.Point(8, 37);
            this.rtbAddAnimal.Name = "rtbAddAnimal";
            this.rtbAddAnimal.Size = new System.Drawing.Size(284, 173);
            this.rtbAddAnimal.TabIndex = 24;
            this.rtbAddAnimal.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAnimalSpec);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Apu Animal park - by Alireza Davoudian";
            this.gbAnimalSpec.ResumeLayout(false);
            this.gbAnimalSpec.PerformLayout();
            this.gbSpeciesSpec.ResumeLayout(false);
            this.gbSpeciesSpec.PerformLayout();
            this.gbAnimalCatSpec.ResumeLayout(false);
            this.gbAnimalCatSpec.PerformLayout();
            this.gbGenderType.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnimalSpec;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbGenderType;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listSpecies;
        private System.Windows.Forms.GroupBox gbSpeciesSpec;
        private System.Windows.Forms.Label lblSpeciesSpec;
        private System.Windows.Forms.TextBox tbSpeciesSpec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbAnimalCatSpec;
        private System.Windows.Forms.Label lblAnimalSpec2;
        private System.Windows.Forms.Label lblAnimalSpec;
        private System.Windows.Forms.TextBox tbAnimalSpec1;
        private System.Windows.Forms.TextBox tbAnimalSpec2;
        private System.Windows.Forms.ListBox listCategoryType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAddAnimal;
        private System.Windows.Forms.ListBox listBox1;
    }
}

