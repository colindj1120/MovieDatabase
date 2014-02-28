namespace MovieDatabase.Database
{
    partial class CreateDatabase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.movieDatabase = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Runtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.sortOrderLabel = new System.Windows.Forms.Label();
            this.multiSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // movieDatabase
            // 
            this.movieDatabase.AllowUserToAddRows = false;
            this.movieDatabase.AllowUserToDeleteRows = false;
            this.movieDatabase.AllowUserToResizeRows = false;
            this.movieDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.movieDatabase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.movieDatabase.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.movieDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Runtime,
            this.ReleaseDate,
            this.Gross,
            this.Genre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movieDatabase.DefaultCellStyle = dataGridViewCellStyle8;
            this.movieDatabase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.movieDatabase.EnableHeadersVisualStyles = false;
            this.movieDatabase.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieDatabase.Location = new System.Drawing.Point(12, 12);
            this.movieDatabase.MultiSelect = false;
            this.movieDatabase.Name = "movieDatabase";
            this.movieDatabase.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.movieDatabase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.movieDatabase.RowTemplate.Height = 30;
            this.movieDatabase.RowTemplate.ReadOnly = true;
            this.movieDatabase.Size = new System.Drawing.Size(583, 620);
            this.movieDatabase.TabIndex = 1;
            this.movieDatabase.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.movieDatabase_ColumnWidthChanged);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 75;
            // 
            // Runtime
            // 
            this.Runtime.HeaderText = "Runtime";
            this.Runtime.Name = "Runtime";
            this.Runtime.ReadOnly = true;
            this.Runtime.Width = 106;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 137;
            // 
            // Gross
            // 
            this.Gross.HeaderText = "Gross";
            this.Gross.Name = "Gross";
            this.Gross.ReadOnly = true;
            this.Gross.Width = 80;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre(s)";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genre.Visible = false;
            this.Genre.Width = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(859, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortComboBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Title",
            "Runtime",
            "Release Date",
            "Gross",
            "Genre"});
            this.sortComboBox.Location = new System.Drawing.Point(863, 37);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(214, 30);
            this.sortComboBox.TabIndex = 3;
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortOrderComboBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrderComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(863, 116);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(214, 30);
            this.sortOrderComboBox.TabIndex = 5;
            // 
            // sortOrderLabel
            // 
            this.sortOrderLabel.AutoSize = true;
            this.sortOrderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortOrderLabel.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sortOrderLabel.Location = new System.Drawing.Point(859, 91);
            this.sortOrderLabel.Name = "sortOrderLabel";
            this.sortOrderLabel.Size = new System.Drawing.Size(101, 22);
            this.sortOrderLabel.TabIndex = 4;
            this.sortOrderLabel.Text = "Sort Order:";
            // 
            // multiSortButton
            // 
            this.multiSortButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiSortButton.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiSortButton.ForeColor = System.Drawing.SystemColors.Control;
            this.multiSortButton.Location = new System.Drawing.Point(863, 177);
            this.multiSortButton.Name = "multiSortButton";
            this.multiSortButton.Size = new System.Drawing.Size(214, 33);
            this.multiSortButton.TabIndex = 6;
            this.multiSortButton.Text = "Multi-Field Sort";
            this.multiSortButton.UseVisualStyleBackColor = false;
            // 
            // CreateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1089, 644);
            this.Controls.Add(this.multiSortButton);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.sortOrderLabel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieDatabase);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateDatabase";
            this.Text = "Movies Database";
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movieDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Runtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.Label sortOrderLabel;
        private System.Windows.Forms.Button multiSortButton;
    }
}