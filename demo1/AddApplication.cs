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
    public partial class AddApplication : Form
    {
        public AddApplication()
        {
            InitializeComponent();

            cb_type_problem.Items.Add("Дефект");
            cb_type_problem.Items.Add("Повреждение");
            cb_type_problem.Items.Add("Сбой");
            cb_type_problem.Items.Add("Отказ");



        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string addQuery = $"INSERT INTO application (number, date_input, device, id_type_problem, id_client, description, id_status) " +
                   $"VALUES ('{tb_number.Text}', '{tb_date.Text}', '{tb_device.Text}', " +
                   $"(SELECT id FROM type_problem WHERE name = '{cb_type_problem.SelectedItem.ToString()}'), " +
                   $"(SELECT id FROM client WHERE name = '{tb_client.Text}'), " +
                   $"'{tb_description.Text}', " +
                   $"(SELECT id FROM status WHERE name = 'Не выполнено'))";

            try
            {
                Program.con.Open();
                NpgsqlCommand AddApplication = new NpgsqlCommand(addQuery, Program.con);
                AddApplication.ExecuteNonQuery();
                Program.con.Close();
                Applications application = new Applications();
                application.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка! Проверьте введенные данные");
            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                    c.Text = "";
            }
        }

        private void AddApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Applications applications = new Applications();
            applications.Show();
            this.Hide();
        }
    }
}
