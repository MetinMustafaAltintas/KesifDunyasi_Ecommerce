using Project.COREMVC.Models.Shopping.PureVMs;
using Project.ENTITIES.Models;
using X.PagedList;

namespace Project.COREMVC.Models.Shopping.PageVMs
{
    public class ShoppingPageVM
    {
        public IPagedList<ProductPureVM> ProductPureVMs { get; set; }
        public List<CategoryPureVM> CategoryPureVMs { get; set; }
    }
}
