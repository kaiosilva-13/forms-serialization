namespace projeto_wf
{
    partial class Adicionar_Usuário
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
            lb_usuario = new Label();
            tb_usuario = new TextBox();
            lb_ip = new Label();
            lb_senha = new Label();
            tb_senha = new TextBox();
            tb_ip = new TextBox();
            btn_adicionar_usuario = new Button();
            btn_remover_usuario = new Button();
            SuspendLayout();
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_usuario.Location = new Point(44, 60);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(64, 21);
            lb_usuario.TabIndex = 0;
            lb_usuario.Text = "Usuário";
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(146, 58);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(206, 23);
            tb_usuario.TabIndex = 1;
            // 
            // lb_ip
            // 
            lb_ip.AutoSize = true;
            lb_ip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_ip.Location = new Point(44, 144);
            lb_ip.Name = "lb_ip";
            lb_ip.Size = new Size(23, 21);
            lb_ip.TabIndex = 2;
            lb_ip.Text = "IP";
            // 
            // lb_senha
            // 
            lb_senha.AutoSize = true;
            lb_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_senha.Location = new Point(44, 101);
            lb_senha.Name = "lb_senha";
            lb_senha.Size = new Size(53, 21);
            lb_senha.TabIndex = 3;
            lb_senha.Text = "Senha";
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(146, 103);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(206, 23);
            tb_senha.TabIndex = 4;
            tb_senha.UseSystemPasswordChar = true;
            tb_senha.WordWrap = false;
            tb_senha.TextChanged += textBox2_TextChanged;
            // 
            // tb_ip
            // 
            tb_ip.Location = new Point(146, 142);
            tb_ip.Name = "tb_ip";
            tb_ip.Size = new Size(206, 23);
            tb_ip.TabIndex = 5;
            // 
            // btn_adicionar_usuario
            // 
            btn_adicionar_usuario.Location = new Point(44, 189);
            btn_adicionar_usuario.Name = "btn_adicionar_usuario";
            btn_adicionar_usuario.Size = new Size(308, 23);
            btn_adicionar_usuario.TabIndex = 6;
            btn_adicionar_usuario.Text = "Adicionar Usuário";
            btn_adicionar_usuario.UseVisualStyleBackColor = true;
            // 
            // btn_remover_usuario
            // 
            btn_remover_usuario.Location = new Point(44, 229);
            btn_remover_usuario.Name = "btn_remover_usuario";
            btn_remover_usuario.Size = new Size(308, 23);
            btn_remover_usuario.TabIndex = 7;
            btn_remover_usuario.Text = "Remover Usuário";
            btn_remover_usuario.UseVisualStyleBackColor = true;
            // 
            // Adicionar_Usuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 284);
            Controls.Add(btn_remover_usuario);
            Controls.Add(btn_adicionar_usuario);
            Controls.Add(tb_ip);
            Controls.Add(tb_senha);
            Controls.Add(lb_senha);
            Controls.Add(lb_ip);
            Controls.Add(tb_usuario);
            Controls.Add(lb_usuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Adicionar_Usuário";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuario";
            Load += Adicionar_Usuário_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_usuario;
        private TextBox tb_usuario;
        private Label lb_ip;
        private Label lb_senha;
        private TextBox tb_senha;
        private TextBox tb_ip;
        private Button btn_adicionar_usuario;
        private Button btn_remover_usuario;
    }
}