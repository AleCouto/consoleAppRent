using System;

namespace RentCar
{
    class Program
    {
        public static string opc;
        public static string opc2;

        static void Main(string[] args)
        {
            Console.Clear();
            Inicio();
        }

         private static void Inicio()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Bem Vindo ao Rent Manager 1.0");
                Console.WriteLine("------------------------------");
                Console.WriteLine("--Selecione a opção desejada--");
                Console.WriteLine("[1] Adicionar Novo Veículo");
                Console.WriteLine("[2] Listar todos os Veículos");
                Console.WriteLine("[3] Pesquisar por Matricula");
                Console.WriteLine("[4] Pesquisar por Nome");
                Console.WriteLine("[5] Remover Veículo");
                Console.WriteLine("[6] Encerrar Programa");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine();
                        SelecionarTipo();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        listarVeiculos();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        PesquisaMatriculas();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        PesquisaNomes();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        RemoverVeiculos();
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        Console.WriteLine("Fim Do Programa Rent Manager 1.0");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc != "6");
        }

        private static void RemoverVeiculos()
        {
            Tratamento.RemoverVeiculo();
        }

        private static void PesquisaNomes()
        {
            Tratamento.PesquisaNome();
        }

        private static void PesquisaMatriculas()
        {
            Tratamento.PesquisaMatriculas();
        }

        private static void listarVeiculos()
        {
            Tratamento.ListarVeiculo();
        }

        private static void SelecionarTipo()
        {
            do
            {
              Console.Clear();
              Console.WriteLine("------------------------------");
              Console.WriteLine("Qual o Tipo de Veículo Irá Adicionar");
              Console.WriteLine("[1] Automoveis Ligeiros");
              Console.WriteLine("[2] Automoveis Pesados");
              Console.WriteLine("[3] Autocaravanas");
              Console.WriteLine("[4] Aviões ou Barcos");
              Console.WriteLine("[5] Voltar");
              Console.WriteLine("------------------------------");
              Console.Write("Opção: ");
                opc2 = Console.ReadLine();
                switch (opc2)
                {
                    case "1":
                        Console.WriteLine();
                        AddVeicLig();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        AddVeicPes();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        AddCravan();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        AddAvioesBarco();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        voltar(); 
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc2 != "5");
        }

        private static void voltar()
        {
            Inicio();
        }

        private static void AddAvioesBarco()
        {
            Tratamento.AdicionarNovoAviaoBarco();
        }

        private static void AddCravan()
        {
            Tratamento.AdicionarNovoVeiculoCaravan();
        }

        private static void AddVeicPes()
        {
            Tratamento.AdicionarNovoVeiculoPesado();
        }

        private static void AddVeicLig()
        {
            Tratamento.AdicionarNovoVeiculoligeiro();
        }
    }
}
