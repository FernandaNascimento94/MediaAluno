using System.ComponentModel;

namespace MediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionarAluno_Click(object sender, EventArgs e)
        {
            FormNovoAluno formNovoAluno = new FormNovoAluno();
            DialogResult resultado = formNovoAluno.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string textoMedia = $"{formNovoAluno.Nome} {formNovoAluno.Media}";
                listBoxAlunos.Items.Add(textoMedia);
            }
        }

        private void buttonDeletarAluno_Click(object sender, EventArgs e)
        {
            if (listBoxAlunos.Items.Count > 0)
            {
                if (listBoxAlunos.SelectedIndex >= 0)
                {
                    listBoxAlunos.Items.RemoveAt(listBoxAlunos.SelectedIndex);
                }
            }
        }
    }
}
