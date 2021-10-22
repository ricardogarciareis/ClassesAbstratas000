using System;

namespace CursoOOP_TestesUnitarios
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    //CLASSE DERIVADA / HERDEIRA
    //----------------------------------------------------------------------------------------------------------------------------------------
    public class Quadrado : Forma
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
}