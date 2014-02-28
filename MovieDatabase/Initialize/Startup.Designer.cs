namespace MovieDatabase.Initialize
{
    partial class Startup
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.viewDatabaseButton = new System.Windows.Forms.Button();
            this.addMoviesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(124, 23);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(131, 33);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "Welcome To\r\n";
            // 
            // titleLabel2
            // 
            this.titleLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(70, 56);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(242, 33);
            this.titleLabel2.TabIndex = 1;
            this.titleLabel2.Text = "Colin\'s Movie Database";
            // 
            // viewDatabaseButton
            // 
            this.viewDatabaseButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDatabaseButton.Location = new System.Drawing.Point(12, 92);
            this.viewDatabaseButton.Name = "viewDatabaseButton";
            this.viewDatabaseButton.Size = new System.Drawing.Size(172, 30);
            this.viewDatabaseButton.TabIndex = 2;
            this.viewDatabaseButton.Text = "View Database";
            this.viewDatabaseButton.UseVisualStyleBackColor = true;
            this.viewDatabaseButton.Click += new System.EventHandler(this.viewDatabaseButton_Click);
            // 
            // addMoviesButton
            // 
            this.addMoviesButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoviesButton.Location = new System.Drawing.Point(196, 92);
            this.addMoviesButton.Name = "addMoviesButton";
            this.addMoviesButton.Size = new System.Drawing.Size(172, 30);
            this.addMoviesButton.TabIndex = 3;
            this.addMoviesButton.Text = "Add Movies";
            this.addMoviesButton.UseVisualStyleBackColor = true;
            this.addMoviesButton.Click += new System.EventHandler(this.addMoviesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 142);
            this.Controls.Add(this.addMoviesButton);
            this.Controls.Add(this.viewDatabaseButton);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Button viewDatabaseButton;
        private System.Windows.Forms.Button addMoviesButton;
    }
}

