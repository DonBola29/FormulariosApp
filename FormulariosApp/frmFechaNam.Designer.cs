namespace FormulariosApp
{
    partial class frmFechaNam
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
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtEdadAn = new System.Windows.Forms.TextBox();
            this.txtEdadDias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(174, 65);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(153, 13);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Ingresa tu fecha de nacimiento";
            this.lbFecha.Click += new System.EventHandler(this.lbFecha_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(193, 111);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(118, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2020, 11, 22, 15, 48, 16, 0);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(214, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtEdadAn
            // 
            this.txtEdadAn.Location = new System.Drawing.Point(177, 201);
            this.txtEdadAn.Name = "txtEdadAn";
            this.txtEdadAn.Size = new System.Drawing.Size(150, 20);
            this.txtEdadAn.TabIndex = 3;
            // 
            // txtEdadDias
            // 
            this.txtEdadDias.Location = new System.Drawing.Point(177, 244);
            this.txtEdadDias.Name = "txtEdadDias";
            this.txtEdadDias.Size = new System.Drawing.Size(150, 20);
            this.txtEdadDias.TabIndex = 4;
            // 
            // frmFechaNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 305);
            this.Controls.Add(this.txtEdadDias);
            this.Controls.Add(this.txtEdadAn);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbFecha);
            this.Name = "frmFechaNam";
            this.Text = "frmFechaNam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtEdadAn;
        private System.Windows.Forms.TextBox txtEdadDias;
    }
}