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
    //
    public partial class UserControlAp : UserControl
    {
        public int id = 0;
        public int numder = 0;
        public DateTime date;
        public string device = "";
        public string type_problem = "";
        public string description = "";
        public string client = "";
        public string status = "";

        public UserControlAp(int id, int number, DateTime date, string device, string type_problem, string description, string client, string status)
        {
            InitializeComponent();

            this.id = id;
            this.numder = number;
            this.date = date;
            this.device = device;
            this.type_problem = type_problem;
            this.description = description;
            this.client = client;
            this.status = status;

            lb_number.Text += numder;
            lb_date.Text += date;
            lb_device.Text += device;

            lb_type_problem.Text += type_problem;


            cb_status.Text += status; 
            
            cb_status.Items.Add("Не выполнено");
            cb_status.Items.Add("В работе");
            cb_status.Items.Add("Выполнено");

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Program.con.Open();
            NpgsqlCommand CommandDelete = new NpgsqlCommand($"DELETE FROM public.application WHERE id = {id}",Program.con);
            CommandDelete.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("Заявка удалена ");
            this.Hide();

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_status.SelectedItem.ToString() != status)
            {
                string newStatus = cb_status.SelectedItem.ToString();
                Program.con.Open();
                NpgsqlCommand CommandUpdate = new NpgsqlCommand($"UPDATE application SET id_status = (SELECT id FROM status WHERE name = '{newStatus}') WHERE id = {id}", Program.con);
                CommandUpdate.ExecuteNonQuery();
                Program.con.Close();
                status = newStatus;
                MessageBox.Show("Статус изменен: " + status);
            }
            if(cb_status.SelectedItem.ToString() == "Выполнено")
            {
                MessageBox.Show($"Заявка: {numder} выполнена!");
                
                return;

            }
        }

        private void UserControlAp_Click(object sender, EventArgs e)
        {
            ApInfo apInfo = new ApInfo(id, numder, date, device, type_problem, description, client, status);
            apInfo.Show();

        }

        private void UserControlAp_Load(object sender, EventArgs e)
        {

        }
    }
}
