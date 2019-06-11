namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.comboBoxTeamMember = new System.Windows.Forms.ComboBox();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.groupBoxTeamMember = new System.Windows.Forms.GroupBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxCellphoneNumber = new System.Windows.Forms.TextBox();
            this.labelCellphoneNumber = new System.Windows.Forms.Label();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.buttonDeleteSelectedMember = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.groupBoxTeamMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(44, 131);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(485, 35);
            this.textBoxTeamName.TabIndex = 13;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamName.Location = new System.Drawing.Point(34, 91);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(157, 37);
            this.labelTeamName.TabIndex = 12;
            this.labelTeamName.Text = "Team Name";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(30, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(213, 50);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "Create Team";
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddMember.Location = new System.Drawing.Point(154, 288);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(248, 53);
            this.buttonAddMember.TabIndex = 19;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // comboBoxTeamMember
            // 
            this.comboBoxTeamMember.FormattingEnabled = true;
            this.comboBoxTeamMember.Location = new System.Drawing.Point(44, 233);
            this.comboBoxTeamMember.Name = "comboBoxTeamMember";
            this.comboBoxTeamMember.Size = new System.Drawing.Size(485, 38);
            this.comboBoxTeamMember.TabIndex = 18;
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSelectTeam.Location = new System.Drawing.Point(37, 193);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(263, 37);
            this.labelSelectTeam.TabIndex = 17;
            this.labelSelectTeam.Text = "Select Team Member";
            // 
            // groupBoxTeamMember
            // 
            this.groupBoxTeamMember.Controls.Add(this.buttonCreateMember);
            this.groupBoxTeamMember.Controls.Add(this.textBoxCellphoneNumber);
            this.groupBoxTeamMember.Controls.Add(this.labelCellphoneNumber);
            this.groupBoxTeamMember.Controls.Add(this.textBoxEmail);
            this.groupBoxTeamMember.Controls.Add(this.labelEmail);
            this.groupBoxTeamMember.Controls.Add(this.textBoxLastName);
            this.groupBoxTeamMember.Controls.Add(this.labelLastName);
            this.groupBoxTeamMember.Controls.Add(this.textBoxFirstName);
            this.groupBoxTeamMember.Controls.Add(this.labelFirstName);
            this.groupBoxTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBoxTeamMember.Location = new System.Drawing.Point(44, 376);
            this.groupBoxTeamMember.Name = "groupBoxTeamMember";
            this.groupBoxTeamMember.Size = new System.Drawing.Size(485, 326);
            this.groupBoxTeamMember.TabIndex = 20;
            this.groupBoxTeamMember.TabStop = false;
            this.groupBoxTeamMember.Text = "Add New Member";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(191, 47);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(267, 43);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelFirstName.Location = new System.Drawing.Point(23, 53);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(144, 37);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(190, 93);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(267, 43);
            this.textBoxLastName.TabIndex = 12;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelLastName.Location = new System.Drawing.Point(23, 99);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(142, 37);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(190, 139);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(267, 43);
            this.textBoxEmail.TabIndex = 14;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelEmail.Location = new System.Drawing.Point(23, 145);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(82, 37);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // textBoxCellphoneNumber
            // 
            this.textBoxCellphoneNumber.Location = new System.Drawing.Point(190, 185);
            this.textBoxCellphoneNumber.Name = "textBoxCellphoneNumber";
            this.textBoxCellphoneNumber.Size = new System.Drawing.Size(267, 43);
            this.textBoxCellphoneNumber.TabIndex = 16;
            // 
            // labelCellphoneNumber
            // 
            this.labelCellphoneNumber.AutoSize = true;
            this.labelCellphoneNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCellphoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelCellphoneNumber.Location = new System.Drawing.Point(23, 191);
            this.labelCellphoneNumber.Name = "labelCellphoneNumber";
            this.labelCellphoneNumber.Size = new System.Drawing.Size(161, 37);
            this.labelCellphoneNumber.TabIndex = 15;
            this.labelCellphoneNumber.Text = "Cellphone #";
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateMember.Location = new System.Drawing.Point(110, 250);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(248, 53);
            this.buttonCreateMember.TabIndex = 21;
            this.buttonCreateMember.Text = "Create Member";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 30;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(574, 131);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(296, 572);
            this.listBoxTeamMembers.TabIndex = 21;
            // 
            // buttonDeleteSelectedMember
            // 
            this.buttonDeleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDeleteSelectedMember.Location = new System.Drawing.Point(896, 342);
            this.buttonDeleteSelectedMember.Name = "buttonDeleteSelectedMember";
            this.buttonDeleteSelectedMember.Size = new System.Drawing.Size(153, 92);
            this.buttonDeleteSelectedMember.TabIndex = 22;
            this.buttonDeleteSelectedMember.Text = "Delete Selected";
            this.buttonDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTeam.Location = new System.Drawing.Point(362, 722);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(331, 62);
            this.buttonCreateTeam.TabIndex = 22;
            this.buttonCreateTeam.Text = "Create Team";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 806);
            this.Controls.Add(this.buttonCreateTeam);
            this.Controls.Add(this.buttonDeleteSelectedMember);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.groupBoxTeamMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.comboBoxTeamMember);
            this.Controls.Add(this.labelSelectTeam);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBoxTeamMember.ResumeLayout(false);
            this.groupBoxTeamMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.ComboBox comboBoxTeamMember;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.GroupBox groupBoxTeamMember;
        private System.Windows.Forms.Button buttonCreateMember;
        private System.Windows.Forms.TextBox textBoxCellphoneNumber;
        private System.Windows.Forms.Label labelCellphoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button buttonDeleteSelectedMember;
        private System.Windows.Forms.Button buttonCreateTeam;
    }
}