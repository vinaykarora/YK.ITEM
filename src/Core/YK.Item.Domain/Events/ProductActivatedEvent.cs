using YK.Item.Domain.Entities;
using YK.Item.SharedKernel;
namespace YK.Item.Domain.Events
{
    public class ProductActivatedEvent : BaseDomainEvent
    {
        public Product ActivedProduct { get; set; }

        public ProductActivatedEvent(Product activedProduct)
        {
            ActivedProduct = activedProduct;
        }
    }
}
