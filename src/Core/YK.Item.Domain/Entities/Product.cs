using System;
using YK.Item.Domain.Events;
using YK.Item.SharedKernel;
namespace YK.Item.Domain.Entities
{
    public class Product : BaseEntity<Guid>, IAggregateRoot
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public bool IsActive { get; set; }

        public void MarkActive()
        {
            IsActive = true;

            Events.Add(new ProductActivatedEvent(this));
        }

        public override string ToString()
        {
            string status = IsActive ? "Active!" : "Not done.";
            return $"{Id}: Status: {status} - {Name} - {Description}";
        }
    }
}
