namespace WinForms231226_walidacjaDanych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sprawdzaj(textBoxKod1.Text);
        }

        private void textBoxKod2_TextChanged(object sender, EventArgs e)
        {
            Sprawdzaj(textBoxKod2.Text);
        }

        private void Sprawdzaj(string s)
        {
            labelKomunikat.Text = "";
            if ( s != "")
            {
                //sprawdzamy ka¿dy znak
                foreach (char i in s)
                {
                    if (!Char.IsDigit(i))
                    {
                        labelKomunikat.Text +=
                            i + " nie jest cyfr¹\n";
                    }
                }
            }
            if (labelKomunikat.Text == "")
                labelKomunikat.Text = "nie ma b³êdu";
        }
    }
}