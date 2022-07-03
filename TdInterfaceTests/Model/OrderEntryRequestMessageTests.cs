using Microsoft.VisualStudio.TestTools.UnitTesting;
using TdInterface.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TdInterface.Model.Tests
{
    [TestClass()]
    public class OrderEntryRequestMessageTests
    {
        [TestMethod()]
        public void ParseXmlTest()
        {
            var xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><OrderEntryRequestMessage xmlns=\"urn:xmlns:beb.ameritrade.com\"><OrderGroupID><Firm/><Branch>863</Branch><ClientKey>xx12</ClientKey><AccountKey>xx12</AccountKey><Segment>tos</Segment><SubAccountType>Short</SubAccountType><CDDomainID/></OrderGroupID><ActivityTimestamp>2022-05-18T10:24:04.074-05:00</ActivityTimestamp><Order xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"EquityOrderT\"><OrderKey>5587678491</OrderKey><Security><CUSIP>037833100</CUSIP><Symbol>AAPL</Symbol><SecurityType>Common Stock</SecurityType></Security><OrderPricing xsi:type=\"MarketT\"/><OrderType>Market</OrderType><OrderDuration>Day</OrderDuration><OrderEnteredDateTime>2022-05-18T10:24:04.074-05:00</OrderEnteredDateTime><OrderInstructions>Short</OrderInstructions><OriginalQuantity>100</OriginalQuantity><AmountIndicator>Shares</AmountIndicator><Discretionary>false</Discretionary><OrderSource>Web</OrderSource><Solicited>false</Solicited><MarketCode>Normal</MarketCode><DeliveryInstructions>Ship In Customer Name</DeliveryInstructions><Capacity>Agency</Capacity><NetShortQty>0</NetShortQty><Taxlot>null or blank</Taxlot><EnteringDevice>other</EnteringDevice></Order><ToSecurity><CUSIP>037833100</CUSIP><Symbol>AAPL</Symbol><SecurityType>Common Stock</SecurityType></ToSecurity></OrderEntryRequestMessage>";

            var orderEntryRequestMessage = OrderEntryRequestMessage.ParseXml(xmlString); ;

            Assert.AreEqual(100, orderEntryRequestMessage.Order.OriginalQuantity);
        }
    }
}