namespace FormulariosApp
{
    partial class Menu_Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnNumEnBinario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFormalarioNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(274, 87);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(123, 23);
            this.btnSueldo.TabIndex = 1;
            this.btnSueldo.Text = "Calcular Sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnNumEnBinario
            // 
            this.btnNumEnBinario.Location = new System.Drawing.Point(274, 127);
            this.btnNumEnBinario.Name = "btnNumEnBinario";
            this.btnNumEnBinario.Size = new System.Drawing.Size(123, 23);
            this.btnNumEnBinario.TabIndex = 2;
            this.btnNumEnBinario.Text = "Entero en Binario";
            this.btnNumEnBinario.UseVisualStyleBackColor = true;
            this.btnNumEnBinario.Click += new System.EventHandler(this.btnNumEnBinario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(274, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFormalarioNuevo
            // 
            this.btnFormalarioNuevo.Location = new System.Drawing.Point(274, 174);
            this.btnFormalarioNuevo.Name = "btnFormalarioNuevo";
            this.btnFormalarioNuevo.Size = new System.Drawing.Size(123, 23);
            this.btnFormalarioNuevo.TabIndex = 4;
            this.btnFormalarioNuevo.Text = "Formulario Nuevo";
            this.btnFormalarioNuevo.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 331);
            this.Controls.Add(this.btnFormalarioNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNumEnBinario);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button btnNumEnBinario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFormalarioNuevo;
    }
}