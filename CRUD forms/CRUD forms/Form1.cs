using System;
using funzioni;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace CRUD_forms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        prodotto[] eleP = new prodotto[1000];
        int num = default;

        string[] filecaricati = new string[1000];
        int numFile = default;

        //Tab 1----------------------------------------------------------------------------------------------------------------------------------------------------

        private void Inserisci(object sender, EventArgs e)
        {
            prodotto Nuovo = default;

            //Codice
            bool valido = MyLibrary.ControllaCodice(num, eleP, txtCod.Text);
            if (!valido)
                txtCod.Text = "Codice non valido";
            Nuovo.codice = txtCod.Text;

            //Nome
            Nuovo.nome = txtNome.Text;

            //Categoria
            Nuovo.categoria = txtCat.Text;

            //Scorte
            if (!int.TryParse(txtQt.Text, out int ProvaSco))
            {
                txtQt.Text = "Numero non valido";
                valido = false;
            }
            else if (ProvaSco < 0)
            {
                txtQt.Text = "Numero non valido";
                valido = false;
            }
            else
            {
                Nuovo.scorte = ProvaSco;
            }

            //Prezzo
            if (!Decimal.TryParse(txtPre.Text, out decimal provaPre))
            {
                txtPre.Text = "Prezzo non valido";
                valido = false;
            }
            else if (provaPre < 0)
            {
                txtPre.Text = "Prezzo non valido";
                valido = false;
            }
            else
            {
                Nuovo.prezzo = provaPre;
            }

            if (!DateTime.TryParse(txtDat.Text, out DateTime ProvaDat))
            {
                txtDat.Text = "Data non valida";
                valido = false;
            }
            else
            {
                Nuovo.data = ProvaDat;
            }

            if (valido)
            {
                DialogResult a = MessageBox.Show("Inserire questo prodotto?", "Prodotto valido", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (a == DialogResult.Yes)
                {
                    eleP[num] = Nuovo;
                    num += 1;
                    MessageBox.Show("Prodotto inserito correttamente");
                }
            }

            if (!valido)
            {
                DialogResult ErroreSco = MessageBox.Show("Errore, Hai inserito un campo non valido", "Non è possibile inserire il prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void nonNumeri(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(e.KeyChar.ToString(), out int p))
                e.Handled = true;
        }

        private void nonSpazio(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        //Tab 2-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void OrdinaPrezzo(object sender, EventArgs e)
        {
            MyLibrary.Prezzo(num, eleP);

            int x = 0;
            /*
            listBox1.Items.Clear();
            /*
            listBox1.Items.Add("Codice\tNome\t\tCategoria\t\tNumero scorte\tPrezzo prodotto\tDiscponibile dal");
            /*
            while (x<num)
            {
                if(eleP[x].nome.Length > 8)
                listBox1.Items.Add(eleP[x].codice + "\t"+ eleP[x].nome + "\t"+eleP[x].categoria + "\t"+ eleP[x].scorte.ToString() + "\t"+ eleP[x].prezzo.ToString() + "\t"+ eleP[x].data.ToString("dd/MM/yyyy")+ "   ");
                else
                    listBox1.Items.Add(eleP[x].codice + "\t" + eleP[x].nome + "\t\t" + eleP[x].categoria + "\t" + eleP[x].scorte.ToString() + "\t" + eleP[x].prezzo.ToString() + "\t" + eleP[x].data.ToString("dd/MM/yyyy") + "   ");

                x++;
            }*/

            ListViewItem riga = default(ListViewItem);
            listView1.Items.Clear();

            while (x < num)
            {
                riga = new ListViewItem(new string[]
                {
                    eleP[x].codice,
                    eleP[x].nome,
                    eleP[x].categoria,
                    eleP[x].scorte.ToString(),
                    eleP[x].prezzo.ToString("0.00"),
                    eleP[x].data.ToString("dd/MM/yyyy")});
                listView1.Items.Add(riga);

                x++;
            }

        }


        private void OrdinaCodice(object sender, EventArgs e)
        {
            MyLibrary.Codice(num, eleP);

            int x = 0;

            ListViewItem riga = default;
            listView1.Items.Clear();

            while (x < num)
            {
                riga = new ListViewItem(new string[]
                {
                    eleP[x].codice,
                    eleP[x].nome,
                    eleP[x].categoria,
                    eleP[x].scorte.ToString(),
                    eleP[x].prezzo.ToString("0.00"),
                    eleP[x].data.ToString("dd/MM/yyyy")}
                );
                listView1.Items.Add(riga);

                x++;
            }
        }

        //Tab 3------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Salva(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFile.Text))
            {
                MessageBox.Show("Non hai inserito un nome valido");
                MessageBox.Show("Prodotti inseriti correttamente");
                return;
            }

            if(File.Exists(txtFile.Text + ".txt"))
            {
                MyLibrary.SalvaFile(num, eleP, txtFile.Text + ".txt");
                MessageBox.Show("Prodotti salvati correttamente");
                return;
            }

            DialogResult a = MessageBox.Show("File già esistente", "Hai già un file con questo nome, sostituirlo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(a == DialogResult.No || a == DialogResult.Abort)
            {
                return;
            }

            string spostato = $"{Path.GetFileNameWithoutExtension(txtFile.Text)}_{DateTime.Now.ToString("dd/MM/yyyy-HH:mm:ss")}.bak";
            File.Move(txtFile.Text, spostato);

            MyLibrary.SalvaFile(num, eleP, txtFile.Text);
            MessageBox.Show("Prodotti salvati correttamente");
        }

        private void Carica(object sender, EventArgs e)
        {

            int b = 0;
            string file = txtFile.Text;

            bool caricato = false;
            while (b < numFile)
            {
                if (filecaricati[b] == file)
                {
                    caricato = true;
                    break;
                }
                b++;
            }

            if (caricato)
            {
                DialogResult a = MessageBox.Show("Hai già inserito i dati di questo file");
                return;
            }
            if (!caricato)
            {
                filecaricati[numFile] = file;
                numFile++;

            }

            bool trovato = MyLibrary.LeggiFile(ref num, eleP, file);


            if (!trovato)          //else
            {
                DialogResult a = MessageBox.Show("Nessun file trovato");
                return;
            }

            MessageBox.Show("File letto correttamente", "Lettura di un file", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Tab 4-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Cerca(object sender, EventArgs e)
        {
            box_src.Items.Clear();

            int x = 0;

            while (x < num)
            {
                if (eleP[x].codice.Contains(txt_src.Text) || eleP[x].nome.Contains(txt_src.Text))
                {
                    box_src.Items.Add(eleP[x].codice + "      " + eleP[x].nome + "\t" + eleP[x].categoria + "\t" + eleP[x].scorte.ToString() + "\t" + eleP[x].prezzo.ToString() + "\t" + eleP[x].data.ToString("dd/MM/yyyy"));
                }

                x++;
            }
        }

        private void Selezione(object sender, EventArgs e)
        {
            int k = 0;
            int x = 0;



            while (x < num)
            {
                if (box_src.SelectedItem.ToString().Split(' ')[0] == eleP[x].codice)
                {
                    break;
                }

                x++;
            }


            k = box_src.SelectedIndex;

            if (k == -1) return;


            editCod.Text = eleP[x].codice;
            editNom.Text = eleP[x].nome;
            editCat.Text = eleP[x].categoria;
            editQt.Text = eleP[x].scorte.ToString();
            EditPre.Text = eleP[x].prezzo.ToString("0.00");
            editDat.Text = eleP[x].data.ToString("dd/MM/yyyy");

            btn_edit.Enabled = true;
        }

        private void Modifica(object sender, EventArgs e)
        {
            int x = 0;

            while (x < num)
            {
                if (eleP[x].codice == editCod.Text)
                {
                    break;
                }
                x++;
            }

            bool valido = true;
            prodotto Nuovo = default;

            //Nome
            Nuovo.nome = editNom.Text;

            //Categoria
            Nuovo.categoria = editCat.Text;

            //Scorte
            if (!int.TryParse(editQt.Text, out int ProvaSco))
            {
                editQt.Text = "Numero non valido";
                valido = false;
            }
            else
            {
                Nuovo.scorte = ProvaSco;
            }

            //Prezzo
            if (!Decimal.TryParse(EditPre.Text, out decimal provaPre))
            {
                EditPre.Text = "Prezzo non valido";
                valido = false;
            }
            else if (provaPre < 0)
            {
                EditPre.Text = "Prezzo non valido";
                valido = false;
            }
            else
            {
                Nuovo.prezzo = provaPre;
            }

            if (!DateTime.TryParse(editDat.Text, out DateTime ProvaDat))
            {
                editDat.Text = "Data non valida";
                valido = false;
            }
            else
            {
                Nuovo.data = ProvaDat;
            }

            if (valido)
            {
                eleP[x] = Nuovo;
                MessageBox.Show("Prodotto modificato correttamente");

                editCod.Text = "";
                editNom.Text = "";
                editCat.Text = "";
                editQt.Text = "";
                EditPre.Text = "";
                editDat.Text = "";

                btn_edit.Enabled = false;
            }

            if (!valido)
            {
                DialogResult ErroreSco = MessageBox.Show("Errore, Hai inserito un campo non valido", "Non è possibile modificare il prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
