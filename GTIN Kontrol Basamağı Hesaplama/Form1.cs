using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace GTIN_Kontrol_Basamağı_Hesaplama
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            if (chkAutoGenerate.Checked)
            {
                AutoGenerateGTIN13();
            }
            else
            {
                ManualGenerateGTIN13();
            }

        }
        private void AutoGenerateGTIN13()
        {
            // Otomatik oluşturma için rastgele bir 12 haneli kısmi GTIN oluşturun
            Random rnd = new Random();
            string partialGTIN = "";
            for (int i = 0; i < 12; i++)
            {
                partialGTIN += rnd.Next(0, 10); // 0 ile 9 arasında rastgele rakamlar ekle
            }

            txtPartialGTIN.Text = partialGTIN; // Oluşturulan kısmi GTIN'i metin kutusuna yaz
            string fullGTIN = GenerateGTIN13(partialGTIN);
            txtGeneratedGTIN.Text = fullGTIN;
            txtKontrolBasamagi.Text = fullGTIN.Substring(12); // Son karakter kontrol basamağıdır.

        }
        private void ManualGenerateGTIN13()
        {
            string partialGTIN = txtPartialGTIN.Text.Trim();

            if (partialGTIN.Length != 12)
            {
                MessageBox.Show("Lütfen 12 haneli bir kısmi GTIN giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullGTIN = GenerateGTIN13(partialGTIN);
            txtGeneratedGTIN.Text = fullGTIN;
            txtKontrolBasamagi.Text = fullGTIN.Substring(12); // Son karakter kontrol basamağıdır.
        }
        private string GenerateGTIN13(string partialGTIN)
        {
            if (partialGTIN.Length != 12)
                throw new ArgumentException("12 haneli bir kısmi GTIN gereklidir.", nameof(partialGTIN));

            int[] digits = new int[13]; // Kontrol basamağı için yer açın.

            for (int i = 0; i < 12; i++)
            {
                digits[i] = partialGTIN[i] - '0'; // Karakterlerin sayısal değerlerini alın.
            }

            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += (i % 2 == 0) ? digits[i] : digits[i] * 3;
            }

            int checksum = (10 - (sum % 10)) % 10;
            digits[12] = checksum; // Kontrol basamağını ekle.

            return string.Concat(digits); // Diziyi birleştirin ve GTIN-13 olarak döndürün.
        }
        private void txtPartialGTIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayıları ve backspace tuşunu kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Sadece 12 basamaklı girişi kabul et
            if (txtPartialGTIN.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // Çoklu Üret
        private const int MaxItemCount = 200;
        private void btnCokluUret_Click(object sender, EventArgs e)
        {

            if (chkAutoGenerate.Checked)
            {

                int itemCount;
                if (!int.TryParse(txtKacAdet.Text, out itemCount) || itemCount <= 0 || itemCount > MaxItemCount)
                {
                    MessageBox.Show($"Lütfen geçerli bir sayı giriniz (1 - {MaxItemCount} arası).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GenerateGTINs(itemCount);

                txtKacAdet.ResetText();
            }
            else
            {
                MessageBox.Show("Otomatik Oluştur Seçili Değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void GenerateGTINs(int count)
        {
            listBoxGTINs.Items.Clear();
            listBoxTicariNumara.Items.Clear();
            listBoxKontrolBasamagi.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                string gtin = GenerateRandomGTIN13();
                string ticariNumara = GenerateTicariNumara(gtin);
                string kontrolBasamagi = CalculateControlDigit(gtin);

                listBoxGTINs.Items.Add(gtin);
                listBoxTicariNumara.Items.Add(ticariNumara);
                listBoxKontrolBasamagi.Items.Add(kontrolBasamagi);
            }
        }
        private string GenerateRandomGTIN13()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); // Her GTIN için yeni bir rastgele sayı dizisi oluştur
            string gtin = "";

            for (int i = 0; i < 12; i++)
            {
                gtin += rnd.Next(0, 10); // 0 ile 9 arasında rastgele rakamlar ekle
            }

            string controlDigit = CalculateControlDigit(gtin);
            return gtin + controlDigit;
        }

        private string GenerateTicariNumara(string gtin)
        {
            // GTIN'in ilk 6 hanesini Ticari Ürün Numarası olarak alalım
            return gtin.Substring(0, 12);
        }

        private string CalculateControlDigit(string partialGTIN)
        {
            int[] digits = new int[12];

            for (int i = 0; i < 12; i++)
            {
                digits[i] = partialGTIN[i] - '0'; // Karakterlerin sayısal değerlerini alın.
            }

            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += (i % 2 == 0) ? digits[i] : digits[i] * 3;
            }

            int checksum = (10 - (sum % 10)) % 10;

            return checksum.ToString();
        }

        private void listBoxTicariNumara_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxTicariNumara.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxGTINs.Items.Count)
            {
                listBoxGTINs.SelectedIndex = selectedIndex;
                listBoxKontrolBasamagi.SelectedIndex = selectedIndex;
            }

        }

        private void listBoxKontrolBasamagi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxKontrolBasamagi.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxGTINs.Items.Count)
            {
                listBoxGTINs.SelectedIndex = selectedIndex;
                listBoxTicariNumara.SelectedIndex = selectedIndex;
            }
        }

        private void listBoxGTINs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxGTINs.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxGTINs.Items.Count)
            {
                listBoxGTINs.SelectedIndex = selectedIndex;
                listBoxTicariNumara.SelectedIndex = selectedIndex;
            }
        }

        private void SaveToExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            worksheet.Cells[1, 1] = "Ticari Ürün Numarası";
            worksheet.Cells[1, 2] = "Kontrol Basamağı";
            worksheet.Cells[1, 3] = "Ticari Ürün Numarası (GTIN)";

            for (int i = 0; i < listBoxTicariNumara.Items.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = listBoxTicariNumara.Items[i].ToString();
                worksheet.Cells[i + 2, 2] = listBoxKontrolBasamagi.Items[i].ToString();
                worksheet.Cells[i + 2, 3] = listBoxGTINs.Items[i].ToString();
            }

            // Excel hücre biçimlendirmesi
            Excel.Range range = worksheet.UsedRange;
            range.NumberFormat = "0"; // Tüm hücreleri tamsayı olarak biçimlendir

            // Excel dosyasını kaydet
            string excelFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GTINs.xlsx");
            workbook.SaveAs(excelFileName);

            MessageBox.Show("Veriler Excel'e aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string directoryPath = Path.GetDirectoryName(excelFileName);
            System.Diagnostics.Process.Start(directoryPath);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveToExcel();
        }

        private void SaveToText()
        {
            string textFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GTINs.txt");
            using (StreamWriter writer = new StreamWriter(textFileName))
            {
                writer.WriteLine("TÜN         \tKB    \tTicari Ürün Numarası (GTIN)");
                for (int i = 0; i < listBoxTicariNumara.Items.Count; i++)
                {
                    string ticari = listBoxTicariNumara.Items[i].ToString();
                    string kontrolBasamagi = listBoxKontrolBasamagi.Items[i].ToString();
                    string gtin = listBoxGTINs.Items[i].ToString();
                    writer.WriteLine($"{ticari}\t{kontrolBasamagi}\t{gtin}");
                }
            }

            MessageBox.Show("Veriler metin dosyasına aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Dosya yolunu aç
            string directoryPath = Path.GetDirectoryName(textFileName);
            System.Diagnostics.Process.Start(directoryPath);
        }

        private void btnMetin_Click(object sender, EventArgs e)
        {
            SaveToText();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Kullandığınız için teşekkürler. Program ücretsizdir");
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBoxGTINs.Items.Clear();
            listBoxKontrolBasamagi.Items.Clear();
            listBoxTicariNumara.Items.Clear();
        }
    }
}
