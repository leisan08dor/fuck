 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace demo1
{
    internal static class Program
    {

        public static int currentRole { get; set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Avtorization());
        }


        public static NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;UserName=postgres;Password=123456789;Database=demo_repair");
        
    }
}
