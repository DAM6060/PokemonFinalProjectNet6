namespace PokemonFinalProjectNet6.Core.Models.Paging
{
    public class PagingModel
    {
        public  int ItemsPerPage { get; init; } = 10;

        public int CurrentPage { get; set; } = 1;

        public int TotalItemsCount { get; set; }

        public int NextPage => this.CurrentPage == this.PagesCount ? this.PagesCount : this.CurrentPage + 1;

        public int PreviousPage => this.CurrentPage == 1 ? 1 : this.CurrentPage - 1;

        public int PagesCount => (int)Math.Ceiling((double)this.TotalItemsCount / ItemsPerPage);


    }
}
