
namespace CRUD_forms
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader Codice;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.titolo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDat = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titolo2 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Scorte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_src = new System.Windows.Forms.Button();
            this.editNom = new System.Windows.Forms.TextBox();
            this.editDat = new System.Windows.Forms.TextBox();
            this.EditPre = new System.Windows.Forms.TextBox();
            this.editQt = new System.Windows.Forms.TextBox();
            this.editCat = new System.Windows.Forms.TextBox();
            this.editCod = new System.Windows.Forms.TextBox();
            this.box_src = new System.Windows.Forms.ListBox();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            Codice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Codice
            // 
            Codice.Text = "Codice";
            Codice.Width = 83;
            // 
            // titolo
            // 
            this.titolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titolo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titolo.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titolo.Location = new System.Drawing.Point(20, 20);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(760, 50);
            this.titolo.TabIndex = 0;
            this.titolo.Text = "Gestione prodotti";
            this.titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(20, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 340);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDat);
            this.tabPage1.Controls.Add(this.txtPre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtQt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.titolo2);
            this.tabPage1.Controls.Add(this.txtCat);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtCod);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserimento";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(40, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data di arrivo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDat
            // 
            this.txtDat.Location = new System.Drawing.Point(215, 274);
            this.txtDat.Name = "txtDat";
            this.txtDat.Size = new System.Drawing.Size(200, 20);
            this.txtDat.TabIndex = 12;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(215, 234);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(200, 20);
            this.txtPre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(40, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantità del prodotto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQt
            // 
            this.txtQt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQt.Location = new System.Drawing.Point(215, 194);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(200, 20);
            this.txtQt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(40, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prezzo del prodotto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titolo2
            // 
            this.titolo2.BackColor = System.Drawing.Color.SkyBlue;
            this.titolo2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo2.Location = new System.Drawing.Point(20, 20);
            this.titolo2.Name = "titolo2";
            this.titolo2.Size = new System.Drawing.Size(712, 34);
            this.titolo2.TabIndex = 7;
            this.titolo2.Text = "INSERISCI UN PRODOTTO";
            this.titolo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(215, 154);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(200, 20);
            this.txtCat.TabIndex = 6;
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nonNumeri);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(215, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(215, 74);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(200, 20);
            this.txtCod.TabIndex = 4;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nonSpazio);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria del prodotto:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome del prodotto:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice del prodotto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(533, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserisci il prodotto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Inserisci);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizza";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Codice,
            this.Nome,
            this.Categoria,
            this.Scorte,
            this.Prezzo,
            this.Data});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(233, 20);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(498, 277);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 83;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 83;
            // 
            // Scorte
            // 
            this.Scorte.Text = "Scorte";
            this.Scorte.Width = 83;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 83;
            // 
            // Data
            // 
            this.Data.Text = "Data di arrivo";
            this.Data.Width = 83;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(20, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "CODICE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.OrdinaCodice);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(233, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 277);
            this.listBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(20, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 80);
            this.button4.TabIndex = 3;
            this.button4.Text = "PREZZO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OrdinaPrezzo);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 60);
            this.label7.TabIndex = 1;
            this.label7.Text = "Elenco di tutti i prodotti per:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3.Controls.Add(this.txtFile);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carica/Salva";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(190, 40);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(400, 20);
            this.txtFile.TabIndex = 19;
            this.txtFile.Text = "prodotti.txt";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Inserisci il nome del file:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(430, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 80);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salva i prodotti su file";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Salva);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.Location = new System.Drawing.Point(190, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 80);
            this.button3.TabIndex = 16;
            this.button3.Text = "Carica i prodotti da file";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Carica);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage4.Controls.Add(this.btn_edit);
            this.tabPage4.Controls.Add(this.btn_src);
            this.tabPage4.Controls.Add(this.editNom);
            this.tabPage4.Controls.Add(this.editDat);
            this.tabPage4.Controls.Add(this.EditPre);
            this.tabPage4.Controls.Add(this.editQt);
            this.tabPage4.Controls.Add(this.editCat);
            this.tabPage4.Controls.Add(this.editCod);
            this.tabPage4.Controls.Add(this.box_src);
            this.tabPage4.Controls.Add(this.txt_src);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(752, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cerca";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(480, 256);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(240, 40);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Modifica";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_src
            // 
            this.btn_src.Location = new System.Drawing.Point(259, 30);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(100, 20);
            this.btn_src.TabIndex = 11;
            this.btn_src.Text = "Cerca";
            this.btn_src.UseVisualStyleBackColor = true;
            this.btn_src.Click += new System.EventHandler(this.Cerca);
            // 
            // editNom
            // 
            this.editNom.Location = new System.Drawing.Point(480, 60);
            this.editNom.Name = "editNom";
            this.editNom.Size = new System.Drawing.Size(240, 20);
            this.editNom.TabIndex = 10;
            // 
            // editDat
            // 
            this.editDat.Location = new System.Drawing.Point(480, 220);
            this.editDat.Name = "editDat";
            this.editDat.Size = new System.Drawing.Size(240, 20);
            this.editDat.TabIndex = 9;
            // 
            // EditPre
            // 
            this.EditPre.Location = new System.Drawing.Point(480, 180);
            this.EditPre.Name = "EditPre";
            this.EditPre.Size = new System.Drawing.Size(240, 20);
            this.EditPre.TabIndex = 8;
            // 
            // editQt
            // 
            this.editQt.Location = new System.Drawing.Point(480, 140);
            this.editQt.Name = "editQt";
            this.editQt.Size = new System.Drawing.Size(240, 20);
            this.editQt.TabIndex = 7;
            // 
            // editCat
            // 
            this.editCat.Location = new System.Drawing.Point(480, 100);
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(240, 20);
            this.editCat.TabIndex = 6;
            // 
            // editCod
            // 
            this.editCod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editCod.Location = new System.Drawing.Point(480, 20);
            this.editCod.Name = "editCod";
            this.editCod.ReadOnly = true;
            this.editCod.Size = new System.Drawing.Size(240, 20);
            this.editCod.TabIndex = 5;
            // 
            // box_src
            // 
            this.box_src.FormattingEnabled = true;
            this.box_src.Location = new System.Drawing.Point(30, 65);
            this.box_src.Name = "box_src";
            this.box_src.Size = new System.Drawing.Size(400, 225);
            this.box_src.TabIndex = 1;
            this.box_src.SelectedIndexChanged += new System.EventHandler(this.Selezione);
            // 
            // txt_src
            // 
            this.txt_src.Location = new System.Drawing.Point(30, 30);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(200, 20);
            this.txt_src.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(752, 314);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(752, 314);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titolo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titolo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDat;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Scorte;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.TextBox editNom;
        private System.Windows.Forms.TextBox editDat;
        private System.Windows.Forms.TextBox EditPre;
        private System.Windows.Forms.TextBox editQt;
        private System.Windows.Forms.TextBox editCat;
        private System.Windows.Forms.TextBox editCod;
        private System.Windows.Forms.ListBox box_src;
        private System.Windows.Forms.TextBox txt_src;
    }
}

