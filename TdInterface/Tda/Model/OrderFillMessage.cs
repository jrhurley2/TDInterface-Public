using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace TdInterface.Tda.Model
{



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    [XmlRoot(Namespace = "urn:xmlns:beb.ameritrade.com", IsNullable = false)]
    public partial class OrderFillMessage
    {
        public static OrderFillMessage ParseXml(string xmlContent)
        {
            var xmlDel = new XmlDeserializationEvents();
            xmlDel.OnUnknownAttribute += (o, e) => { };
            xmlDel.OnUnknownNode += (o, e) => { };
            xmlDel.OnUnreferencedObject += (o, e) => { };
            xmlDel.OnUnknownElement += (o, e) => { };

            OrderFillMessage orderFillMessage = null;

            var xmlSerializer = new XmlSerializer(typeof(OrderFillMessage));

            using (TextReader reader = new StringReader(xmlContent))
            {
                try
                {
                    var xmlReader = XmlReader.Create(reader);
                    orderFillMessage = xmlSerializer.Deserialize(xmlReader, xmlDel) as OrderFillMessage;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                }
            }

            return orderFillMessage;

        }

        private OrderFillMessageOrderGroupID orderGroupIDField;

        private DateTime activityTimestampField;

        private OrderFillMessageOrder orderField;

        private string orderCompletionCodeField;

        private OrderFillMessageContraInformation contraInformationField;

        private OrderFillMessageSettlementInformation settlementInformationField;

        private OrderFillMessageExecutionInformation executionInformationField;

        private byte markupAmountField;

        private byte markdownAmountField;

        private decimal tradeCreditAmountField;

        private object[] confirmTextsField;

        private byte trueCommCostField;

        private DateTime tradeDateField;

        /// <remarks/>
        public OrderFillMessageOrderGroupID OrderGroupID
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
        public OrderFillMessageOrder Order
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
        public string OrderCompletionCode
        {
            get
            {
                return orderCompletionCodeField;
            }
            set
            {
                orderCompletionCodeField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageContraInformation ContraInformation
        {
            get
            {
                return contraInformationField;
            }
            set
            {
                contraInformationField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageSettlementInformation SettlementInformation
        {
            get
            {
                return settlementInformationField;
            }
            set
            {
                settlementInformationField = value;
            }
        }

        /// <remarks/>
        public OrderFillMessageExecutionInformation ExecutionInformation
        {
            get
            {
                return executionInformationField;
            }
            set
            {
                executionInformationField = value;
            }
        }

        /// <remarks/>
        public byte MarkupAmount
        {
            get
            {
                return markupAmountField;
            }
            set
            {
                markupAmountField = value;
            }
        }

        /// <remarks/>
        public byte MarkdownAmount
        {
            get
            {
                return markdownAmountField;
            }
            set
            {
                markdownAmountField = value;
            }
        }

        /// <remarks/>
        public decimal TradeCreditAmount
        {
            get
            {
                return tradeCreditAmountField;
            }
            set
            {
                tradeCreditAmountField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("ConfirmText", IsNullable = false)]
        public object[] ConfirmTexts
        {
            get
            {
                return confirmTextsField;
            }
            set
            {
                confirmTextsField = value;
            }
        }

        /// <remarks/>
        public byte TrueCommCost
        {
            get
            {
                return trueCommCostField;
            }
            set
            {
                trueCommCostField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime TradeDate
        {
            get
            {
                return tradeDateField;
            }
            set
            {
                tradeDateField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageOrderGroupID
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
    public partial class OrderFillMessageOrder
    {

        private ulong orderKeyField;

        private OrderFillMessageOrderSecurity securityField;

        private object orderPricingField;

        private string orderTypeField;

        private string orderDurationField;

        private DateTime orderEnteredDateTimeField;

        private string orderInstructionsField;

        private int originalQuantityField;

        private string amountIndicatorField;

        private bool discretionaryField;

        private string orderSourceField;

        private bool solicitedField;

        private string marketCodeField;

        private string deliveryInstructionsField;

        private string capacityField;

        private OrderFillMessageOrderCharge[] chargesField;

        private int netShortQtyField;

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
        public OrderFillMessageOrderSecurity Security
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
        public int OriginalQuantity
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
        [XmlArrayItem("Charge", IsNullable = false)]
        public OrderFillMessageOrderCharge[] Charges
        {
            get
            {
                return chargesField;
            }
            set
            {
                chargesField = value;
            }
        }

        /// <remarks/>
        public int NetShortQty
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
    public partial class OrderFillMessageOrderCharge
    {

        private string typeField;

        private decimal amountField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return amountField;
            }
            set
            {
                amountField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageContraInformation
    {

        private OrderFillMessageContraInformationContra contraField;

        /// <remarks/>
        public OrderFillMessageContraInformationContra Contra
        {
            get
            {
                return contraField;
            }
            set
            {
                contraField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageContraInformationContra
    {

        private string accountKeyField;

        private string subAccountTypeField;

        private string brokerField;

        private int quantityField;

        private object badgeNumberField;

        private DateTime reportTimeField;

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
        public string Broker
        {
            get
            {
                return brokerField;
            }
            set
            {
                brokerField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        public object BadgeNumber
        {
            get
            {
                return badgeNumberField;
            }
            set
            {
                badgeNumberField = value;
            }
        }

        /// <remarks/>
        public DateTime ReportTime
        {
            get
            {
                return reportTimeField;
            }
            set
            {
                reportTimeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageSettlementInformation
    {

        private string instructionsField;

        private DateTime dateField;

        /// <remarks/>
        public string Instructions
        {
            get
            {
                return instructionsField;
            }
            set
            {
                instructionsField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime Date
        {
            get
            {
                return dateField;
            }
            set
            {
                dateField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:xmlns:beb.ameritrade.com")]
    public partial class OrderFillMessageExecutionInformation
    {

        private string typeField;

        private DateTime timestampField;

        private int quantityField;

        private decimal executionPriceField;

        private bool averagePriceIndicatorField;

        private byte leavesQuantityField;

        private string idField;

        private string exchangeField;

        private string brokerIdField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        public DateTime Timestamp
        {
            get
            {
                return timestampField;
            }
            set
            {
                timestampField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        public decimal ExecutionPrice
        {
            get
            {
                return executionPriceField;
            }
            set
            {
                executionPriceField = value;
            }
        }

        /// <remarks/>
        public bool AveragePriceIndicator
        {
            get
            {
                return averagePriceIndicatorField;
            }
            set
            {
                averagePriceIndicatorField = value;
            }
        }

        /// <remarks/>
        public byte LeavesQuantity
        {
            get
            {
                return leavesQuantityField;
            }
            set
            {
                leavesQuantityField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        public string Exchange
        {
            get
            {
                return exchangeField;
            }
            set
            {
                exchangeField = value;
            }
        }

        /// <remarks/>
        public string BrokerId
        {
            get
            {
                return brokerIdField;
            }
            set
            {
                brokerIdField = value;
            }
        }
    }



}
