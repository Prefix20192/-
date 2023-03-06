
namespace ООО__ЭКО_Сити_
{
    partial class Personal_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal_account));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailuser = new System.Windows.Forms.Label();
            this.exit_account = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fiz_tab_face = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.contract_info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.send_contact_fiz = new System.Windows.Forms.Button();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_number_check = new System.Windows.Forms.TextBox();
            this.urid_tab_face = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.urid_lab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number_contracts__urid_face = new System.Windows.Forms.TextBox();
            this.inn_urid_face = new System.Windows.Forms.TextBox();
            this.kpp_urid_face = new System.Windows.Forms.TextBox();
            this.send_urid_face = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.fiz_tab_face.SuspendLayout();
            this.urid_tab_face.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(207, 68);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Личный кабинет абонента";
            // 
            // emailuser
            // 
            this.emailuser.AutoSize = true;
            this.emailuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailuser.Location = new System.Drawing.Point(668, 51);
            this.emailuser.Name = "emailuser";
            this.emailuser.Size = new System.Drawing.Size(0, 29);
            this.emailuser.TabIndex = 2;
            // 
            // exit_account
            // 
            this.exit_account.Location = new System.Drawing.Point(795, 95);
            this.exit_account.Name = "exit_account";
            this.exit_account.Size = new System.Drawing.Size(106, 29);
            this.exit_account.TabIndex = 3;
            this.exit_account.Text = "Выход";
            this.exit_account.UseVisualStyleBackColor = true;
            this.exit_account.Click += new System.EventHandler(this.exit_account_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(316, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(278, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Сменить пароль от учетной записи";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fiz_tab_face);
            this.tabControl1.Controls.Add(this.urid_tab_face);
            this.tabControl1.Location = new System.Drawing.Point(33, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 327);
            this.tabControl1.TabIndex = 5;
            // 
            // fiz_tab_face
            // 
            this.fiz_tab_face.Controls.Add(this.label4);
            this.fiz_tab_face.Controls.Add(this.contract_info);
            this.fiz_tab_face.Controls.Add(this.label2);
            this.fiz_tab_face.Controls.Add(this.send_contact_fiz);
            this.fiz_tab_face.Controls.Add(this.textBox_surname);
            this.fiz_tab_face.Controls.Add(this.textBox_number_check);
            this.fiz_tab_face.Location = new System.Drawing.Point(4, 22);
            this.fiz_tab_face.Name = "fiz_tab_face";
            this.fiz_tab_face.Padding = new System.Windows.Forms.Padding(3);
            this.fiz_tab_face.Size = new System.Drawing.Size(819, 301);
            this.fiz_tab_face.TabIndex = 0;
            this.fiz_tab_face.Text = "Физическое личо";
            this.fiz_tab_face.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(483, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Добавить договор";
            // 
            // contract_info
            // 
            this.contract_info.AutoSize = true;
            this.contract_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contract_info.Location = new System.Drawing.Point(64, 99);
            this.contract_info.Name = "contract_info";
            this.contract_info.Size = new System.Drawing.Size(319, 58);
            this.contract_info.TabIndex = 4;
            this.contract_info.Text = "              У вас нету \r\nдокоговорных документов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(123, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваши договоры";
            // 
            // send_contact_fiz
            // 
            this.send_contact_fiz.Location = new System.Drawing.Point(536, 189);
            this.send_contact_fiz.Name = "send_contact_fiz";
            this.send_contact_fiz.Size = new System.Drawing.Size(140, 38);
            this.send_contact_fiz.TabIndex = 2;
            this.send_contact_fiz.Text = "Добавить договор";
            this.send_contact_fiz.UseVisualStyleBackColor = true;
            this.send_contact_fiz.Click += new System.EventHandler(this.send_contact_fiz_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_surname.Location = new System.Drawing.Point(506, 146);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(199, 23);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.Text = "Введите фамилию";
            this.textBox_surname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_surname_MouseClick);
            // 
            // textBox_number_check
            // 
            this.textBox_number_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_number_check.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_number_check.Location = new System.Drawing.Point(506, 108);
            this.textBox_number_check.Name = "textBox_number_check";
            this.textBox_number_check.Size = new System.Drawing.Size(199, 23);
            this.textBox_number_check.TabIndex = 0;
            this.textBox_number_check.Text = "Введите номер лиц. счета";
            this.textBox_number_check.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_number_check_MouseClick);
            // 
            // urid_tab_face
            // 
            this.urid_tab_face.Controls.Add(this.send_urid_face);
            this.urid_tab_face.Controls.Add(this.kpp_urid_face);
            this.urid_tab_face.Controls.Add(this.inn_urid_face);
            this.urid_tab_face.Controls.Add(this.number_contracts__urid_face);
            this.urid_tab_face.Controls.Add(this.label6);
            this.urid_tab_face.Controls.Add(this.urid_lab);
            this.urid_tab_face.Controls.Add(this.label3);
            this.urid_tab_face.Location = new System.Drawing.Point(4, 22);
            this.urid_tab_face.Name = "urid_tab_face";
            this.urid_tab_face.Padding = new System.Windows.Forms.Padding(3);
            this.urid_tab_face.Size = new System.Drawing.Size(819, 301);
            this.urid_tab_face.TabIndex = 1;
            this.urid_tab_face.Text = "Юридическое лицр";
            this.urid_tab_face.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(69, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ваши договоры";
            // 
            // urid_lab
            // 
            this.urid_lab.AutoSize = true;
            this.urid_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urid_lab.Location = new System.Drawing.Point(71, 86);
            this.urid_lab.Name = "urid_lab";
            this.urid_lab.Size = new System.Drawing.Size(211, 60);
            this.urid_lab.TabIndex = 1;
            this.urid_lab.Text = "              У вас нету \r\nдокоговорных документов\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(448, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Добавление договора";
            // 
            // number_contracts__urid_face
            // 
            this.number_contracts__urid_face.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_contracts__urid_face.ForeColor = System.Drawing.SystemColors.GrayText;
            this.number_contracts__urid_face.Location = new System.Drawing.Point(500, 88);
            this.number_contracts__urid_face.Name = "number_contracts__urid_face";
            this.number_contracts__urid_face.Size = new System.Drawing.Size(187, 23);
            this.number_contracts__urid_face.TabIndex = 3;
            this.number_contracts__urid_face.Text = "Номер договора";
            this.number_contracts__urid_face.MouseClick += new System.Windows.Forms.MouseEventHandler(this.number_contracts__urid_face_MouseClick);
            // 
            // inn_urid_face
            // 
            this.inn_urid_face.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn_urid_face.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inn_urid_face.Location = new System.Drawing.Point(500, 123);
            this.inn_urid_face.Name = "inn_urid_face";
            this.inn_urid_face.Size = new System.Drawing.Size(187, 23);
            this.inn_urid_face.TabIndex = 4;
            this.inn_urid_face.Text = "ИНН";
            this.inn_urid_face.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inn_urid_face_MouseClick);
            // 
            // kpp_urid_face
            // 
            this.kpp_urid_face.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kpp_urid_face.ForeColor = System.Drawing.SystemColors.GrayText;
            this.kpp_urid_face.Location = new System.Drawing.Point(500, 162);
            this.kpp_urid_face.Name = "kpp_urid_face";
            this.kpp_urid_face.Size = new System.Drawing.Size(187, 23);
            this.kpp_urid_face.TabIndex = 5;
            this.kpp_urid_face.Text = "КПП (если есть)";
            this.kpp_urid_face.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kpp_urid_face_MouseClick);
            // 
            // send_urid_face
            // 
            this.send_urid_face.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_urid_face.Location = new System.Drawing.Point(531, 205);
            this.send_urid_face.Name = "send_urid_face";
            this.send_urid_face.Size = new System.Drawing.Size(131, 35);
            this.send_urid_face.TabIndex = 6;
            this.send_urid_face.Text = "Добавить договор";
            this.send_urid_face.UseVisualStyleBackColor = true;
            this.send_urid_face.Click += new System.EventHandler(this.send_urid_face_Click);
            // 
            // Personal_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.exit_account);
            this.Controls.Add(this.emailuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Personal_account";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Personal_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.fiz_tab_face.ResumeLayout(false);
            this.fiz_tab_face.PerformLayout();
            this.urid_tab_face.ResumeLayout(false);
            this.urid_tab_face.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailuser;
        private System.Windows.Forms.Button exit_account;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fiz_tab_face;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label contract_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_contact_fiz;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_number_check;
        private System.Windows.Forms.TabPage urid_tab_face;
        private System.Windows.Forms.Button send_urid_face;
        private System.Windows.Forms.TextBox kpp_urid_face;
        private System.Windows.Forms.TextBox inn_urid_face;
        private System.Windows.Forms.TextBox number_contracts__urid_face;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label urid_lab;
        private System.Windows.Forms.Label label3;
    }
}