using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BeslenmeTakipSistemi
{
    public partial class Register : Form
    {
        BaglantiSQL bag = new BaglantiSQL();  // Bağlantı nesnesi
        SqlCommand komut = new SqlCommand();  // SQL komut nesnesi

        public Register()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbAd.Text) ||
        string.IsNullOrWhiteSpace(tbSoyad.Text) ||
        string.IsNullOrWhiteSpace(tbregmail.Text) ||
        string.IsNullOrWhiteSpace(tbRegSifre.Text) ||
        cbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kayıt işlemini durdur
            }


            if (!KayitVarMi()) // Kayıt yoksa ekleme yapılabilir
            {
                try
                {
                    string sorgu = @"INSERT INTO Users
                        (Name, Surname, BirthDate, Gender, Email, PasswordHash)
                        VALUES 
                        (@name, @surname, @birthdate, @gender, @email, @passwordhash)";

                    komut = new SqlCommand(sorgu, bag.baglan());

                    komut.Parameters.AddWithValue("@name", tbAd.Text.Trim());
                    komut.Parameters.AddWithValue("@surname", tbSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@birthdate", dateTimeDg.Value);

                    string gender = cbCinsiyet.SelectedItem.ToString();
                    if (gender == "Kadın")
                        gender = "Female";
                    else if (gender == "Erkek")
                        gender = "Male";
                    komut.Parameters.AddWithValue("@gender", gender);

                    komut.Parameters.AddWithValue("@email", tbregmail.Text.Trim());
                    komut.Parameters.AddWithValue("@passwordhash", Hashle(tbRegSifre.Text.Trim())); // Şifre hashleniyor

                    komut.ExecuteNonQuery();
                    komut.Connection.Close();

                    MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu e-posta ile zaten bir kullanıcı kayıtlı.");
            }
        }

        private bool KayitVarMi()
        {
            bool varMi = false;
            string sorgu = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            komut = new SqlCommand(sorgu, bag.baglan());
            komut.Parameters.AddWithValue("@Email", tbregmail.Text.Trim());

            int sayi = (int)komut.ExecuteScalar(); // Kullanıcı sayısını alır
            if (sayi > 0)
                varMi = true;

            komut.Connection.Close();
            return varMi;
        }

        private string Hashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(sifre);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
