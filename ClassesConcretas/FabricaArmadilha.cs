using FactoryMethod.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassesConcretas
{
    class FabricaArmadilha : FabricaDesafio
    {
        public override Desafio CriarDesafio()
        {
            return new Armadilha();
        }
    }
}
