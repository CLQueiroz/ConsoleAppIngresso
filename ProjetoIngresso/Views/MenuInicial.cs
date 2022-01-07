using ProjetoIngresso.Views._Partials;

namespace ProjetoIngresso.Views
{
    public static class MenuInicial
    {
        /// <summary>
        /// Renderizar visualização
        /// </summary>
        public static void Render()
        {
            Cabecalho.Render("Projeto Ingressos");
            GerarMenu.Render();
        }        
    }
}
