using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace demo1
{
    public partial class Avtorization : Form
    {
        string login = "";
        string password = "";
        int count = 0;
        public Avtorization()
        {
            InitializeComponent();
        }

        private async void bt_input_Click(object sender, EventArgs e)
        {
            login = tb_login.Text;
            password = tb_password.Text;
            string getPassword = "";

            try
            {
                if (login.Length == 0 || password.Length == 0)
                {
                    return;
                }

                Program.con.Open();
                NpgsqlCommand CommandGetLogin = new NpgsqlCommand($"SELECT password FROM users WHERE login = '{login}'", Program.con);
                if (CommandGetLogin.ExecuteScalar() == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    Program.con.Close();
                    return;
                }
                else
                {
                    getPassword = CommandGetLogin.ExecuteScalar().ToString();

                }

                Program.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! Проверьте введенные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.con.Close();
                return;
            }

            if (getPassword != password)
            {
                count++;
                if (count == 3)
                {
                    this.Enabled = false;
                    await Task.Delay(2000);
                    this.Enabled = true;
                }
                MessageBox.Show("Пароль неверный");
                return;
            }
            else
            {
                Program.con.Open();
                NpgsqlCommand CommandGetRole = new NpgsqlCommand($"SELECT id_role FROM users WHERE login = '{login}'", Program.con);
                Program.currentRole = Convert.ToInt32(CommandGetRole.ExecuteScalar());
                Program.con.Close();

                Applications application = new Applications();
                application.Show();
                this.Hide();
            }
        }
    }
}
