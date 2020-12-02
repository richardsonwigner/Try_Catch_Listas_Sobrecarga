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
        public List<Data> DatasAdicionadas(List<Data> datas)
        {
            return datas.Where(x => x.Contains(datas)).ToList();
        }

      
    }
}
