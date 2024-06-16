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
    public partial class Applications : Form
    {
        private List<UserControlAp> dataList = new List<UserControlAp>();
        private int currentPage = 1;
        private int itemsPerPage = 2 ;
        public Applications()
        {
            InitializeComponent();

            lb_resultSearch.Text = "";

            cb_sort.Items.Add("Старые");
            cb_sort.Items.Add("Новые");

            cb_filter.Items.Add("Все");
            cb_filter.Items.Add("Не выполнено");
            cb_filter.Items.Add("В работе");
            cb_filter.Items.Add("Выполнено");


        }

        private void Application_Load(object sender, EventArgs e)
        {           
            LoadData();
        }

        private void LoadData()
        {
            Program.con.Open();
            string search = tb_search.Text;
            string sortStr = " a.date_input ASC";
            if (cb_sort.SelectedItem != null)
            {
                if (cb_sort.SelectedItem.ToString() == "Новые")
                {
                    sortStr = " a.date_input DESC";
                }
                  
            }

            string filter = cb_filter.Text;
            if(cb_filter.SelectedIndex > 0)
            {
                filter = $" AND s.name = '{cb_filter.SelectedItem}'";
            }
            else
            {
                filter = "";
            }
            

            NpgsqlCommand GetData = new NpgsqlCommand($"SELECT a.id, a.number, a.date_input, a.device, t.name, a.description, c.name, s.name FROM application a JOIN type_problem t ON a.id_type_problem = t.id " +
                $"JOIN client c ON a.id_client = c.id JOIN status s ON a.id_status = s.id WHERE CAST(a.number AS TEXT) LIKE '%{search}%'" + filter + $" ORDER BY {sortStr}, id", Program.con);
            NpgsqlDataReader GetDataReader = GetData.ExecuteReader();
            dataList.Clear();
            while(GetDataReader.Read())
            {
                dataList.Add(new UserControlAp(GetDataReader.GetInt32(0), GetDataReader.GetInt32(1), GetDataReader.GetDateTime(2), GetDataReader.GetString(3), GetDataReader.GetString(4), GetDataReader.GetString(5), GetDataReader.GetString(6), GetDataReader.GetString(7)));
            }

            Program.con.Close();
            flowLayoutPanel1.Controls.Clear();

            if (dataList.Count > 0)
            {
                foreach (UserControlAp ap in dataList)
                {
                    flowLayoutPanel1.Controls.Add(ap);
                }
            }
            else
            {
                lb_resultSearch.Text = "Соответствий не найдено";
            }

            Paginate();

        }

        private void Paginate()
        {
            int startIndex = (currentPage - 1) * itemsPerPage;
            int totalItems = dataList.Count;
            int endIndex = Math.Min(startIndex + itemsPerPage, totalItems);

            flowLayoutPanel1.Controls.Clear();
            List<UserControlAp> paginate = dataList.Skip(startIndex).Take(endIndex-startIndex).ToList();

            foreach (UserControlAp ap in paginate)
            {
                flowLayoutPanel1.Controls.Add(ap);
            }

            lb_back.Visible = currentPage > 1;
            lb_next.Visible = endIndex < totalItems;
        }

        private void lb_next_Click(object sender, EventArgs e)
        {
            currentPage++;
            Paginate();
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            currentPage--;
            Paginate();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            AddApplication addApplication = new AddApplication();
            addApplication.Show();
            this.Hide();
        }

        private void Application_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
