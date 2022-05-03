namespace atestat
{
    partial class cerere_prietene
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nume = new System.Windows.Forms.Label();
            this.refuza = new ePOSOne.btnProduct.Button_WOC();
            this.accepta = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.nume.Location = new System.Drawing.Point(0, 15);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(231, 23);
            this.nume.TabIndex = 24;
            this.nume.Text = "Username";
            this.nume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refuza
            // 
            this.refuza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refuza.BackColor = System.Drawing.Color.LightGray;
            this.refuza.BorderColor = System.Drawing.Color.LightGray;
            this.refuza.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.refuza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refuza.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.refuza.FlatAppearance.BorderSize = 0;
            this.refuza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.refuza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.refuza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refuza.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refuza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refuza.Location = new System.Drawing.Point(229, 4);
            this.refuza.Name = "refuza";
            this.refuza.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.refuza.OnHoverButtonColor = System.Drawing.Color.Red;
            this.refuza.OnHoverTextColor = System.Drawing.Color.White;
            this.refuza.Size = new System.Drawing.Size(86, 47);
            this.refuza.TabIndex = 26;
            this.refuza.Text = "Refuza";
            this.refuza.TextColor = System.Drawing.Color.White;
            this.refuza.UseMnemonic = false;
            this.refuza.UseVisualStyleBackColor = false;
            this.refuza.Click += new System.EventHandler(this.refuza_Click);
            // 
            // accepta
            // 
            this.accepta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accepta.BackColor = System.Drawing.Color.LightGray;
            this.accepta.BorderColor = System.Drawing.Color.LightGray;
            this.accepta.ButtonColor = System.Drawing.Color.Green;
            this.accepta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accepta.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.accepta.FlatAppearance.BorderSize = 0;
            this.accepta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.accepta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.accepta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accepta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accepta.Location = new System.Drawing.Point(312, 4);
            this.accepta.Name = "accepta";
            this.accepta.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.accepta.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accepta.OnHoverTextColor = System.Drawing.Color.White;
            this.accepta.Size = new System.Drawing.Size(91, 47);
            this.accepta.TabIndex = 25;
            this.accepta.Text = "Adauga";
            this.accepta.TextColor = System.Drawing.Color.White;
            this.accepta.UseMnemonic = false;
            this.accepta.UseVisualStyleBackColor = false;
            this.accepta.Click += new System.EventHandler(this.accepta_Click);
            // 
            // cerere_prietene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.refuza);
            this.Controls.Add(this.accepta);
            this.Controls.Add(this.nume);
            this.Name = "cerere_prietene";
            this.Size = new System.Drawing.Size(406, 53);
            this.Load += new System.EventHandler(this.cerere_prietene_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nume;
        private ePOSOne.btnProduct.Button_WOC refuza;
        private ePOSOne.btnProduct.Button_WOC accepta;
    }
}
