using ProjetoIngresso.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoIngresso.Repositories
{
    public class ShowRepository
    {
        /// <summary>
        /// Retorna todas as telas
        /// </summary>
        /// <returns>List <a>Telas<a></returns>
        public List<Show> ObterShows()
        {
            return Shows();
        }

        /// <summary>
        /// Obter todas as telas
        /// </summary>
        /// <returns>List Telas</returns>
        private List<Show> Shows()
        {
            var formatarData = DateTime.Now.ToShortDateString();

            List<Show> shows = new List<Show>
            {
                new Show { ID = 1, Decscricao = "Gusttavo lima", Data = "2021-10-10", Valor = 500.00},
                new Show { ID = 2, Decscricao = "Henrique e Juliano", Data = "2021-10-10", Valor = 500.00},
                new Show { ID = 3, Decscricao = "Gusttavo lima", Data = "2021-10-10", Valor = 500.00},
                new Show { ID = 4, Decscricao = "Gusttavo lima", Data = "2021-10-10", Valor = 500.00},
                new Show { ID = 5, Decscricao = "Gusttavo lima", Data = "2021-10-10", Valor = 500.00},

            };

            return shows;
        }
    }
}
