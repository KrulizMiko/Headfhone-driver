using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace VaultSound
{
    public partial class Profile : Form
    {
        private List<string> playlist; // Объявление поля для хранения плейлиста

        public Profile(string nickname, string email, List<string> playlist)
        {
            InitializeComponent();

            // Проверяем и инициализируем плейлист, если он равен null
            this.playlist = playlist ?? new List<string>();

            // Проверяем инициализацию элементов управления
            if (Nickname == null || Mail == null)
            {
                MessageBox.Show("Не удалось найти компоненты для отображения никнейма и почты.");
                return;
            }

            // Устанавливаем никнейм и почту в Label
            Nickname.Text = $"Никнейм: {nickname}";
            Mail.Text = $"Почта: {email}";

            LoadPlaylist(); // Загружаем плейлист при создании формы
        }

        private void LoadPlaylist()
        {
            listBoxPlaylist.Items.Clear(); // Сначала очищаем
            foreach (var song in playlist)
            {
                listBoxPlaylist.Items.Add(song); // Добавляем каждую песню в listBox
            }
        }

        private void sw()
        {
            Application.Run(new Main());
        }

        private void sw1()
        {
            Application.Run(new Authorization());
        }

        private void General_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(sw);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(sw1);
            th.Start();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           
        }

        private void svv_Click(object sender, EventArgs e)
        {
            svv.BackColor = Color.Violet;
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта!");
            this.Close();
            Thread th = new Thread(sw1);
            th.Start();
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            ShowPlaylists(); // Показать плейлисты при нажатии на кнопку
        }

        private void ShowPlaylists()
        {
            listBoxPlaylist.Items.Clear(); // Сначала очищаем ListBox
            foreach (var song in playlist) // Перебираем песни в плейлисте
            {
                listBoxPlaylist.Items.Add(song); // Добавляем каждую песню в ListBox
            }

            listBoxPlaylist.Visible = true; // Показываем ListBox
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
