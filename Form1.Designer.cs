namespace Gestion_de_cuenta_de_ahorros
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
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            txtMonto = new TextBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRetiro = new Button();
            btnDeposito = new Button();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            txtSaldo = new TextBox();
            label5 = new Label();
            lstRetiros = new ListBox();
            lstDepositos = new ListBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(329, 39);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(101, 39);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(98, 73);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(206, 29);
            txtMonto.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(98, 34);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(206, 29);
            txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trasacciones";
            // 
            // btnRetiro
            // 
            btnRetiro.Location = new Point(286, 43);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(144, 30);
            btnRetiro.TabIndex = 1;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(55, 43);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(144, 30);
            btnDeposito.TabIndex = 0;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lstRetiros);
            groupBox3.Controls.Add(lstDepositos);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(26, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(478, 182);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.Location = new Point(336, 123);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 33);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(329, 78);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(88, 29);
            txtSaldo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 47);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // lstRetiros
            // 
            lstRetiros.FormattingEnabled = true;
            lstRetiros.ItemHeight = 21;
            lstRetiros.Location = new Point(162, 47);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(119, 109);
            lstRetiros.TabIndex = 3;
            // 
            // lstDepositos
            // 
            lstDepositos.FormattingEnabled = true;
            lstDepositos.ItemHeight = 21;
            lstDepositos.Location = new Point(19, 47);
            lstDepositos.Name = "lstDepositos";
            lstDepositos.Size = new Size(120, 109);
            lstDepositos.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(188, 29);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 1;
            label4.Text = "Retiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 29);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 0;
            label3.Text = "Depositos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(535, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAbrir;
        private TextBox txtMonto;
        private TextBox txtCliente;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnRetiro;
        private Button btnDeposito;
        private GroupBox groupBox3;
        private Label label3;
        private Button btnNuevo;
        private TextBox txtSaldo;
        private Label label5;
        private ListBox lstRetiros;
        private ListBox lstDepositos;
        private Label label4;
    }
}