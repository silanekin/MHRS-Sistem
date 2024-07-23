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
namespace _210601046_Şilan_Ekin_veri_finalproje
{
    public partial class HastaSil : Form
    {
        public HastaSil()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=SilanMBYS;User Id=postgres;Password=1234");
        public void showData(string query)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            NpgsqlDataReader dataread = command.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable database = new DataTable();
                database.Load(dataread);
                dataGridView1.DataSource = database;
            }

            command.Dispose();
            connection.Close();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnHastaSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand DeleteCommand = new NpgsqlCommand();
            DeleteCommand.Connection = connection;
            DeleteCommand.Parameters.AddWithValue("@tcno",Convert.ToInt64(txttcNo.Text));

            DeleteCommand.CommandType = CommandType.Text;
            DeleteCommand.CommandText = "delete from hastatablosu where tcno = @tcno";

            NpgsqlDataReader dataread = DeleteCommand.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable database = new DataTable();
                database.Load(dataread);
                dataGridView1.DataSource = database;
            }
            DeleteCommand.Dispose();
            connection.Close();

            showData("select * from hastatablosu");
        }

        private void HastaSil_Load(object sender, EventArgs e)
        {
            showData("select * from hastatablosu");
        }
    }
}
