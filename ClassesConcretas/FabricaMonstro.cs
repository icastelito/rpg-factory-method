using FactoryMethod.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassesConcretas
{
    class FabricaMonstro : FabricaDesafio
    {
        public override Desafio CriarDesafio()
        {
            return new Monstro();
        }
    }
}
