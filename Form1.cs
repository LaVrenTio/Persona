using Persone_Form.MyClasses;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
namespace Persone_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db_settings dbSet = new Db_settings();
        public bool isPersonOk = false;
        public string? prefix;
        Persona p = new();
        DataTable dataTable = new DataTable();
  




        private void InsertPerson_btn_Click(object sender, EventArgs e)
        {

        }

        private void nome_box_TextChanged(object sender, EventArgs e)
        {

        }


        private void confermi_btn_Click(object sender, EventArgs e)
        {
            if (!isPersonOk)
            {
                MessageBox.Show("Probabilmente mancano ancora dei campi fondamentali ");
            }
            using (SQLiteConnection connection = new SQLiteConnection(dbSet.ConnectionString))
            {
                connection.Open();
                string queryInsert = "INSERT INTO Persone (Nome, Cognome, Data_di_Nascita, Età, Email, Telefono) VALUES(" +
    $"'{nome_box.Text}', '{congome_txtBox.Text}', '{dateTimePicker1.Value.ToShortDateString()}'," +
    $"{Int32.Parse(eta_txtBox.Text)}, '{email_txtbox.Text}', '{Int32.Parse(telefono_Box.Text)}')";



                Query q = new(queryInsert);
                using (SQLiteCommand command = new SQLiteCommand(q.QueryText, connection))
                {
                    using (SQLiteDataAdapter adapter = new(command))
                    {

                        adapter.Fill(dataTable);
                        Person_GridView.DataSource = dataTable; 

                    }

                }
            }

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

        private char SetLetter(int num)
        {


            char lettera;
            switch (num)
            {
                case 0:
                    lettera = 'o';
                    break;
                case 1:
                    lettera = 'a';
                    break;
                case 2:
                    lettera = '*';
                    break;
                default:
                    lettera = '_';
                    break;
            }
            return lettera;

        }

        private void viewData_btn_Click(object sender, EventArgs e)
        {
            char lettera = SetLetter(genere_comboBox.SelectedIndex);

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

                isPersonOk = true;
            }


        }

        private void genere_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genere_comboBox.SelectedIndex == 0)
            {
                prefix = "Signor";
            }
            else if (genere_comboBox.SelectedIndex == 1)
            {
                prefix = "Signora";
            }
            else { prefix = "essere umano"; }

        }

        private void Person_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
