namespace VaultSound
{
    partial class Profile
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
            this.Nickname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.General = new System.Windows.Forms.Button();
            this.Playlist = new System.Windows.Forms.Button();
            this.ForU = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.svv = new System.Windows.Forms.Button();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname.Location = new System.Drawing.Point(7, 61);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(119, 28);
            this.Nickname.TabIndex = 8;
            this.Nickname.Text = "Никнейм:";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(800, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Авторизация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(753, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ваш профиль";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail.Location = new System.Drawing.Point(7, 101);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(115, 28);
            this.Mail.TabIndex = 12;
            this.Mail.Text = "Эл.почта:";
            // 
            // General
            // 
            this.General.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.General.Location = new System.Drawing.Point(12, 8);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(81, 31);
            this.General.TabIndex = 13;
            this.General.Text = "Главная";
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // Playlist
            // 
            this.Playlist.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Playlist.Location = new System.Drawing.Point(99, 8);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(94, 31);
            this.Playlist.TabIndex = 14;
            this.Playlist.Text = "Плейлисты";
            this.Playlist.UseVisualStyleBackColor = true;
            this.Playlist.Click += new System.EventHandler(this.Playlist_Click);
            // 
            // ForU
            // 
            this.ForU.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForU.Location = new System.Drawing.Point(199, 8);
            this.ForU.Name = "ForU";
            this.ForU.Size = new System.Drawing.Size(82, 31);
            this.ForU.TabIndex = 15;
            this.ForU.Text = "Для тебя";
            this.ForU.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(821, 467);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 56);
            this.exit.TabIndex = 16;
            this.exit.Text = "Выйти из аккаунта";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // svv
            // 
            this.svv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.svv.Location = new System.Drawing.Point(785, 12);
            this.svv.Name = "svv";
            this.svv.Size = new System.Drawing.Size(131, 35);
            this.svv.TabIndex = 28;
            this.svv.Text = "Свернуть прил";
            this.svv.UseVisualStyleBackColor = true;
            this.svv.Click += new System.EventHandler(this.svv_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.Location = new System.Drawing.Point(12, 461);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(466, 108);
            this.listBoxPlaylist.TabIndex = 29;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ваш плейлист";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::VaultSound.Properties.Resources.Rectangle_1;
            this.ClientSize = new System.Drawing.Size(928, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.svv);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ForU);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Nickname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Button General;
        private System.Windows.Forms.Button Playlist;
        private System.Windows.Forms.Button ForU;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button svv;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Label label1;
    }
}