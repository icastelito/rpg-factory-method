using FactoryMethod.ClassesAbstratas;
using FactoryMethod.ClassesConcretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDesafio fabricaMonstro = new FabricaMonstro();
            Desafio monstro = fabricaMonstro.CriarDesafio();
            Console.WriteLine($"Desafio criado: {monstro.Nome}");
            monstro.Executar();

            FabricaDesafio fabricaArmadilha = new FabricaArmadilha();
            Desafio armadilha = fabricaArmadilha.CriarDesafio();
            Console.WriteLine($"Desafio criado: {armadilha.Nome}");
            armadilha.Executar();
            Console.ReadLine();
        }
    }
}
