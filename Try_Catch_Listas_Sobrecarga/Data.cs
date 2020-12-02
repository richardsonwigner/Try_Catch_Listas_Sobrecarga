using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Try_Catch_Listas_Sobrecarga
{
    class Data
    {
        List<Data> datas = new List<Data>();
        int dia;
        int mes;
        int ano;

        public Data()
        {
           
        }
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public List<Data> Datas
        {
            get { return datas; }
        }
        public static void DataAtual()
        {          
            Console.WriteLine(DateTime.Today.ToString());
        }
        public void DatasAdicionadas(List<Data> datas)
        {
            datas.ForEach(data => Console.WriteLine(data.ToString()));
            Console.WriteLine("Deseja Escolher Uma data?\n1:Sim\n2:Não");
            int EscolhaUsuario = int.Parse(Console.ReadLine());
            if (EscolhaUsuario == 1)
            {
                EscolherData();
            }
            else if(EscolhaUsuario == 2)
            {
                Program.PedirUsuario();
            }
        }
        public void EscolherData()
        {
            Console.WriteLine("Escolha Um dia");
            int diaEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine("1:Aumentar um dia\n2:Diminuir um Dia\n");
            int OperacaoEscolhida = int.Parse(Console.ReadLine());
            if (OperacaoEscolhida == 1)
            {
                AumentarUmDia(diaEscolhido);
                Program.PedirUsuario();
            }
            if (OperacaoEscolhida == 2)
            {
                DiminuirUmDia(diaEscolhido);
                Program.PedirUsuario();
            }
        }
        public void AumentarUmDia(int diaEscolhido)
        {
            Data diaescolhido = datas.Find(number => number.dia == diaEscolhido);
            diaescolhido.dia += 1;
        }
        public void DiminuirUmDia(int diaEscolhido)
        {
            Data diaescolhido = datas.Find(number => number.dia == diaEscolhido);
            diaescolhido.dia -= 1;
        }
        public override string ToString()
        {
            return $"{dia}/{mes}/{ano}";
        }           
    }
}
