namespace BerGEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string arananMetin = maskedTextBox1.Text;

                string[] satirlar = richTextBox1.Lines;
                richTextBox2.Clear(); 

                foreach (string satir in satirlar)
                {
                    if (satir.Contains(arananMetin))
                    {
                        richTextBox2.AppendText(satir + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatasý: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = saveFileDialog1.FileName;
                    File.WriteAllText(dosyaYolu, richTextBox2.Text);
                    MessageBox.Show("Veriler baþarýyla dýþa aktarýldý.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dýþa aktarma hatasý: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = openFileDialog1.FileName;
                    string dosyaIcerigi = File.ReadAllText(dosyaYolu);
                    richTextBox1.Text = dosyaIcerigi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatasý: " + ex.Message);
            }
        }
    }
}
