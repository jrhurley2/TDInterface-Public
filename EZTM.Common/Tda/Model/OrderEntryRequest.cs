using System.Xml.Serialization;

namespace EZTM.Common.Tda.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    [XmlRoot(Namespace = "urn:xmlns:beb.ameritrade.com", IsNullable = false)]
    public partial class OrderEntryRequestMessage
    {

        public static OrderEntryRequestMessage ParseXml(string xmlContent)
        {
            OrderEntryRequestMessage orderEntryRequestMessage = null;

            var xmlSerializer = new XmlSerializer(typeof(OrderEntryRequestMessage));
            using (TextReader reader = new StringReader(xmlContent))
            {
                orderEntryRequestMessage = xmlSerializer.Deserialize(reader) as OrderEntryRequestMessage;
            }
            return orderEntryRequestMessage;

        }


        private OrderEntryRequestMessageOrderGroupID orderGroupIDField;

        private DateTime activityTimestampField;

        private OrderEntryRequestMessageOrder orderField;

        private OrderEntryRequestMessageToSecurity toSecurityField;

        /// <remarks/>
        public OrderEntryRequestMessageOrderGroupID OrderGroupID
        {
            get
            {
                return orderGroupIDField;
            }
            set
            {
                orderGroupIDField = value;
            }
        }

        /// <remarks/>
        public DateTime ActivityTimestamp
        {
            get
            {
                return activityTimestampField;
            }
            set
            {
                activityTimestampField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageOrder Order
        {
            get
            {
                return orderField;
            }
            set
            {
                orderField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageToSecurity ToSecurity
        {
            get
            {
                return toSecurityField;
            }
            set
            {
                toSecurityField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderEntryRequestMessageOrderGroupID
    {

        private object firmField;

        private ushort branchField;

        private string clientKeyField;

        private string accountKeyField;

        private string segmentField;

        private string subAccountTypeField;

        private object cDDomainIDField;

        /// <remarks/>
        public object Firm
        {
            get
            {
                return firmField;
            }
            set
            {
                firmField = value;
            }
        }

        /// <remarks/>
        public ushort Branch
        {
            get
            {
                return branchField;
            }
            set
            {
                branchField = value;
            }
        }

        /// <remarks/>
        public string ClientKey
        {
            get
            {
                return clientKeyField;
            }
            set
            {
                clientKeyField = value;
            }
        }

        /// <remarks/>
        public string AccountKey
        {
            get
            {
                return accountKeyField;
            }
            set
            {
                accountKeyField = value;
            }
        }

        /// <remarks/>
        public string Segment
        {
            get
            {
                return segmentField;
            }
            set
            {
                segmentField = value;
            }
        }

        /// <remarks/>
        public string SubAccountType
        {
            get
            {
                return subAccountTypeField;
            }
            set
            {
                subAccountTypeField = value;
            }
        }

        /// <remarks/>
        public object CDDomainID
        {
            get
            {
                return cDDomainIDField;
            }
            set
            {
                cDDomainIDField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:xmlns:beb.ameritrade.com", TypeName = "EquityOrderT")]
    public partial class OrderEntryRequestMessageOrder
    {

        private ulong orderKeyField;

        private OrderEntryRequestMessageOrderSecurity securityField;

        private object orderPricingField;

        private string orderTypeField;

        private string orderDurationField;

        private DateTime orderEnteredDateTimeField;

        private string orderInstructionsField;

        private byte originalQuantityField;

        private string amountIndicatorField;

        private bool discretionaryField;

        private string orderSourceField;

        private bool solicitedField;

        private string marketCodeField;

        private string deliveryInstructionsField;

        private string capacityField;

        private byte netShortQtyField;

        private string taxlotField;

        private string enteringDeviceField;

        /// <remarks/>
        public ulong OrderKey
        {
            get
            {
                return orderKeyField;
            }
            set
            {
                orderKeyField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageOrderSecurity Security
        {
            get
            {
                return securityField;
            }
            set
            {
                securityField = value;
            }
        }

        /// <remarks/>
        public object OrderPricing
        {
            get
            {
                return orderPricingField;
            }
            set
            {
                orderPricingField = value;
            }
        }

        /// <remarks/>
        public string OrderType
        {
            get
            {
                return orderTypeField;
            }
            set
            {
                orderTypeField = value;
            }
        }

        /// <remarks/>
        public string OrderDuration
        {
            get
            {
                return orderDurationField;
            }
            set
            {
                orderDurationField = value;
            }
        }

        /// <remarks/>
        public DateTime OrderEnteredDateTime
        {
            get
            {
                return orderEnteredDateTimeField;
            }
            set
            {
                orderEnteredDateTimeField = value;
            }
        }

        /// <remarks/>
        public string OrderInstructions
        {
            get
            {
                return orderInstructionsField;
            }
            set
            {
                orderInstructionsField = value;
            }
        }

        /// <remarks/>
        public byte OriginalQuantity
        {
            get
            {
                return originalQuantityField;
            }
            set
            {
                originalQuantityField = value;
            }
        }

        /// <remarks/>
        public string AmountIndicator
        {
            get
            {
                return amountIndicatorField;
            }
            set
            {
                amountIndicatorField = value;
            }
        }

        /// <remarks/>
        public bool Discretionary
        {
            get
            {
                return discretionaryField;
            }
            set
            {
                discretionaryField = value;
            }
        }

        /// <remarks/>
        public string OrderSource
        {
            get
            {
                return orderSourceField;
            }
            set
            {
                orderSourceField = value;
            }
        }

        /// <remarks/>
        public bool Solicited
        {
            get
            {
                return solicitedField;
            }
            set
            {
                solicitedField = value;
            }
        }

        /// <remarks/>
        public string MarketCode
        {
            get
            {
                return marketCodeField;
            }
            set
            {
                marketCodeField = value;
            }
        }

        /// <remarks/>
        public string DeliveryInstructions
        {
            get
            {
                return deliveryInstructionsField;
            }
            set
            {
                deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        public string Capacity
        {
            get
            {
                return capacityField;
            }
            set
            {
                capacityField = value;
            }
        }

        /// <remarks/>
        public byte NetShortQty
        {
            get
            {
                return netShortQtyField;
            }
            set
            {
                netShortQtyField = value;
            }
        }

        /// <remarks/>
        public string Taxlot
        {
            get
            {
                return taxlotField;
            }
            set
            {
                taxlotField = value;
            }
        }

        /// <remarks/>
        public string EnteringDevice
        {
            get
            {
                return enteringDeviceField;
            }
            set
            {
                enteringDeviceField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderEntryRequestMessageOrderSecurity
    {

        private string cUSIPField;

        private string symbolField;

        private string securityTypeField;

        /// <remarks/>
        public string CUSIP
        {
            get
            {
                return cUSIPField;
            }
            set
            {
                cUSIPField = value;
            }
        }

        /// <remarks/>
        public string Symbol
        {
            get
            {
                return symbolField;
            }
            set
            {
                symbolField = value;
            }
        }

        /// <remarks/>
        public string SecurityType
        {
            get
            {
                return securityTypeField;
            }
            set
            {
                securityTypeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderEntryRequestMessageToSecurity
    {

        private string cUSIPField;

        private string symbolField;

        private string securityTypeField;

        /// <remarks/>
        public string CUSIP
        {
            get
            {
                return cUSIPField;
            }
            set
            {
                cUSIPField = value;
            }
        }

        /// <remarks/>
        public string Symbol
        {
            get
            {
                return symbolField;
            }
            set
            {
                symbolField = value;
            }
        }

        /// <remarks/>
        public string SecurityType
        {
            get
            {
                return securityTypeField;
            }
            set
            {
                securityTypeField = value;
            }
        }
    }

}
