namespace Esoft_Project
{
    partial class FormDemand
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
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.listViewLand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.listViewApartments = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHouse = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(12, 221);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgents.TabIndex = 0;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(12, 181);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 133);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(184, 51);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinPrice.TabIndex = 3;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(184, 109);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPrice.TabIndex = 4;
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(184, 164);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinArea.TabIndex = 5;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(184, 221);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxArea.TabIndex = 6;
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(327, 52);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinFloors.TabIndex = 7;
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(327, 109);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFloors.TabIndex = 8;
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(327, 164);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinFloor.TabIndex = 9;
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(327, 221);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFloor.TabIndex = 10;
            // 
            // listViewLand
            // 
            this.listViewLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewLand.FullRowSelect = true;
            this.listViewLand.GridLines = true;
            this.listViewLand.HideSelection = false;
            this.listViewLand.Location = new System.Drawing.Point(12, 277);
            this.listViewLand.MultiSelect = false;
            this.listViewLand.Name = "listViewLand";
            this.listViewLand.Size = new System.Drawing.Size(711, 97);
            this.listViewLand.TabIndex = 11;
            this.listViewLand.UseCompatibleStateImageBehavior = false;
            this.listViewLand.View = System.Windows.Forms.View.Details;
            this.listViewLand.SelectedIndexChanged += new System.EventHandler(this.listViewLand_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО клиента";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фио риелтора";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Минимальная площадь";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Максимальная площадь";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Минимальная цена";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Максимальная цена";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(10, 205);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 12;
            this.labelAgent.Text = "Риелтор";
            this.labelAgent.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(9, 157);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 13;
            this.labelClient.Text = "Клиент";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(10, 109);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Тип";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(181, 26);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(105, 13);
            this.labelMinPrice.TabIndex = 15;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(181, 89);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(111, 13);
            this.labelMaxPrice.TabIndex = 16;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(181, 147);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(126, 13);
            this.labelMinArea.TabIndex = 17;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(181, 205);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(132, 13);
            this.labelMaxArea.TabIndex = 18;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(324, 26);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(135, 13);
            this.labelMinFloors.TabIndex = 19;
            this.labelMinFloors.Text = "Минимальная этажность";
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Location = new System.Drawing.Point(321, 89);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(141, 13);
            this.labelMaxFloors.TabIndex = 20;
            this.labelMaxFloors.Text = "Максимальная этажность";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(324, 144);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(108, 13);
            this.labelMinFloor.TabIndex = 21;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(321, 205);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(114, 13);
            this.labelMaxFloor.TabIndex = 22;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonAdd.Location = new System.Drawing.Point(486, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 48);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonEdit.Location = new System.Drawing.Point(567, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 48);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonDel.Location = new System.Drawing.Point(648, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDel.Size = new System.Drawing.Size(75, 48);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(471, 164);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinRooms.TabIndex = 26;
            this.textBoxMinRooms.TextChanged += new System.EventHandler(this.textBoxMinRooms_TextChanged);
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(471, 221);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxRooms.TabIndex = 27;
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(468, 144);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(179, 13);
            this.labelMinRooms.TabIndex = 28;
            this.labelMinRooms.Text = "Минимальное количество комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(468, 205);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(185, 13);
            this.labelMaxRooms.TabIndex = 29;
            this.labelMaxRooms.Text = "Максимальное количество комнат";
            // 
            // listViewApartments
            // 
            this.listViewApartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.listViewApartments.FullRowSelect = true;
            this.listViewApartments.GridLines = true;
            this.listViewApartments.HideSelection = false;
            this.listViewApartments.Location = new System.Drawing.Point(12, 277);
            this.listViewApartments.MultiSelect = false;
            this.listViewApartments.Name = "listViewApartments";
            this.listViewApartments.Size = new System.Drawing.Size(711, 97);
            this.listViewApartments.TabIndex = 30;
            this.listViewApartments.UseCompatibleStateImageBehavior = false;
            this.listViewApartments.View = System.Windows.Forms.View.Details;
            this.listViewApartments.SelectedIndexChanged += new System.EventHandler(this.listViewApartments_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ФИО клиента";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ФИО риелтора";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Минимальная площадь";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Максимальная площадь";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Минимальное количество комнат";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Максимальное количество комнат";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Минимальная цена";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Максимальная цена";
            // 
            // listViewHouse
            // 
            this.listViewHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewHouse.FullRowSelect = true;
            this.listViewHouse.GridLines = true;
            this.listViewHouse.HideSelection = false;
            this.listViewHouse.Location = new System.Drawing.Point(12, 277);
            this.listViewHouse.MultiSelect = false;
            this.listViewHouse.Name = "listViewHouse";
            this.listViewHouse.Size = new System.Drawing.Size(711, 97);
            this.listViewHouse.TabIndex = 31;
            this.listViewHouse.UseCompatibleStateImageBehavior = false;
            this.listViewHouse.View = System.Windows.Forms.View.Details;
            this.listViewHouse.SelectedIndexChanged += new System.EventHandler(this.listViewHouse_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО клиента";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ФИО риелтора";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Минимальная площадь";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Максимальная площадь";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Минимальная этажность";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Максимальная этажность";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewHouse);
            this.Controls.Add(this.listViewApartments);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.listViewLand);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Name = "FormDemand";
            this.Text = "FormDemand";
            this.Load += new System.EventHandler(this.FormDemand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.ListView listViewLand;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.ListView listViewApartments;
        private System.Windows.Forms.ListView listViewHouse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}