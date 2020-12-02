using System;

namespace Try_Catch_Listas_Sobrecarga
{
    class Program
    {
        static Data dia = new Data();
        static void Main(string[] args)
        {
            PedirUsuario();
          
        }
        public static void PedirUsuario()
        {
            Console.WriteLine("O que deseja fazer?\n1:Ver Data Atual\n2:Adicionar Data");
            if(dia.Datas.Count != 0)
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
                dia.DatasAdicionadas(dia.Datas);
                PedirUsuario();
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
                    dia.Datas.Add(new Data(Dia, Mes, Ano));
                    Console.WriteLine("Deseja adicionar mais uma data?\n1:Sim\n2:Não");                  
                    string EscolhaUsuario = Console.ReadLine();
                    if  (EscolhaUsuario == "1")
                    {
                        AdicionarData();
                    }
                    else if (EscolhaUsuario == "2")
                    {
                        Loop = false;
                        PedirUsuario();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Data Inválida");
                }
            }
        }
    }
}
