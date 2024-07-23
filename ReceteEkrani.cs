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
    public partial class ReceteEkrani : Form
    {
        public ReceteEkrani()
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
                dtGridReceteGoruntule.DataSource = data;
            }
            command.Dispose();
            connect.Close();
        }
        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
           form1.Show();
           this.Hide();
        }

        private void BtnReceteYazdir_Click(object sender, EventArgs e)
        {

            connect.Open();
            NpgsqlCommand Recete = new NpgsqlCommand();
            Recete.Connection = connect;

            Recete.Parameters.AddWithValue("@receteno", Convert.ToInt64(txtreceteNo.Text));
            Recete.Parameters.AddWithValue("@muayenetarihi", Convert.ToDateTime(dtimeMuayene.Value));
           
            Recete.Parameters.AddWithValue("@ilac1", ilac1.Text);
            Recete.Parameters.AddWithValue("@ilac1kullanilacakdoz", txtDoz1.Text);
            Recete.Parameters.AddWithValue("@ilac1kullanilacakgunsayisi", Convert.ToInt64(txtkullannilacakgun1.Text));
            Recete.Parameters.AddWithValue("@ilac2", ilac2.Text);
            Recete.Parameters.AddWithValue("@ilac2kullanilacakdoz", txtDoz2.Text);
            Recete.Parameters.AddWithValue("@ilac2kullanilacakgunsayisi", Convert.ToInt64(txtkullannilacakgun2.Text));
            Recete.Parameters.AddWithValue("@ilac3", ilac3.Text);
            Recete.Parameters.AddWithValue("@ilac3kullanilacakdoz", txtDoz3.Text);
            Recete.Parameters.AddWithValue("@ilac3kullanilacakgunsayisi", Convert.ToInt64(txtkullannilacakgun3.Text));
            Recete.Parameters.AddWithValue("@ilac4", ilac4.Text);
            Recete.Parameters.AddWithValue("@ilac4kullanilacakdoz", txtDoz4.Text);
            Recete.Parameters.AddWithValue("@ilac4kullanilacakgunsayisi", Convert.ToInt64(txtkullannilacakgun4.Text));
            Recete.Parameters.AddWithValue("@ilac5", ilac5.Text);
            Recete.Parameters.AddWithValue("@ilac5kullanilacakdoz", txtDoz5.Text);
            Recete.Parameters.AddWithValue("@ilac5kullanilacakgunsayisi", Convert.ToInt64(txtkullannilacakgun5.Text));

            Recete.CommandType = CommandType.Text;
            Recete.CommandText = "insert into recetetablosu values (@receteno, @muayenetarihi, @ilac1, @ilac1kullanilacakdoz, @ilac1kullanilacakgunsayisi, @ilac2, @ilac2kullanilacakdoz, @ilac2kullanilacakgunsayisi, @ilac3, @ilac3kullanilacakdoz, @ilac3kullanilacakgunsayisi, @ilac4, @ilac4kullanilacakdoz, @ilac4kullanilacakgunsayisi, @ilac5, @ilac5kullanilacakdoz, @ilac5kullanilacakgunsayisi)";

            NpgsqlDataReader dataread = Recete.ExecuteReader();
            if (dataread.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataread);
                dtGridReceteGoruntule.DataSource = data;
            }
            Recete.Dispose();
            connect.Close();

            Data("Select * from recetetablosu");
        

    }

        private void cmbilac1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilac1.Items.Add("1");
            cmbilac1.Items.Add("2");
            cmbilac1.Items.Add("3");
        }

        private void cmbilac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilac2.Items.Add("1");
            cmbilac2.Items.Add("2");
            cmbilac2.Items.Add("3");
        }

        private void cmbilac3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilac3.Items.Add("1");
            cmbilac3.Items.Add("2");
            cmbilac3.Items.Add("3");
        }

        private void cmbilac4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilac4.Items.Add("1");
            cmbilac4.Items.Add("2");
            cmbilac4.Items.Add("3");
        }

        private void cmbilac5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilac5.Items.Add("1");
            cmbilac5.Items.Add("2");
            cmbilac5.Items.Add("3");
        }
    }
}
