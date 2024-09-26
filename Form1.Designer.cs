namespace AgendaWF
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
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btExcluir = new Button();
            dgvDados = new DataGridView();
            lbDados = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "NOME";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(507, 39);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(398, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 42);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "EMAIL";
            // 
            // btInserir
            // 
            btInserir.Location = new Point(507, 72);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(94, 29);
            btInserir.TabIndex = 6;
            btInserir.Text = "Inserir";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(607, 72);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(94, 29);
            btAlterar.TabIndex = 7;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(811, 72);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(94, 29);
            btLocalizar.TabIndex = 8;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(712, 72);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(94, 29);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 120);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 51;
            dgvDados.Size = new Size(893, 280);
            dgvDados.TabIndex = 10;
            // 
            // lbDados
            // 
            lbDados.AutoSize = true;
            lbDados.Location = new Point(22, 413);
            lbDados.Name = "lbDados";
            lbDados.Size = new Size(285, 20);
            lbDados.TabIndex = 11;
            lbDados.Text = "Local onde os  Dados estão armazenados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(lbDados);
            Controls.Add(dgvDados);
            Controls.Add(btExcluir);
            Controls.Add(btLocalizar);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda - CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Button btInserir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btExcluir;
        private DataGridView dgvDados;
        private Label lbDados;
    }
}
