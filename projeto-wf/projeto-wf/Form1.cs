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
            if (Application.OpenForms.Count > 1)
            {
                var result = MessageBox.Show("Uma janela está aberta no momento, para abrir uma outra,feche a janela atual.Deseja fechar a janela atual e abrir uma nova janela?", "Erro ao abrir janela", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    this.ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }

            }
            Adicionar_Usuário adicionar_usuario = new Adicionar_Usuário();
            adicionar_usuario.MdiParent = this;
            adicionar_usuario.Show();
        }
        private void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                var result = MessageBox.Show("Uma janela está aberta no momento, para abrir uma outra,feche a janela atual.Deseja fechar a janela atual e abrir uma nova janela?", "Erro ao abrir janela", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    this.ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }
            }
            Testar_Conexão testar_conexao = new Testar_Conexão();
            testar_conexao.MdiParent = this;
            testar_conexao.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                var result = MessageBox.Show("Uma janela está aberta no momento, para abrir uma outra,feche a janela atual.Deseja fechar a janela atual e abrir uma nova janela?", "Erro ao abrir janela", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    this.ActiveMdiChild.Close();
                }
                else
                {
                    return;
                }
            }
            Listar_Usuário listar_usuario = new Listar_Usuário();
            listar_usuario.MdiParent = this;
            listar_usuario.Show();
        }
    }
}
