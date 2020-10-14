namespace Proect3x
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRegist = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bRegistr = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPasswordTwo = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecovery = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLoginRecovery = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.authorization = new System.Windows.Forms.Panel();
            this.LLRecovery = new System.Windows.Forms.LinkLabel();
            this.Registration = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRemambeMe = new System.Windows.Forms.CheckBox();
            this.tbPasswordAut = new System.Windows.Forms.TextBox();
            this.tbLoginAut = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.LLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnRegist.SuspendLayout();
            this.panelRecovery.SuspendLayout();
            this.authorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.authorization);
            this.panel1.Controls.Add(this.panelRecovery);
            this.panel1.Controls.Add(this.pnRegist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 438);
            this.panel1.TabIndex = 0;
            // 
            // pnRegist
            // 
            this.pnRegist.Controls.Add(this.tbPhone);
            this.pnRegist.Controls.Add(this.label11);
            this.pnRegist.Controls.Add(this.bRegistr);
            this.pnRegist.Controls.Add(this.label9);
            this.pnRegist.Controls.Add(this.tbEmail);
            this.pnRegist.Controls.Add(this.label2);
            this.pnRegist.Controls.Add(this.tbName);
            this.pnRegist.Controls.Add(this.tbPasswordTwo);
            this.pnRegist.Controls.Add(this.tbPassword);
            this.pnRegist.Controls.Add(this.tbLogin);
            this.pnRegist.Controls.Add(this.label6);
            this.pnRegist.Controls.Add(this.label5);
            this.pnRegist.Controls.Add(this.label4);
            this.pnRegist.Controls.Add(this.label3);
            this.pnRegist.Controls.Add(this.label1);
            this.pnRegist.Location = new System.Drawing.Point(75, 62);
            this.pnRegist.Name = "pnRegist";
            this.pnRegist.Size = new System.Drawing.Size(340, 270);
            this.pnRegist.TabIndex = 1;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(193, 168);
            this.tbPhone.Mask = "8(900) 000-00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(131, 20);
            this.tbPhone.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Поля со знаком * являются обязательными.";
            // 
            // bRegistr
            // 
            this.bRegistr.Location = new System.Drawing.Point(106, 210);
            this.bRegistr.Name = "bRegistr";
            this.bRegistr.Size = new System.Drawing.Size(126, 23);
            this.bRegistr.TabIndex = 13;
            this.bRegistr.Text = "Зарегистрироваться";
            this.bRegistr.UseVisualStyleBackColor = true;
            this.bRegistr.Click += new System.EventHandler(this.bRegistr_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Регистрация";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(193, 56);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(131, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:*";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 109);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbPasswordTwo
            // 
            this.tbPasswordTwo.Location = new System.Drawing.Point(11, 167);
            this.tbPasswordTwo.Name = "tbPasswordTwo";
            this.tbPasswordTwo.Size = new System.Drawing.Size(131, 20);
            this.tbPasswordTwo.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(11, 109);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(131, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(11, 56);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(131, 20);
            this.tbLogin.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя пользователя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подтверждение пароля:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:*";
            // 
            // panelRecovery
            // 
            this.panelRecovery.Controls.Add(this.label8);
            this.panelRecovery.Controls.Add(this.tbLoginRecovery);
            this.panelRecovery.Controls.Add(this.label7);
            this.panelRecovery.Controls.Add(this.buttonRecovery);
            this.panelRecovery.Location = new System.Drawing.Point(153, 93);
            this.panelRecovery.Name = "panelRecovery";
            this.panelRecovery.Size = new System.Drawing.Size(176, 187);
            this.panelRecovery.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Восстановление пароля";
            // 
            // tbLoginRecovery
            // 
            this.tbLoginRecovery.Location = new System.Drawing.Point(31, 79);
            this.tbLoginRecovery.Name = "tbLoginRecovery";
            this.tbLoginRecovery.Size = new System.Drawing.Size(100, 20);
            this.tbLoginRecovery.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Логин/Email: *";
            // 
            // buttonRecovery
            // 
            this.buttonRecovery.Location = new System.Drawing.Point(31, 121);
            this.buttonRecovery.Name = "buttonRecovery";
            this.buttonRecovery.Size = new System.Drawing.Size(113, 23);
            this.buttonRecovery.TabIndex = 0;
            this.buttonRecovery.Text = "Восстановить";
            this.buttonRecovery.UseVisualStyleBackColor = true;
            // 
            // authorization
            // 
            this.authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.authorization.Controls.Add(this.LLRecovery);
            this.authorization.Controls.Add(this.Registration);
            this.authorization.Controls.Add(this.label10);
            this.authorization.Controls.Add(this.cbRemambeMe);
            this.authorization.Controls.Add(this.tbPasswordAut);
            this.authorization.Controls.Add(this.tbLoginAut);
            this.authorization.Controls.Add(this.LPassword);
            this.authorization.Controls.Add(this.LLogin);
            this.authorization.Controls.Add(this.button1);
            this.authorization.Location = new System.Drawing.Point(109, 62);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(249, 235);
            this.authorization.TabIndex = 0;
            // 
            // LLRecovery
            // 
            this.LLRecovery.AutoSize = true;
            this.LLRecovery.Location = new System.Drawing.Point(80, 207);
            this.LLRecovery.Name = "LLRecovery";
            this.LLRecovery.Size = new System.Drawing.Size(91, 13);
            this.LLRecovery.TabIndex = 8;
            this.LLRecovery.TabStop = true;
            this.LLRecovery.Text = "Забыли пароль?";
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(126, 165);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(82, 23);
            this.Registration.TabIndex = 7;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(52, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Авторизация";
            // 
            // cbRemambeMe
            // 
            this.cbRemambeMe.AutoSize = true;
            this.cbRemambeMe.Location = new System.Drawing.Point(71, 133);
            this.cbRemambeMe.Name = "cbRemambeMe";
            this.cbRemambeMe.Size = new System.Drawing.Size(111, 17);
            this.cbRemambeMe.TabIndex = 5;
            this.cbRemambeMe.Text = "Запомнить меня";
            this.cbRemambeMe.UseVisualStyleBackColor = true;
            // 
            // tbPasswordAut
            // 
            this.tbPasswordAut.Location = new System.Drawing.Point(71, 107);
            this.tbPasswordAut.Name = "tbPasswordAut";
            this.tbPasswordAut.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordAut.TabIndex = 4;
            this.tbPasswordAut.UseSystemPasswordChar = true;
            // 
            // tbLoginAut
            // 
            this.tbLoginAut.Location = new System.Drawing.Point(71, 62);
            this.tbLoginAut.Name = "tbLoginAut";
            this.tbLoginAut.Size = new System.Drawing.Size(100, 20);
            this.tbLoginAut.TabIndex = 3;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(68, 91);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(48, 13);
            this.LPassword.TabIndex = 2;
            this.LPassword.Text = "Пароль:";
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(68, 46);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(71, 13);
            this.LLogin.TabIndex = 1;
            this.LLogin.Text = "Логин/Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 438);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Главная страница";
            this.panel1.ResumeLayout(false);
            this.pnRegist.ResumeLayout(false);
            this.pnRegist.PerformLayout();
            this.panelRecovery.ResumeLayout(false);
            this.panelRecovery.PerformLayout();
            this.authorization.ResumeLayout(false);
            this.authorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel authorization;
        private System.Windows.Forms.TextBox tbPasswordAut;
        private System.Windows.Forms.TextBox tbLoginAut;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbRemambeMe;
        private System.Windows.Forms.Panel pnRegist;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPasswordTwo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRecovery;
        private System.Windows.Forms.TextBox tbLoginRecovery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bRegistr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel LLRecovery;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.MaskedTextBox tbPhone;
    }
}

