using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VaultSound
{
    public partial class Main : Form
    {
        private AudioFileReader audioFileReader;
        private IWavePlayer waveOut;
        private List<string> playlist; // Добавляем плейлист


        public Main()
        {
            InitializeComponent();
            InitializeTrackBar();
            playlist = new List<string>(); // Инициализируем плейлист
        }

        private void InitializeTrackBar()
        {
            trackBar1.Minimum = 0; // минималка
            trackBar1.Maximum = 100; // максималка
            trackBar1.Value = 100; // начальное значение
            trackBar1.Scroll += trackBar1_Scroll; // подписка на событие
        }

        private void LoadSongs()
        {
            
        }

        void gn()
        {
            Application.Run(new Main());
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile("никнейм", "email", playlist); // передаем плейлист
            profileForm.Show();
            this.Hide();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Действия при выборе элемента в listBox1 (если необходимо)
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedSong = listBox1.SelectedItem.ToString();

                StopAudio(); // остановим и освободим ресурсы, если играет
                waveOut = new WaveOut();
                audioFileReader = new AudioFileReader(selectedSong);

                waveOut.Init(audioFileReader);
                waveOut.Play();
            }
        }

        private void StopAudio()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null; // убираем ссылку на исполнителя
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null; // убираем ссылку на аудиофайл
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            waveOut?.Pause();
        }

        private void stp_Click(object sender, EventArgs e)
        {
            StopAudio();
        }

        private void src_Click(object sender, EventArgs e)
        {
            string[] extensions = { ".mp3", ".wav", ".flac" }; // можно добавить и другие форматы
            string musicDirectory = @"C:\Users\артём\OneDrive\Рабочий стол"; // путь к папке с музыкой
            try
            {
                if (listBox1.Items.Count > 0) // 
                {
                    MessageBox.Show("Все треки уже найдены!", "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return; // Выходим, если треки уже добавлены
                }

                var musicFiles = Directory.GetFiles(musicDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(file => extensions.Contains(Path.GetExtension(file).ToLower())).ToList();

                foreach (var file in musicFiles)
                {
                    listBox1.Items.Add(file);
                }

                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Музыкальные файлы не найдены!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка:\n{ex.Message}", "Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void resum_Click(object sender, EventArgs e)
        {
            waveOut?.Play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                float volume = trackBar1.Value / 100f; // преобразование в диапазон от 0 до 1
                waveOut.Volume = volume;
            }
        }

        private void rnd_Click(object sender, EventArgs e)
        {
            PlayRandomTrack();
        }

        private void PlayRandomTrack()
        {
            if (listBox1.Items.Count == 0)
                return;

            Random random = new Random();
            int rndIndex = random.Next(listBox1.Items.Count);
            string selectedTrack = listBox1.Items[rndIndex].ToString();
            PlayTrack(selectedTrack);
        }

        private void PlayTrack(string track)
        {
            StopAudio();
            waveOut = new WaveOut();
            audioFileReader = new AudioFileReader(track);
            waveOut.Init(audioFileReader);
            waveOut.Play();
        }

        [STAThread]
        private void search_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav|All Files|*.*";
                openFileDialog.Multiselect = true;

                // Показать диалог открытия файла
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in openFileDialog.FileNames)
                    {
                        listBox1.Items.Add(file); // Добавляем выбранные файлы в listBox
                    }
                }
            }
        }

        private void svv_Click_1(object sender, EventArgs e)
        {
            svv.BackColor = Color.Violet;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ser_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string src = ser.Text;
            if (src.Trim() == "")
            {
                MessageBox.Show("Введите название трека!");
            }
            else
            {
                string searchTerm = src.ToLower();
                var results = listBox1.Items.Cast<string>()
                    .Where(song => song.ToLower().Contains(searchTerm))
                    .ToList();

                listBox1.Items.Clear();  // Очищаем listBox перед добавлением результатов

                if (results.Count > 0)
                {
                    foreach (var song in results)
                    {
                        listBox1.Items.Add(song);
                    }
                }
                else
                {
                    MessageBox.Show("Ничего не найдено.", "Результаты поиска", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void General_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы и так на этой форме!");
            Thread thread = new Thread(gn);
            thread.Start(); 
        }

        private void addMsc_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedSong = listBox1.SelectedItem.ToString();
                if (!playlist.Contains(selectedSong)) // Проверяем, что песня уже не в плейлисте
                {
                    playlist.Add(selectedSong); // Добавляем в плейлист
                    MessageBox.Show($"{selectedSong} добавлена в плейлист.");
                }
                else
                {
                    MessageBox.Show("Эта песня уже в плейлисте.");
                }
            }
            else
            {
                MessageBox.Show("Выберите песню для добавления в плейлист.");
            }
        }
    }
}
