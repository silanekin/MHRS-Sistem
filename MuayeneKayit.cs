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
    public partial class MuayeneKayit : Form
    {
        public MuayeneKayit()
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
                dtGridMuayeneKayit.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }
        private void BtnMuayeneEkrani_Click(object sender, EventArgs e)
        {
            MuayeneEkrani muayeneEkrani = new MuayeneEkrani();
            muayeneEkrani.Show();
            this.Hide();
           
        }

        private void MuayeneKayit_Load(object sender, EventArgs e)
        {
            Data("select * from hastatablosu");
        }

        private void BtnMuayeneKayit_Click(object sender, EventArgs e)
        {
            Data("select * from hastatablosu where tcno = '" + txtTcNO.Text + "'");
        }
    }
}
