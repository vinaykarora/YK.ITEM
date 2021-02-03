using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using YK.Item.Application.Interfaces;
using YK.Item.Domain.Events;

namespace YK.Item.Application.Handlers
{
    public class ProductActivatedEmailNotificationHandler : INotificationHandler<ProductActivatedEvent>
    {
        private readonly IEmailSender _emailSender;

        public ProductActivatedEmailNotificationHandler(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        // configure a test email server to demo this works
        // https://ardalis.com/configuring-a-local-test-email-server
        public Task Handle(ProductActivatedEvent domainEvent, CancellationToken cancellationToken)
        {
            if (domainEvent is null)
            {
                throw new ArgumentNullException(nameof(domainEvent));
            }

            return _emailSender.SendEmailAsync("test@test.com", "test@test.com", $"{domainEvent.ActivedProduct.Name} was completed.", domainEvent.ActivedProduct.ToString());
        }
    }
}
