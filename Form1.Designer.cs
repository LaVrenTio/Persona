namespace Persone_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nome_lbl = new Label();
            nome_box = new TextBox();
            congome_txtBox = new TextBox();
            cognome_lbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            datadinascita_lbl = new Label();
            eta_txtBox = new TextBox();
            eta_lbl = new Label();
            telefono_Box = new TextBox();
            Telefono_lbl = new Label();
            email_txtbox = new TextBox();
            email_lbl = new Label();
            viewData_btn = new Button();
            InsertPerson_btn = new Button();
            confermi_btn = new Button();
            visualizzadata_lbl = new Label();
            confirmData_lbl = new Label();
            genere_lbl = new Label();
            genere_comboBox = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Person_GridView = new DataGridView();
            tabPage2 = new TabPage();
            Lorenz_dbbindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Person_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lorenz_dbbindingSource).BeginInit();
            SuspendLayout();
            // 
            // nome_lbl
            // 
            nome_lbl.AutoSize = true;
            nome_lbl.Location = new Point(30, 39);
            nome_lbl.Name = "nome_lbl";
            nome_lbl.Size = new Size(50, 20);
            nome_lbl.TabIndex = 0;
            nome_lbl.Text = "Nome";
            // 
            // nome_box
            // 
            nome_box.Location = new Point(30, 73);
            nome_box.Name = "nome_box";
            nome_box.PlaceholderText = "Insert your Name";
            nome_box.Size = new Size(144, 27);
            nome_box.TabIndex = 1;
            nome_box.TextChanged += nome_box_TextChanged;
            // 
            // congome_txtBox
            // 
            congome_txtBox.Location = new Point(30, 146);
            congome_txtBox.Name = "congome_txtBox";
            congome_txtBox.PlaceholderText = "Insert your Surname";
            congome_txtBox.Size = new Size(144, 27);
            congome_txtBox.TabIndex = 3;
            // 
            // cognome_lbl
            // 
            cognome_lbl.AutoSize = true;
            cognome_lbl.Location = new Point(30, 112);
            cognome_lbl.Name = "cognome_lbl";
            cognome_lbl.Size = new Size(74, 20);
            cognome_lbl.TabIndex = 2;
            cognome_lbl.Text = "Cognome";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // datadinascita_lbl
            // 
            datadinascita_lbl.AutoSize = true;
            datadinascita_lbl.Location = new Point(31, 186);
            datadinascita_lbl.Name = "datadinascita_lbl";
            datadinascita_lbl.Size = new Size(111, 20);
            datadinascita_lbl.TabIndex = 5;
            datadinascita_lbl.Text = "Data di Nascita";
            // 
            // eta_txtBox
            // 
            eta_txtBox.Location = new Point(31, 281);
            eta_txtBox.Name = "eta_txtBox";
            eta_txtBox.ReadOnly = true;
            eta_txtBox.Size = new Size(125, 27);
            eta_txtBox.TabIndex = 6;
            eta_txtBox.Visible = false;
            // 
            // eta_lbl
            // 
            eta_lbl.AutoSize = true;
            eta_lbl.Location = new Point(37, 264);
            eta_lbl.Name = "eta_lbl";
            eta_lbl.Size = new Size(30, 20);
            eta_lbl.TabIndex = 7;
            eta_lbl.Text = "Età";
            eta_lbl.Visible = false;
            // 
            // telefono_Box
            // 
            telefono_Box.Location = new Point(31, 364);
            telefono_Box.Name = "telefono_Box";
            telefono_Box.PlaceholderText = "Insert your Phone";
            telefono_Box.Size = new Size(144, 27);
            telefono_Box.TabIndex = 9;
            // 
            // Telefono_lbl
            // 
            Telefono_lbl.AutoSize = true;
            Telefono_lbl.Location = new Point(31, 330);
            Telefono_lbl.Name = "Telefono_lbl";
            Telefono_lbl.Size = new Size(67, 20);
            Telefono_lbl.TabIndex = 8;
            Telefono_lbl.Text = "Telefono";
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(220, 364);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.PlaceholderText = "Insert your e-mail";
            email_txtbox.Size = new Size(144, 27);
            email_txtbox.TabIndex = 11;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(220, 330);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(52, 20);
            email_lbl.TabIndex = 10;
            email_lbl.Text = "E-mail";
            // 
            // viewData_btn
            // 
            viewData_btn.Location = new Point(546, 144);
            viewData_btn.Name = "viewData_btn";
            viewData_btn.Size = new Size(94, 29);
            viewData_btn.TabIndex = 12;
            viewData_btn.Text = "View data";
            viewData_btn.UseVisualStyleBackColor = true;
            viewData_btn.Click += viewData_btn_Click;
            // 
            // InsertPerson_btn
            // 
            InsertPerson_btn.Location = new Point(536, 362);
            InsertPerson_btn.Name = "InsertPerson_btn";
            InsertPerson_btn.Size = new Size(185, 29);
            InsertPerson_btn.TabIndex = 13;
            InsertPerson_btn.Text = "Insert Person";
            InsertPerson_btn.UseVisualStyleBackColor = true;
            InsertPerson_btn.Visible = false;
            InsertPerson_btn.Click += InsertPerson_btn_Click;
            // 
            // confermi_btn
            // 
            confermi_btn.Location = new Point(540, 244);
            confermi_btn.Name = "confermi_btn";
            confermi_btn.Size = new Size(181, 29);
            confermi_btn.TabIndex = 14;
            confermi_btn.Text = "Confermi i dati?";
            confermi_btn.UseVisualStyleBackColor = true;
            confermi_btn.Click += confermi_btn_Click;
            // 
            // visualizzadata_lbl
            // 
            visualizzadata_lbl.AutoSize = true;
            visualizzadata_lbl.Location = new Point(549, 108);
            visualizzadata_lbl.Name = "visualizzadata_lbl";
            visualizzadata_lbl.Size = new Size(112, 20);
            visualizzadata_lbl.TabIndex = 15;
            visualizzadata_lbl.Text = "Visualizza i dati";
            // 
            // confirmData_lbl
            // 
            confirmData_lbl.AutoSize = true;
            confirmData_lbl.Location = new Point(543, 209);
            confirmData_lbl.Name = "confirmData_lbl";
            confirmData_lbl.Size = new Size(161, 20);
            confirmData_lbl.TabIndex = 16;
            confirmData_lbl.Text = "confermi i dati inseriti?";
            // 
            // genere_lbl
            // 
            genere_lbl.AutoSize = true;
            genere_lbl.Location = new Point(237, 122);
            genere_lbl.Name = "genere_lbl";
            genere_lbl.Size = new Size(55, 20);
            genere_lbl.TabIndex = 17;
            genere_lbl.Text = "genere";
            genere_lbl.Click += genere_lbl_Click;
            // 
            // genere_comboBox
            // 
            genere_comboBox.FormattingEnabled = true;
            genere_comboBox.Items.AddRange(new object[] { "maschio", "femmina", "non genere" });
            genere_comboBox.Location = new Point(240, 152);
            genere_comboBox.Name = "genere_comboBox";
            genere_comboBox.Size = new Size(151, 28);
            genere_comboBox.TabIndex = 18;
            genere_comboBox.SelectedIndexChanged += genere_comboBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(779, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(295, 248);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Person_GridView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(287, 215);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // person_GridView
            // 
            Person_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Person_GridView.Location = new Point(6, 6);
            Person_GridView.Name = "person_GridView";
            Person_GridView.RowHeadersWidth = 51;
            Person_GridView.Size = new Size(300, 188);
            Person_GridView.TabIndex = 0;
            Person_GridView.CellContentClick += Person_GridView_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(287, 215);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 450);
            Controls.Add(tabControl1);
            Controls.Add(genere_comboBox);
            Controls.Add(genere_lbl);
            Controls.Add(confirmData_lbl);
            Controls.Add(visualizzadata_lbl);
            Controls.Add(confermi_btn);
            Controls.Add(InsertPerson_btn);
            Controls.Add(viewData_btn);
            Controls.Add(email_txtbox);
            Controls.Add(email_lbl);
            Controls.Add(telefono_Box);
            Controls.Add(Telefono_lbl);
            Controls.Add(eta_lbl);
            Controls.Add(eta_txtBox);
            Controls.Add(datadinascita_lbl);
            Controls.Add(dateTimePicker1);
            Controls.Add(congome_txtBox);
            Controls.Add(cognome_lbl);
            Controls.Add(nome_box);
            Controls.Add(nome_lbl);
            Name = "Form1";
            Text = "Insert_Person";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Person_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lorenz_dbbindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nome_lbl;
        private TextBox nome_box;
        private TextBox congome_txtBox;
        private Label cognome_lbl;
        private DateTimePicker dateTimePicker1;
        private Label datadinascita_lbl;
        private TextBox eta_txtBox;
        private Label eta_lbl;
        private TextBox telefono_Box;
        private Label Telefono_lbl;
        private TextBox email_txtbox;
        private Label email_lbl;
        private Button viewData_btn;
        private Button InsertPerson_btn;
        private Button confermi_btn;
        private Label visualizzadata_lbl;
        private Label confirmData_lbl;
        private Label genere_lbl;
        private ComboBox genere_comboBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView Person_GridView;
        private TabPage tabPage2;
        private BindingSource Lorenz_dbbindingSource;
    }
}
