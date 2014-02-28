namespace MovieDatabase.AddMovies
{
    partial class AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderPathBrowseButton = new System.Windows.Forms.Button();
            this.filePathBrowseButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.cancelMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Note if both paths filled in code defaults to File Path*";
            // 
            // folderPathBrowseButton
            // 
            this.folderPathBrowseButton.Location = new System.Drawing.Point(542, 8);
            this.folderPathBrowseButton.Name = "folderPathBrowseButton";
            this.folderPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.folderPathBrowseButton.TabIndex = 5;
            this.folderPathBrowseButton.Text = "Browse...";
            this.folderPathBrowseButton.UseVisualStyleBackColor = true;
            this.folderPathBrowseButton.Click += new System.EventHandler(this.folderPathBrowseButton_Click);
            // 
            // filePathBrowseButton
            // 
            this.filePathBrowseButton.Location = new System.Drawing.Point(542, 46);
            this.filePathBrowseButton.Name = "filePathBrowseButton";
            this.filePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.filePathBrowseButton.TabIndex = 6;
            this.filePathBrowseButton.Text = "Browse...";
            this.filePathBrowseButton.UseVisualStyleBackColor = true;
            this.filePathBrowseButton.Click += new System.EventHandler(this.filePathBrowseButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(108, 10);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(428, 20);
            this.folderTextBox.TabIndex = 7;
            this.folderTextBox.TextChanged += new System.EventHandler(this.folderTextBox_TextChanged);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(108, 48);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(428, 20);
            this.fileTextBox.TabIndex = 8;
            this.fileTextBox.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(153, 94);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(144, 23);
            this.addMovieButton.TabIndex = 9;
            this.addMovieButton.Text = "Add";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // cancelMovieButton
            // 
            this.cancelMovieButton.Location = new System.Drawing.Point(309, 94);
            this.cancelMovieButton.Name = "cancelMovieButton";
            this.cancelMovieButton.Size = new System.Drawing.Size(144, 23);
            this.cancelMovieButton.TabIndex = 10;
            this.cancelMovieButton.Text = "Cancel";
            this.cancelMovieButton.UseVisualStyleBackColor = true;
            this.cancelMovieButton.Click += new System.EventHandler(this.cancelMovieButton_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 130);
            this.Controls.Add(this.cancelMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.filePathBrowseButton);
            this.Controls.Add(this.folderPathBrowseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button folderPathBrowseButton;
        private System.Windows.Forms.Button filePathBrowseButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button cancelMovieButton;
    }
}