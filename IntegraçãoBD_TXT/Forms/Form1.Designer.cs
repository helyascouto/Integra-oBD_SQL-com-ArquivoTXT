namespace IntegraçãoBD_TXT
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
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.BtnPessoa = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(131, 191);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(86, 23);
            this.btnLerArquivo.TabIndex = 0;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(346, 191);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(427, 191);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // BtnPessoa
            // 
            this.BtnPessoa.Location = new System.Drawing.Point(508, 191);
            this.BtnPessoa.Name = "BtnPessoa";
            this.BtnPessoa.Size = new System.Drawing.Size(75, 23);
            this.BtnPessoa.TabIndex = 2;
            this.BtnPessoa.Text = "Pessoa";
            this.BtnPessoa.UseVisualStyleBackColor = true;
            this.BtnPessoa.Click += new System.EventHandler(this.BtnPessoa_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(223, 191);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(117, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Quatidade";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 297);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.BtnPessoa);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLerArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLerArquivo;
        private DataGridView dataGridView1;
        private Button btnAluno;
        private Button btnCurso;
        private Button BtnPessoa;
        private Button btnMostrar;
    }
}