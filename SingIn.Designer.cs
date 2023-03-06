
namespace ООО__ЭКО_Сити_
{
    partial class SingIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingIn));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_singin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.forgot_password = new System.Windows.Forms.LinkLabel();
            this.register_form = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(207, 68);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(430, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Личный кабинет абонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(597, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Всегда актуальная информация\r\nо вашем лицевом счете\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вход в личный кабинет";
            // 
            // button_singin
            // 
            this.button_singin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_singin.Location = new System.Drawing.Point(306, 287);
            this.button_singin.Name = "button_singin";
            this.button_singin.Size = new System.Drawing.Size(222, 46);
            this.button_singin.TabIndex = 5;
            this.button_singin.Text = "Войти";
            this.button_singin.UseVisualStyleBackColor = true;
            this.button_singin.Click += new System.EventHandler(this.button_singin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(278, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Введите email";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(278, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Введите пароль";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgot_password.LinkColor = System.Drawing.Color.DarkOrange;
            this.forgot_password.Location = new System.Drawing.Point(345, 419);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(136, 20);
            this.forgot_password.TabIndex = 10;
            this.forgot_password.TabStop = true;
            this.forgot_password.Text = "Забыли пароль?";
            this.forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_password_LinkClicked);
            // 
            // register_form
            // 
            this.register_form.AutoSize = true;
            this.register_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_form.LinkColor = System.Drawing.Color.DarkOrange;
            this.register_form.Location = new System.Drawing.Point(316, 376);
            this.register_form.Name = "register_form";
            this.register_form.Size = new System.Drawing.Size(201, 24);
            this.register_form.TabIndex = 11;
            this.register_form.TabStop = true;
            this.register_form.Text = "Зарегистрироваться";
            this.register_form.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_form_LinkClicked);
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(853, 459);
            this.Controls.Add(this.register_form);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_singin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SingIn";
            this.Text = "SingIn";
            this.Load += new System.EventHandler(this.SingIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_singin;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel forgot_password;
        private System.Windows.Forms.LinkLabel register_form;
    }
}