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
            this.gbMamalSpec = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumofTeeth = new System.Windows.Forms.TextBox();
            this.tbLengthOfTail = new System.Windows.Forms.TextBox();
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
            this.listAddAnimal = new System.Windows.Forms.ListBox();
            this.gbAnimalSpec.SuspendLayout();
            this.gbSpeciesSpec.SuspendLayout();
            this.gbMamalSpec.SuspendLayout();
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
            this.gbAnimalSpec.Controls.Add(this.gbMamalSpec);
            this.gbAnimalSpec.Controls.Add(this.listCategoryType);
            this.gbAnimalSpec.Controls.Add(this.gbGenderType);
            this.gbAnimalSpec.Controls.Add(this.tbName);
            this.gbAnimalSpec.Controls.Add(this.tbAge);
            this.gbAnimalSpec.Controls.Add(this.label6);
            this.gbAnimalSpec.Controls.Add(this.label5);
            this.gbAnimalSpec.ForeColor = System.Drawing.Color.Green;
            this.gbAnimalSpec.Location = new System.Drawing.Point(29, 10);
            this.gbAnimalSpec.Name = "gbAnimalSpec";
            this.gbAnimalSpec.Size = new System.Drawing.Size(1246, 343);
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(451, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "List aall species";
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
            this.gbSpeciesSpec.Text = "SpeciesSpec title";
            // 
            // lblSpeciesSpec
            // 
            this.lblSpeciesSpec.AutoSize = true;
            this.lblSpeciesSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpeciesSpec.Location = new System.Drawing.Point(10, 26);
            this.lblSpeciesSpec.Name = "lblSpeciesSpec";
            this.lblSpeciesSpec.Size = new System.Drawing.Size(60, 13);
            this.lblSpeciesSpec.TabIndex = 15;
            this.lblSpeciesSpec.Text = "SpecName";
            // 
            // tbSpeciesSpec
            // 
            this.tbSpeciesSpec.Location = new System.Drawing.Point(70, 26);
            this.tbSpeciesSpec.Name = "tbSpeciesSpec";
            this.tbSpeciesSpec.Size = new System.Drawing.Size(96, 20);
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
            // gbMamalSpec
            // 
            this.gbMamalSpec.Controls.Add(this.label8);
            this.gbMamalSpec.Controls.Add(this.label7);
            this.gbMamalSpec.Controls.Add(this.tbNumofTeeth);
            this.gbMamalSpec.Controls.Add(this.tbLengthOfTail);
            this.gbMamalSpec.Location = new System.Drawing.Point(8, 205);
            this.gbMamalSpec.Name = "gbMamalSpec";
            this.gbMamalSpec.Size = new System.Drawing.Size(172, 97);
            this.gbMamalSpec.TabIndex = 17;
            this.gbMamalSpec.TabStop = false;
            this.gbMamalSpec.Text = " Mammal Specifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Length of tail";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number of teeth";
            // 
            // tbNumofTeeth
            // 
            this.tbNumofTeeth.Location = new System.Drawing.Point(137, 19);
            this.tbNumofTeeth.Name = "tbNumofTeeth";
            this.tbNumofTeeth.Size = new System.Drawing.Size(35, 20);
            this.tbNumofTeeth.TabIndex = 3;
            // 
            // tbLengthOfTail
            // 
            this.tbLengthOfTail.Location = new System.Drawing.Point(137, 45);
            this.tbLengthOfTail.Name = "tbLengthOfTail";
            this.tbLengthOfTail.Size = new System.Drawing.Size(35, 20);
            this.tbLengthOfTail.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.listAddAnimal);
            this.groupBox2.Location = new System.Drawing.Point(29, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of registered animals";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID     Name          Age     GenderType     Special charactristics";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(671, 173);
            this.listBox1.TabIndex = 22;
            // 
            // listAddAnimal
            // 
            this.listAddAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.listAddAnimal.Enabled = false;
            this.listAddAnimal.FormattingEnabled = true;
            this.listAddAnimal.Location = new System.Drawing.Point(6, 37);
            this.listAddAnimal.Name = "listAddAnimal";
            this.listAddAnimal.Size = new System.Drawing.Size(172, 173);
            this.listAddAnimal.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 598);
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
            this.gbMamalSpec.ResumeLayout(false);
            this.gbMamalSpec.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbMamalSpec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumofTeeth;
        private System.Windows.Forms.TextBox tbLengthOfTail;
        private System.Windows.Forms.ListBox listCategoryType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listAddAnimal;
        private System.Windows.Forms.Label label1;
    }
}

