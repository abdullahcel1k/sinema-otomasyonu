namespace CinemaAutomation.Formlar
{
    partial class frmKasiyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasiyer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.gridBilet = new System.Windows.Forms.DataGridView();
            this.b_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Seans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Koltuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Personel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblBiletid = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboxBilet = new System.Windows.Forms.ComboBox();
            this.txtBiletara = new System.Windows.Forms.TextBox();
            this.btnBiletara = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnselonseans = new System.Windows.Forms.Button();
            this.btnBiletkesdevam = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.grupSalon = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.combobxSeanssec = new System.Windows.Forms.ComboBox();
            this.VTcombobxsalon = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBiletsat = new System.Windows.Forms.Button();
            this.lblKoltukno = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.btnRezerve = new System.Windows.Forms.Button();
            this.txtToplamucret = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.labelOgrenciUcret = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.labelNormalUcret = new System.Windows.Forms.Label();
            this.radiobtnNormal = new System.Windows.Forms.RadioButton();
            this.radiobtnOgrenci = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBiletiptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilet)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 402);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnBiletiptal);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.btnIptal);
            this.tabPage1.Controls.Add(this.lblBiletid);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Biletler";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.gridBilet);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox11.Location = new System.Drawing.Point(3, 110);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(723, 260);
            this.groupBox11.TabIndex = 19;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Bilet Listesi";
            // 
            // gridBilet
            // 
            this.gridBilet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBilet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBilet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_Id,
            this.b_Film,
            this.b_Salon,
            this.b_Seans,
            this.b_Koltuk,
            this.b_Personel,
            this.b_Ucret});
            this.gridBilet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBilet.Location = new System.Drawing.Point(3, 18);
            this.gridBilet.Name = "gridBilet";
            this.gridBilet.Size = new System.Drawing.Size(717, 239);
            this.gridBilet.TabIndex = 15;
            this.gridBilet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBilet_CellClick);
            // 
            // b_Id
            // 
            this.b_Id.DataPropertyName = "b_Id";
            this.b_Id.HeaderText = "ID";
            this.b_Id.Name = "b_Id";
            this.b_Id.Visible = false;
            // 
            // b_Film
            // 
            this.b_Film.DataPropertyName = "b_Film";
            this.b_Film.HeaderText = "Film";
            this.b_Film.Name = "b_Film";
            // 
            // b_Salon
            // 
            this.b_Salon.DataPropertyName = "b_Salon";
            this.b_Salon.HeaderText = "Salon";
            this.b_Salon.Name = "b_Salon";
            // 
            // b_Seans
            // 
            this.b_Seans.DataPropertyName = "b_Seans";
            this.b_Seans.HeaderText = "Seans";
            this.b_Seans.Name = "b_Seans";
            // 
            // b_Koltuk
            // 
            this.b_Koltuk.DataPropertyName = "b_Koltuk";
            this.b_Koltuk.HeaderText = "Koltuk No";
            this.b_Koltuk.Name = "b_Koltuk";
            // 
            // b_Personel
            // 
            this.b_Personel.DataPropertyName = "b_Personel";
            this.b_Personel.HeaderText = "Personel";
            this.b_Personel.Name = "b_Personel";
            // 
            // b_Ucret
            // 
            this.b_Ucret.DataPropertyName = "b_Ucret";
            this.b_Ucret.HeaderText = "Ücret";
            this.b_Ucret.Name = "b_Ucret";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(619, 75);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(83, 29);
            this.btnIptal.TabIndex = 18;
            this.btnIptal.Text = "BİLET İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblBiletid
            // 
            this.lblBiletid.AutoSize = true;
            this.lblBiletid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBiletid.Location = new System.Drawing.Point(527, 79);
            this.lblBiletid.Name = "lblBiletid";
            this.lblBiletid.Size = new System.Drawing.Size(35, 20);
            this.lblBiletid.TabIndex = 16;
            this.lblBiletid.Text = "N/A";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(455, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 17;
            this.label21.Text = "Bilet Id :";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboxBilet);
            this.groupBox10.Controls.Add(this.txtBiletara);
            this.groupBox10.Controls.Add(this.btnBiletara);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(723, 65);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Bilet Ara";
            // 
            // comboxBilet
            // 
            this.comboxBilet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBilet.FormattingEnabled = true;
            this.comboxBilet.Items.AddRange(new object[] {
            "Film adı"});
            this.comboxBilet.Location = new System.Drawing.Point(193, 21);
            this.comboxBilet.Name = "comboxBilet";
            this.comboxBilet.Size = new System.Drawing.Size(121, 24);
            this.comboxBilet.TabIndex = 12;
            // 
            // txtBiletara
            // 
            this.txtBiletara.Location = new System.Drawing.Point(330, 21);
            this.txtBiletara.Name = "txtBiletara";
            this.txtBiletara.Size = new System.Drawing.Size(172, 22);
            this.txtBiletara.TabIndex = 9;
            // 
            // btnBiletara
            // 
            this.btnBiletara.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBiletara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiletara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBiletara.ForeColor = System.Drawing.Color.White;
            this.btnBiletara.Location = new System.Drawing.Point(642, 17);
            this.btnBiletara.Name = "btnBiletara";
            this.btnBiletara.Size = new System.Drawing.Size(57, 29);
            this.btnBiletara.TabIndex = 10;
            this.btnBiletara.Text = "Ara";
            this.btnBiletara.UseVisualStyleBackColor = false;
            this.btnBiletara.Click += new System.EventHandler(this.btnBiletara_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.Location = new System.Drawing.Point(112, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 20);
            this.label25.TabIndex = 11;
            this.label25.Text = "Bilet Ara :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Koltuk Seç";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnselonseans);
            this.groupBox12.Controls.Add(this.btnBiletkesdevam);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.Controls.Add(this.pictureBox13);
            this.groupBox12.Controls.Add(this.pictureBox14);
            this.groupBox12.Controls.Add(this.pictureBox15);
            this.groupBox12.Controls.Add(this.grupSalon);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.combobxSeanssec);
            this.groupBox12.Controls.Add(this.VTcombobxsalon);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(723, 367);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            // 
            // btnselonseans
            // 
            this.btnselonseans.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnselonseans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselonseans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnselonseans.ForeColor = System.Drawing.Color.White;
            this.btnselonseans.Location = new System.Drawing.Point(568, 19);
            this.btnselonseans.Name = "btnselonseans";
            this.btnselonseans.Size = new System.Drawing.Size(73, 24);
            this.btnselonseans.TabIndex = 89;
            this.btnselonseans.Text = "DEVAM";
            this.btnselonseans.UseVisualStyleBackColor = false;
            this.btnselonseans.Click += new System.EventHandler(this.btnselonseans_Click);
            // 
            // btnBiletkesdevam
            // 
            this.btnBiletkesdevam.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBiletkesdevam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiletkesdevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBiletkesdevam.ForeColor = System.Drawing.Color.White;
            this.btnBiletkesdevam.Location = new System.Drawing.Point(626, 309);
            this.btnBiletkesdevam.Name = "btnBiletkesdevam";
            this.btnBiletkesdevam.Size = new System.Drawing.Size(73, 29);
            this.btnBiletkesdevam.TabIndex = 89;
            this.btnBiletkesdevam.Text = "DEVAM";
            this.btnBiletkesdevam.UseVisualStyleBackColor = false;
            this.btnBiletkesdevam.Click += new System.EventHandler(this.btnBiletkesdevam_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label31.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label31.Location = new System.Drawing.Point(462, 316);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(128, 17);
            this.label31.TabIndex = 54;
            this.label31.Text = "Satıldı ve ya Rezev";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label32.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label32.Location = new System.Drawing.Point(306, 316);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 17);
            this.label32.TabIndex = 53;
            this.label32.Text = "Boş";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label33.Location = new System.Drawing.Point(122, 316);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 17);
            this.label33.TabIndex = 52;
            this.label33.Text = "Sectiniz";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(427, 310);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(29, 29);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 51;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(271, 310);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(29, 29);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 50;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(87, 310);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(29, 29);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 49;
            this.pictureBox15.TabStop = false;
            // 
            // grupSalon
            // 
            this.grupSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupSalon.Location = new System.Drawing.Point(83, 52);
            this.grupSalon.Name = "grupSalon";
            this.grupSalon.Size = new System.Drawing.Size(507, 251);
            this.grupSalon.TabIndex = 13;
            this.grupSalon.TabStop = false;
            this.grupSalon.Text = "Salon ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(322, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Seans Seç :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label26.Location = new System.Drawing.Point(83, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 20);
            this.label26.TabIndex = 12;
            this.label26.Text = "Salon Seç :";
            // 
            // combobxSeanssec
            // 
            this.combobxSeanssec.FormattingEnabled = true;
            this.combobxSeanssec.Location = new System.Drawing.Point(419, 19);
            this.combobxSeanssec.Name = "combobxSeanssec";
            this.combobxSeanssec.Size = new System.Drawing.Size(121, 24);
            this.combobxSeanssec.TabIndex = 0;
            // 
            // VTcombobxsalon
            // 
            this.VTcombobxsalon.FormattingEnabled = true;
            this.VTcombobxsalon.Location = new System.Drawing.Point(179, 19);
            this.VTcombobxsalon.Name = "VTcombobxsalon";
            this.VTcombobxsalon.Size = new System.Drawing.Size(121, 24);
            this.VTcombobxsalon.TabIndex = 0;
            this.VTcombobxsalon.SelectedIndexChanged += new System.EventHandler(this.VTcombobxsalon_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnBiletsat);
            this.tabPage3.Controls.Add(this.lblKoltukno);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.btnRezerve);
            this.tabPage3.Controls.Add(this.txtToplamucret);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(729, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bilet Satış";
            // 
            // btnBiletsat
            // 
            this.btnBiletsat.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBiletsat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiletsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBiletsat.ForeColor = System.Drawing.Color.White;
            this.btnBiletsat.Location = new System.Drawing.Point(442, 305);
            this.btnBiletsat.Name = "btnBiletsat";
            this.btnBiletsat.Size = new System.Drawing.Size(53, 29);
            this.btnBiletsat.TabIndex = 95;
            this.btnBiletsat.Text = "Sat";
            this.btnBiletsat.UseVisualStyleBackColor = false;
            this.btnBiletsat.Click += new System.EventHandler(this.btnBiletsat_Click);
            // 
            // lblKoltukno
            // 
            this.lblKoltukno.AutoSize = true;
            this.lblKoltukno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKoltukno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKoltukno.Location = new System.Drawing.Point(292, 43);
            this.lblKoltukno.Name = "lblKoltukno";
            this.lblKoltukno.Size = new System.Drawing.Size(0, 17);
            this.lblKoltukno.TabIndex = 94;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label35.Location = new System.Drawing.Point(233, 43);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(51, 17);
            this.label35.TabIndex = 93;
            this.label35.Text = "Koltuk:";
            // 
            // btnRezerve
            // 
            this.btnRezerve.BackColor = System.Drawing.Color.Coral;
            this.btnRezerve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRezerve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezerve.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRezerve.ForeColor = System.Drawing.Color.White;
            this.btnRezerve.Location = new System.Drawing.Point(236, 305);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(83, 29);
            this.btnRezerve.TabIndex = 92;
            this.btnRezerve.Text = "Rezerv";
            this.btnRezerve.UseVisualStyleBackColor = false;
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click);
            // 
            // txtToplamucret
            // 
            this.txtToplamucret.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamucret.Location = new System.Drawing.Point(426, 38);
            this.txtToplamucret.Name = "txtToplamucret";
            this.txtToplamucret.ReadOnly = true;
            this.txtToplamucret.Size = new System.Drawing.Size(69, 26);
            this.txtToplamucret.TabIndex = 91;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.Location = new System.Drawing.Point(344, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(76, 17);
            this.label34.TabIndex = 90;
            this.label34.Text = "TOPLAM:";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.Transparent;
            this.groupBox14.Controls.Add(this.labelOgrenciUcret);
            this.groupBox14.Controls.Add(this.label37);
            this.groupBox14.Controls.Add(this.label38);
            this.groupBox14.Controls.Add(this.labelNormalUcret);
            this.groupBox14.Controls.Add(this.radiobtnNormal);
            this.groupBox14.Controls.Add(this.radiobtnOgrenci);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox14.Location = new System.Drawing.Point(236, 142);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(259, 64);
            this.groupBox14.TabIndex = 89;
            this.groupBox14.TabStop = false;
            // 
            // labelOgrenciUcret
            // 
            this.labelOgrenciUcret.AutoSize = true;
            this.labelOgrenciUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciUcret.Location = new System.Drawing.Point(26, 40);
            this.labelOgrenciUcret.Name = "labelOgrenciUcret";
            this.labelOgrenciUcret.Size = new System.Drawing.Size(13, 13);
            this.labelOgrenciUcret.TabIndex = 2;
            this.labelOgrenciUcret.Text = "8";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(187, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 13);
            this.label37.TabIndex = 5;
            this.label37.Text = "TL";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(46, 40);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 13);
            this.label38.TabIndex = 4;
            this.label38.Text = "TL";
            // 
            // labelNormalUcret
            // 
            this.labelNormalUcret.AutoSize = true;
            this.labelNormalUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNormalUcret.Location = new System.Drawing.Point(162, 39);
            this.labelNormalUcret.Name = "labelNormalUcret";
            this.labelNormalUcret.Size = new System.Drawing.Size(19, 13);
            this.labelNormalUcret.TabIndex = 3;
            this.labelNormalUcret.Text = "12";
            // 
            // radiobtnNormal
            // 
            this.radiobtnNormal.AutoSize = true;
            this.radiobtnNormal.Location = new System.Drawing.Point(162, 19);
            this.radiobtnNormal.Name = "radiobtnNormal";
            this.radiobtnNormal.Size = new System.Drawing.Size(56, 17);
            this.radiobtnNormal.TabIndex = 1;
            this.radiobtnNormal.Text = "normal";
            this.radiobtnNormal.UseVisualStyleBackColor = true;
            this.radiobtnNormal.CheckedChanged += new System.EventHandler(this.radiobtnNormal_CheckedChanged);
            // 
            // radiobtnOgrenci
            // 
            this.radiobtnOgrenci.AutoSize = true;
            this.radiobtnOgrenci.Location = new System.Drawing.Point(16, 19);
            this.radiobtnOgrenci.Name = "radiobtnOgrenci";
            this.radiobtnOgrenci.Size = new System.Drawing.Size(60, 17);
            this.radiobtnOgrenci.TabIndex = 0;
            this.radiobtnOgrenci.Text = "öğrenci";
            this.radiobtnOgrenci.UseVisualStyleBackColor = true;
            this.radiobtnOgrenci.CheckedChanged += new System.EventHandler(this.radiobtnOgrenci_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(585, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BİLET İŞLEM";
            // 
            // btnBiletiptal
            // 
            this.btnBiletiptal.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBiletiptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiletiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBiletiptal.ForeColor = System.Drawing.Color.White;
            this.btnBiletiptal.Location = new System.Drawing.Point(8, 75);
            this.btnBiletiptal.Name = "btnBiletiptal";
            this.btnBiletiptal.Size = new System.Drawing.Size(122, 29);
            this.btnBiletiptal.TabIndex = 16;
            this.btnBiletiptal.Text = "BİLET KONTROL";
            this.btnBiletiptal.UseVisualStyleBackColor = false;
            this.btnBiletiptal.Click += new System.EventHandler(this.btnBiletiptal_Click);
            // 
            // frmKasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasiyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİLET İŞLEM";
            this.Load += new System.EventHandler(this.frmKasiyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBilet)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboxBilet;
        private System.Windows.Forms.TextBox txtBiletara;
        private System.Windows.Forms.Button btnBiletara;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblBiletid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView gridBilet;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Seans;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Koltuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Personel;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_Ucret;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnselonseans;
        private System.Windows.Forms.Button btnBiletkesdevam;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.GroupBox grupSalon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox combobxSeanssec;
        private System.Windows.Forms.ComboBox VTcombobxsalon;
        private System.Windows.Forms.Button btnBiletsat;
        public System.Windows.Forms.Label lblKoltukno;
        public System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnRezerve;
        public System.Windows.Forms.TextBox txtToplamucret;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label labelOgrenciUcret;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label labelNormalUcret;
        private System.Windows.Forms.RadioButton radiobtnNormal;
        private System.Windows.Forms.RadioButton radiobtnOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBiletiptal;
    }
}