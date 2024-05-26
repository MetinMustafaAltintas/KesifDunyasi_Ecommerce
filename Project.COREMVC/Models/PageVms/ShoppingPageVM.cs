using Project.ENTITIES.Models;
using X.PagedList;

namespace Project.COREMVC.Models.PageVms
{
    public class ShoppingPageVM
    {

        //YZL3170 : Refactor yaparken Domain Entity'leri VM'lere cevireceksiniz

        //PageVM

        //PageVM'ler iclerinde veri kapsülleyen ve sayfalara model olarak gönderilecek VM'lerdik...(Request ve Response icin aynı kullanılacaksa direkt PageVM denilebilir)

        //RequestPageVM
        //ResponsePageVM

        public IPagedList<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

    }
}