using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAluno
{
    public partial class FormNovoAluno : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public decimal Nota1 { get { return numericUpDownNota1.Value; } }
        public decimal Nota2 { get { return numericUpDownNota2.Value; } }
        public decimal Nota3 { get { return numericUpDownNota3.Value; } }
        public decimal Media { get { return ( Nota1 + Nota2 + Nota3) / 3; } }

        public FormNovoAluno()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
