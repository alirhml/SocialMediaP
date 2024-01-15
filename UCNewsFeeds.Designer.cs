namespace SocialMediaP
{
    partial class UCNewsFeeds
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNewsFeeds));
            pictureBoxPosts = new PictureBox();
            pictureBoxProfile = new PictureBox();
            labelUserName = new Label();
            labelTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPosts
            // 
            pictureBoxPosts.BackColor = Color.White;
            pictureBoxPosts.Dock = DockStyle.Top;
            pictureBoxPosts.Image = (Image)resources.GetObject("pictureBoxPosts.Image");
            pictureBoxPosts.Location = new Point(0, 0);
            pictureBoxPosts.Name = "pictureBoxPosts";
            pictureBoxPosts.Size = new Size(186, 167);
            pictureBoxPosts.TabIndex = 0;
            pictureBoxPosts.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = (Image)resources.GetObject("pictureBoxProfile.Image");
            pictureBoxProfile.Location = new Point(7, 175);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(33, 29);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 1;
            pictureBoxProfile.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(52, 177);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(78, 16);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Ali Rahimli";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(55, 193);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(70, 16);
            labelTime.TabIndex = 3;
            labelTime.Text = "3 hours ago";
            // 
            // UCNewsFeeds
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(labelTime);
            Controls.Add(labelUserName);
            Controls.Add(pictureBoxProfile);
            Controls.Add(pictureBoxPosts);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UCNewsFeeds";
            Size = new Size(186, 220);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPosts;
        private PictureBox pictureBoxProfile;
        private Label labelUserName;
        private Label labelTime;
    }
}
