using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VaultSound
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private List<string> playlist; // Объявление поля для хранения плейлиста

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Enter.BackColor = Color.Violet;
            string nk = Nick.Text;
            string ps = Pass.Text;

            try
            {
                // Проверки на пустые поля
                if (string.IsNullOrWhiteSpace(nk) || string.IsNullOrWhiteSpace(ps))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                string connection = "Data Source=VaultDB.db;";
                using (SQLiteConnection DB = new SQLiteConnection(connection))
                {
                    DB.Open();
                    string query = "SELECT Mail FROM User WHERE Nickname = @nik AND Password = @Pass";
                    SQLiteCommand cmd = new SQLiteCommand(query, DB);
                    cmd.Parameters.AddWithValue("@nik", nk);
                    cmd.Parameters.AddWithValue("@Pass", ps);

                    var mailResult = cmd.ExecuteScalar();
                    if (mailResult != null)
                    {
                        string email = mailResult.ToString();
                        MessageBox.Show("Вы успешно авторизовались!");

                        // Открытие формы профиля с передачей данных
                        Profile profileForm = new Profile(nk, email, playlist);
                        this.Hide(); // Скрыть форму авторизации
                        profileForm.Show(); // Показать форму профиля
                    }
                    else
                    {
                        MessageBox.Show("Ваши данные неверные!");
                        Nick.Clear();
                        Pass.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка авторизации:\n{ex.Message}");
            }

        }

        private void gn()
        {
            Application.Run(new Main());
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Reg.BackColor = Color.Violet;
            string nnk = newNick.Text;
            string ps = newPass.Text;
            string ml = Mail0.Text;

            if (string.IsNullOrWhiteSpace(nnk) || string.IsNullOrWhiteSpace(ps) || string.IsNullOrWhiteSpace(ml))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для регистрации.");
                return;
            }

            try
            {
                string conn = "Data Source=VaultDB.db;";
                using (SQLiteConnection DB = new SQLiteConnection(conn))
                {
                    DB.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO User(Nickname, Password, Mail) VALUES (@nick, @pass, @mail)", DB);
                    cmd.Parameters.AddWithValue("@nick", nnk);
                    cmd.Parameters.AddWithValue("@pass", ps);
                    cmd.Parameters.AddWithValue("@mail", ml);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при регистрации:\n{ex.Message}");
            }
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            newPass.PasswordChar = '#';// при вводе, символы скрыты
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            Pass.PasswordChar = '#';// при вводе, символы скрыты
            if (Pass.ForeColor == Color.Violet)
            {
                Pass.ForeColor = Color.Black;
            }
        }

        private void svv_Click(object sender, EventArgs e)
        {
            svv.BackColor = Color.Violet;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Nick_TextChanged(object sender, EventArgs e)
        {
            if (Nick.ForeColor == Color.Violet)
            {
                Nick.ForeColor = Color.Black;
            }
        }

        private void Compl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хорошо, наслаждайся музыкой!");
            this.Close();
            Thread thread = new Thread(gn);
            thread.Start();
        }

        private bool sh = false;

        private void show_Click(object sender, EventArgs e)
        {
            show.BackColor = Color.Violet;
            sh = !sh;

            Pass.UseSystemPasswordChar = !sh;
        }

        private bool ssh = false;

        private void show1_Click(object sender, EventArgs e)
        {
            newPass.BackColor = Color.Violet;
            ssh = !ssh;

            Pass.UseSystemPasswordChar = !ssh;
        }
    }
}
