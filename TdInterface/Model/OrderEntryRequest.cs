using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TdInterface.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:xmlns:beb.ameritrade.com", IsNullable = false)]
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

        private System.DateTime activityTimestampField;

        private OrderEntryRequestMessageOrder orderField;

        private OrderEntryRequestMessageToSecurity toSecurityField;

        /// <remarks/>
        public OrderEntryRequestMessageOrderGroupID OrderGroupID
        {
            get
            {
                return this.orderGroupIDField;
            }
            set
            {
                this.orderGroupIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ActivityTimestamp
        {
            get
            {
                return this.activityTimestampField;
            }
            set
            {
                this.activityTimestampField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageOrder Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageToSecurity ToSecurity
        {
            get
            {
                return this.toSecurityField;
            }
            set
            {
                this.toSecurityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
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
                return this.firmField;
            }
            set
            {
                this.firmField = value;
            }
        }

        /// <remarks/>
        public ushort Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }

        /// <remarks/>
        public string ClientKey
        {
            get
            {
                return this.clientKeyField;
            }
            set
            {
                this.clientKeyField = value;
            }
        }

        /// <remarks/>
        public string AccountKey
        {
            get
            {
                return this.accountKeyField;
            }
            set
            {
                this.accountKeyField = value;
            }
        }

        /// <remarks/>
        public string Segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }

        /// <remarks/>
        public string SubAccountType
        {
            get
            {
                return this.subAccountTypeField;
            }
            set
            {
                this.subAccountTypeField = value;
            }
        }

        /// <remarks/>
        public object CDDomainID
        {
            get
            {
                return this.cDDomainIDField;
            }
            set
            {
                this.cDDomainIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:xmlns:beb.ameritrade.com", TypeName = "EquityOrderT")]
    public partial class OrderEntryRequestMessageOrder
    {

        private ulong orderKeyField;

        private OrderEntryRequestMessageOrderSecurity securityField;

        private object orderPricingField;

        private string orderTypeField;

        private string orderDurationField;

        private System.DateTime orderEnteredDateTimeField;

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
                return this.orderKeyField;
            }
            set
            {
                this.orderKeyField = value;
            }
        }

        /// <remarks/>
        public OrderEntryRequestMessageOrderSecurity Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }

        /// <remarks/>
        public object OrderPricing
        {
            get
            {
                return this.orderPricingField;
            }
            set
            {
                this.orderPricingField = value;
            }
        }

        /// <remarks/>
        public string OrderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        public string OrderDuration
        {
            get
            {
                return this.orderDurationField;
            }
            set
            {
                this.orderDurationField = value;
            }
        }

        /// <remarks/>
        public System.DateTime OrderEnteredDateTime
        {
            get
            {
                return this.orderEnteredDateTimeField;
            }
            set
            {
                this.orderEnteredDateTimeField = value;
            }
        }

        /// <remarks/>
        public string OrderInstructions
        {
            get
            {
                return this.orderInstructionsField;
            }
            set
            {
                this.orderInstructionsField = value;
            }
        }

        /// <remarks/>
        public byte OriginalQuantity
        {
            get
            {
                return this.originalQuantityField;
            }
            set
            {
                this.originalQuantityField = value;
            }
        }

        /// <remarks/>
        public string AmountIndicator
        {
            get
            {
                return this.amountIndicatorField;
            }
            set
            {
                this.amountIndicatorField = value;
            }
        }

        /// <remarks/>
        public bool Discretionary
        {
            get
            {
                return this.discretionaryField;
            }
            set
            {
                this.discretionaryField = value;
            }
        }

        /// <remarks/>
        public string OrderSource
        {
            get
            {
                return this.orderSourceField;
            }
            set
            {
                this.orderSourceField = value;
            }
        }

        /// <remarks/>
        public bool Solicited
        {
            get
            {
                return this.solicitedField;
            }
            set
            {
                this.solicitedField = value;
            }
        }

        /// <remarks/>
        public string MarketCode
        {
            get
            {
                return this.marketCodeField;
            }
            set
            {
                this.marketCodeField = value;
            }
        }

        /// <remarks/>
        public string DeliveryInstructions
        {
            get
            {
                return this.deliveryInstructionsField;
            }
            set
            {
                this.deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        public string Capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public byte NetShortQty
        {
            get
            {
                return this.netShortQtyField;
            }
            set
            {
                this.netShortQtyField = value;
            }
        }

        /// <remarks/>
        public string Taxlot
        {
            get
            {
                return this.taxlotField;
            }
            set
            {
                this.taxlotField = value;
            }
        }

        /// <remarks/>
        public string EnteringDevice
        {
            get
            {
                return this.enteringDeviceField;
            }
            set
            {
                this.enteringDeviceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
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
                return this.cUSIPField;
            }
            set
            {
                this.cUSIPField = value;
            }
        }

        /// <remarks/>
        public string Symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public string SecurityType
        {
            get
            {
                return this.securityTypeField;
            }
            set
            {
                this.securityTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderEntryRequestMessageToSecurity
    {

        private string  cUSIPField;

        private string symbolField;

        private string securityTypeField;

        /// <remarks/>
        public string CUSIP
        {
            get
            {
                return this.cUSIPField;
            }
            set
            {
                this.cUSIPField = value;
            }
        }

        /// <remarks/>
        public string Symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public string SecurityType
        {
            get
            {
                return this.securityTypeField;
            }
            set
            {
                this.securityTypeField = value;
            }
        }
    }

}
