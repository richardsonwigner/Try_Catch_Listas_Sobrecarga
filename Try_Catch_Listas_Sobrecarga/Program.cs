using System;

namespace Try_Catch_Listas_Sobrecarga
{
    class Program
    {
        static Data diaAtual = new Data();
        static void Main(string[] args)
        {
            PedirUsuario();
          
        }
        public static void PedirUsuario()
        {
            Console.WriteLine(@$"O que deseja fazer?
            1:Ver Data Atual
            2:Adicionar Data");
            if(diaAtual.Datas.Count != 0)
            {
                Console.WriteLine("3:Ver Datas Adicionadas");
            }
            string PedidoUsuario = Console.ReadLine();
            if(PedidoUsuario == "1")
            {
                Data.DataAtual();
            }
            else if (PedidoUsuario == "2")
            {
                AdicionarData();
            }
            else if (PedidoUsuario == "3")
            {
                Data.DatasAdicionadas();
            }
        }
        public static void AdicionarData()
        {
            bool Loop = true;
            while (Loop == true)
            {
                try
                {
                    Console.WriteLine("Adicione o dia");
                    int Dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adicione o mês");
                    int Mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adicione o ano");
                    int Ano = int.Parse(Console.ReadLine());
                    diaAtual.Datas.Add(new Data(Dia, Mes, Ano));
                    Loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Data Inválida");
                }
            }
        }
    }
}
