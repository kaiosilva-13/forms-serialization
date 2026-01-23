namespace projeto_wf
{
    partial class Testar_Conexão
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
            tb_senha_teste = new TextBox();
            lb_senha_teste = new Label();
            tb_usuario_teste = new TextBox();
            lb_usuario_teste = new Label();
            btn_testar_conexao = new Button();
            SuspendLayout();
            // 
            // tb_senha_teste
            // 
            tb_senha_teste.Location = new Point(147, 134);
            tb_senha_teste.Name = "tb_senha_teste";
            tb_senha_teste.Size = new Size(206, 23);
            tb_senha_teste.TabIndex = 8;
            tb_senha_teste.UseSystemPasswordChar = true;
            tb_senha_teste.WordWrap = false;
            // 
            // lb_senha_teste
            // 
            lb_senha_teste.AutoSize = true;
            lb_senha_teste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_senha_teste.Location = new Point(45, 132);
            lb_senha_teste.Name = "lb_senha_teste";
            lb_senha_teste.Size = new Size(53, 21);
            lb_senha_teste.TabIndex = 7;
            lb_senha_teste.Text = "Senha";
            // 
            // tb_usuario_teste
            // 
            tb_usuario_teste.Location = new Point(147, 89);
            tb_usuario_teste.Name = "tb_usuario_teste";
            tb_usuario_teste.Size = new Size(206, 23);
            tb_usuario_teste.TabIndex = 6;
            // 
            // lb_usuario_teste
            // 
            lb_usuario_teste.AutoSize = true;
            lb_usuario_teste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_usuario_teste.Location = new Point(45, 91);
            lb_usuario_teste.Name = "lb_usuario_teste";
            lb_usuario_teste.Size = new Size(64, 21);
            lb_usuario_teste.TabIndex = 5;
            lb_usuario_teste.Text = "Usuário";
            // 
            // btn_testar_conexao
            // 
            btn_testar_conexao.Location = new Point(45, 180);
            btn_testar_conexao.Name = "btn_testar_conexao";
            btn_testar_conexao.Size = new Size(308, 23);
            btn_testar_conexao.TabIndex = 9;
            btn_testar_conexao.Text = "Testar conexão";
            btn_testar_conexao.UseVisualStyleBackColor = true;
            // 
            // Testar_Conexão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 284);
            Controls.Add(btn_testar_conexao);
            Controls.Add(tb_senha_teste);
            Controls.Add(lb_senha_teste);
            Controls.Add(tb_usuario_teste);
            Controls.Add(lb_usuario_teste);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Testar_Conexão";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Testar_Conexão";
            Load += Testar_Conexão_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_senha_teste;
        private Label lb_senha_teste;
        private TextBox tb_usuario_teste;
        private Label lb_usuario_teste;
        private Button btn_testar_conexao;
    }
}