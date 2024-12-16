namespace ejercicioTelegrama
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
            label1 = new Label();
            txtTelegrama = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            cbOrdinario = new RadioButton();
            cbUrgente = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(99, 47);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(307, 27);
            txtTelegrama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 195);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(155, 192);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(196, 27);
            txtPrecio.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(588, 291);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcularPrecio_Click;
            // 
            // cbOrdinario
            // 
            cbOrdinario.AutoSize = true;
            cbOrdinario.Location = new Point(99, 133);
            cbOrdinario.Name = "cbOrdinario";
            cbOrdinario.Size = new Size(93, 24);
            cbOrdinario.TabIndex = 6;
            cbOrdinario.TabStop = true;
            cbOrdinario.Text = "Ordinario";
            cbOrdinario.UseVisualStyleBackColor = true;
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(256, 133);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(83, 24);
            cbUrgente.TabIndex = 7;
            cbUrgente.TabStop = true;
            cbUrgente.Text = "Urgente";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbUrgente);
            Controls.Add(cbOrdinario);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelegrama;
        private Label label2;
        private TextBox txtPrecio;
        private Button button1;
        private RadioButton cbOrdinario;
        private RadioButton cbUrgente;
    }
}
