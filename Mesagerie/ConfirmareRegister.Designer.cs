namespace atestat
{
    partial class ConfirmareRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmareRegister));
            this.login_text_1 = new System.Windows.Forms.Label();
            this.back_register = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // login_text_1
            // 
            this.login_text_1.AutoSize = true;
            this.login_text_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.login_text_1.ForeColor = System.Drawing.Color.Silver;
            this.login_text_1.Location = new System.Drawing.Point(47, 48);
            this.login_text_1.Name = "login_text_1";
            this.login_text_1.Size = new System.Drawing.Size(310, 23);
            this.login_text_1.TabIndex = 13;
            this.login_text_1.Text = "Contul a fost creat cu succes !";
            this.login_text_1.Click += new System.EventHandler(this.login_text_1_Click);
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
            this.back_register.Location = new System.Drawing.Point(138, 108);
            this.back_register.Name = "back_register";
            this.back_register.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.back_register.OnHoverTextColor = System.Drawing.Color.Black;
            this.back_register.Size = new System.Drawing.Size(124, 37);
            this.back_register.TabIndex = 24;
            this.back_register.Text = "Inapoi";
            this.back_register.TextColor = System.Drawing.Color.Black;
            this.back_register.UseMnemonic = false;
            this.back_register.UseVisualStyleBackColor = false;
            this.back_register.Click += new System.EventHandler(this.back_register_Click);
            // 
            // ConfirmareRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 188);
            this.ControlBox = false;
            this.Controls.Add(this.back_register);
            this.Controls.Add(this.login_text_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmareRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfirmareRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_text_1;
        private ePOSOne.btnProduct.Button_WOC back_register;
    }
}