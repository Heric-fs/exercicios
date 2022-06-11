using System;

namespace orientaçaoobjeto2
{
      public class Carro 
      {
       
        
        public string Chassis { get; set; }
        public string Ano { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
        public double  Preco { get; set; }
        public string Motor  { get; set; }

        public Carro(string chassis, string ano, string modelo, string marca, double preco, string motor)
        {
            this.Chassis = chassis;
            this.Ano = ano;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Preco = preco;
            this.Motor = motor;

        }

        public Carro()
        {
        }

        class Program
        {
            static void Main(string[] args)
            {
                Carro carro1 = new Carro(Console.ReadLine(), Console.ReadLine(),
                                                     (Console.ReadLine()),
                                                     Console.ReadLine());

                Console.WriteLine("Chassis:" + carro1.Chassis);
                Console.WriteLine("Ano:" + carro1.Ano);
                Console.WriteLine("Modelo:" + carro1.Modelo);
                Console.WriteLine("Marca:" + carro1.Marca);
                Console.WriteLine("Preço:" + carro1.Preco);
                Console.WriteLine("Motor:" + carro1.Motor);
                






            }
        }
