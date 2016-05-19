using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacTec.TA.Library;

namespace VTB
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.List<double> listOfPrices;
        System.Collections.Generic.List<double> listOfHighs;
        System.Collections.Generic.List<double> listOfLows;
        string strategyToApply;

        public Form1()            
        {   
            // this is the list of prices which will be shown on the chart
            listOfPrices = new System.Collections.Generic.List<double>();
            listOfHighs = new System.Collections.Generic.List<double>();
            listOfLows = new System.Collections.Generic.List<double>();
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
        {   
            /* 
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
            */


            listOfPrices.Clear();
            listOfHighs.Clear();
            listOfLows.Clear();
            OurChart.Series["Price"].Points.Clear();

            // Cancel the Initial Market data Connection when pressing connect
            axTws1.cancelMktData(0);
            // Create a new TagValueList object (for API version 9.71) 
            TWSLib.ITagValueList mktDataOptions = axTws1.createTagValueList();
            // Create a new contract object
            TWSLib.IContract ContractInfo = axTws1.createContract();
            // Now fill the ContractInfo object with the necessary information 
            // Contract ID
            ContractInfo.conId = 0;
            // Stock symbol
            ContractInfo.symbol = tbSymbol.Text;
            // Type of instrument: Stock=STK,Option=OPT,Future=FUT, etc.
            ContractInfo.secType = "STK";
            // The destination of order or request. "SMART" =IB order router
            ContractInfo.exchange = "SMART";
            // The primary exchange for the stock.
            ContractInfo.primaryExchange = "NASDAQ";
            // The currency of the exchange USD or GBP or CAD or EUR, etc.
            ContractInfo.currency = "USD";
            // Make the request for Real Time Bars. Parameters are:
            //   TickerID       Use a unique number for each request
            //   ContractInfo   The Contract object specifying the financial instrument
            //   barSize        The size of a data bar - 5 seconds is the current setting
            //   whatToShow     Use "TRADES" to show OHLC trades. Can also use 
            //                  "BID", "ASK" or "MID" for quotes
            //   useRTH         Use Regular Trading Hours only (set to 1)
            axTws1.reqRealTimeBarsEx(0, ContractInfo, 5, "TRADES", 1, mktDataOptions);

        }// end Reconnect code segment.

        private void axTws1_tickPrice(object sender, AxTWSLib._DTwsEvents_tickPriceEvent e)
        {   // If the price is the Last Price, add it to the list of prices
            if(e.tickType == 4)
            {   
                listOfPrices.Add(e.price);
                /* Not this is currently just adding the price from connection to the chart, we might need
                 more data for functions */
                OurChart.ChartAreas[0].AxisY.Maximum = listOfPrices.Max() + .05;
                OurChart.ChartAreas[0].AxisY.Minimum = listOfPrices.Min() - .05;
                OurChart.Series["Price"].Points.AddY(e.price);
            }
        }// end TWS tick price event handler


        private void axTws1_realtimeBar(object sender, AxTWSLib._DTwsEvents_realtimeBarEvent e)
        {

            // A real time bar has been generated. The data is held in object e.
            // e.time         The time stamp for the bar (seconds since UNIX Epoc)
            // e.open         Opening (first) price at the start of the bar
            // e.high         Highest price during the bar
            // e.low          Lowest price during the bar
            // e.close        Closing (last) price at the end of the bar
            // e.volume       Total volume during the bar
            // e.count        Number of trades (or quotes) during the bar
            // e.wAP          Volume weighted average price during the bar
            //
            // Create a string to hold the completed bar
            String strBarString = "";
            // Define a DateTime to hold the end time of the bar
            System.DateTime dtDateTime =
                          new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            // Convert the e.time to a DateTime format
            dtDateTime = dtDateTime.AddSeconds(e.time).ToLocalTime();
            // Build up the bar in a string
            strBarString += dtDateTime + "," + e.open + "," + e.high + ",";
            strBarString += e.low + "," + e.close + "," + e.volume;

            listOfPrices.Add(e.close);
            listOfHighs.Add(e.high);
            listOfLows.Add(e.low);

            OurChart.ChartAreas[0].AxisY.Maximum = listOfPrices.Max() + .05;
            OurChart.ChartAreas[0].AxisY.Minimum = listOfPrices.Min() - .05;
            OurChart.Series["Price"].Points.AddY(e.close);

        }// end axTws1_realtimeBar

        private void comboStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboStrategy.Text.ToString() == "SMA Crossover")
            {
                tbDescription.Text = "This strategy will look for bullish trends, buying if the current price crosses above the Simple Moving Avg.";
                strategyToApply = "smaCrossover"; 
            }
            else if (comboStrategy.Text.ToString() == "SMA Crossunder")
            {
                tbDescription.Text = "This strategy will look for bearish trends, shorting the stock if the current price is below the Simple Moving Avg.";
                strategyToApply = "smaCrossunder";
            }
            else if (comboStrategy.Text.ToString() == "EMA Crossover")
            {
                tbDescription.Text = "This strategy will look for bullish trends, shorting the stock if the current price is above the Exponential Moving Avg.";
                strategyToApply = "emaCrossover";
            }
            else if (comboStrategy.Text.ToString() == "EMA Crossunder")
            {
                tbDescription.Text = "This strategy will look for bearish trends, shorting the stock if the current price is below the Exponential Moving Avg.";
                strategyToApply = "emaCrossunder";
            }
            else if (comboStrategy.Text.ToString() == "RSI Over Sold")
            {
                tbDescription.Text = "This strategy will buy if the RSI is less than 30, indicating the stock had been over sold";
                strategyToApply = "rsiOverSold";
            }
            else if (comboStrategy.Text.ToString() == "RSI Over Bought")
            {
                tbDescription.Text = "This strategy will short a company if the RSI is greater than 70, indicating the stock had been over bought";
                strategyToApply = "rsiOverBought";
            }
            
        }// end comboStrategy_SelectedIndexChanged

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double[] priceArray = listOfPrices.ToArray();
            int timeFrame = Convert.ToInt32(numTimeFrame.Value);

            if (strategyToApply == "smaCrossover")
            {
                int outBegIdxSma, outNbElementSma;
                double[] outputSma = new double[priceArray.Length];

                Core.Sma(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxSma, out outNbElementSma, outputSma);
            }

            else if (strategyToApply == "smaCrossunder")
            {
                int outBegIdxSma, outNbElementSma;
                double[] outputSma = new double[priceArray.Length];

                Core.Sma(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxSma, out outNbElementSma, outputSma);
            }

            else if (strategyToApply == "emaCrossover")
            {
                int outBegIdxEma, outNbElementEma;
                double[] outputEma = new double[priceArray.Length];

                Core.Ema(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxEma, out outNbElementEma, outputEma);
            }

            else if (strategyToApply == "emaCrossunder")
            {
                int outBegIdxEma, outNbElementEma;
                double[] outputEma = new double[priceArray.Length];

                Core.Ema(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxEma, out outNbElementEma, outputEma);
            }

            else if (strategyToApply == "rsiOverSold")
            {
                int outBegIdxRsi, outNbElementRsi;
                double[] outputRsi = new double[priceArray.Length];

                Core.Rsi(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxRsi, out outNbElementRsi, outputRsi);
            }

            else if (strategyToApply == "rsiOverBought")
            {
                int outBegIdxRsi, outNbElementRsi;
                double[] outputRsi = new double[priceArray.Length];

                Core.Rsi(0, listOfPrices.Count - 1, priceArray, timeFrame, out outBegIdxRsi, out outNbElementRsi, outputRsi);
            }

        }// end btnSubmit_Click

    }
}
