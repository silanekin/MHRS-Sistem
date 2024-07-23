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
    public partial class poliklinikkayıtdefter : Form
    {
        public poliklinikkayıtdefter()
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
                dtGridkayitdefter.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }

        private void Btnkayitdefter_Click(object sender, EventArgs e)
        {
            connect.Open();
            NpgsqlCommand defterekle = new NpgsqlCommand();
            defterekle.Connection = connect;

            defterekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dtimeTarih.Value));
            defterekle.Parameters.AddWithValue("@hastaad",txthastaAd.Text);
            defterekle.Parameters.AddWithValue("@hastasoyad", txthastaSoyad.Text);
            defterekle.Parameters.AddWithValue("@adres", txtAdres.Text);
            defterekle.Parameters.AddWithValue("@telefon", Convert.ToInt64(txtTelno.Text));

            defterekle.CommandType = CommandType.Text;
            defterekle.CommandText = "insert into poliklinikkayitdefter values (@tarih, @hastaad, @hastasoyad, @adres, @telefon)";

            NpgsqlDataReader dataread = defterekle.ExecuteReader();
            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridkayitdefter.DataSource = data;
            }
            defterekle.Dispose();
            connect.Close();

            Data("Select * from poliklinikkayitdefter");
        }

        private void poliklinikkayıtdefter_Load(object sender, EventArgs e)
        {
            Data("select * from poliklinikkayitdefter");
        }
    }
}
