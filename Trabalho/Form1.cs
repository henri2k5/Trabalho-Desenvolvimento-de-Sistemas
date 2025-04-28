namespace Trabalho
{
    public partial class Form1 : Form
    {
        double somaTotalCompra = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos para que o usuário não se esqueça de escrever nada
            if (string.IsNullOrWhiteSpace(textNomeJogo.Text))
            {
                MessageBox.Show("Digite o nome do jogo", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNomeJogo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textValorJogo.Text))
            {
                MessageBox.Show("Digite o valor do jogo", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textValorJogo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textDesconto.Text))
            {
                MessageBox.Show("Digite a porcentagem do desconto recebido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDesconto.Focus();
                return;
            }

            // Transforma os textos de valor e desconto em variáveis do tipo float para fazer os cálculos
            float valorJogo, desconto;
            if (!float.TryParse(textValorJogo.Text, out valorJogo))
            {
                MessageBox.Show("Valor do jogo inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textValorJogo.Focus();
                return;
            }

            if (!float.TryParse(textDesconto.Text, out desconto))
            {
                MessageBox.Show("Valor do desconto inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDesconto.Focus();
                return;
            }

            // Cálculo para mostrar o valor com desconto na tabela
            float valorComDesconto = valorJogo - (valorJogo * (desconto / 100));

            // Adicionar os dados na tabela
                dataGridViewJogos.Rows.Add
                (textNomeJogo.Text,
                valorJogo.ToString("N2"),
                desconto,
                valorComDesconto.ToString("N2"));

            //Cálculo para mostrar o valor total gasto no textTotal

            somaTotalCompra += valorComDesconto;
            textTotal.Text = somaTotalCompra.ToString("N2");

            // Limpeza dos campos
            textNomeJogo.Clear();
            textValorJogo.Clear();
            textDesconto.Clear();
            textNomeJogo.Focus();

        }


        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewJogos.SelectedRows.Count > 0)
            {
                // Remove a linha selecionada
                dataGridViewJogos.Rows.RemoveAt(dataGridViewJogos.SelectedRows[0].Index);

                // Conta para recalcular o total depois de remover um jogo
                RecalcularTotal();
            }
            else
            {
                MessageBox.Show("Selecione a linha que deseja remover", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecalcularTotal()
        {
            double novoTotal = 0.0;

            foreach (DataGridViewRow linha in dataGridViewJogos.Rows)
            {
                {
                    double valorLinha = double.Parse(linha.Cells[3].Value.ToString());
                    novoTotal += valorLinha;
                }
            }

            somaTotalCompra = novoTotal;
            textTotal.Text = somaTotalCompra.ToString("N2");
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
