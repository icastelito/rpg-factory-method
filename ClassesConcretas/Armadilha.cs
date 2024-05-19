using FactoryMethod.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassesConcretas
{

    class Armadilha : Desafio
    {
        public override string Nome => "Armadilha";

        public override void Executar()
        {
            Console.WriteLine("Você caiu em uma armadilha! Tente escapar!");
        }
    }
}
