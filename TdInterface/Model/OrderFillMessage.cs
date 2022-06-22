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
    public partial class OrderFillMessage
    {
        public static OrderFillMessage ParseXml(string xmlContent)
        {
            OrderFillMessage orderFillMessage = null;

            var xmlSerializer = new XmlSerializer(typeof(OrderFillMessage));
            using (TextReader reader = new StringReader(xmlContent))
            {
                orderFillMessage = xmlSerializer.Deserialize(reader) as OrderFillMessage;
            }
            return orderFillMessage;

        }

        private OrderFillMessageOrderGroupID orderGroupIDField;

        private System.DateTime activityTimestampField;

        private OrderFillMessageOrder orderField;

        private string orderCompletionCodeField;

        private OrderFillMessageContraInformation contraInformationField;

        private OrderFillMessageSettlementInformation settlementInformationField;

        private OrderFillMessageExecutionInformation executionInformationField;

        private byte markupAmountField;

        private byte markdownAmountField;

        private byte tradeCreditAmountField;

        /// <remarks/>
        public OrderFillMessageOrderGroupID OrderGroupID
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
        public OrderFillMessageOrder Order
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
        public string OrderCompletionCode
        {
            get
            {
                return this.orderCompletionCodeField;
            }
            set
            {
                this.orderCompletionCodeField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageContraInformation ContraInformation
        {
            get
            {
                return this.contraInformationField;
            }
            set
            {
                this.contraInformationField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageSettlementInformation SettlementInformation
        {
            get
            {
                return this.settlementInformationField;
            }
            set
            {
                this.settlementInformationField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageExecutionInformation ExecutionInformation
        {
            get
            {
                return this.executionInformationField;
            }
            set
            {
                this.executionInformationField = value;
            }
        }

        /// <remarks/>
        public byte MarkupAmount
        {
            get
            {
                return this.markupAmountField;
            }
            set
            {
                this.markupAmountField = value;
            }
        }

        /// <remarks/>
        public byte MarkdownAmount
        {
            get
            {
                return this.markdownAmountField;
            }
            set
            {
                this.markdownAmountField = value;
            }
        }

        /// <remarks/>
        public byte TradeCreditAmount
        {
            get
            {
                return this.tradeCreditAmountField;
            }
            set
            {
                this.tradeCreditAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageOrderGroupID
    {

        private object firmField;

        private ushort branchField;

        private uint clientKeyField;

        private uint accountKeyField;

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
        public uint ClientKey
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
        public uint AccountKey
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
    [System.Xml.Serialization.XmlTypeAttribute( Namespace = "urn:xmlns:beb.ameritrade.com", TypeName = "EquityOrderT")]
    public partial class OrderFillMessageOrder
    {

        private ulong orderKeyField;

        private OrderFillMessageOrderSecurity securityField;

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

        private OrderFillMessageOrderCharge[] chargesField;

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
        public OrderFillMessageOrderSecurity Security
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable = false)]
        public OrderFillMessageOrderCharge[] Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
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
    public partial class OrderFillMessageOrderSecurity
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
    public partial class OrderFillMessageOrderCharge
    {

        private string typeField;

        private decimal amountField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageContraInformation
    {

        private OrderFillMessageContraInformationContra contraField;

        /// <remarks/>
        public OrderFillMessageContraInformationContra Contra
        {
            get
            {
                return this.contraField;
            }
            set
            {
                this.contraField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageContraInformationContra
    {

        private uint accountKeyField;

        private string subAccountTypeField;

        private string brokerField;

        private byte quantityField;

        private object badgeNumberField;

        private System.DateTime reportTimeField;

        /// <remarks/>
        public uint AccountKey
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
        public string Broker
        {
            get
            {
                return this.brokerField;
            }
            set
            {
                this.brokerField = value;
            }
        }

        /// <remarks/>
        public byte Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public object BadgeNumber
        {
            get
            {
                return this.badgeNumberField;
            }
            set
            {
                this.badgeNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReportTime
        {
            get
            {
                return this.reportTimeField;
            }
            set
            {
                this.reportTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageSettlementInformation
    {

        private string instructionsField;

        private System.DateTime dateField;

        /// <remarks/>
        public string Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageExecutionInformation
    {

        private string typeField;

        private System.DateTime timestampField;

        private byte quantityField;

        private decimal executionPriceField;

        private bool averagePriceIndicatorField;

        private byte leavesQuantityField;

        private ulong idField;

        private byte exchangeField;

        private string brokerIdField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        public byte Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public decimal ExecutionPrice
        {
            get
            {
                return this.executionPriceField;
            }
            set
            {
                this.executionPriceField = value;
            }
        }

        /// <remarks/>
        public bool AveragePriceIndicator
        {
            get
            {
                return this.averagePriceIndicatorField;
            }
            set
            {
                this.averagePriceIndicatorField = value;
            }
        }

        /// <remarks/>
        public byte LeavesQuantity
        {
            get
            {
                return this.leavesQuantityField;
            }
            set
            {
                this.leavesQuantityField = value;
            }
        }

        /// <remarks/>
        public ulong ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public byte Exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        public string BrokerId
        {
            get
            {
                return this.brokerIdField;
            }
            set
            {
                this.brokerIdField = value;
            }
        }
    }



}
