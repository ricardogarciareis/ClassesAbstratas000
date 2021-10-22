using System;

namespace CursoOOP_TestesUnitarios
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    //CLASSE BASE ABSTRATA
    //----------------------------------------------------------------------------------------------------------------------------------------
    public abstract class Forma
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
}