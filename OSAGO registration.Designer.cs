namespace OSAGO
{
    partial class OSAGO_registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSAGO_registration));
            this.CarNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductionDate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HorsePower = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.Identifier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumbOfIdentifier_label = new System.Windows.Forms.Label();
            this.IdentifierNumber = new System.Windows.Forms.TextBox();
            this.Document = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DocumentNumber_label = new System.Windows.Forms.Label();
            this.DocumentNumber = new System.Windows.Forms.TextBox();
            this.DocumentDate_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DocumentDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CarNumber
            // 
            this.CarNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CarNumber.Location = new System.Drawing.Point(16, 140);
            this.CarNumber.MaxLength = 10;
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.Size = new System.Drawing.Size(197, 33);
            this.CarNumber.TabIndex = 0;
            this.CarNumber.TextChanged += new System.EventHandler(this.CarNumber_TextChanged);
            this.CarNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CarNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гос. номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Данные для расчета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Данные автомобиля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Марка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(222, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Модель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(432, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Год выпуска";
            // 
            // ProductionDate
            // 
            this.ProductionDate.Enabled = false;
            this.ProductionDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductionDate.FormattingEnabled = true;
            this.ProductionDate.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.ProductionDate.Location = new System.Drawing.Point(436, 209);
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.Size = new System.Drawing.Size(197, 34);
            this.ProductionDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Мощность двигателя";
            // 
            // HorsePower
            // 
            this.HorsePower.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HorsePower.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HorsePower.Location = new System.Drawing.Point(16, 280);
            this.HorsePower.MaxLength = 4;
            this.HorsePower.Name = "HorsePower";
            this.HorsePower.Size = new System.Drawing.Size(197, 33);
            this.HorsePower.TabIndex = 4;
            this.HorsePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HorsePower_KeyPress);
            // 
            // model
            // 
            this.model.Enabled = false;
            this.model.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(226, 210);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(197, 34);
            this.model.TabIndex = 2;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(16, 209);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(197, 34);
            this.brand.TabIndex = 1;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_TextChanged);
            // 
            // Identifier
            // 
            this.Identifier.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifier.FormattingEnabled = true;
            this.Identifier.Items.AddRange(new object[] {
            "VIN",
            "Кузов",
            "Шасси"});
            this.Identifier.Location = new System.Drawing.Point(16, 350);
            this.Identifier.Name = "Identifier";
            this.Identifier.Size = new System.Drawing.Size(197, 34);
            this.Identifier.TabIndex = 5;
            this.Identifier.Text = "VIN";
            this.Identifier.SelectedIndexChanged += new System.EventHandler(this.Identifier_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(12, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Идентификатор";
            // 
            // NumbOfIdentifier_label
            // 
            this.NumbOfIdentifier_label.AutoSize = true;
            this.NumbOfIdentifier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbOfIdentifier_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.NumbOfIdentifier_label.Location = new System.Drawing.Point(222, 326);
            this.NumbOfIdentifier_label.Name = "NumbOfIdentifier_label";
            this.NumbOfIdentifier_label.Size = new System.Drawing.Size(90, 20);
            this.NumbOfIdentifier_label.TabIndex = 18;
            this.NumbOfIdentifier_label.Text = "Номер VIN";
            // 
            // IdentifierNumber
            // 
            this.IdentifierNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdentifierNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IdentifierNumber.Location = new System.Drawing.Point(226, 350);
            this.IdentifierNumber.MaxLength = 17;
            this.IdentifierNumber.Name = "IdentifierNumber";
            this.IdentifierNumber.Size = new System.Drawing.Size(407, 33);
            this.IdentifierNumber.TabIndex = 6;
            // 
            // Document
            // 
            this.Document.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document.FormattingEnabled = true;
            this.Document.Items.AddRange(new object[] {
            "ПТС",
            "СТС"});
            this.Document.Location = new System.Drawing.Point(16, 420);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(197, 34);
            this.Document.TabIndex = 7;
            this.Document.Text = "ПТС";
            this.Document.SelectedIndexChanged += new System.EventHandler(this.Document_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(12, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Документ на авто";
            // 
            // DocumentNumber_label
            // 
            this.DocumentNumber_label.AutoSize = true;
            this.DocumentNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentNumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.DocumentNumber_label.Location = new System.Drawing.Point(222, 396);
            this.DocumentNumber_label.Name = "DocumentNumber_label";
            this.DocumentNumber_label.Size = new System.Drawing.Size(95, 20);
            this.DocumentNumber_label.TabIndex = 22;
            this.DocumentNumber_label.Text = "Номер ПТС";
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DocumentNumber.Location = new System.Drawing.Point(226, 420);
            this.DocumentNumber.MaxLength = 10;
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.Size = new System.Drawing.Size(197, 33);
            this.DocumentNumber.TabIndex = 8;
            this.DocumentNumber.TextChanged += new System.EventHandler(this.DocumentNumber_TextChanged);
            // 
            // DocumentDate_label
            // 
            this.DocumentDate_label.AutoSize = true;
            this.DocumentDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentDate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.DocumentDate_label.Location = new System.Drawing.Point(432, 396);
            this.DocumentDate_label.Name = "DocumentDate_label";
            this.DocumentDate_label.Size = new System.Drawing.Size(146, 20);
            this.DocumentDate_label.TabIndex = 24;
            this.DocumentDate_label.Text = "Дата выдачи ПТС";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(436, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(16, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocumentDate
            // 
            this.DocumentDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.DocumentDate.Location = new System.Drawing.Point(436, 421);
            this.DocumentDate.Mask = "00:00:0000";
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.Size = new System.Drawing.Size(197, 33);
            this.DocumentDate.TabIndex = 9;
            this.DocumentDate.Click += new System.EventHandler(this.DocumentDate_Click);
            this.DocumentDate.Leave += new System.EventHandler(this.DocumentDate_Leave);
            // 
            // OSAGO_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(654, 536);
            this.Controls.Add(this.DocumentDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocumentDate_label);
            this.Controls.Add(this.DocumentNumber_label);
            this.Controls.Add(this.DocumentNumber);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumbOfIdentifier_label);
            this.Controls.Add(this.IdentifierNumber);
            this.Controls.Add(this.Identifier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HorsePower);
            this.Controls.Add(this.ProductionDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSAGO_registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSAGO_registration";
            this.Load += new System.EventHandler(this.OSAGO_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HorsePower;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.ComboBox Identifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NumbOfIdentifier_label;
        private System.Windows.Forms.TextBox IdentifierNumber;
        private System.Windows.Forms.ComboBox Document;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DocumentNumber_label;
        private System.Windows.Forms.TextBox DocumentNumber;
        private System.Windows.Forms.Label DocumentDate_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox DocumentDate;
    }
}