namespace OSAGO
{
    partial class OSAGO_registration3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSAGO_registration3));
            this.OwnerPassportDate = new System.Windows.Forms.MaskedTextBox();
            this.OwnerDateofbirth = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OwnerPatronymic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OwnerSurname = new System.Windows.Forms.TextBox();
            this.OwnerPassport = new System.Windows.Forms.TextBox();
            this.NumbOfIdentifier_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerRegistrationAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Same = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OwnerPassportDate
            // 
            this.OwnerPassportDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.OwnerPassportDate.Location = new System.Drawing.Point(436, 212);
            this.OwnerPassportDate.Mask = "00:00:0000";
            this.OwnerPassportDate.Name = "OwnerPassportDate";
            this.OwnerPassportDate.Size = new System.Drawing.Size(197, 33);
            this.OwnerPassportDate.TabIndex = 5;
            // 
            // OwnerDateofbirth
            // 
            this.OwnerDateofbirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.OwnerDateofbirth.Location = new System.Drawing.Point(16, 212);
            this.OwnerDateofbirth.Mask = "00:00:0000";
            this.OwnerDateofbirth.Name = "OwnerDateofbirth";
            this.OwnerDateofbirth.Size = new System.Drawing.Size(197, 33);
            this.OwnerDateofbirth.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label11.Location = new System.Drawing.Point(432, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Отчество";
            // 
            // OwnerPatronymic
            // 
            this.OwnerPatronymic.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerPatronymic.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OwnerPatronymic.Location = new System.Drawing.Point(436, 140);
            this.OwnerPatronymic.MaxLength = 45;
            this.OwnerPatronymic.Name = "OwnerPatronymic";
            this.OwnerPatronymic.Size = new System.Drawing.Size(197, 33);
            this.OwnerPatronymic.TabIndex = 2;
            this.OwnerPatronymic.TextChanged += new System.EventHandler(this.patronymic1_TextChanged);
            this.OwnerPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(432, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Дата выдачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label10.Location = new System.Drawing.Point(222, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 90;
            this.label10.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Дата рождения";
            // 
            // OwnerName
            // 
            this.OwnerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OwnerName.Location = new System.Drawing.Point(226, 140);
            this.OwnerName.MaxLength = 45;
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(197, 33);
            this.OwnerName.TabIndex = 1;
            this.OwnerName.TextChanged += new System.EventHandler(this.Name1_TextChanged);
            this.OwnerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 32);
            this.label3.TabIndex = 84;
            this.label3.Text = "Данные собственника";
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OwnerSurname.Location = new System.Drawing.Point(16, 140);
            this.OwnerSurname.MaxLength = 45;
            this.OwnerSurname.Name = "OwnerSurname";
            this.OwnerSurname.Size = new System.Drawing.Size(197, 33);
            this.OwnerSurname.TabIndex = 0;
            this.OwnerSurname.TextChanged += new System.EventHandler(this.surname1_TextChanged);
            this.OwnerSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_KeyPress);
            // 
            // OwnerPassport
            // 
            this.OwnerPassport.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerPassport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OwnerPassport.Location = new System.Drawing.Point(226, 212);
            this.OwnerPassport.MaxLength = 10;
            this.OwnerPassport.Name = "OwnerPassport";
            this.OwnerPassport.Size = new System.Drawing.Size(196, 33);
            this.OwnerPassport.TabIndex = 4;
            this.OwnerPassport.TextChanged += new System.EventHandler(this.driverlicense_TextChanged);
            // 
            // NumbOfIdentifier_label
            // 
            this.NumbOfIdentifier_label.AutoSize = true;
            this.NumbOfIdentifier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbOfIdentifier_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.NumbOfIdentifier_label.Location = new System.Drawing.Point(222, 189);
            this.NumbOfIdentifier_label.Name = "NumbOfIdentifier_label";
            this.NumbOfIdentifier_label.Size = new System.Drawing.Size(195, 20);
            this.NumbOfIdentifier_label.TabIndex = 88;
            this.NumbOfIdentifier_label.Text = "Серия и номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 46);
            this.label2.TabIndex = 95;
            this.label2.Text = "Данные для расчета";
            // 
            // OwnerRegistrationAddress
            // 
            this.OwnerRegistrationAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerRegistrationAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OwnerRegistrationAddress.Location = new System.Drawing.Point(16, 288);
            this.OwnerRegistrationAddress.MaxLength = 100;
            this.OwnerRegistrationAddress.Name = "OwnerRegistrationAddress";
            this.OwnerRegistrationAddress.Size = new System.Drawing.Size(407, 33);
            this.OwnerRegistrationAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(14, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Адрес регистрации (город, улица, дом)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(16, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(436, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Same
            // 
            this.Same.AutoSize = true;
            this.Same.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Same.Location = new System.Drawing.Point(16, 327);
            this.Same.Name = "Same";
            this.Same.Size = new System.Drawing.Size(359, 24);
            this.Same.TabIndex = 7;
            this.Same.Text = "Страхователь совпадает с собственником ";
            this.Same.UseVisualStyleBackColor = true;
            // 
            // OSAGO_registration3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 536);
            this.Controls.Add(this.Same);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OwnerRegistrationAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OwnerPassportDate);
            this.Controls.Add(this.OwnerDateofbirth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OwnerPatronymic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OwnerSurname);
            this.Controls.Add(this.OwnerPassport);
            this.Controls.Add(this.NumbOfIdentifier_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSAGO_registration3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSAGO_registration3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox OwnerPassportDate;
        private System.Windows.Forms.MaskedTextBox OwnerDateofbirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OwnerPatronymic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OwnerSurname;
        private System.Windows.Forms.TextBox OwnerPassport;
        private System.Windows.Forms.Label NumbOfIdentifier_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerRegistrationAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Same;
    }
}