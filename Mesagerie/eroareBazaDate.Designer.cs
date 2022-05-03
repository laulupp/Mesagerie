namespace atestat
{
    partial class eroareBazaDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eroareBazaDate));
            this.back_register = new ePOSOne.btnProduct.Button_WOC();
            this.login_text_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_register
            // 
            this.back_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.ButtonColor = System.Drawing.Color.Silver;
            this.back_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatAppearance.BorderSize = 0;
            this.back_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_register.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.Location = new System.Drawing.Point(196, 148);
            this.back_register.Name = "back_register";
            this.back_register.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.back_register.OnHoverTextColor = System.Drawing.Color.Black;
            this.back_register.Size = new System.Drawing.Size(135, 56);
            this.back_register.TabIndex = 26;
            this.back_register.Text = "Inchide";
            this.back_register.TextColor = System.Drawing.Color.Black;
            this.back_register.UseMnemonic = false;
            this.back_register.UseVisualStyleBackColor = false;
            this.back_register.Click += new System.EventHandler(this.back_register_Click);
            // 
            // login_text_1
            // 
            this.login_text_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.login_text_1.ForeColor = System.Drawing.Color.Silver;
            this.login_text_1.Location = new System.Drawing.Point(0, 38);
            this.login_text_1.Name = "login_text_1";
            this.login_text_1.Size = new System.Drawing.Size(538, 23);
            this.login_text_1.TabIndex = 25;
            this.login_text_1.Text = "Nu s-a putut realiza conexiunea la baza de date";
            this.login_text_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(127, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Te rog sa incerci mai tarziu";
            // 
            // eroareBazaDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(537, 247);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_register);
            this.Controls.Add(this.login_text_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eroareBazaDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC back_register;
        private System.Windows.Forms.Label login_text_1;
        private System.Windows.Forms.Label label1;
    }
}