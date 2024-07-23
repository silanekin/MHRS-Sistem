using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _210601046_Şilan_Ekin_veri_finalproje
{
    public partial class HastaEkleme : Form
    {
        public HastaEkleme()
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
                dtGridHastaEkle.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }


        private void BtnAnaMenü_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnMuayenekayıt_Click(object sender, EventArgs e)
        {
            MuayeneKayit muayeneKayit = new MuayeneKayit();
            muayeneKayit.Show();
            this.Hide();
        }

        private void HastaEkleme_Load(object sender, EventArgs e)
        {
            Data("select * from hastatablosu");
        }

        private void BtnHastaEkle_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand HastaEkleme = new NpgsqlCommand();
            HastaEkleme.Connection = connect;

            HastaEkleme.Parameters.AddWithValue("@TcNo", Convert.ToInt64(txtTcNo.Text));
            HastaEkleme.Parameters.AddWithValue("@hastaAd", txtAd.Text);
            HastaEkleme.Parameters.AddWithValue("@hastaSoyad", txtSoyad.Text);
            HastaEkleme.Parameters.AddWithValue("@dogumYeri", txtDogumYeri.Text);
            HastaEkleme.Parameters.AddWithValue("@dogumTarihi", Convert.ToDateTime(dtimeDogumTarih.Value));
            HastaEkleme.Parameters.AddWithValue("@medeniDurum", txtmedeniDurum.Text);
            HastaEkleme.Parameters.AddWithValue("@adres", txtAdres.Text);
            HastaEkleme.Parameters.AddWithValue("@telNo", Convert.ToInt64(txtTelNo.Text));

            HastaEkleme.CommandType = CommandType.Text;
            HastaEkleme.CommandText = "insert into hastatablosu values (@TcNo, @hastaAd, @hastaSoyad, @dogumYeri, @dogumTarihi, @medeniDurum, @adres, @telNo)";

            NpgsqlDataReader dataread = HastaEkleme.ExecuteReader();
            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridHastaEkle.DataSource = data;
            }
            HastaEkleme.Dispose();
            connect.Close();

            Data("Select * from hastatablosu");
        }
    }
    }

