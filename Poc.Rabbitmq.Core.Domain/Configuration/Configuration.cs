using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception;
namespace Poc.Rabbitmq.Core.Domain.Configuration
{
    public class Configuration : IConfiguration
    {
        #region Properties
        public string AgentName { get; internal set; }

        public string DefaultCulture { get; internal set; }

        public string Password { get; internal set; }

        public string DomainName { get; internal set; }

        public DateTime ExpirationDate { get; internal set; }

        public string CreditShellPaymentMethodCode { get; internal set; }

        public string IncrementPaymentMethodCode { get; internal set; }

        public string RefundAgencyPaymentMethodCode { get; internal set; }

        public string Environment { get; set; }

        public string ServiceDirectoryServiceUri { get; set; }

        public int ContractVersion { get; set; }

        public string CreditFilePaymentMethodCode { get; internal set; }

        public string CrmPendingTransferFeeCode { get; internal set; }

        public decimal AmountMargin { get; internal set; }

        public List<string> PaymentCodesAllowed { get; internal set; }
        #endregion

        #region Ctor.
        public Configuration()
        {
            try
            {
                LoadCustomSettings();
            }
            catch (ConfigurationInitializationException) { throw; }
            catch (System.Exception ex)
            {
                var errorMessage = string.Format("Error initializing configuration in {0}: {1}. {2}",
                    this.GetType().FullName, ex.Message, ex);

                Trace.TraceError(errorMessage);
                throw new ConfigurationInitializationException(errorMessage);
            }
        }
        #endregion

        #region Private_Methods
        private void LoadCustomSettings()
        {
            AgentName = FindKey("AgentName");
            Password = FindKey("Password");
            DomainName = FindKey("DomainName");
            DefaultCulture = FindKey("DefaultCulture");
            ExpirationDate = DateTime.Parse(FindKey("ExpirationDate"));
            ServiceDirectoryServiceUri = FindKey("ServiceDirectoryServiceUri");
            Environment = FindKey("Environment");
            CreditShellPaymentMethodCode = FindKey("CreditShellPaymentMethodCode");
            IncrementPaymentMethodCode = FindKey("IncrementPaymentMethodCode");
            RefundAgencyPaymentMethodCode = FindKey("RefundAgencyPaymentMethodCode");
            ContractVersion = int.Parse(FindKey("ContractVersion"));
            CreditFilePaymentMethodCode = FindKey("CreditFilePaymentMethodCode");
            AmountMargin = Convert.ToDecimal(FindKey("AmountMargin"));
            PaymentCodesAllowed = FindKey("PaymentCodesAllowed").Split(';').ToList();
            CrmPendingTransferFeeCode = FindKey("CrmPendingTransferFeeCode");
        }

        private string FindKey(string keyVar)
        {
            return ConfigurationManager.AppSettings[keyVar];
        }
        #endregion
    }
}
