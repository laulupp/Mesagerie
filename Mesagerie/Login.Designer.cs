namespace atestat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_text_1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.creare_cont_label = new System.Windows.Forms.Label();
            this.eroare = new System.Windows.Forms.Label();
            this.login_button = new ePOSOne.btnProduct.Button_WOC();
            this.iesire_login = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // login_text_1
            // 
            this.login_text_1.AutoSize = true;
            this.login_text_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.login_text_1.ForeColor = System.Drawing.Color.Silver;
            this.login_text_1.Location = new System.Drawing.Point(102, 34);
            this.login_text_1.Name = "login_text_1";
            this.login_text_1.Size = new System.Drawing.Size(187, 23);
            this.login_text_1.TabIndex = 0;
            this.login_text_1.Text = "Mesagerie - Login";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(122, 192);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(147, 20);
            this.Password.TabIndex = 2;
            this.Password.Tag = "";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(122, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(147, 20);
            this.Username.TabIndex = 1;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Username_label.ForeColor = System.Drawing.Color.White;
            this.Username_label.Location = new System.Drawing.Point(153, 102);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(86, 18);
            this.Username_label.TabIndex = 4;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Password_label.ForeColor = System.Drawing.Color.White;
            this.Password_label.Location = new System.Drawing.Point(153, 171);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(83, 18);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password";
            // 
            // creare_cont_label
            // 
            this.creare_cont_label.AutoSize = true;
            this.creare_cont_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creare_cont_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 7F);
            this.creare_cont_label.ForeColor = System.Drawing.Color.White;
            this.creare_cont_label.Location = new System.Drawing.Point(77, 279);
            this.creare_cont_label.Name = "creare_cont_label";
            this.creare_cont_label.Size = new System.Drawing.Size(238, 13);
            this.creare_cont_label.TabIndex = 4;
            this.creare_cont_label.Text = "Nu ai cont? Apasa aici pentru a crea unul.";
            this.creare_cont_label.Click += new System.EventHandler(this.creare_cont_label_Click);
            // 
            // eroare
            // 
            this.eroare.AutoSize = true;
            this.eroare.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F);
            this.eroare.ForeColor = System.Drawing.Color.Black;
            this.eroare.Location = new System.Drawing.Point(164, 309);
            this.eroare.Name = "eroare";
            this.eroare.Size = new System.Drawing.Size(0, 15);
            this.eroare.TabIndex = 8;
            this.eroare.Click += new System.EventHandler(this.eroare_Click);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.Location = new System.Drawing.Point(156, 231);
            this.login_button.Name = "login_button";
            this.login_button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_button.OnHoverTextColor = System.Drawing.Color.White;
            this.login_button.Size = new System.Drawing.Size(80, 36);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.TextColor = System.Drawing.Color.White;
            this.login_button.UseMnemonic = false;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // iesire_login
            // 
            this.iesire_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iesire_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.ButtonColor = System.Drawing.Color.Red;
            this.iesire_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iesire_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.FlatAppearance.BorderSize = 0;
            this.iesire_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iesire_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.Location = new System.Drawing.Point(293, 334);
            this.iesire_login.Name = "iesire_login";
            this.iesire_login.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_login.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iesire_login.OnHoverTextColor = System.Drawing.Color.White;
            this.iesire_login.Size = new System.Drawing.Size(66, 39);
            this.iesire_login.TabIndex = 5;
            this.iesire_login.Text = "Iesire";
            this.iesire_login.TextColor = System.Drawing.Color.White;
            this.iesire_login.UseMnemonic = false;
            this.iesire_login.UseVisualStyleBackColor = false;
            this.iesire_login.Click += new System.EventHandler(this.iesire_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(380, 394);
            this.ControlBox = false;
            this.Controls.Add(this.eroare);
            this.Controls.Add(this.creare_cont_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.login_text_1);
            this.Controls.Add(this.iesire_login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.MenuHighlight;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC iesire_login;
        private System.Windows.Forms.Label login_text_1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private ePOSOne.btnProduct.Button_WOC login_button;
        private System.Windows.Forms.Label creare_cont_label;
        private System.Windows.Forms.Label eroare;
    }
}

