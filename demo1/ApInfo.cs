using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace demo1
{
    public partial class ApInfo : Form
    {
        public int id = 0;
        public string description = "";
        public string comment = "";
        public string executor = "";
        private bool exData= false;
       
        public ApInfo(int id, int number, DateTime date, string device, string type_problem, string description, string client, string status)
        {
            InitializeComponent();
            this.id = id;
            this.description = description;

            tb_number.Text += number;
            tb_date.Text += date;
            tb_device.Text += device;
            tb_type_problem.Text += type_problem;
            tb_description.Text += description;
            tb_client.Text += client;
            tb_status.Text += status;

            if (Program.currentRole != 1)
            {
                // Если Program.currentRole != 1, делаем cb_executor неактивным и только для чтения
                cb_executor.Enabled = false;
            }
            if (Program.currentRole == 1)
            {
                // Если Program.currentRole = 1, делаем tb_comment неактивным и только для чтения
                tb_comment.Enabled = false;
                tb_comment.ReadOnly = true;
            }

            cb_executor.Items.Add("Федоров Петр Якимович");
            cb_executor.Items.Add("Ешметов Артем Кириллович");
            cb_executor.Items.Add("Опраксин Евгений Андреевич");
            cb_executor.Items.Add("Скалозуб Шарль Эдуардович");
            cb_executor.Items.Add("Бадяжин Тимур Ринатович");


            Program.con.Open();
            NpgsqlCommand GetExecutor = new NpgsqlCommand($"SELECT e.name, ex.comment FROM executor ex JOIN employee e ON ex.id_employee = e.id WHERE ex.id_application = {id}", Program.con);
            NpgsqlDataReader GetDataReader = GetExecutor.ExecuteReader();
            if (GetDataReader.Read())
            {
                executor = GetDataReader.GetString(0);
                comment = GetDataReader.IsDBNull(1) ? "" : GetDataReader.GetString(1);
                Program.con.Close();   
            }
            else
            {
                Program.con.Close();
            }
            cb_executor.Text = executor;
            tb_comment.Text = comment;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

            try
            {
                Program.con.Open();
                if (tb_description.Text != description)
                {
                    NpgsqlCommand CommandUpdate = new NpgsqlCommand($"UPDATE application SET description = '{tb_description.Text}' WHERE id = {id}", Program.con);
                    CommandUpdate.ExecuteNonQuery();
                }
                if (exData == true)
                {
                    if (cb_executor.SelectedItem.ToString() != executor)// если роль "менеджер", пользователь может назначить/сменить исполнителя
                    {
                        NpgsqlCommand CommandUpdate = new NpgsqlCommand($"UPDATE executor SET id_employee = (SELECT id FROM employee WHERE name = '{cb_executor.SelectedItem.ToString()}') WHERE id_application = {id}", Program.con);
                        CommandUpdate.ExecuteNonQuery();
                    }

                    if (tb_comment.Text != comment)
                    {
                        NpgsqlCommand CommandUpdate = new NpgsqlCommand($"UPDATE executor SET comment = '{tb_comment.Text}' WHERE id_application = {id}", Program.con);
                        CommandUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    executor = cb_executor.SelectedItem.ToString();
                    comment = tb_comment.Text;
                    NpgsqlCommand CommandAdd = new NpgsqlCommand($"INSERT INTO executor (id_application, id_employee, comment) VALUES ({id}, (SELECT id FROM employee WHERE name = '{executor}'), '{comment}')" , Program.con);
                    CommandAdd.ExecuteNonQuery();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Все поля должны быть заполнены!");
            }
            finally 
            {
                MessageBox.Show("Обновите данные в списке для корректного отображения!");
                Program.con.Close();
            }
        }

        private void ApInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_comment.Text = comment;
            tb_description.Text = description;
            cb_executor.SelectedItem = executor;
        }
    }
}
