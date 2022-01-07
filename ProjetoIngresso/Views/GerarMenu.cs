using ProjetoIngresso.Models;
using ProjetoIngresso.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoIngresso
{
    public static class GerarMenu
    {

        /// <summary>
        /// Renderiza o Menu
        /// </summary>
        public static void Render()
        {
            List<Menu> menus = Menus();
            GeraTabulacao(60);
            menus.ForEach(m => Console.WriteLine("DIGITE [{0}] PARA ACESSAR => {1} ", m.Id, m.Tela));
            GeraTabulacao(60);            
            CarregarTela.Render();
        }

        /// <summary>
        /// Lista de Menus
        /// </summary>
        /// <returns>List Menus</returns>
        private static List<Menu> Menus()
        {
            TelaRepository _telaRepository = new TelaRepository();
            List<Menu> menu = new List<Menu>();
            List<Tela> telas = _telaRepository.ObterTodasAsTelas();
            telas.ForEach(t => menu.Add(new Menu { Tela = t.Descricao, Id = t.Id }));

            return menu;
        }

        /// <summary>
        /// Gera a tabulação para formatar a tela
        /// </summary>
        public static void GeraTabulacao(int tamanho)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("".PadRight(tamanho, '='));
            Console.WriteLine(sb);
        }
    }
}






