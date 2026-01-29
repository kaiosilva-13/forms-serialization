namespace projeto_wf
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
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            adicionarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            testarConexãoToolStripMenuItem = new ToolStripMenuItem();
            listarUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(580, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarUsuárioToolStripMenuItem, testarConexãoToolStripMenuItem, listarUsuáriosToolStripMenuItem, sairToolStripMenuItem });
            opçõesToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(65, 21);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            adicionarUsuárioToolStripMenuItem.Size = new Size(182, 22);
            adicionarUsuárioToolStripMenuItem.Text = "&Cadastrar Usuário";
            adicionarUsuárioToolStripMenuItem.Click += adicionarUsuárioToolStripMenuItem_Click;
            // 
            // testarConexãoToolStripMenuItem
            // 
            testarConexãoToolStripMenuItem.Name = "testarConexãoToolStripMenuItem";
            testarConexãoToolStripMenuItem.Size = new Size(182, 22);
            testarConexãoToolStripMenuItem.Text = "&Testar conexão";
            testarConexãoToolStripMenuItem.Click += testarConexãoToolStripMenuItem_Click;
            // 
            // listarUsuáriosToolStripMenuItem
            // 
            listarUsuáriosToolStripMenuItem.Name = "listarUsuáriosToolStripMenuItem";
            listarUsuáriosToolStripMenuItem.Size = new Size(182, 22);
            listarUsuáriosToolStripMenuItem.Text = "&Listar usuários";
            listarUsuáriosToolStripMenuItem.Click += listarUsuáriosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(182, 22);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 393);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Usuários de Rede";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private ToolStripMenuItem testarConexãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem listarUsuáriosToolStripMenuItem;
    }
}
