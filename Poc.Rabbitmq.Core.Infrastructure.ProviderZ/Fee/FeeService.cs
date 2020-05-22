using System;
using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Fee;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Fee;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Fee
{
    public class FeeService : IFeeService
    {
        #region Properties
        private readonly IBookingService _bookingService;
        private const string FeeNote = "Done by ProviderZ";
        #endregion

        #region Ctor
        public FeeService(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        #endregion

        #region Public_Methods
        public void SellPenaltyFee(string currencyCode, string feeCode, short passengerNumber, string sessionToken, decimal feeAmount)
        {
            try
            {
                var sellPenaltyFeeRequest = CreateSellPenaltyFeeRequest(feeCode, sessionToken, currencyCode);
                var sellPenaltyFeeResponse = _bookingService.SellPenaltyFee(sellPenaltyFeeRequest);

                var passengerWithFeeCode = GetPassengerWithFeeCode(sellPenaltyFeeResponse, feeCode);

                var overrideFeeRequest = CreateOverrideFee(currencyCode, passengerWithFeeCode.PassengerFees.First(passengerFee => passengerFee.FeeCode.Equals(feeCode)).FeeNumber, feeAmount, sessionToken, passengerWithFeeCode.PassengerNumber);
                _bookingService.OverrideFee(overrideFeeRequest);
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: SellPenaltyFee, exception: SellPenaltyFeeException, message: {ex.Message}.";
                throw new SellPenaltyFeeException(errorMessage);
            }
        }

        public void SellServiceFee(string currencyCode, string feeCode, string sessionToken, decimal feeAmount)
        {
            try
            {
                var sellServiceFeeRequest = CreateSellServiceFeeRequest(feeCode, sessionToken, currencyCode);
                var sellServiceFeeResponse = _bookingService.SellServiceFee(sellServiceFeeRequest);

                var passengerWithFeeCode = GetPassengerWithFeeCode(sellServiceFeeResponse, feeCode);

                var overrideFeeRequest = CreateOverrideFee(currencyCode, passengerWithFeeCode.PassengerFees.First(passengerFee => passengerFee.FeeCode.Equals(feeCode)).FeeNumber, feeAmount, sessionToken, 0);
                _bookingService.OverrideFee(overrideFeeRequest);
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: SellServiceFee, exception: SellServiceFeeException, message: {ex.Message}.";
                throw new SellServiceFeeException(errorMessage);
            }
        }
        #endregion

        #region Private_Methods
        private static SellServiceFeeRequestDto CreateSellServiceFeeRequest(string feeCode, string sessionToken,
            string currencyCode)
        {
            return new SellServiceFeeRequestDto()
            {
                FeeCode = feeCode,
                Note = FeeNote,
                SessionId = sessionToken,
                CollectedCurrencyCode = currencyCode,
                MessageContext = string.Empty,
                OriginatingStationCode = string.Empty,
                PassengerNumber = 0
            };
        }

        private static SellPenaltyFeeRequestDto CreateSellPenaltyFeeRequest(string feeCode, string sessionToken,
            string currencyCode)
        {
            return new SellPenaltyFeeRequestDto()
            {
                FeeCode = feeCode,
                Note = FeeNote,
                SessionId = sessionToken,
                MessageContext = string.Empty,
                CollectedCurrencyCode = currencyCode,
                OriginatingStationCode = string.Empty
            };
        }
        
        private static FeeRequestDto CreateOverrideFee(string currencyCode, short feeNumber, decimal feeAmount,
            string sessionToken, short passengerNumber)
        {
            return new FeeRequestDto()
            {
                CurrencyCode = currencyCode,
                FeeNumber = feeNumber,
                NetAmount = feeAmount,
                MessageContext = FeeNote,
                SessionId = sessionToken,
                PassengerNumber = passengerNumber
            };
        }

        private PassengerDto GetPassengerWithFeeCode(BookingDeltaDto bookingDeltaResponse, object feeCode)
        {
            return bookingDeltaResponse.Passengers
                .FirstOrDefault(passenger =>
                    passenger.PassengerFees.Any(passengerFee => passengerFee.FeeCode.Equals(feeCode)));
        }
        #endregion
    }
}
