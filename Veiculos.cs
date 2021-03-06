using System;
namespace RentCar //Class models
{
    public class Veiculos //Base class
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }

        public void AdicionarVeiculos() //Methods for adding data
        {
           
            Console.Write("Matricula: ");
            matricula = Convert.ToString(Console.ReadLine());
            Console.Write("Nome do Veículo: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.Write("Marca: ");
            marca = Convert.ToString(Console.ReadLine());
        }

        public virtual void MostrarVeiculos() //Methods for displaying data
        {
            Console.WriteLine();
            Console.WriteLine("Matricula............:" + matricula);
            Console.WriteLine("Nome do Veiculo......:" + nome);
            Console.WriteLine("Marca:...............:" + marca);
        }
    }

    public class Ligeiros : Veiculos //Derived class
    {
        public string modelo { get; set; }
        public string estado { get; set; }

        public void AdicionarVeiculosligeiros() //Constructor methods
        {
            base.AdicionarVeiculos();
            Console.Write("Modelo: ");
            modelo = Convert.ToString(Console.ReadLine());
            Console.Write("Estado do Veiculo: ");
            estado = Convert.ToString(Console.ReadLine());
            Console.ReadLine();
        }

        public override void MostrarVeiculos() //Overriding methods
        {
            base.MostrarVeiculos();
            Console.WriteLine("Modelo...............:" + modelo);
            Console.WriteLine("Estado...............:" + estado);
        }
    }

    public class Pesados : Veiculos //Derived class
    {
        public int peso { get; set; }
        public string carga { get; set; }
        public int numeropassageiros { get; set; }    

        public void AdicionarVeiculosPesados() //Constructor methods
        {
            base.AdicionarVeiculos();
            Console.Write("Peso: ");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Carga do Veiculo: ");
            carga = Convert.ToString(Console.ReadLine());
            Console.Write("Numero de Passageiros: ");
            numeropassageiros = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }

        public override void MostrarVeiculos() //Overriding methods
        {
            base.MostrarVeiculos();
            Console.WriteLine("Peso.................:" + peso);
            Console.WriteLine("Carga................:" + carga);
            Console.WriteLine("Número de Pasageiros.:" + numeropassageiros);
        }
    }

    public class AutoCaravana : Veiculos //Derived class
    {
        public string cbanho { get; set; }
        public string quartos { get; set; }
        public string cozinha { get; set; }

        public void AdicionarAutoCaravana() //Constructor methods
        {
            base.AdicionarVeiculos();
            Console.Write("Tem Casa de Banho?: ");
            cbanho = Convert.ToString(Console.ReadLine());
            Console.Write("Tem Casa de Quarto?: ");
            quartos = Convert.ToString(Console.ReadLine());
            Console.Write("Tem Casa de cozinha?: ");
            cozinha = Convert.ToString(Console.ReadLine());
            Console.ReadLine();
        }

        public override void MostrarVeiculos() //Overriding methods
        {
            base.MostrarVeiculos();
            Console.WriteLine("Casa de Banho........:" + cbanho);
            Console.WriteLine("Quartos..............:" + quartos);
            Console.WriteLine("Cozinha..............:" + cozinha);
        }
    }

    public class AvioesBarcos : Veiculos //Derived class
    {
        public int tamanho { get; set; }
        public int potencia { get; set; }

        public void AdicionarAvioesBarcos() //Constructor methods
        {
            base.AdicionarVeiculos();
            Console.Write("Tamanho: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Potencia do motor: ");
            potencia = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        public override void MostrarVeiculos() //Overriding methods
        {
            base.MostrarVeiculos();
            Console.WriteLine("Tamanho..............:" + tamanho);
            Console.WriteLine("Potencia.............:" + potencia);
        }
    }
}



