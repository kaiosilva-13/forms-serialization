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
            adicionar_usuario.MdiParent = this;
            adicionar_usuario.Show();
        }
        private void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testar_Conexão testar_conexao = new Testar_Conexão();
            testar_conexao.MdiParent = this;
            testar_conexao.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
