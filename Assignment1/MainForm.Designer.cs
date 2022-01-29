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
            this.gbGenderType = new System.Windows.Forms.GroupBox();
            this.textbName = new System.Windows.Forms.TextBox();
            this.textbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbInviteGuest = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblTotalCosts = new System.Windows.Forms.Label();
            this.lblSurplus = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.gbAnimalSpec.SuspendLayout();
            this.gbGenderType.SuspendLayout();
            this.gbInviteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnimalSpec
            // 
            this.gbAnimalSpec.Controls.Add(this.gbGenderType);
            this.gbAnimalSpec.Controls.Add(this.textbName);
            this.gbAnimalSpec.Controls.Add(this.textbAge);
            this.gbAnimalSpec.Controls.Add(this.label6);
            this.gbAnimalSpec.Controls.Add(this.label5);
            this.gbAnimalSpec.ForeColor = System.Drawing.Color.Green;
            this.gbAnimalSpec.Location = new System.Drawing.Point(29, 10);
            this.gbAnimalSpec.Name = "gbAnimalSpec";
            this.gbAnimalSpec.Size = new System.Drawing.Size(645, 197);
            this.gbAnimalSpec.TabIndex = 0;
            this.gbAnimalSpec.TabStop = false;
            this.gbAnimalSpec.Text = "Animal Specifications";
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
            // textbName
            // 
            this.textbName.Location = new System.Drawing.Point(46, 21);
            this.textbName.Name = "textbName";
            this.textbName.Size = new System.Drawing.Size(134, 20);
            this.textbName.TabIndex = 1;
            this.textbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaxNumOfGuests_Validating);
            // 
            // textbAge
            // 
            this.textbAge.Location = new System.Drawing.Point(46, 51);
            this.textbAge.Name = "textbAge";
            this.textbAge.Size = new System.Drawing.Size(134, 20);
            this.textbAge.TabIndex = 2;
            this.textbAge.Validating += new System.ComponentModel.CancelEventHandler(this.tbCostPerPerson_Validating);
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
            // gbInviteGuest
            // 
            this.gbInviteGuest.Controls.Add(this.btnAdd);
            this.gbInviteGuest.Controls.Add(this.tbFirstName);
            this.gbInviteGuest.Controls.Add(this.tbLastName);
            this.gbInviteGuest.Controls.Add(this.label9);
            this.gbInviteGuest.Controls.Add(this.label8);
            this.gbInviteGuest.Location = new System.Drawing.Point(21, 248);
            this.gbInviteGuest.Name = "gbInviteGuest";
            this.gbInviteGuest.Size = new System.Drawing.Size(185, 124);
            this.gbInviteGuest.TabIndex = 1;
            this.gbInviteGuest.TabStop = false;
            this.gbInviteGuest.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(55, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(75, 29);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(106, 20);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(75, 58);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(106, 20);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "First Name";
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(377, 359);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(83, 27);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(501, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surplus/Deficit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Costs";
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfGuests.Enabled = false;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(158, 393);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(51, 15);
            this.lblNumberOfGuests.TabIndex = 14;
            this.lblNumberOfGuests.Text = "0000000";
            this.lblNumberOfGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCosts
            // 
            this.lblTotalCosts.AutoSize = true;
            this.lblTotalCosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCosts.Enabled = false;
            this.lblTotalCosts.Location = new System.Drawing.Point(158, 430);
            this.lblTotalCosts.Name = "lblTotalCosts";
            this.lblTotalCosts.Size = new System.Drawing.Size(51, 15);
            this.lblTotalCosts.TabIndex = 15;
            this.lblTotalCosts.Text = "0000000";
            this.lblTotalCosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSurplus
            // 
            this.lblSurplus.AutoSize = true;
            this.lblSurplus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplus.Enabled = false;
            this.lblSurplus.Location = new System.Drawing.Point(158, 498);
            this.lblSurplus.Name = "lblSurplus";
            this.lblSurplus.Size = new System.Drawing.Size(51, 15);
            this.lblSurplus.TabIndex = 16;
            this.lblSurplus.Text = "0000000";
            this.lblSurplus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Enabled = false;
            this.lblTotalFees.Location = new System.Drawing.Point(158, 464);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(51, 15);
            this.lblTotalFees.TabIndex = 17;
            this.lblTotalFees.Text = "0000000";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.Location = new System.Drawing.Point(21, 19);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(146, 56);
            this.lbGender.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 609);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblSurplus);
            this.Controls.Add(this.lblTotalCosts);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gbInviteGuest);
            this.Controls.Add(this.gbAnimalSpec);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Party Organizer by Alireza Davoudian";
            this.gbAnimalSpec.ResumeLayout(false);
            this.gbAnimalSpec.PerformLayout();
            this.gbGenderType.ResumeLayout(false);
            this.gbInviteGuest.ResumeLayout(false);
            this.gbInviteGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnimalSpec;
        private System.Windows.Forms.TextBox textbName;
        private System.Windows.Forms.TextBox textbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbInviteGuest;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblTotalCosts;
        private System.Windows.Forms.Label lblSurplus;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.GroupBox gbGenderType;
        private System.Windows.Forms.ListBox lbGender;
    }
}

