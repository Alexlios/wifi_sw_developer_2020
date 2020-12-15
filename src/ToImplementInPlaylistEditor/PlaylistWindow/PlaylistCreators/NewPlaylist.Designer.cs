namespace PlaylistWindow
{
    partial class NewPlaylist
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
            this.OkButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.autorBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CatVibe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CatVibe)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 64);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "name";
            // 
            // autorBox
            // 
            this.autorBox.Location = new System.Drawing.Point(12, 38);
            this.autorBox.Name = "autorBox";
            this.autorBox.Size = new System.Drawing.Size(100, 20);
            this.autorBox.TabIndex = 2;
            this.autorBox.Text = "autor";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(93, 64);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(81, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CatVibe
            // 
            this.CatVibe.Location = new System.Drawing.Point(180, 12);
            this.CatVibe.Name = "CatVibe";
            this.CatVibe.Size = new System.Drawing.Size(80, 80);
            this.CatVibe.TabIndex = 4;
            this.CatVibe.TabStop = false;
            // 
            // NewPlaylist
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(267, 104);
            this.Controls.Add(this.CatVibe);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.autorBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewPlaylist";
            this.Text = "NewPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.CatVibe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox autorBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox CatVibe;
    }
}