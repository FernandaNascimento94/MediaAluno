namespace MediaAluno
{
    partial class FormNovoAluno
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
            buttonOk = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownNota1 = new NumericUpDown();
            numericUpDownNota2 = new NumericUpDown();
            numericUpDownNota3 = new NumericUpDown();
            textBoxNome = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota3).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(96, 218);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(204, 218);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Nota 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "Nota 3:";
            // 
            // numericUpDownNota1
            // 
            numericUpDownNota1.DecimalPlaces = 1;
            numericUpDownNota1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownNota1.Location = new Point(138, 65);
            numericUpDownNota1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNota1.Name = "numericUpDownNota1";
            numericUpDownNota1.Size = new Size(141, 23);
            numericUpDownNota1.TabIndex = 6;
            numericUpDownNota1.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownNota2
            // 
            numericUpDownNota2.DecimalPlaces = 1;
            numericUpDownNota2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownNota2.Location = new Point(138, 99);
            numericUpDownNota2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNota2.Name = "numericUpDownNota2";
            numericUpDownNota2.Size = new Size(141, 23);
            numericUpDownNota2.TabIndex = 7;
            numericUpDownNota2.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownNota3
            // 
            numericUpDownNota3.DecimalPlaces = 1;
            numericUpDownNota3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownNota3.Location = new Point(138, 133);
            numericUpDownNota3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNota3.Name = "numericUpDownNota3";
            numericUpDownNota3.Size = new Size(141, 23);
            numericUpDownNota3.TabIndex = 8;
            numericUpDownNota3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(138, 26);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(141, 23);
            textBoxNome.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Media:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 11;
            // 
            // FormNovoAluno
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(322, 274);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(textBoxNome);
            Controls.Add(numericUpDownNota3);
            Controls.Add(numericUpDownNota2);
            Controls.Add(numericUpDownNota1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormNovoAluno";
            Text = "FormNovoAluno";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNota3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownNota1;
        private NumericUpDown numericUpDownNota2;
        private NumericUpDown numericUpDownNota3;
        private TextBox textBoxNome;
        private Label label5;
        private TextBox textBox1;
    }
}