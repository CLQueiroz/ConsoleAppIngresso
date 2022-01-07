using ProjetoIngresso.Repositories;
using ProjetoIngresso.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoIngresso
{
    public static class CarregarTela
    {
        public static void Render()
        {
            try
            {
                int codigoTela = int.Parse(Console.ReadLine());
                if (TelaExiste(codigoTela))
                {
                    RedirecionarTela(codigoTela);
                }
                else
                {
                    Console.WriteLine("Tela não encontrada");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Redireciona para a tela selecionada
        /// </summary>
        private static void RedirecionarTela(int codigoTela)
        {
            try
            {
                switch (codigoTela)
                {
                    case 1: 
                        Console.Clear();
                        ViewShows.Render();
                        break;
                    case 2:
                        Console.Clear();
                        Cadastro.Render();
                        break;
                    default:
                        Console.WriteLine("Tela não encontrada");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Verifica se a tela existe
        /// </summary>
        private static bool TelaExiste(int codigoTela) 
        {
            List<Tela> tela = new List<Tela>();
            TelaRepository telaRepository = new TelaRepository();

            tela = telaRepository.ObterTodasAsTelas().ToList();

            return tela.Any(i => i.Id == codigoTela);
        }
    }
}
