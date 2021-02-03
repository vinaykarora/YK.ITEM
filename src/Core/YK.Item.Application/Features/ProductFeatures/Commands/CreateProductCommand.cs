using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using YK.Item.Application.Interfaces;
using YK.Item.Domain.Entities;

namespace YK.Item.Application.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            private readonly IApplicationDbContext _context;
            public CreateProductCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                var product = new Product
                {
                    Barcode = command.Barcode,
                    Name = command.Name,
                    Rate = command.Rate,
                    Description = command.Description
                };

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product.Id;
            }

        }
    }
}
