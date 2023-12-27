using Persone_Form.MyClasses;

namespace Persone_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isPersonOk = false;
        public string prefix;
        Persona p= new Persona();

        private void InsertPerson_btn_Click(object sender, EventArgs e)
        {

        }

        private void nome_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void confermi_btn_Click(object sender, EventArgs e)
        {
            isPersonOk = true;

        }

        private void genere_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTimeToday = DateTime.Today;
            DateTime insertDataTime = dateTimePicker1.Value;
            int age = dateTimeToday.Year - insertDataTime.Year;

            eta_txtBox.Text = age.ToString();
            eta_txtBox.Visible = true;
            eta_lbl.Visible = true;

            if (dateTimePicker1.Value == DateTime.Now)
                MessageBox.Show("la persona è appena nata auguri");



        }

        private void viewData_btn_Click(object sender, EventArgs e)
        {
            char lettera;
            switch (prefix)
            {
                case "Signor": lettera = 'o';
                        break;
                case "Signora": lettera = 'a';
                    break;
                case "essere umano": lettera = '*';
                    break;
                default:lettera = '_';
                    break;
            }

            //FormPersonCreated personCreated= new FormPersonCreated(this);
            //personCreated.ShowDialog();
           DialogResult dr = MessageBox.Show($"Questi i dati inseriti {prefix}\n" +
                $"Nome: {nome_box.Text}" +
                $"\nCognome: {congome_txtBox.Text}" +
                $"\n nat{lettera} il: {dateTimePicker1.Value.ToShortDateString()}" +
                $"\n età: {eta_txtBox.Text}" +
                $"\n email: {email_txtbox.Text}" +
                $"\n telefono: {telefono_Box.Text}", "confermi?", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes)
            {

                p.Nome = nome_box.Text;
                p.Cognome = congome_txtBox.Text;
                p.Eta = Int32.Parse(eta_txtBox.Text);
                p.Email = email_txtbox.Text;
                p.Genere = genere_comboBox.Text;
                p.Telefono = Int32.Parse(telefono_Box.Text);
               
            }
            
            
        }

        private void genere_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(genere_comboBox.SelectedIndex == 0)
            {
                prefix = "Signor";
            }
            else if(genere_comboBox.SelectedIndex == 1)
            {
                prefix = "Signora";
            }
            else { prefix = "essere umano"; }

        }
    }
}
