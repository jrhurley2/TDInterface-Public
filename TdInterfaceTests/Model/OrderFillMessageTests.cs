using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TdInterface.Tda.Model;

namespace TdInterface.Model.Tests
{
    [TestClass()]
    public class OrderFillMessageTests
    {
        [TestMethod()]
        public void ParseXmlTest()
        {
            var xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><OrderFillMessage xmlns=\"urn:xmlns:beb.ameritrade.com\"><OrderGroupID><Firm/><Branch>863</Branch><ClientKey>xx12</ClientKey><AccountKey>xx12</AccountKey><Segment>tos</Segment><SubAccountType>Short</SubAccountType><CDDomainID/></OrderGroupID><ActivityTimestamp>2022-05-18T10:24:04.221-05:00</ActivityTimestamp><Order xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"EquityOrderT\"><OrderKey>5587678491</OrderKey><Security><CUSIP>037833100</CUSIP><Symbol>AAPL</Symbol><SecurityType>Common Stock</SecurityType></Security><OrderPricing xsi:type=\"MarketT\"/><OrderType>Market</OrderType><OrderDuration>Day</OrderDuration><OrderEnteredDateTime>2022-05-18T10:24:04.074-05:00</OrderEnteredDateTime><OrderInstructions>Short</OrderInstructions><OriginalQuantity>100</OriginalQuantity><AmountIndicator>Shares</AmountIndicator><Discretionary>false</Discretionary><OrderSource>Web</OrderSource><Solicited>false</Solicited><MarketCode>Normal</MarketCode><DeliveryInstructions>Ship In Customer Name</DeliveryInstructions><Capacity>Agency</Capacity><Charges><Charge><Type>SEC Fee</Type><Amount>0.33</Amount></Charge><Charge><Type>Commission Override</Type><Amount>0</Amount></Charge><Charge><Type>TAF Fee</Type><Amount>0.01</Amount></Charge></Charges><NetShortQty>100</NetShortQty><Taxlot>null or blank</Taxlot><EnteringDevice>other</EnteringDevice></Order><OrderCompletionCode>Normal Completion</OrderCompletionCode><ContraInformation><Contra><AccountKey>xx12</AccountKey><SubAccountType>Short</SubAccountType><Broker>NKNIGHT2 FIX</Broker><Quantity>100</Quantity><BadgeNumber/><ReportTime>2022-05-18T10:24:04.221-05:00</ReportTime></Contra></ContraInformation><SettlementInformation><Instructions>Normal</Instructions><Date>2022-05-20</Date></SettlementInformation><ExecutionInformation><Type>Sold Short</Type><Timestamp>2022-05-18T10:24:04.221-05:00</Timestamp><Quantity>100</Quantity><ExecutionPrice>143.8401</ExecutionPrice><AveragePriceIndicator>false</AveragePriceIndicator><LeavesQuantity>0</LeavesQuantity><ID>8785452771</ID><Exchange>3</Exchange><BrokerId>NITE</BrokerId></ExecutionInformation><MarkupAmount>0</MarkupAmount><MarkdownAmount>0</MarkdownAmount><TradeCreditAmount>0</TradeCreditAmount></OrderFillMessage>";
            var orderFillMessage = OrderFillMessage.ParseXml(xmlString); ;

            Assert.AreEqual(143.8401m, orderFillMessage.ExecutionInformation.ExecutionPrice);

        }
    }
}