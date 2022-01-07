using ProjetoIngresso.Models;
using ProjetoIngresso.Repositories;
using ProjetoIngresso.Views._Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoIngresso.Views
{
    public static class ViewShows
    {
        public static void Render()
        {
            Cabecalho.Render("Visualizar Shows");
            CarregarShows();
        }

        private static void CarregarShows()
        {
            ShowRepository _showRepository = new ShowRepository();
            List<Show> listShow = _showRepository.ObterShows().ToList();
            StringBuilder stringBuilderHeader = new StringBuilder();

            stringBuilderHeader.AppendLine(String.Format("|{0,-3}|{1, -23}|{2, -18}|{3, -11:F}|", "ID", "Titulo", "Data", "Valor"));
            stringBuilderHeader.Append("".PadRight(60, '-'));
            Console.WriteLine(stringBuilderHeader);

            listShow.ForEach(show =>
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(string.Format("|{0,-3}|{1, -23}|{2, -18:dd/MM/yyyy HH:mm}|R${3, -9:F}|", show.ID, show.Decscricao, show.Data, show.Valor));
                Console.WriteLine(stringBuilder);
            });
        }
    }
}