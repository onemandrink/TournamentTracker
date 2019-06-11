namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.textBoxEntryFee = new System.Windows.Forms.TextBox();
            this.labelEntryFee = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.linkLabelNewTeam = new System.Windows.Forms.LinkLabel();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreatePrize = new System.Windows.Forms.Button();
            this.listBoxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.labelTournamentPlayers = new System.Windows.Forms.Label();
            this.buttonDeleteSelectedTeam = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.labelPrizes = new System.Windows.Forms.Label();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(35, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(317, 50);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Create Tournament";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Location = new System.Drawing.Point(49, 153);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(334, 35);
            this.textBoxTournamentName.TabIndex = 10;
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentName.Location = new System.Drawing.Point(39, 113);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(236, 37);
            this.labelTournamentName.TabIndex = 9;
            this.labelTournamentName.Text = "Tournament Name";
            // 
            // textBoxEntryFee
            // 
            this.textBoxEntryFee.Location = new System.Drawing.Point(174, 208);
            this.textBoxEntryFee.Name = "textBoxEntryFee";
            this.textBoxEntryFee.Size = new System.Drawing.Size(114, 35);
            this.textBoxEntryFee.TabIndex = 12;
            this.textBoxEntryFee.Text = "0";
            // 
            // labelEntryFee
            // 
            this.labelEntryFee.AutoSize = true;
            this.labelEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelEntryFee.Location = new System.Drawing.Point(39, 206);
            this.labelEntryFee.Name = "labelEntryFee";
            this.labelEntryFee.Size = new System.Drawing.Size(125, 37);
            this.labelEntryFee.TabIndex = 11;
            this.labelEntryFee.Text = "Entry Fee";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(49, 321);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(334, 38);
            this.comboBoxTeam.TabIndex = 14;
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSelectTeam.Location = new System.Drawing.Point(42, 281);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.labelSelectTeam.TabIndex = 13;
            this.labelSelectTeam.Text = "Select Team";
            // 
            // linkLabelNewTeam
            // 
            this.linkLabelNewTeam.AutoSize = true;
            this.linkLabelNewTeam.Location = new System.Drawing.Point(262, 287);
            this.linkLabelNewTeam.Name = "linkLabelNewTeam";
            this.linkLabelNewTeam.Size = new System.Drawing.Size(121, 30);
            this.linkLabelNewTeam.TabIndex = 15;
            this.linkLabelNewTeam.TabStop = true;
            this.linkLabelNewTeam.Text = "Create New";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddTeam.Location = new System.Drawing.Point(92, 382);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(248, 53);
            this.buttonAddTeam.TabIndex = 16;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            // 
            // buttonCreatePrize
            // 
            this.buttonCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreatePrize.Location = new System.Drawing.Point(92, 455);
            this.buttonCreatePrize.Name = "buttonCreatePrize";
            this.buttonCreatePrize.Size = new System.Drawing.Size(248, 53);
            this.buttonCreatePrize.TabIndex = 17;
            this.buttonCreatePrize.Text = "Create Prize";
            this.buttonCreatePrize.UseVisualStyleBackColor = true;
            // 
            // listBoxTournamentPlayers
            // 
            this.listBoxTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTournamentPlayers.FormattingEnabled = true;
            this.listBoxTournamentPlayers.ItemHeight = 30;
            this.listBoxTournamentPlayers.Location = new System.Drawing.Point(453, 153);
            this.listBoxTournamentPlayers.Name = "listBoxTournamentPlayers";
            this.listBoxTournamentPlayers.Size = new System.Drawing.Size(339, 152);
            this.listBoxTournamentPlayers.TabIndex = 18;
            // 
            // labelTournamentPlayers
            // 
            this.labelTournamentPlayers.AutoSize = true;
            this.labelTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentPlayers.Location = new System.Drawing.Point(446, 113);
            this.labelTournamentPlayers.Name = "labelTournamentPlayers";
            this.labelTournamentPlayers.Size = new System.Drawing.Size(187, 37);
            this.labelTournamentPlayers.TabIndex = 19;
            this.labelTournamentPlayers.Text = "Team / Players";
            // 
            // buttonDeleteSelectedTeam
            // 
            this.buttonDeleteSelectedTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDeleteSelectedTeam.Location = new System.Drawing.Point(826, 185);
            this.buttonDeleteSelectedTeam.Name = "buttonDeleteSelectedTeam";
            this.buttonDeleteSelectedTeam.Size = new System.Drawing.Size(153, 92);
            this.buttonDeleteSelectedTeam.TabIndex = 20;
            this.buttonDeleteSelectedTeam.Text = "Delete Selected";
            this.buttonDeleteSelectedTeam.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelectedPrize
            // 
            this.buttonDeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDeleteSelectedPrize.Location = new System.Drawing.Point(826, 384);
            this.buttonDeleteSelectedPrize.Name = "buttonDeleteSelectedPrize";
            this.buttonDeleteSelectedPrize.Size = new System.Drawing.Size(153, 92);
            this.buttonDeleteSelectedPrize.TabIndex = 23;
            this.buttonDeleteSelectedPrize.Text = "Delete Selected";
            this.buttonDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // labelPrizes
            // 
            this.labelPrizes.AutoSize = true;
            this.labelPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelPrizes.Location = new System.Drawing.Point(446, 318);
            this.labelPrizes.Name = "labelPrizes";
            this.labelPrizes.Size = new System.Drawing.Size(85, 37);
            this.labelPrizes.TabIndex = 22;
            this.labelPrizes.Text = "Prizes";
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 30;
            this.listBoxPrizes.Location = new System.Drawing.Point(453, 358);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(339, 152);
            this.listBoxPrizes.TabIndex = 21;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTournament.Location = new System.Drawing.Point(267, 546);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(406, 67);
            this.buttonCreateTournament.TabIndex = 24;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 654);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.buttonDeleteSelectedPrize);
            this.Controls.Add(this.labelPrizes);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.buttonDeleteSelectedTeam);
            this.Controls.Add(this.labelTournamentPlayers);
            this.Controls.Add(this.listBoxTournamentPlayers);
            this.Controls.Add(this.buttonCreatePrize);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.linkLabelNewTeam);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.labelSelectTeam);
            this.Controls.Add(this.textBoxEntryFee);
            this.Controls.Add(this.labelEntryFee);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.TextBox textBoxEntryFee;
        private System.Windows.Forms.Label labelEntryFee;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.LinkLabel linkLabelNewTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreatePrize;
        private System.Windows.Forms.ListBox listBoxTournamentPlayers;
        private System.Windows.Forms.Label labelTournamentPlayers;
        private System.Windows.Forms.Button buttonDeleteSelectedTeam;
        private System.Windows.Forms.Button buttonDeleteSelectedPrize;
        private System.Windows.Forms.Label labelPrizes;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Button buttonCreateTournament;
    }
}