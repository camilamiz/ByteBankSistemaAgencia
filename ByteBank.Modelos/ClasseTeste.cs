using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificaresTeste teste = new ModificaresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado(); //dá erro
            //teste.MetodoProtegido(); //dá erro
            teste.MetodoInterno(); //dá certo
        }
    }

    class ClasseDerivada : ModificaresTeste
    {
        public ClasseDerivada()
        {
            //dá certo
            MetodoProtegido();
        }
    }

    public class ModificaresTeste
    {
        public void MetodoPublico()
        {
            //Visiível fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            //Visível apelas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            //Visível apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            //Não é visível fora do projeto ByteBank.Modelos
        }
    }
}
