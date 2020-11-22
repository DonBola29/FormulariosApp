namespace FormulariosApp
{
    partial class frmEdadNombre
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(44, 36);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Ingrese Nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(198, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(149, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(47, 69);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(70, 13);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Ingrese Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(198, 69);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(149, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 122);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmEdadNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 209);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbNombre);
            this.Name = "frmEdadNombre";
            this.Text = "frmEdadNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnCalcular;
    }
}