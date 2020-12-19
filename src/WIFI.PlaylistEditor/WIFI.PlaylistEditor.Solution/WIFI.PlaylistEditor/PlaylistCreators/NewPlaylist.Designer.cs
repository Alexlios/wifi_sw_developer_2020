
namespace WIFI.PlaylistEditor.PlaylistCreators
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
            this.OK_bttn = new System.Windows.Forms.Button();
            this.Cancel_bttn = new System.Windows.Forms.Button();
            this.PlaylistName = new System.Windows.Forms.TextBox();
            this.PlaylistAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_bttn
            // 
            this.OK_bttn.Location = new System.Drawing.Point(12, 64);
            this.OK_bttn.Name = "OK_bttn";
            this.OK_bttn.Size = new System.Drawing.Size(75, 23);
            this.OK_bttn.TabIndex = 0;
            this.OK_bttn.Text = "OK";
            this.OK_bttn.UseVisualStyleBackColor = true;
            // 
            // Cancel_bttn
            // 
            this.Cancel_bttn.Location = new System.Drawing.Point(93, 64);
            this.Cancel_bttn.Name = "Cancel_bttn";
            this.Cancel_bttn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_bttn.TabIndex = 1;
            this.Cancel_bttn.Text = "Cancel";
            this.Cancel_bttn.UseVisualStyleBackColor = true;
            // 
            // PlaylistName
            // 
            this.PlaylistName.Location = new System.Drawing.Point(12, 12);
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.Size = new System.Drawing.Size(156, 20);
            this.PlaylistName.TabIndex = 2;
            this.PlaylistName.Text = "[name]";
            // 
            // PlaylistAutor
            // 
            this.PlaylistAutor.Location = new System.Drawing.Point(12, 38);
            this.PlaylistAutor.Name = "PlaylistAutor";
            this.PlaylistAutor.Size = new System.Drawing.Size(156, 20);
            this.PlaylistAutor.TabIndex = 3;
            this.PlaylistAutor.Text = "[autor]";
            // 
            // NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 102);
            this.Controls.Add(this.PlaylistAutor);
            this.Controls.Add(this.PlaylistName);
            this.Controls.Add(this.Cancel_bttn);
            this.Controls.Add(this.OK_bttn);
            this.Name = "NewPlaylist";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_bttn;
        private System.Windows.Forms.Button Cancel_bttn;
        private System.Windows.Forms.TextBox PlaylistName;
        private System.Windows.Forms.TextBox PlaylistAutor;
    }
}