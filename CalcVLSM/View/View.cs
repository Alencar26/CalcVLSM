using System;
using System.Linq;
using System.Windows.Forms;
using CalcVLSM.Controler;

namespace CalcVLSM
{
    //André Augusto R. Alencar - RA:2019101851
    //Luiz Felipe Andrich - RA: 2019100625
    // Fabiano Zonatto dos Santos - RA:2019203270 (Calouro)

    public partial class View : Form
    {
        private static CalcControler controler = new CalcControler();
       
        // Componentes do Form.
        public View()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (oct1.Text == "" || oct2.Text =="" || oct3.Text =="" || oct4.Text == "" || int.Parse(oct1.Text) > 255 || int.Parse(oct2.Text) > 255 || int.Parse(oct3.Text) > 255 || int.Parse(oct4.Text) > 255)
            {
                MessageBox.Show("IP inválido. Tente novamente...");
                limparControles();
            }
            else
            {
                controler.ObterInfoIP(int.Parse(oct1.Text));
                mostrarinforIP();
                habilitaHosts();
                desabiliarCampoIP();
                convertBinario();


            }
        }
        private void btnRecomeço_Click(object sender, EventArgs e)
        {
            limparControles();
            habilitarCampoIP();
            zerarLabel();
            desabilitaAddHost();
            controler.limparList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddHost_Click(object sender, EventArgs e)
        {
            controler.listarHosts(int.Parse(numHost.Text));
            carregaDataGrid();
            totalHostlbl.Text = $"Total de Hosts: {controler.somaTotalHost()}";
        }
        private void dgvHosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void View_Load(object sender, EventArgs e)
        {
            carregaDataGrid();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculosDeSubrede();
            desabilitarHostAposCalculo();
        }


        // Funções de Interação com Form.
        private void limparControles()
        {
            oct1.Text = "";
            oct2.Text = "";
            oct3.Text = "";
            oct4.Text = "";
            ListaResultados.Items.Clear();
        }  // limpar campos onde o ip é inserido.
        private void carregaDataGrid()
        {
            dgvHosts.DataSource = controler.listarTodosHost().OrderByDescending(x => x.Hosts).ToList();
        }  // carrega o DGV com as informações dos Host
        private void habilitaHosts()
        {
            label4.Enabled = true;
            groupBox3.Enabled = true;
            numHost.Enabled = true;
            btnAddHost.Enabled = true;
            btnCalcular.Enabled = true;
            totalHostlbl.Enabled = true;
            dgvHosts.Enabled = true;

        }   // abilita o campo de host
        private void desabilitaAddHost()
        {
            label4.Enabled = false;
            groupBox3.Enabled = false;
            numHost.Enabled = false;
            btnAddHost.Enabled = false;
            btnCalcular.Enabled = false;
            totalHostlbl.Enabled = false;
            dgvHosts.Enabled = false;
            totalHostlbl.Text = "Total de Hosts:";
            numHost.Text = "";
            dgvHosts.Columns.Clear();
        } // desabilita o campo de host
        private void desabiliarCampoIP()
        {
            oct1.Enabled = false;
            oct2.Enabled = false;
            oct3.Enabled = false;
            oct4.Enabled = false;
            btnProsseguir.Enabled = false;
            
            outIPBase.ForeColor = System.Drawing.Color.Red;
            outMascara.ForeColor = System.Drawing.Color.Red;
            outClasse.ForeColor = System.Drawing.Color.Red;
        } // desabilita o campo do IP e muda as cores das Label
        private void habilitarCampoIP()
        {
            oct1.Enabled = true;
            oct2.Enabled = true;
            oct3.Enabled = true;
            oct4.Enabled = true;
            btnProsseguir.Enabled = true;
        }  // habilita novamente o campo IP
        private void zerarLabel()
        {
            outClasse.Text = "Classe:";
            outIPBase.Text = "IP Base:";
            outMascara.Text = "Máscara:";
            ipBinario.Text = "IP Binário:";
            maskBinario.Text = "Mácasa Binário:";
            outIPBase.ForeColor = System.Drawing.Color.Black;
            outMascara.ForeColor = System.Drawing.Color.Black;
            outClasse.ForeColor = System.Drawing.Color.Black;
        }  // reseta as Label do campo IP e retorna a cor para preto
        private void mostrarinforIP()
        {
            outClasse.Text = $"Classe: {controler.classe}";
            outMascara.Text = $"Máscara: {controler.mascara}";
            outIPBase.Text = controler.ObtemIpBase(oct1.Text, oct2.Text, oct3.Text, oct4.Text);
        } // determina a Classe do IP, mascara e o próprio IP
        private void convertBinario()
        {
             // Converte a ip base para binário.
            string oct1Bin = oct1.Text;
            string oct2Bin = oct2.Text;
            string oct3Bin = oct3.Text;
            string oct4Bin = oct4.Text;

            string bin1 = controler.DecimalParaBinario(oct1Bin);
            string bin2= controler.DecimalParaBinario(oct2Bin);
            string bin3 = controler.DecimalParaBinario(oct3Bin);
            string bin4 = controler.DecimalParaBinario(oct4Bin);

            // mostrar na tela.
            ipBinario.Text = $"IP Base: {bin1}.{bin2}.{bin3}.{bin4}";
            ipBinario.ForeColor = System.Drawing.Color.Blue;

            // AGORA É A MÁCARA <<<< (usando as mesmas variáveis)

            oct1Bin = controler.oct1Dec.ToString();
            oct2Bin = controler.oct2Dec.ToString();
            oct3Bin = controler.oct3Dec.ToString();
            oct4Bin = controler.oct4Dec.ToString();

            bin1 = controler.DecimalParaBinario(oct1Bin);
            bin2 = controler.DecimalParaBinario(oct2Bin);
            bin3 = controler.DecimalParaBinario(oct3Bin);
            bin4 = controler.DecimalParaBinario(oct4Bin);

            maskBinario.Text = $"Máscara Padrão: {bin1}.{bin2}.{bin3}.{bin4}";
            maskBinario.ForeColor = System.Drawing.Color.Blue;
            
        } //  mostra os Binários do IP e da Mácara Padrão
        private void calculosDeSubrede()
        {
            controler.calculosDeSubRede(int.Parse(oct1.Text), int.Parse(oct2.Text), int.Parse(oct3.Text), int.Parse(oct4.Text));
          
            foreach (var item in controler.listaResultado)
            {
                ListaResultados.Items.Add(item);
            }

        } // metodo de calculo para subredes
        private void desabilitarHostAposCalculo()
        {
            label4.Enabled = false;
            groupBox3.Enabled = false;
            numHost.Enabled = false;
            btnAddHost.Enabled = false;
            btnCalcular.Enabled = false;
            totalHostlbl.Enabled = false;
            totalHostlbl.Text = "Total de Hosts:";
            numHost.Text = "";
        } // desabilita campo de host após o calculo
    }
}

