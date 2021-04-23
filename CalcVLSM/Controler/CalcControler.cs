using System;
using System.Collections.Generic;
using System.Linq;
using CalcVLSM.Entidade;

namespace CalcVLSM.Controler
{
    //André Augusto R. Alencar - RA:2019101851
    //Luiz Felipe Andrich - RA: 2019100625
    // Fabiano Zonatto dos Santos - RA:2019203270 (Calouro)

    public class CalcControler
    {
        public static List<NumHost> listaDeHost = new List<NumHost>();
        public static List<int> listaDeHostBase2 = new List<int>();
        public List<string> listaResultado = new List<string>();

        public string mascara;
        public string classe;
        public string ip;
        public int oct1Dec;
        public int oct2Dec;
        public int oct3Dec;
        public int oct4Dec;
        public int mascaraInt;
        public double numBase2;
        public int listaEmOrdemDecrescente;
       
        

        public void ObterInfoIP(int priOct)
        {
            EstruturaIP ipInfo = new EstruturaIP();
            if (priOct >= 0 && priOct <= 127)
            {
                oct1Dec = 255;
                oct2Dec = 0;
                oct3Dec = 0;
                oct4Dec = 0;
                
                mascara = $"{oct1Dec}.{oct2Dec}.{oct3Dec}.{oct4Dec}";
                classe = "A";
        
            }
            else if (priOct >= 128 && priOct <= 191)
            {
                oct1Dec = 255;
                oct2Dec = 255;
                oct3Dec = 0;
                oct4Dec = 0;
                
                mascara = $"{oct1Dec}.{oct2Dec}.{oct3Dec}.{oct4Dec}";
                classe = "B";
                
            }
            else if (priOct >= 192 && priOct <= 223)
            {
                oct1Dec = 255;
                oct2Dec = 255;
                oct3Dec = 255;
                oct4Dec = 0;
               
                mascara = $"{oct1Dec}.{oct2Dec}.{oct3Dec}.{oct4Dec}";
                classe = "C";
                
            }
            else if (priOct >= 224 && priOct <= 239)
            {
                oct1Dec = 255;
                oct2Dec = 255;
                oct3Dec = 255;
                oct4Dec = 255;
               
                mascara = $"{oct1Dec}.{oct2Dec}.{oct3Dec}.{oct4Dec}";
                classe = "D - (Multcast)";
                
            }
            else if (priOct >= 240 && priOct <= 255)
            {
                oct1Dec = 255;
                oct2Dec = 255;
                oct3Dec = 255;
                oct4Dec = 255;
                
                mascara = $"{oct1Dec}.{oct2Dec}.{oct3Dec}.{oct4Dec}";
                classe = "E - (Novas Tecnologias)";
               
            
            }
            ipInfo.mascara = mascara;
            ipInfo.classe = classe;
        } // obtem a classe padrão
        public string ObtemIpBase(string oct1,string oct2,string oct3, string oct4)
        {
            string ipBase = $"IP Base: {oct1}.{oct2}.{oct3}.{oct4}";
            return ipBase;
        } // obtem o IP Base e retorna o mesmo
        public void listarHosts(int numDeHost)
        {
            var host = new NumHost();
            host.Hosts = numDeHost;
            numDeHost = numDeHost + 2;
            host.HostMais2 = numDeHost;
            
            for (int i = 1; i < numDeHost; i++)
            {
                numBase2 = Math.Pow(2, i);
                if (numBase2 >= numDeHost)
                {
                    break;
                }
            }
            
            host.HostTotal = int.Parse(numBase2.ToString());
            listaDeHost.Add(host);
            listaDeHostBase2.Add(int.Parse(numBase2.ToString()));
        } // adiciona os Host , host + 2 e host base 2
        internal List<NumHost> listarTodosHost()
        {
            return listaDeHost;
        } // lista os hosts para aparecer Na DataGridView
        public int somaTotalHost()
        {
            var somaDosHosts = listaDeHost.Sum(x => x.HostTotal);
            return somaDosHosts;
        } // obtem o total de host base 2 que a lista tem.
        public string InverterSequenciaCaracteres(string numDecimal)
        {
            int tamanhoDeCaracteres = numDecimal.Length;

            char[] caracteres = new char[tamanhoDeCaracteres];

            for (int i = 0; i < tamanhoDeCaracteres; i++)
            {
                caracteres[i] = numDecimal[tamanhoDeCaracteres - 1 - i];
            }

            return new string(caracteres);
        } // inverte a sequência do números(string) para conversão em Binário
        public string DecimalParaBinario(string numero)
        {

            string valor = "";

            int numParaDivisao = Convert.ToInt32(numero);

            while (numParaDivisao > 0)
            {

                valor += Convert.ToString(numParaDivisao % 2);

                numParaDivisao = numParaDivisao / 2;

            }

             // COMPLEMENTO DOS ZEROS RESTANTES.
                for (int i = 0; valor.Length < 8; i++)
                {
                string bitCompl = "0";
                bitCompl += bitCompl;
                valor = valor + bitCompl;
                }
                // VERIFICAR ESSA PARTE <<< não está incrementando os "0" restantes.
            
            return InverterSequenciaCaracteres(valor);

        } // função para converter em binário
        public void calculosDeSubRede(int oct1, int oct2, int oct3, int oct4)
        {
            // teste de sub redes e mascaras custon
            int subnet1 = oct1;
            int subnet2 = oct2;
            int subnet3 = oct3;
            int subnet4 = oct4;
            int broadcast = -1;

            var listaEmOrdem = new List<int>();
           foreach (var item in listaDeHostBase2.OrderByDescending(x => x))
           {
              listaEmOrdem.Add(item);
           }


            if (oct1 != 0 && oct2 != 0 && oct3 != 0 && oct4 == 0)
            {
                for (int i = 0; i < listaEmOrdem.Count; i++)
                {
                    listaEmOrdemDecrescente = listaEmOrdem[i];
                    string mascaraCustomDec = (256 - listaEmOrdemDecrescente).ToString(); // máscara decimal 
                    string mascaraCustomBin = DecimalParaBinario(mascaraCustomDec);   // transforma a máscara para binário

                    string subnetDecimal = $"{i}-Subnet: {subnet1}.{subnet2}.{subnet3}.{subnet4 + broadcast + 1}";
                    broadcast += listaEmOrdem[i];
                    string broadCast = $"BroadCast: {subnet1}.{subnet2}.{subnet3}.{broadcast}";
                    
                    oct1 = 255;
                    oct2 = 255;
                    oct3 = 255;
                    oct4 = 0;
                    oct1Dec = int.Parse(DecimalParaBinario(oct1.ToString()));
                    oct2Dec = int.Parse(DecimalParaBinario(oct2.ToString()));
                    oct3Dec = int.Parse(DecimalParaBinario(oct3.ToString()));
                    oct4Dec = int.Parse(DecimalParaBinario(oct4.ToString()));

                    string retornoMascaraCustomDec = $"Máscara Custom: {oct1}.{oct2}.{oct3}.{mascaraCustomDec}";
                    string retornaMascaraCustom = $"Máscara Custom Binário: {oct1Dec}.{oct2Dec}.{oct3Dec}.{mascaraCustomBin}";

                    string resultado = $"{subnetDecimal} -{retornoMascaraCustomDec} - {retornaMascaraCustom} - {broadCast}";
                    listaResultado.Add(resultado);
                }
            }
            else if (oct1 != 0 && oct2 != 0 && oct3 == 0 && oct4 == 0)
            {
                for (int i = 0; i < listaEmOrdem.Count; i++)
                {
                    listaEmOrdemDecrescente = listaEmOrdem[i];
                    string mascaraCustomDec = (256 - listaEmOrdemDecrescente).ToString(); // máscara decimal 
                    string mascaraCustomBin = DecimalParaBinario(mascaraCustomDec);   // transforma a máscara para binário
                    
                    

                    string subnetDecimal = $"{i}-Subnet: {subnet1}.{subnet2}.{subnet3 + broadcast + 1}.{subnet4}";
                    broadcast += listaEmOrdem[i];
                    string broadCast = $"BroadCast: {subnet1}.{subnet2}.{broadcast}.{subnet4}";
                    oct1 = 255;
                    oct2 = 255;
                    oct3 = 0;
                    oct4 = 0;
                    oct1Dec = int.Parse(DecimalParaBinario(oct1.ToString()));
                    oct2Dec = int.Parse(DecimalParaBinario(oct2.ToString()));
                    oct3Dec = int.Parse(DecimalParaBinario(oct3.ToString()));
                    oct4Dec = int.Parse(DecimalParaBinario(oct4.ToString()));
                    string retornoMascaraCustomDec = $"Máscara Custom: {oct1}.{oct2}.{oct3}.{mascaraCustomDec}";
                    string retornaMascaraCustom = $"Máscara Custom: {oct1Dec}.{oct2Dec}.{mascaraCustomBin}.{oct4Dec}";
                    string resultado = $"{subnetDecimal} -{retornoMascaraCustomDec} - {retornaMascaraCustom} - {broadCast} \n ";

                    listaResultado.Add(resultado);
                } }

            else if (oct1 != 0 && oct2 == 0 && oct3 == 0 && oct4 == 0)
            {
                for (int i = 0; i < listaEmOrdem.Count; i++)
                {
                    listaEmOrdemDecrescente = listaEmOrdem[i];
                    string mascaraCustomDec = (256 - listaEmOrdemDecrescente).ToString(); // máscara decimal 
                    string mascaraCustomBin = DecimalParaBinario(mascaraCustomDec);   // transforma a máscara para binário
                  
                    
                    string subnetDecimal = $"{i}-Subnet: {subnet1}.{subnet2 + broadcast + 1}.{subnet3}.{subnet4}";
                    broadcast += listaEmOrdem[i];
                    string broadCast = $"BroadCast: {subnet1}.{broadcast}.{subnet3}.{subnet4}";
                    oct1 = 255;
                    oct2 = 0;
                    oct3 = 0;
                    oct4 = 0;
                    oct1Dec = int.Parse(DecimalParaBinario(oct1.ToString()));
                    oct2Dec = int.Parse(DecimalParaBinario(oct2.ToString()));
                    oct3Dec = int.Parse(DecimalParaBinario(oct3.ToString()));
                    oct4Dec = int.Parse(DecimalParaBinario(oct4.ToString()));
                    string retornoMascaraCustomDec = $"Máscara Custom: {oct1}.{oct2}.{oct3}.{mascaraCustomDec}";
                    string retornaMascaraCustom = $"Máscara Custom: {oct1Dec}.{mascaraCustomBin}.{oct3Dec}.{oct4Dec}";
                    string resultado = $"{subnetDecimal} -{retornoMascaraCustomDec} - {retornaMascaraCustom} - {broadCast} \n ";

                    listaResultado.Add(resultado);

            }   }
        } // função de calculos de SubRede
        public string motrarListaResultado()
        {
            foreach (var item in listaResultado)
            {
                return item;
            }
            return null;
        } // lista que detem todos os resultados dos calculos de subrede, ela é encaminhada para a View
        public void limparList()
        {
            listaDeHost.Clear();
            listaResultado.Clear();
            listaDeHostBase2.Clear();
        } // função que limpa as listas para novos calculos

    }    
       
        

    
}
