namespace projeto_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar_Usuário adicionar_usuario = new Adicionar_Usuário();
            adicionar_usuario.ShowDialog();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_Usuário editar_usuario = new Editar_Usuário();
            editar_usuario.ShowDialog();
        }

        private void removerUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remover_Usuário remover_usuario = new Remover_Usuário();
            remover_usuario.ShowDialog();
        }

        private void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testar_Conexão testar_conexao = new Testar_Conexão();
            testar_conexao.ShowDialog();
        }
    }
}
