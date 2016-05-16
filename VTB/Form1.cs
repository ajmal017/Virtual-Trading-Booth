using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VTB
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.List<double> listOfPrices;
        public Form1()
            
        {   // this is the list of prices which will be shown on the chart
            listOfPrices = new System.Collections.Generic.List<double>();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Code to connect to Trader Work Station
            axTws1.connect("", 7496, 0);
            // Code to have a standard connection to a specific Stock 

            // Create a new contract object
            TWSLib.IContract ContractInfo = axTws1.createContract();
            // Create a new TagValueList object (for API version 9.71) 
            TWSLib.ITagValueList mktDataOptions = axTws1.createTagValueList();
            // Now fill the ContractInfo object with the necessary information 
            // Contract identifier (use a unique number for each security)
            ContractInfo.conId = 0;
            // Stock symbol
            ContractInfo.symbol = "AAPL";
            // Type of instrument: Stock=STK,Option=OPT,Future=FUT, etc.
            ContractInfo.secType = "STK";
            // The Options or Futures expiration data in the format YYYYMM
            ContractInfo.expiry = "";
            // The Options Strike Price 
            ContractInfo.strike = 0;
            // The Options "PUT" or "CALL" rights 
            ContractInfo.right = "";
            // The contract multiplier for Futures or Options 
            ContractInfo.multiplier = "";
            // The destination of order or request. "SMART" =IB order router
            ContractInfo.exchange = "SMART";
            // The primary exchange where the instrument trades. 
            // NYSE,  NASDAQ, AMEX, BATS, ARCA, PHLX etc.
            ContractInfo.primaryExchange = "NASDAQ";
            // The currency of the exchange USD or GBP or CAD or EUR, etc.
            ContractInfo.currency = "USD";

            // Make the request for streaming market data
            //   TickerID - use a unique number for each request
            //   ContractInfo - the Contract object containing the financial instrument
            //   genericTicks - Can be used to get different tick types (use "" for now)
            //   Snapshot (0 for streaming, 1 to get a single data point)
            axTws1.reqMktDataEx(0, ContractInfo, "", 0, mktDataOptions);
            //   Note: If you receive an error asking for 5 parameters, try passing mktDataOptions 
            //   as the fifth parameter - this may have been fixed in newer version of the API
            //   axTws1.reqMktDataEx(0, ContractInfo, "", 0, mktDataOptions);  




        }// End code segment for Connect Button

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
           // Cancel the request for market data
           // Parameters are:
           // - OrderID  This should be the identifier used in the call to reqMktData
           // axTws1.cancelMktData(0);

           // Disconnect from the IB Data Server
            axTws1.disconnect();
        }// End Code Segment for Disconnect Button

        private void btnReconnect_Click(object sender, EventArgs e)
        {   //Balls 
            listOfPrices.Clear();
            OurChart.Series["Price"].Points.Clear();
            // Cancel the Initial Market data Connection when pressing connect
            axTws1.cancelMktData(0);
            // Create a new contract object
            TWSLib.IContract ContractInfo = axTws1.createContract();
            // Create a new TagValueList object (for API version 9.71) 
            TWSLib.ITagValueList mktDataOptions = axTws1.createTagValueList();
            // Now fill the ContractInfo object with the necessary information 
            // Contract identifier (use a unique number for each security)
            ContractInfo.conId = 0;
            // Stock symbol
            ContractInfo.symbol = tbSymbol.Text;
            // Type of instrument: Stock=STK,Option=OPT,Future=FUT, etc.
            ContractInfo.secType = "STK";
            // The Options or Futures expiration data in the format YYYYMM
            ContractInfo.expiry = "";
            // The Options Strike Price 
            ContractInfo.strike = 0;
            // The Options "PUT" or "CALL" rights 
            ContractInfo.right = "";
            // The contract multiplier for Futures or Options 
            ContractInfo.multiplier = "";
            // The destination of order or request. "SMART" =IB order router
            ContractInfo.exchange = sMARTToolStripMenuItem.Text;
            // The primary exchange where the instrument trades. 
            // NYSE,  NASDAQ, AMEX, BATS, ARCA, PHLX etc.
            ContractInfo.primaryExchange = tbExchange.Text;
            // The currency of the exchange USD or GBP or CAD or EUR, etc.
            ContractInfo.currency = "USD";

            // Make the request for streaming market data
            //   TickerID - use a unique number for each request
            //   ContractInfo - the Contract object containing the financial instrument
            //   genericTicks - Can be used to get different tick types (use "" for now)
            //   Snapshot (0 for streaming, 1 to get a single data point)
            axTws1.reqMktDataEx(0, ContractInfo, "", 0, mktDataOptions);
            //   Note: If you receive an error asking for 5 parameters, try passing mktDataOptions 
            //   as the fifth parameter - this may have been fixed in newer version of the API
            //   axTws1.reqMktDataEx(0, ContractInfo, "", 0, mktDataOptions);  




        }// end Reconnect code segment.

        private void axTws1_tickPrice(object sender, AxTWSLib._DTwsEvents_tickPriceEvent e)
        {   // If the price is the Last Price, add it to the list of prices
            if(e.tickType == 4)
            {   
                listOfPrices.Add(e.price);
                /* Not this is currently just adding the price from connection to the chart, we might need
                 more data for functions */
                OurChart.ChartAreas[0].AxisY.Minimum = listOfPrices.Min() - .05;
                OurChart.Series["Price"].Points.AddY(e.price);
            }
        }// end TWS tick price event handler
    }
}
