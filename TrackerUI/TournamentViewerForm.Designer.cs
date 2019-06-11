namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.comboBoxRound = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.labelTeamOneName = new System.Windows.Forms.Label();
            this.labelTeamOneScore = new System.Windows.Forms.Label();
            this.textBoxTeamOneScore = new System.Windows.Forms.TextBox();
            this.textBoxTeamTwoScore = new System.Windows.Forms.TextBox();
            this.labelTeamTwoScore = new System.Windows.Forms.Label();
            this.labelTeamTwoName = new System.Windows.Forms.Label();
            this.labelVs = new System.Windows.Forms.Label();
            this.buttonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelHeader.Location = new System.Drawing.Point(35, 36);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(214, 50);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Tournament:";
            // 
            // labelTournament
            // 
            this.labelTournament.AutoSize = true;
            this.labelTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournament.Location = new System.Drawing.Point(255, 36);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(150, 50);
            this.labelTournament.TabIndex = 1;
            this.labelTournament.Text = "<none>";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelRound.Location = new System.Drawing.Point(37, 126);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(94, 37);
            this.labelRound.TabIndex = 2;
            this.labelRound.Text = "Round";
            // 
            // comboBoxRound
            // 
            this.comboBoxRound.FormattingEnabled = true;
            this.comboBoxRound.Location = new System.Drawing.Point(148, 125);
            this.comboBoxRound.Name = "comboBoxRound";
            this.comboBoxRound.Size = new System.Drawing.Size(235, 38);
            this.comboBoxRound.TabIndex = 3;
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(148, 179);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(212, 41);
            this.checkBoxUnplayedOnly.TabIndex = 4;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 30;
            this.listBoxMatchup.Location = new System.Drawing.Point(44, 239);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(339, 332);
            this.listBoxMatchup.TabIndex = 5;
            // 
            // labelTeamOneName
            // 
            this.labelTeamOneName.AutoSize = true;
            this.labelTeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamOneName.Location = new System.Drawing.Point(442, 239);
            this.labelTeamOneName.Name = "labelTeamOneName";
            this.labelTeamOneName.Size = new System.Drawing.Size(165, 37);
            this.labelTeamOneName.TabIndex = 6;
            this.labelTeamOneName.Text = "<team one>";
            // 
            // labelTeamOneScore
            // 
            this.labelTeamOneScore.AutoSize = true;
            this.labelTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamOneScore.Location = new System.Drawing.Point(442, 286);
            this.labelTeamOneScore.Name = "labelTeamOneScore";
            this.labelTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.labelTeamOneScore.TabIndex = 7;
            this.labelTeamOneScore.Text = "Score";
            // 
            // textBoxTeamOneScore
            // 
            this.textBoxTeamOneScore.Location = new System.Drawing.Point(530, 289);
            this.textBoxTeamOneScore.Name = "textBoxTeamOneScore";
            this.textBoxTeamOneScore.Size = new System.Drawing.Size(226, 35);
            this.textBoxTeamOneScore.TabIndex = 8;
            // 
            // textBoxTeamTwoScore
            // 
            this.textBoxTeamTwoScore.Location = new System.Drawing.Point(530, 442);
            this.textBoxTeamTwoScore.Name = "textBoxTeamTwoScore";
            this.textBoxTeamTwoScore.Size = new System.Drawing.Size(226, 35);
            this.textBoxTeamTwoScore.TabIndex = 11;
            // 
            // labelTeamTwoScore
            // 
            this.labelTeamTwoScore.AutoSize = true;
            this.labelTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamTwoScore.Location = new System.Drawing.Point(442, 439);
            this.labelTeamTwoScore.Name = "labelTeamTwoScore";
            this.labelTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.labelTeamTwoScore.TabIndex = 10;
            this.labelTeamTwoScore.Text = "Score";
            // 
            // labelTeamTwoName
            // 
            this.labelTeamTwoName.AutoSize = true;
            this.labelTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamTwoName.Location = new System.Drawing.Point(442, 392);
            this.labelTeamTwoName.Name = "labelTeamTwoName";
            this.labelTeamTwoName.Size = new System.Drawing.Size(165, 37);
            this.labelTeamTwoName.TabIndex = 9;
            this.labelTeamTwoName.Text = "<team two>";
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelVs.Location = new System.Drawing.Point(579, 345);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(84, 37);
            this.labelVs.TabIndex = 12;
            this.labelVs.Text = "- VS -";
            // 
            // buttonScore
            // 
            this.buttonScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonScore.Location = new System.Drawing.Point(773, 345);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(131, 53);
            this.buttonScore.TabIndex = 13;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 606);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.textBoxTeamTwoScore);
            this.Controls.Add(this.labelTeamTwoScore);
            this.Controls.Add(this.labelTeamTwoName);
            this.Controls.Add(this.textBoxTeamOneScore);
            this.Controls.Add(this.labelTeamOneScore);
            this.Controls.Add(this.labelTeamOneName);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.checkBoxUnplayedOnly);
            this.Controls.Add(this.comboBoxRound);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelTournament);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox comboBoxRound;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTeamOneName;
        private System.Windows.Forms.Label labelTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamTwoScore;
        private System.Windows.Forms.Label labelTeamTwoScore;
        private System.Windows.Forms.Label labelTeamTwoName;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.Button buttonScore;
    }
}

