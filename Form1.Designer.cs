namespace HolaMundo_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            txtContraseña4 = new TextBox();
            txtConfirmarContraseña4 = new TextBox();
            BtnValidar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();

            // Campo de texto adicional
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;

            // Campo para ingresar la contraseña
            txtContraseña4.Location = new Point(267, 118);
            txtContraseña4.Name = "txtContraseña4";
            txtContraseña4.Size = new Size(100, 23);
            txtContraseña4.TabIndex = 1;

            // Campo para repetir la contraseña
            txtConfirmarContraseña4.Location = new Point(267, 160);
            txtConfirmarContraseña4.Name = "txtConfirmarContraseña4";
            txtConfirmarContraseña4.Size = new Size(100, 23);
            txtConfirmarContraseña4.TabIndex = 2;

            // Botón para validar la contraseña
            BtnValidar.Location = new Point(405, 138);
            BtnValidar.Name = "BtnValidar";
            BtnValidar.Size = new Size(155, 23);
            BtnValidar.TabIndex = 3;
            BtnValidar.Text = "Validar Contraseña";
            BtnValidar.UseVisualStyleBackColor = true;

            // Evento Click del botón
            BtnValidar.Click += BtnValidar_Click;

            // Etiqueta del primer campo
            label1.AutoSize = true;
            label1.Location = new Point(152, 121);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingresa contraseña:";

            // Etiqueta del segundo campo
            label2.AutoSize = true;
            label2.Location = new Point(152, 163);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Repite contraseña:";

            // Configuración del formulario
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnValidar);
            Controls.Add(txtConfirmarContraseña4);
            Controls.Add(txtContraseña4);
            Controls.Add(textBox1);

            Name = "Form1";
            Text = "HolaMundo";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtContraseña4;
        private TextBox txtConfirmarContraseña4;
        private Label label1;
        private Label label2;
        private Button BtnValidar;
    }

}
