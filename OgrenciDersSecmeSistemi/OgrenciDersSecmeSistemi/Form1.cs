using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace OgrenciDersSecmeSistemi
{
    public partial class Form1 : Form
    {
        // Örnek veri yapıları
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        List<Ders> dersler = new List<Ders>();

        public Form1()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için yardımcı sınıf
        public class DatabaseHelper
        {
            private string connectionString = ConfigurationManager.ConnectionStrings["ogubsConnectionString"].ConnectionString;

            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }

            // Öğrencileri veritabanından çekme
            public List<Ogrenci> GetOgrenciler()
            {
                List<Ogrenci> ogrenciler = new List<Ogrenci>();

                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Ad, Soyad, Gano FROM Ogrenciler";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string ad = reader["Ad"].ToString();
                        string soyad = reader["Soyad"].ToString();
                        double gano = Convert.ToDouble(reader["Gano"]);
                        ogrenciler.Add(new Ogrenci(ad, soyad, gano));
                    }
                }
                return ogrenciler;
            }

            // Dersleri veritabanından çekme
            public List<Ders> GetDersler()
            {
                List<Ders> dersler = new List<Ders>();

                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Ad, Kredi, Kontenjan FROM Dersler";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string ad = reader["Ad"].ToString();
                        int kredi = Convert.ToInt32(reader["Kredi"]);
                        int kontenjan = Convert.ToInt32(reader["Kontenjan"]);
                        dersler.Add(new Ders(ad, kredi, kontenjan));
                    }
                }
                return dersler;
            }

            // Öğrenci ekleme
            public void AddOgrenci(Ogrenci ogrenci)
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Ogrenciler (Ad, Soyad, Gano) VALUES (@Ad, @Soyad, @Gano)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", ogrenci.Ad);
                    command.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
                    command.Parameters.AddWithValue("@Gano", ogrenci.Gano);
                    command.ExecuteNonQuery();
                }
            }

            // Ders ekleme
            public void AddDers(Ders ders)
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Dersler (Ad, Kredi, Kontenjan) VALUES (@Ad, @Kredi, @Kontenjan)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", ders.Ad);
                    command.Parameters.AddWithValue("@Kredi", ders.Kredi);
                    command.Parameters.AddWithValue("@Kontenjan", ders.Kontenjan);
                    command.ExecuteNonQuery();
                }
            }
        }


        // Öğrenci ekleme
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            double gano = Convert.ToDouble(txtGano.Text);

            Ogrenci ogrenci = new Ogrenci(ad, soyad, gano);
            ogrenciler.Add(ogrenci);
            // Veritabanına ekleme
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.AddOgrenci(ogrenci);
            // Öğrenciler listesine ekleme
            UpdateOgrenciList();
        }



        // Öğrenci listeyi güncelleme
        private void UpdateOgrenciList()
        {
            // DataGridView'in veri kaynağını sıfırlıyoruz
            dgvOgrenciler.Rows.Clear();

            // Veritabanından güncel veriyi almak
            DatabaseHelper dbHelper = new DatabaseHelper();
            ogrenciler = dbHelper.GetOgrenciler();

            // Yeniden veriyi DataGridView'e yüklemek
            foreach (var ogrenci in ogrenciler)
            {
                dgvOgrenciler.Rows.Add(ogrenci.Ad, ogrenci.Soyad, ogrenci.Gano);
            }
        }
        // Ders ekleme
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            string dersAdı = txtDersAdı.Text;
            int kredi = Convert.ToInt32(txtKredi.Text);
            int kontenjan = Convert.ToInt32(txtKontenjan.Text);

            Ders ders = new Ders(dersAdı, kredi, kontenjan);
            dersler.Add(ders);

            // Veritabanına ekleme
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.AddDers(ders);

            // Dersler listesine ekleme
            UpdateDersList();
        }


        // Ders listeyi güncelleme
        private void UpdateDersList()
        {
            lbSeçilebilirDersler.Items.Clear();
            foreach (var ders in dersler)
            {
                lbSeçilebilirDersler.Items.Add(ders.Ad);
            }
        }

        // Öğrenci panelinde ders ekleme
        private void btnDersEkleOgrenci_Click(object sender, EventArgs e)
        {
            if (lbSeçilebilirDersler.SelectedItem != null)
            {
                string dersAdı = lbSeçilebilirDersler.SelectedItem.ToString();
                Ders secilenDers = dersler.Find(d => d.Ad == dersAdı);
                // Gano'ya göre kredi sınırı kontrolü
                Ogrenci ogrenci = ogrenciler[0];  // Varsayılan öğrenci seçildi
                int toplamKredi = ogrenci.ToplamKredi();
                if (ogrenci.Gano >= 3 && toplamKredi + secilenDers.Kredi <= 30)
                {
                    lbSeçilenDersler.Items.Add(secilenDers.Ad);
                    ogrenci.DersEkle(secilenDers);
                    UpdateToplamKredi();
                }
                else if (ogrenci.Gano < 3 && toplamKredi + secilenDers.Kredi <= 21)
                {
                    lbSeçilenDersler.Items.Add(secilenDers.Ad);
                    ogrenci.DersEkle(secilenDers);
                    UpdateToplamKredi();
                }
                else
                {
                    MessageBox.Show("Kredi sınırını aştınız!");
                }
            }
        }

        // Öğrenci panelinde ders silme
        private void btnDersSilOgrenci_Click(object sender, EventArgs e)
        {
            if (lbSeçilenDersler.SelectedItem != null)
            {
                string dersAdı = lbSeçilenDersler.SelectedItem.ToString();
                Ders silinecekDers = dersler.Find(d => d.Ad == dersAdı);

                // Ders silme işlemi
                Ogrenci ogrenci = ogrenciler[0];  // Varsayılan öğrenci seçildi
                ogrenci.DersSil(silinecekDers);

                lbSeçilenDersler.Items.Remove(silinecekDers.Ad);
                UpdateToplamKredi();
            }
        }

        // Toplam kredi güncelleme
        private void UpdateToplamKredi()
        {
            Ogrenci ogrenci = ogrenciler[0];  // Varsayılan öğrenci seçildi
            lblToplamKredi.Text = "Toplam Kredi: " + ogrenci.ToplamKredi();
        }

        // Öğrenci derslerini göndermek için onay isteği
        private void btnGönder_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = ogrenciler[0];  // Varsayılan öğrenci seçildi
            DanismanOnayla(ogrenci);
        }

        // Danışman onaylama işlemi
        private void DanismanOnayla(Ogrenci ogrenci)
        {
            // Danışman onayı kontrolü
            if (ogrenci.Dersler.Count > 0)
            {
                MessageBox.Show("Dersler onaylandı!");
            }
            else
            {
                MessageBox.Show("Ders seçmediniz.");
            }
        }

        // Danışman onayla
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Öğrencinin ders listesini onaylama
            MessageBox.Show("Dersler onaylandı.");
        }

        // Danışman geri gönder
        private void btnGeriGönder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dersler düzenleme için geri gönderildi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veriler güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veriler silindi.");
        }

        private void tabPageOgrenciIsleri_Click(object sender, EventArgs e)
        {

        }

        private void txtDersAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // DataGridView'i veritabanı verisiyle güncelleyen metot
        private void LoadDataGrid()
        {
            string connectionString = "YourConnectionStringHere";
            string query = "SELECT * FROM OgrenciDersleri";  // Tabloyu istediğiniz şekilde düzenleyin

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // DataGridView'i verilerle güncelle
                dgvOgrenciler.DataSource = dataTable;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogubsDataSet1.OgrenciDersleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciDersleriTableAdapter.Fill(this.ogubsDataSet1.OgrenciDersleri);
            // TODO: Bu kod satırı 'ogubsDataSet.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.ogubsDataSet.Ogrenciler);

        }
    }

    // Öğrenci sınıfı
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Gano { get; set; }
        public List<Ders> Dersler { get; set; }

        public Ogrenci(string ad, string soyad, double gano)
        {
            Ad = ad;
            Soyad = soyad;
            Gano = gano;
            Dersler = new List<Ders>();
        }

        public void DersEkle(Ders ders)
        {
            Dersler.Add(ders);
        }

        public void DersSil(Ders ders)
        {
            Dersler.Remove(ders);
        }

        public int ToplamKredi()
        {
            int toplamKredi = 0;
            foreach (var ders in Dersler)
            {
                toplamKredi += ders.Kredi;
            }
            return toplamKredi;
        }
    }

    // Ders sınıfı
    public class Ders
    {
        public string Ad { get; set; }
        public int Kredi { get; set; }
        public int Kontenjan { get; set; }

        public Ders(string ad, int kredi, int kontenjan)
        {
            Ad = ad;
            Kredi = kredi;
            Kontenjan = kontenjan;
        }
    }
}
