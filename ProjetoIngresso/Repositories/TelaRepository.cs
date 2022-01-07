using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoIngresso.Repositories
{
    public class TelaRepository
    {
        /// <summary>
        /// Retorna todas as telas
        /// </summary>
        /// <returns>List <a>Telas<a></returns>
        public List<Tela> ObterTodasAsTelas()
        {
            return Telas();
        }

        /// <summary>
        /// Obter todas as telas
        /// </summary>
        /// <returns>List Telas</returns>
        private List<Tela> Telas()
        {
            List<Tela> telas = new List<Tela>
            {
                new Tela {Descricao = "Shows", Id = 1},
                new Tela {Descricao = "Comprar Ingresso", Id = 2},
                new Tela {Descricao = "Cancelar Ingresso", Id = 3},
                new Tela {Descricao = "Listagem Pessoas por show", Id = 4},
                new Tela {Descricao = "Ver Ingresso", Id = 5},
            };

            return telas;
        }
    }
}
