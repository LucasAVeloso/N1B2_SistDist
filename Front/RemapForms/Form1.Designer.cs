namespace RemapForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox01 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPFBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefoneBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnderecoBox = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.EstadoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CidadeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox01
            // 
            this.TextBox01.Location = new System.Drawing.Point(16, 128);
            this.TextBox01.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox01.Name = "TextBox01";
            this.TextBox01.Size = new System.Drawing.Size(559, 215);
            this.TextBox01.TabIndex = 0;
            this.TextBox01.Text = "";
            this.TextBox01.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listar usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Listar medicoes vento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "Listar medicoes solares";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(422, 82);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 19);
            this.button4.TabIndex = 6;
            this.button4.Text = "Listar dados usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(422, 106);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 19);
            this.button5.TabIndex = 7;
            this.button5.Text = "Deletar usuario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Usuario";
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(706, 19);
            this.NomeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(132, 20);
            this.NomeBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF";
            // 
            // CPFBox
            // 
            this.CPFBox.Location = new System.Drawing.Point(706, 58);
            this.CPFBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CPFBox.Mask = "00000000000";
            this.CPFBox.Name = "CPFBox";
            this.CPFBox.Size = new System.Drawing.Size(132, 20);
            this.CPFBox.TabIndex = 11;
            // 
            // TelefoneBox
            // 
            this.TelefoneBox.Location = new System.Drawing.Point(706, 93);
            this.TelefoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelefoneBox.Mask = "00000000000";
            this.TelefoneBox.Name = "TelefoneBox";
            this.TelefoneBox.Size = new System.Drawing.Size(132, 20);
            this.TelefoneBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefone";
            // 
            // EnderecoBox
            // 
            this.EnderecoBox.Location = new System.Drawing.Point(706, 128);
            this.EnderecoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnderecoBox.Name = "EnderecoBox";
            this.EnderecoBox.Size = new System.Drawing.Size(132, 20);
            this.EnderecoBox.TabIndex = 15;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Location = new System.Drawing.Point(632, 128);
            this.Endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(53, 13);
            this.Endereco.TabIndex = 14;
            this.Endereco.Text = "Endereco";
            // 
            // EstadoBox
            // 
            this.EstadoBox.Location = new System.Drawing.Point(706, 166);
            this.EstadoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EstadoBox.Name = "EstadoBox";
            this.EstadoBox.Size = new System.Drawing.Size(132, 20);
            this.EstadoBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // CidadeBox
            // 
            this.CidadeBox.Location = new System.Drawing.Point(706, 202);
            this.CidadeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CidadeBox.Name = "CidadeBox";
            this.CidadeBox.Size = new System.Drawing.Size(132, 20);
            this.CidadeBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cidade";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(634, 242);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 19);
            this.button6.TabIndex = 20;
            this.button6.Text = "Cadastrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 404);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CidadeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EstadoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnderecoBox);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.TelefoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPFBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox01);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CPFBox;
        private System.Windows.Forms.MaskedTextBox TelefoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnderecoBox;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox EstadoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CidadeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
    }
}

