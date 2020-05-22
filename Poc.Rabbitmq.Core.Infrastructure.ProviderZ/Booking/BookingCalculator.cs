using System;
using System.Collections.Generic;
using System.Diagnostics;
using Poc.Rabbitmq.Core.Domain.Exception;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Authentication;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Authentication;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Booking
{
    public class BookingCalculator : IBookingCalculator
    {
        #region Properties
        private readonly IBookingService _bookingService;
        private readonly IAuthenticationService _authenticationService;
        #endregion

        #region Ctor
        public BookingCalculator(IBookingService bookingService,
            IAuthenticationService authenticationService)
        {
            _bookingService = bookingService;
            _authenticationService = authenticationService;
        }
        #endregion

        #region Static_Methods
        
        #endregion

        #region Public_Methods
        public decimal GetRefundableTotalAmount(string recordLocator, List<string> sellKeyList)
        {
            SessionDto sessionContext = null;
            var refundableTotalAmount = 0.00M;

            try
            {
                sessionContext = _authenticationService.LogOn();
                refundableTotalAmount = _bookingService.GetBalanceDueForTheUncommittedBookingCancel(recordLocator, sessionContext.SessionToken, sellKeyList);
            }
            catch (BaseException ex)
            {
                Trace.TraceError(ex.Message, ex);
            }
            finally
            {
                if (sessionContext != null)
                {
                    _authenticationService.LogOut(sessionContext);
                }
            }

            return refundableTotalAmount;
        }

        public decimal GetBookingTotalAmount(BookingDto booking)
        {
            var bookingTotalAmount = 0.00M;

            try
            {
                //ToDo
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: GetBookingTotalAmount, exception: BookingCalculatorException, message: {ex.Message}.";
                Trace.TraceError(errorMessage, ex);
            }

            return bookingTotalAmount;
        }        
        #endregion
    }
}
