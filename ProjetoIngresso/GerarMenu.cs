using ProjetoIngresso.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProjetoIngresso.Repositories;

namespace ProjetoIngresso
{
    public class GerarMenu
    {
        TelaRepository _telaRepository = new TelaRepository();

        /// <summary>
        /// Renderiza o Menu
        /// </summary>
        public void Render()
        {
            List<Menu> menus = Menus();
            GeraTabulacao(60);
            menus.ForEach(m => Console.WriteLine("DIGITE [{0}] PARA ACESSAR => {1} ", m.Id, m.Tela));
            GeraTabulacao(60);
            Console.Write("=> ");
            CarregarTela.Render();
        }


        /// <summary>
        /// Lista de Menus
        /// </summary>
        /// <returns>List Menus</returns>
        private List<Menu> Menus()
        {
            List<Menu> menu = new List<Menu>();
            List<Tela> telas = _telaRepository.ObterTodasAsTelas();
            telas.ForEach(t => menu.Add(new Menu { Tela = t.Descricao, Id = t.Id }));

            return menu;
        }

        #region 'Auxiliares'

        /// <summary>
        /// Gera a tabulação para formatar a tela
        /// </summary>
        public static void GeraTabulacao(int tamanho)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("".PadRight(tamanho, '='));
            Console.WriteLine(sb);
        }
        #endregion
    }
}






