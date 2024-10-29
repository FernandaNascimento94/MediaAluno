namespace MediaAluno
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
            buttonAdicionarAluno = new Button();
            buttonDeletarAluno = new Button();
            listBoxAlunos = new ListBox();
            SuspendLayout();
            // 
            // buttonAdicionarAluno
            // 
            buttonAdicionarAluno.Location = new Point(21, 12);
            buttonAdicionarAluno.Name = "buttonAdicionarAluno";
            buttonAdicionarAluno.Size = new Size(123, 23);
            buttonAdicionarAluno.TabIndex = 0;
            buttonAdicionarAluno.Text = "Novo Aluno";
            buttonAdicionarAluno.UseVisualStyleBackColor = true;
            buttonAdicionarAluno.Click += buttonAdicionarAluno_Click;
            // 
            // buttonDeletarAluno
            // 
            buttonDeletarAluno.Location = new Point(150, 12);
            buttonDeletarAluno.Name = "buttonDeletarAluno";
            buttonDeletarAluno.Size = new Size(127, 23);
            buttonDeletarAluno.TabIndex = 1;
            buttonDeletarAluno.Text = "Deletar Aluno";
            buttonDeletarAluno.UseVisualStyleBackColor = true;
            buttonDeletarAluno.Click += buttonDeletarAluno_Click;
            // 
            // listBoxAlunos
            // 
            listBoxAlunos.FormattingEnabled = true;
            listBoxAlunos.ItemHeight = 15;
            listBoxAlunos.Location = new Point(12, 41);
            listBoxAlunos.Name = "listBoxAlunos";
            listBoxAlunos.Size = new Size(344, 334);
            listBoxAlunos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 395);
            Controls.Add(listBoxAlunos);
            Controls.Add(buttonDeletarAluno);
            Controls.Add(buttonAdicionarAluno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarAluno;
        private Button buttonDeletarAluno;
        private ListBox listBoxAlunos;
    }
}
