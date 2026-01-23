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
            editarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            removerUsuárioToolStripMenuItem = new ToolStripMenuItem();
            testarConexãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(559, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarUsuárioToolStripMenuItem, editarUsuárioToolStripMenuItem, removerUsuárioToolStripMenuItem, testarConexãoToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            adicionarUsuárioToolStripMenuItem.Size = new Size(180, 22);
            adicionarUsuárioToolStripMenuItem.Text = "&Adicionar Usuário";
            adicionarUsuárioToolStripMenuItem.Click += adicionarUsuárioToolStripMenuItem_Click;
            // 
            // editarUsuárioToolStripMenuItem
            // 
            editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            editarUsuárioToolStripMenuItem.Size = new Size(180, 22);
            editarUsuárioToolStripMenuItem.Text = "&Editar Usuário";
            editarUsuárioToolStripMenuItem.Click += editarUsuárioToolStripMenuItem_Click;
            // 
            // removerUsuárioToolStripMenuItem
            // 
            removerUsuárioToolStripMenuItem.Name = "removerUsuárioToolStripMenuItem";
            removerUsuárioToolStripMenuItem.Size = new Size(180, 22);
            removerUsuárioToolStripMenuItem.Text = "&Remover Usuário";
            removerUsuárioToolStripMenuItem.Click += removerUsuárioToolStripMenuItem_Click;
            // 
            // testarConexãoToolStripMenuItem
            // 
            testarConexãoToolStripMenuItem.Name = "testarConexãoToolStripMenuItem";
            testarConexãoToolStripMenuItem.Size = new Size(180, 22);
            testarConexãoToolStripMenuItem.Text = "&Testar conexão";
            testarConexãoToolStripMenuItem.Click += testarConexãoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 371);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciados de Usuários de Rede";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private ToolStripMenuItem removerUsuárioToolStripMenuItem;
        private ToolStripMenuItem testarConexãoToolStripMenuItem;
    }
}
