using System;

namespace ProjetoIngresso.Views._Partials
{
    public static class Cabecalho
    {
        public static void Render(string titulo)
        {
            int lengthString = titulo.Length;
            GerarMenu.GeraTabulacao(lengthString + (lengthString * 2));
            Console.WriteLine("{0}", titulo.PadLeft(lengthString + lengthString));
            GerarMenu.GeraTabulacao(lengthString + (lengthString * 2));
        }
    }
}
