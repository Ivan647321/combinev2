namespace Assignment_1
{
    partial class frmCompetition
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompetition = new System.Windows.Forms.DataGridView();
            this.competitionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new Assignment_1.Database1DataSet4();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Assignment_1.Database1DataSet();
            this.competitionTableAdapter = new Assignment_1.Database1DataSet4TableAdapters.CompetitionTableAdapter();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblShowWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblShowLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetition
            // 
            this.dgvCompetition.AllowUserToAddRows = false;
            this.dgvCompetition.AllowUserToDeleteRows = false;
            this.dgvCompetition.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competitionNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dgvCompetition.DataSource = this.competitionBindingSource;
            this.dgvCompetition.Location = new System.Drawing.Point(71, 99);
            this.dgvCompetition.Name = "dgvCompetition";
            this.dgvCompetition.ReadOnly = true;
            this.dgvCompetition.RowHeadersWidth = 51;
            this.dgvCompetition.RowTemplate.Height = 24;
            this.dgvCompetition.Size = new System.Drawing.Size(608, 264);
            this.dgvCompetition.TabIndex = 13;
            // 
            // competitionNameDataGridViewTextBoxColumn
            // 
            this.competitionNameDataGridViewTextBoxColumn.DataPropertyName = "competitionName";
            this.competitionNameDataGridViewTextBoxColumn.HeaderText = "Competition Name";
            this.competitionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.competitionNameDataGridViewTextBoxColumn.Name = "competitionNameDataGridViewTextBoxColumn";
            this.competitionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.competitionNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetition.Location = new System.Drawing.Point(278, 41);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(201, 38);
            this.lblCompetition.TabIndex = 14;
            this.lblCompetition.Text = "Competition";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(103, 414);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(112, 25);
            this.lblWin.TabIndex = 16;
            this.lblWin.Text = "Total Win:";
            // 
            // lblShowWin
            // 
            this.lblShowWin.AutoSize = true;
            this.lblShowWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWin.Location = new System.Drawing.Point(221, 414);
            this.lblShowWin.Name = "lblShowWin";
            this.lblShowWin.Size = new System.Drawing.Size(64, 25);
            this.lblShowWin.TabIndex = 17;
            this.lblShowWin.Text = "label2";
            this.lblShowWin.Click += new System.EventHandler(this.lblShowWin_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(427, 414);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(121, 25);
            this.lblLose.TabIndex = 18;
            this.lblLose.Text = "Total Lose:";
            // 
            // lblShowLose
            // 
            this.lblShowLose.AutoSize = true;
            this.lblShowLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLose.Location = new System.Drawing.Point(554, 414);
            this.lblShowLose.Name = "lblShowLose";
            this.lblShowLose.Size = new System.Drawing.Size(64, 25);
            this.lblShowLose.TabIndex = 19;
            this.lblShowLose.Text = "label4";
            // 
            // frmCompetition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.lblShowLose);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblShowWin);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblCompetition);
            this.Controls.Add(this.dgvCompetition);
            this.Name = "frmCompetition";
            this.Text = "frmCompetition";
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompetition;
        private System.Windows.Forms.Label lblCompetition;
        private Database1DataSet database1DataSet1;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private Database1DataSet4TableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblShowWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblShowLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}