namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonEndereco = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Image = ((System.Drawing.Image)(resources.GetObject("buttonEndereco.Image")));
            this.buttonEndereco.Location = new System.Drawing.Point(22, 16);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(171, 153);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereços";
            this.buttonEndereco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonPacientes.Image")));
            this.buttonPacientes.Location = new System.Drawing.Point(228, 16);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(178, 153);
            this.buttonPacientes.TabIndex = 1;
            this.buttonPacientes.Text = "   Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 194);
            this.Controls.Add(this.buttonPacientes);
            this.Controls.Add(this.buttonEndereco);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEndereco;
        private Button buttonPacientes;
    }
}