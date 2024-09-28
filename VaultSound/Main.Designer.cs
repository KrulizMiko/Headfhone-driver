namespace VaultSound
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Profile = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.Button();
            this.Radio = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.stp = new System.Windows.Forms.Button();
            this.src = new System.Windows.Forms.Button();
            this.resum = new System.Windows.Forms.Button();
            this.rnd = new System.Windows.Forms.Button();
            this.ser = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.svv = new System.Windows.Forms.Button();
            this.addMsc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.BackgroundImage = global::VaultSound.Properties.Resources.Rectangle_1;
            this.Profile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Profile.Location = new System.Drawing.Point(675, 12);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(104, 35);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Профиль";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // General
            // 
            this.General.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.General.Location = new System.Drawing.Point(12, 12);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(81, 31);
            this.General.TabIndex = 2;
            this.General.Text = "Главная";
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // Radio
            // 
            this.Radio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radio.Location = new System.Drawing.Point(99, 12);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(80, 31);
            this.Radio.TabIndex = 3;
            this.Radio.Text = "Радио";
            this.Radio.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.Control;
            this.Settings.BackgroundImage = global::VaultSound.Properties.Resources.Group_1;
            this.Settings.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Settings.Location = new System.Drawing.Point(565, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(104, 35);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Твоя медиатека";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchbtn.Location = new System.Drawing.Point(252, 223);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(67, 31);
            this.Searchbtn.TabIndex = 8;
            this.Searchbtn.Text = "Поиск";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 199);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(325, 524);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(165, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 517);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(94, 23);
            this.play.TabIndex = 17;
            this.play.Text = "start";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(225, 546);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(94, 23);
            this.pause.TabIndex = 18;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stp
            // 
            this.stp.Location = new System.Drawing.Point(12, 546);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(94, 23);
            this.stp.TabIndex = 19;
            this.stp.Text = "stop";
            this.stp.UseVisualStyleBackColor = true;
            this.stp.Click += new System.EventHandler(this.stp_Click);
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(396, 244);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(94, 23);
            this.src.TabIndex = 20;
            this.src.Text = "Найти треки";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // resum
            // 
            this.resum.Location = new System.Drawing.Point(225, 517);
            this.resum.Name = "resum";
            this.resum.Size = new System.Drawing.Size(94, 23);
            this.resum.TabIndex = 21;
            this.resum.Text = "play";
            this.resum.UseVisualStyleBackColor = true;
            this.resum.Click += new System.EventHandler(this.resum_Click);
            // 
            // rnd
            // 
            this.rnd.Location = new System.Drawing.Point(115, 546);
            this.rnd.Name = "rnd";
            this.rnd.Size = new System.Drawing.Size(94, 23);
            this.rnd.TabIndex = 22;
            this.rnd.Text = "random";
            this.rnd.UseVisualStyleBackColor = true;
            this.rnd.Click += new System.EventHandler(this.rnd_Click);
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(12, 223);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(218, 35);
            this.ser.TabIndex = 23;
            this.ser.TextChanged += new System.EventHandler(this.ser_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(396, 215);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 23);
            this.search.TabIndex = 0;
            this.search.Text = "Открыть файл";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            this.svv.Click += new System.EventHandler(this.svv_Click_1);
            // 
            // addMsc
            // 
            this.addMsc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMsc.Location = new System.Drawing.Point(484, 273);
            this.addMsc.Name = "addMsc";
            this.addMsc.Size = new System.Drawing.Size(89, 64);
            this.addMsc.TabIndex = 29;
            this.addMsc.Text = "Добавить в плейлист";
            this.addMsc.UseVisualStyleBackColor = true;
            this.addMsc.Click += new System.EventHandler(this.addMsc_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::VaultSound.Properties.Resources.Rectangle_1;
            this.ClientSize = new System.Drawing.Size(928, 581);
            this.Controls.Add(this.addMsc);
            this.Controls.Add(this.svv);
            this.Controls.Add(this.search);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.rnd);
            this.Controls.Add(this.resum);
            this.Controls.Add(this.src);
            this.Controls.Add(this.stp);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Profile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "VaultSound";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button General;
        private System.Windows.Forms.Button Radio;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stp;
        private System.Windows.Forms.Button src;
        private System.Windows.Forms.Button resum;
        private System.Windows.Forms.Button rnd;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button svv;
        private System.Windows.Forms.Button addMsc;
    }
}

