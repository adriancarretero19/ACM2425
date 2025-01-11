namespace RamaCorregida
{
    partial class Form1
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
            Calcular = new Button();
            chkUrgente = new CheckBox();
            hola = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            txtTelegrama = new TextBox();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(389, 210);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(94, 29);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += btnCalcularPrecio_Click;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(160, 148);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(91, 24);
            chkUrgente.TabIndex = 1;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            chkUrgente.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // hola
            // 
            hola.AutoSize = true;
            hola.Location = new Point(160, 64);
            hola.Name = "hola";
            hola.Size = new Size(45, 20);
            hola.TabIndex = 2;
            hola.Text = "Texto";
            hola.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 215);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            label2.Click += label2_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(210, 212);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(160, 87);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(191, 27);
            txtTelegrama.TabIndex = 5;
            txtTelegrama.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelegrama);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(hola);
            Controls.Add(chkUrgente);
            Controls.Add(Calcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calcular;
        private CheckBox chkUrgente;
        private Label hola;
        private Label label2;
        private TextBox txtPrecio;
        private TextBox txtTelegrama;
    }
}
