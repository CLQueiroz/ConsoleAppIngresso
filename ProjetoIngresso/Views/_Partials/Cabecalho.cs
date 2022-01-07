using System;

namespace ProjetoIngresso.Views._Partials
{
    public static class Cabecalho
    {
        public static void Render(string titulo)
        {
            int lengthString = titulo.Length;
            GerarMenu.GeraTabulacao(lengthString + (lengthString * 3));
            Console.WriteLine("{0}", titulo.PadLeft(lengthString * 3));
            GerarMenu.GeraTabulacao(lengthString + (lengthString * 3));
        }
    }
}
