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

namespace _210601046_Şilan_Ekin_veri_finalproje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=SilanMBYS;User Id=postgres;Password=1234");

        public void Data(string query)
        {
            connect.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connect;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            NpgsqlDataReader dataread = command.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridilac.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }
        private void AnaMenuDon_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Data("select * from ilactablosu");
        }

        private void BtnilacEkle_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand ilacEkleme = new NpgsqlCommand();
            ilacEkleme.Connection = connect;

            ilacEkleme.Parameters.AddWithValue("@barkodno", Convert.ToInt64(txtbarkodNo.Text));
            ilacEkleme.Parameters.AddWithValue("@ilacAdi", txtilacAd.Text);
            ilacEkleme.Parameters.AddWithValue("@ilacTipi", txtilacTip.Text);
           

            ilacEkleme.CommandType = CommandType.Text;
            ilacEkleme.CommandText = "insert into ilactablosu values (@barkodno, @ilacAdi, @ilacTipi)";

            NpgsqlDataReader dataread = ilacEkleme.ExecuteReader();
            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridilac.DataSource = data;
            }
            ilacEkleme.Dispose();
            connect.Close();

            Data("Select * from ilactablosu");
        }
    }
}
