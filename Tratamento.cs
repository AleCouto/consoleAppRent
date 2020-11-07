using System;
using System.Collections.Generic;

namespace RentCar
{
    public class Tratamento
    {
        static private List<Veiculos> listaVeiculos = new List<Veiculos>();
        static private List<Ligeiros> listaVeiculosLig = new List<Ligeiros>();
        static private List<Pesados> listaVeiculosPes = new List<Pesados>();
        static private List<AutoCaravana> listaVeiculosCaravan = new List<AutoCaravana>();
        static private List<AvioesBarcos> listaVeiculosAviaoBarco = new List<AvioesBarcos>();

        private static int contador = 0;

        public static void AdicionarNovoVeiculoligeiro()
        {
            Ligeiros novoVeiculolig = new Ligeiros();
            novoVeiculolig.AdicionarVeiculosligeiros();
            novoVeiculolig.id = ++contador;
            listaVeiculosLig.Add(novoVeiculolig);
            listaVeiculos.Add(novoVeiculolig);
        }

        public static void AdicionarNovoVeiculoPesado()
        {
            Pesados novoVeiculoPes = new Pesados();
            novoVeiculoPes.AdicionarVeiculosPesados();
            novoVeiculoPes.id = ++contador;
            listaVeiculosPes.Add(novoVeiculoPes);
            listaVeiculos.Add(novoVeiculoPes);
        }

        public static void AdicionarNovoVeiculoCaravan()
        {
            AutoCaravana novoVeiculoCarav = new AutoCaravana();
            novoVeiculoCarav.AdicionarAutoCaravana();
            novoVeiculoCarav.id = ++contador;
            listaVeiculosCaravan.Add(novoVeiculoCarav);
            listaVeiculos.Add(novoVeiculoCarav);
        }

        public static void AdicionarNovoAviaoBarco()
        {
            AvioesBarcos novoVeiculoAvBarc = new AvioesBarcos();
            novoVeiculoAvBarc.AdicionarAvioesBarcos();
            novoVeiculoAvBarc.id = ++contador;
            listaVeiculosAviaoBarco.Add(novoVeiculoAvBarc);
            listaVeiculos.Add(novoVeiculoAvBarc);
        }

        public static void ListarVeiculo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Lista de Veículos: ");
            for (int i = 0; i < listaVeiculos.Count; i++)
            {
                var veiculocorrente = listaVeiculos[i];
                if (veiculocorrente is Ligeiros)
                {
                    listaVeiculos[i].MostrarVeiculos();
                }
                else if (veiculocorrente is Pesados)
                {
                    listaVeiculos[i].MostrarVeiculos();
                }
                else if (veiculocorrente is AutoCaravana)
                {
                    listaVeiculos[i].MostrarVeiculos();
                }
                else if (veiculocorrente is AvioesBarcos)
                {
                    listaVeiculos[i].MostrarVeiculos();
                }
            }
        }

        public static void PesquisaMatriculas()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pesquisa de Veículos por Matricula:");
            Console.Write("Número da Matricula: ");
            string m = Console.ReadLine();
            for (int i = 0; i < listaVeiculos.Count; i++)
            {
                if (listaVeiculos[i].matricula.Contains(m))
                {
                    listaVeiculos[i].MostrarVeiculos();
                }

            }
        }

        public static void PesquisaNome()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pesquisa de Veículos por Nome:");
            Console.Write("Nome do Veiculo: ");
            string m = Console.ReadLine();
            for (int i = 0; i < listaVeiculos.Count; i++)
            {
                if (listaVeiculos[i].nome.Contains(m))
                {
                    listaVeiculos[i].MostrarVeiculos();
                }
            }
        }

        public static void RemoverVeiculo()
        {
            Console.Clear(); 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover Veículo por Matricula:");
            Console.Write("Número da Matricula: ");
            string m = Console.ReadLine();
            for (int i = 0; i < listaVeiculos.Count; i++)
            {
                if (listaVeiculos[i].matricula.Contains(m))
                {
                    listaVeiculos.Remove(listaVeiculos[i]);
                    Console.WriteLine("Veículo Removido");
                }
            }
        }
    }
}
