namespace Trabalho
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
            panel1 = new Panel();
            buttonRemover = new Button();
            buttonAdicionar = new Button();
            textDesconto = new TextBox();
            textValorJogo = new TextBox();
            textNomeJogo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            textTotal = new TextBox();
            dataGridViewJogos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 29, 44);
            panel1.BackgroundImage = Properties.Resources.Steam;
            panel1.Controls.Add(buttonRemover);
            panel1.Controls.Add(buttonAdicionar);
            panel1.Controls.Add(textDesconto);
            panel1.Controls.Add(textValorJogo);
            panel1.Controls.Add(textNomeJogo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 85);
            panel1.TabIndex = 0;
            // 
            // buttonRemover
            // 
            buttonRemover.ForeColor = Color.Black;
            buttonRemover.Location = new Point(767, 39);
            buttonRemover.Margin = new Padding(5);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(116, 33);
            buttonRemover.TabIndex = 7;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.ForeColor = Color.Black;
            buttonAdicionar.Location = new Point(634, 39);
            buttonAdicionar.Margin = new Padding(5);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(123, 33);
            buttonAdicionar.TabIndex = 6;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // textDesconto
            // 
            textDesconto.Location = new Point(506, 39);
            textDesconto.Margin = new Padding(5);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(95, 33);
            textDesconto.TabIndex = 5;
            // 
            // textValorJogo
            // 
            textValorJogo.Location = new Point(338, 39);
            textValorJogo.Margin = new Padding(5);
            textValorJogo.Name = "textValorJogo";
            textValorJogo.Size = new Size(130, 33);
            textValorJogo.TabIndex = 4;
            // 
            // textNomeJogo
            // 
            textNomeJogo.Location = new Point(14, 39);
            textNomeJogo.Margin = new Padding(5);
            textNomeJogo.Name = "textNomeJogo";
            textNomeJogo.Size = new Size(304, 33);
            textNomeJogo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 9);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Desconto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 9);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Valor do jogo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome do jogo:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 29, 44);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textTotal);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 410);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 46);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 7;
            label4.Text = "Valor total da compra:";
            // 
            // textTotal
            // 
            textTotal.BackColor = Color.FromArgb(58, 107, 142);
            textTotal.BorderStyle = BorderStyle.None;
            textTotal.ForeColor = Color.White;
            textTotal.Location = new Point(204, 11);
            textTotal.Margin = new Padding(5);
            textTotal.Name = "textTotal";
            textTotal.ReadOnly = true;
            textTotal.Size = new Size(119, 26);
            textTotal.TabIndex = 6;
            textTotal.TextChanged += textTotal_TextChanged;
            // 
            // dataGridViewJogos
            // 
            dataGridViewJogos.AllowUserToAddRows = false;
            dataGridViewJogos.AllowUserToDeleteRows = false;
            dataGridViewJogos.BackgroundColor = Color.FromArgb(28, 44, 66);
            dataGridViewJogos.BorderStyle = BorderStyle.None;
            dataGridViewJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewJogos.Dock = DockStyle.Fill;
            dataGridViewJogos.Location = new Point(0, 85);
            dataGridViewJogos.Margin = new Padding(5);
            dataGridViewJogos.Name = "dataGridViewJogos";
            dataGridViewJogos.ReadOnly = true;
            dataGridViewJogos.Size = new Size(1017, 325);
            dataGridViewJogos.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Jogo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Valor";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Desconto";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor com desconto";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 210;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 456);
            Controls.Add(dataGridViewJogos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Carrinho da Steam";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRemover;
        private Button buttonAdicionar;
        private TextBox textDesconto;
        private TextBox textValorJogo;
        private TextBox textNomeJogo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox textTotal;
        private DataGridView dataGridViewJogos;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
