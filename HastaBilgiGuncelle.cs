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
    public partial class HastaBilgiGuncelle : Form
    {
        public HastaBilgiGuncelle()
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
               dtgridHastaguncelle.DataSource = database;
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

        private void BtnHastaGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand UpdateCommand = new NpgsqlCommand();
            UpdateCommand.Connection = connection;

            
            UpdateCommand.Parameters.AddWithValue("@hastaAd", txtAd.Text);
            UpdateCommand.Parameters.AddWithValue("@hastaSoyad", txtSoyad.Text);
            UpdateCommand.Parameters.AddWithValue("@dogumYeri",txtDogumYeri.Text);
            UpdateCommand.Parameters.AddWithValue("@dogumTarihi", Convert.ToDateTime(dtimeDogumTarih.Value));
            UpdateCommand.Parameters.AddWithValue("@medeniDurum", txtmedeniDurum.Text);
            UpdateCommand.Parameters.AddWithValue("@adres", txtAdres.Text);
            UpdateCommand.Parameters.AddWithValue("@telNo", Convert.ToInt64(txtTelNo.Text));

            UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.CommandText = "insert into hastatablosu values ( @hastaAd, @hastaSoyad, @dogumYeri, @dogumTarihi, @medeniDurum, @adres, @telNo)";
            NpgsqlDataReader dataread = UpdateCommand.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable database = new DataTable();
                database.Load(dataread);
                dtgridHastaguncelle.DataSource = database;
            }

            UpdateCommand.Dispose();
            connection.Close();

            
        }

        private void HastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            showData("select * from hastatablosu");
        }
    }
}
