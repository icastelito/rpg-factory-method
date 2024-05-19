using FactoryMethod.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassesConcretas
{

    class Monstro : Desafio
    {
        public override string Nome => "Monstro";

        public override void Executar()
        {
            Console.WriteLine("Um monstro apareceu! Prepare-se para a batalha!");
        }
    }
}
