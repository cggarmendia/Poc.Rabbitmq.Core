using System;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.SSR;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.SSR;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.SSR;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.SSR
{
    public class SSRService : ISSRService
    {
        #region Properties
        private readonly IBookingService _bookingService;
        #endregion

        #region Ctor
        public SSRService(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        #endregion

        #region Public_Methods
        public void SellSSR(SellSSRDto parameters)
        {
            try
            {
                _bookingService.SellSSR(CreateSsrRequest(parameters));
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: Sell, exception: SellSSRException, message: {ex.Message}.";
                throw new SellSSRException(errorMessage);
            }
        }
        #endregion

        #region Private_Methods
        private static SSRRequestDto CreateSsrRequest(SellSSRDto parameters)
        {
            //ToDo
            return new SSRRequestDto()
            {
                CurrencyCode = parameters.Booking.CurrencyCode,
                SessionId = parameters.SessionToken
            };
        }
        #endregion
    }
}
