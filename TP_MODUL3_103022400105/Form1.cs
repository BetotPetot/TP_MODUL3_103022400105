namespace TP_MODUL3_103022400105
{
    public partial class Form1 : Form
    {
        // Variabel untuk menyimpan total hasil perhitungan
        double total = 0;
        // Variabel untuk menyimpan angka yang sedang diinput user
        string input = "";
        // Variabel untuk menampilkan teks pada label (tampilan kalkulator)
        string display = "";
        public Form1()
        {
            InitializeComponent();
        }

        // Event ketika tombol angka 6 ditekan
        private void button6_Click(object sender, EventArgs e)
        {
            input += "6"; // Menambahkan angka 6 ke input
            display += "6"; // Menambahkan angka 6 ke tampilan
            label1.Text = display; // Menampilkan hasil pada label
        }

        // Event ketika tombol angka 8 ditekan
        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            display += "8";
            label1.Text = display;
        }

        // Event ketika tombol angka 1 ditekan
        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            display += "1";
            label1.Text = display;
        }

        // Event ketika tombol angka 2 ditekan
        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            display += "2";
            label1.Text = display;
        }

        // Event ketika tombol angka 3 ditekan
        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            display += "3";
            label1.Text = display;
        }

        // Event ketika tombol angka 4 ditekan
        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            display += "4";
            label1.Text = display;
        }

        // Event ketika tombol angka 5 ditekan
        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            display += "5";
            label1.Text = display;
        }

        // Event ketika tombol angka 7 ditekan
        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            display += "7";
            label1.Text = display;
        }

        // Event ketika tombol angka 9 ditekan
        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            display += "9";
            label1.Text = display;
        }

        // Event ketika tombol operator tambah (+) ditekan
        private void button10_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(input);
            display += " + ";
            input = "";
            label1.Text = display;
        }

        // Event ketika tombol angka 0 ditekan
        private void button11_Click(object sender, EventArgs e)
        {
            input += "0";
            display += "0";
            label1.Text = display;
        }

        // Event ketika tombol sama dengan (=) ditekan
        private void button12_Click(object sender, EventArgs e)
        {
            // Menambahkan input terakhir ke total
            total += Convert.ToDouble(input);
            // Menampilkan hasil perhitungan pada layar
            display += " = " + total.ToString();
            label1.Text = display;
            // Hasil dijadikan input baru agar bisa lanjut dihitung
            input = total.ToString();
            // Tampilan direset menjadi hasil saja
            display = input;
            // Total direset untuk perhitungan selanjutnya
            total = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
