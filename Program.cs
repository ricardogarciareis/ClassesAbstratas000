using System;

namespace CursoOOP_TestesUnitarios
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    //CLASSE BASE ABSTRATA
    //----------------------------------------------------------------------------------------------------------------------------------------
    public abstract class Forma1   
    {                         
        //Propriedades ---------------------------
        public string Nome { get; set; }
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        //----------------------------------------
        //Métodos Contrutores --------------------


        //----------------------------------------
        //Métodos Comuns -------------------------
        public void Descricao()  
        {
            Console.WriteLine("Descrição: sou um " + this.Nome + " e sou " + this.Cor + ".");
        }
        //----------------------------------------
        //Métodos Abstratos ----------------------
        public abstract double CalcularArea(); 
        public abstract double CalcularPerimetro(); 
        //----------------------------------------
    }

    //----------------------------------------------------------------------------------------------------------------------------------------
    //CLASSE DERIVADA / HERDEIRA
    //----------------------------------------------------------------------------------------------------------------------------------------
    public class Quadrado1 : Forma1
    {
        //Propriedades --------------------------- 
        public double Lado { get; set; }
        //----------------------------------------
        //Implementação obrigatória de métodos abstratos da classe base
        public override double CalcularArea()
        {
            this.Area = Lado * Lado;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            this.Perimetro = 4 * Lado;
            return Perimetro;
        }
        //----------------------------------------
        //Métodos Comuns -------------------------
        public void Informacao()
        {
            Console.WriteLine("Informação: o meu lado mede " + this.Lado + "cm.");
            Console.WriteLine("            Área = " + CalcularArea() + "cm2.");
            Console.WriteLine("            Perímetro = " + CalcularPerimetro() + "cm.");
        }
        //----------------------------------------
    }

    //----------------------------------------------------------------------------------------------------------------------------------------
    //CLASSE PRINCIPAL
    //----------------------------------------------------------------------------------------------------------------------------------------

    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação de objeto da classe herdeira Quadrado
            Quadrado quadrado1 = new Quadrado();
            //Definição de Propriedades do objeto quadrado1
            quadrado1.Nome = "Quadrado";
            quadrado1.Cor = "Azul";
            quadrado1.Lado = 10;
            //Utilização dos Métodos do objeto quadrado1
            quadrado1.Descricao();
            quadrado1.Informacao();
        }
    }
}
