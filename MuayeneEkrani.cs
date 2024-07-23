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
    public partial class MuayeneEkrani : Form
    {
        public MuayeneEkrani()
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
                dtGridSikayetKayit.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }
        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReceteYaz_Click(object sender, EventArgs e)
        {
            ReceteEkrani receteEkrani = new ReceteEkrani();
            receteEkrani.Show();
            this.Hide();
        }

        private void MuayeneEkrani_Load(object sender, EventArgs e)
        {
            Data("select * from muayenetablosu");
        }

        private void BtnHastalikKayit_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand MuayeneKaydi = new NpgsqlCommand();
            MuayeneKaydi.Connection = connect;

            MuayeneKaydi.Parameters.AddWithValue("@tcno", Convert.ToInt64(txtTCNo.Text));
            MuayeneKaydi.Parameters.AddWithValue("@muayenetarih", Convert.ToDateTime(dtimemuayene.Value));
            MuayeneKaydi.Parameters.AddWithValue("@hastasikayeti", txtSikayet.Text);
            MuayeneKaydi.Parameters.AddWithValue("@doktoruntanisi", txtTani.Text);
            MuayeneKaydi.Parameters.AddWithValue("@yapilacaktedavi", txtTedavi.Text);


            MuayeneKaydi.CommandType = CommandType.Text;
            MuayeneKaydi.CommandText = "insert into muayenetablosu values (@tcno, @muayenetarih, @hastasikayeti, @doktoruntanisi, @yapilacaktedavi )";

            NpgsqlDataReader dataread = MuayeneKaydi.ExecuteReader();
            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridSikayetKayit.DataSource = data;
            }
            MuayeneKaydi.Dispose();
            connect.Close();

            Data("Select * from muayenetablosu");
        }
    }
    }
    

