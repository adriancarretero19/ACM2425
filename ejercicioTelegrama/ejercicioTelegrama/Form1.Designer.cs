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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            chkUrgente = new CheckBox();
            txtPrecio = new TextBox();
            txtTelegrama = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(488, 230);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcularPrecio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 239);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Coste";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(174, 156);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(84, 24);
            chkUrgente.TabIndex = 3;
            chkUrgente.Text = "Urgente";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(225, 236);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(174, 80);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(201, 27);
            txtTelegrama.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelegrama);
            Controls.Add(txtPrecio);
            Controls.Add(chkUrgente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private TextBox txtTelegrama;
    }
}
