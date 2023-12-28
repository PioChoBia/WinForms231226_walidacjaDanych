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
            richTextBoxKod1.Text = Sprawdzaj(textBoxKod1.Text);
        }

        private void textBoxKod2_TextChanged(object sender, EventArgs e)
        {
            richTextBoxKod2.Text = Sprawdzaj(textBoxKod2.Text);
        }

        private string Sprawdzaj(string s)
        {
            string bledy = "";
            if ( s != "")
            {
                //sprawdzamy ka¿dy znak
                foreach (char i in s)
                {
                    if (!Char.IsDigit(i))
                    {
                        bledy +=
                            i + " nie jest cyfr¹\n";
                    }
                }
            }
            return bledy;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            richTextBoxMaska.Text = "wprowadzony tekst: "+maskedTextBoxValidating.MaskedTextProvider;
            richTextBoxMaska.Text += "\nmaska: " + maskedTextBoxValidating.Mask;         
        }

        private void textBoxValidating_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (textBoxValidating.Text == "")
            {
                richTextBoxValidating.Text =
                    "nie wyjdziesz z kontrolki zblokowana\na¿ do coœ wpiszesz";
                e.Cancel = true;
                return;
            }
            else
            {
                richTextBoxValidating.Text = "";
                e.Cancel = true;
            }
        }

        private void textBoxValidated_Validated(object sender, EventArgs e)
        {

        }
    }
}