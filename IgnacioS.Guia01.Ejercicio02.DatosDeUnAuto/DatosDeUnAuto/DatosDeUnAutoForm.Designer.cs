namespace IgnacioS.Guia01.Ejercicio02.DatosDeUnAuto
{
    partial class DatosDeUnAutoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarca = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtAnio = new TextBox();
            lblAnio = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            BtnAceptar = new Button();
            cmbMarca = new ComboBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(50, 58);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(79, 32);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(316, 113);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(200, 39);
            txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(316, 58);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(97, 32);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(562, 113);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(200, 39);
            txtAnio.TabIndex = 5;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(562, 58);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(57, 32);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(816, 113);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 39);
            txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(816, 58);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(984, 234);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(150, 46);
            BtnAceptar.TabIndex = 8;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Audi", "Chevrolet", "Fiat", "Ford", "", "" });
            cmbMarca.Location = new Point(50, 113);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(242, 40);
            cmbMarca.TabIndex = 9;
            // 
            // DatosDeUnAutoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 314);
            Controls.Add(cmbMarca);
            Controls.Add(BtnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtAnio);
            Controls.Add(lblAnio);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Name = "DatosDeUnAutoForm";
            Text = "DatosDeUnAuto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtAnio;
        private Label lblAnio;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button BtnAceptar;
        private ComboBox cmbMarca;
    }
}
