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
            this.gbNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.tbFeePerPerson = new System.Windows.Forms.TextBox();
            this.tbMaxNumOfGuests = new System.Windows.Forms.TextBox();
            this.tbCostPerPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbInviteGuest = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstAllGuests = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblTotalCosts = new System.Windows.Forms.Label();
            this.lblSurplus = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.gbNewParty.SuspendLayout();
            this.gbInviteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewParty
            // 
            this.gbNewParty.Controls.Add(this.btnCreateList);
            this.gbNewParty.Controls.Add(this.tbFeePerPerson);
            this.gbNewParty.Controls.Add(this.tbMaxNumOfGuests);
            this.gbNewParty.Controls.Add(this.tbCostPerPerson);
            this.gbNewParty.Controls.Add(this.label7);
            this.gbNewParty.Controls.Add(this.label6);
            this.gbNewParty.Controls.Add(this.label5);
            this.gbNewParty.ForeColor = System.Drawing.Color.Green;
            this.gbNewParty.Location = new System.Drawing.Point(34, 12);
            this.gbNewParty.Name = "gbNewParty";
            this.gbNewParty.Size = new System.Drawing.Size(216, 180);
            this.gbNewParty.TabIndex = 0;
            this.gbNewParty.TabStop = false;
            this.gbNewParty.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.ForeColor = System.Drawing.Color.Green;
            this.btnCreateList.Location = new System.Drawing.Point(64, 133);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(82, 28);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // tbFeePerPerson
            // 
            this.tbFeePerPerson.Location = new System.Drawing.Point(160, 91);
            this.tbFeePerPerson.Name = "tbFeePerPerson";
            this.tbFeePerPerson.Size = new System.Drawing.Size(50, 23);
            this.tbFeePerPerson.TabIndex = 3;
            this.tbFeePerPerson.Validating += new System.ComponentModel.CancelEventHandler(this.tbFeePerPerson_Validating);
            // 
            // tbMaxNumOfGuests
            // 
            this.tbMaxNumOfGuests.Location = new System.Drawing.Point(160, 24);
            this.tbMaxNumOfGuests.Name = "tbMaxNumOfGuests";
            this.tbMaxNumOfGuests.Size = new System.Drawing.Size(50, 23);
            this.tbMaxNumOfGuests.TabIndex = 1;
            this.tbMaxNumOfGuests.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaxNumOfGuests_Validating);
            // 
            // tbCostPerPerson
            // 
            this.tbCostPerPerson.Location = new System.Drawing.Point(160, 59);
            this.tbCostPerPerson.Name = "tbCostPerPerson";
            this.tbCostPerPerson.Size = new System.Drawing.Size(50, 23);
            this.tbCostPerPerson.TabIndex = 2;
            this.tbCostPerPerson.Validating += new System.ComponentModel.CancelEventHandler(this.tbCostPerPerson_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fee per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cost per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max number of guests";
            // 
            // gbInviteGuest
            // 
            this.gbInviteGuest.Controls.Add(this.btnAdd);
            this.gbInviteGuest.Controls.Add(this.tbFirstName);
            this.gbInviteGuest.Controls.Add(this.tbLastName);
            this.gbInviteGuest.Controls.Add(this.label9);
            this.gbInviteGuest.Controls.Add(this.label8);
            this.gbInviteGuest.Location = new System.Drawing.Point(34, 198);
            this.gbInviteGuest.Name = "gbInviteGuest";
            this.gbInviteGuest.Size = new System.Drawing.Size(216, 143);
            this.gbInviteGuest.TabIndex = 1;
            this.gbInviteGuest.TabStop = false;
            this.gbInviteGuest.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(64, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(87, 33);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(123, 23);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(87, 67);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(123, 23);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "First Name";
            // 
            // lstAllGuests
            // 
            this.lstAllGuests.FormattingEnabled = true;
            this.lstAllGuests.ItemHeight = 15;
            this.lstAllGuests.Location = new System.Drawing.Point(423, 40);
            this.lstAllGuests.Name = "lstAllGuests";
            this.lstAllGuests.Size = new System.Drawing.Size(280, 334);
            this.lstAllGuests.TabIndex = 2;
            this.lstAllGuests.Enter += new System.EventHandler(this.lstAllGuests_Enter);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(440, 414);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(97, 31);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(585, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surplus/Deficit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Costs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(528, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Guest List";
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfGuests.Enabled = false;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(194, 366);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(51, 17);
            this.lblNumberOfGuests.TabIndex = 14;
            this.lblNumberOfGuests.Text = "0000000";
            this.lblNumberOfGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCosts
            // 
            this.lblTotalCosts.AutoSize = true;
            this.lblTotalCosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCosts.Enabled = false;
            this.lblTotalCosts.Location = new System.Drawing.Point(194, 408);
            this.lblTotalCosts.Name = "lblTotalCosts";
            this.lblTotalCosts.Size = new System.Drawing.Size(51, 17);
            this.lblTotalCosts.TabIndex = 15;
            this.lblTotalCosts.Text = "0000000";
            this.lblTotalCosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSurplus
            // 
            this.lblSurplus.AutoSize = true;
            this.lblSurplus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplus.Enabled = false;
            this.lblSurplus.Location = new System.Drawing.Point(194, 487);
            this.lblSurplus.Name = "lblSurplus";
            this.lblSurplus.Size = new System.Drawing.Size(51, 17);
            this.lblSurplus.TabIndex = 16;
            this.lblSurplus.Text = "0000000";
            this.lblSurplus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Enabled = false;
            this.lblTotalFees.Location = new System.Drawing.Point(194, 448);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(51, 17);
            this.lblTotalFees.TabIndex = 17;
            this.lblTotalFees.Text = "0000000";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblSurplus);
            this.Controls.Add(this.lblTotalCosts);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lstAllGuests);
            this.Controls.Add(this.gbInviteGuest);
            this.Controls.Add(this.gbNewParty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Party Organizer by Alireza Davoudian";
            this.gbNewParty.ResumeLayout(false);
            this.gbNewParty.PerformLayout();
            this.gbInviteGuest.ResumeLayout(false);
            this.gbInviteGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewParty;
        private System.Windows.Forms.TextBox tbFeePerPerson;
        private System.Windows.Forms.TextBox tbMaxNumOfGuests;
        private System.Windows.Forms.TextBox tbCostPerPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbInviteGuest;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstAllGuests;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblTotalCosts;
        private System.Windows.Forms.Label lblSurplus;
        private System.Windows.Forms.Label lblTotalFees;
    }
}

