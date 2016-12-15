//  --------------------------------------------------------------------------------------
// InteractiveBrokersConsoleClient.TwsClient.cs
// 2016/12/12
//  --------------------------------------------------------------------------------------

using System;
using IBApi;

namespace InteractiveBrokersConsoleClient.TwsApi
{
    public class TwsClient : EWrapper
    {
        public TwsClient()
        {
            ClientSocket = new EClientSocket(this);
        }

        public void accountDownloadEnd(string account)
        {
            WriteMessageToConsole($"AccountDownloadEnd.  Account:  {account}");
        }

        public void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            WriteMessageToConsole(
                $"AccountSummary.  ReqId:  {reqId}, Account:  {account}, Tag:  {tag}, Value:  {value}, Currency:  {currency}");
        }

        public void accountSummaryEnd(int reqId)
        {
            WriteMessageToConsole($"AccountSummaryEnd.  ReqId{reqId}");
        }

        public void bondContractDetails(int reqId, ContractDetails contract)
        {
            // TODO:  Write out additional bond contract details
            WriteMessageToConsole($"BondContractDetails.");
        }

        public EClientSocket ClientSocket { get; set; }

        public void commissionReport(CommissionReport commissionReport)
        {
            // TODO:  Write out Commission Report details
            WriteMessageToConsole($"CommissionReport");
        }

        public void connectionClosed()
        {
            WriteMessageToConsole("ConnectionClosed.");
        }

        public void contractDetails(int reqId, ContractDetails contractDetails)
        {
            //TODO:  Write out more ContractDetails info
            WriteMessageToConsole($"ContractDetails.  ReqId:  {reqId}");
        }

        public void contractDetailsEnd(int reqId)
        {
            WriteMessageToConsole($"ContractDetailsEnd.  ReqId:  {reqId}");
        }

        public void currentTime(long time)
        {
            WriteMessageToConsole($"Current time:  {time}");
        }

        public void deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            WriteMessageToConsole(
                $"DeltaNeutralValidation.  {reqId}, ConId:  {underComp.ConId}, Delta:  {underComp.Delta}, Price:  {underComp.Price}");
        }

        public void displayGroupList(int reqId, string groups)
        {
            WriteMessageToConsole($"DisplayGroupList.  ReqId:  {reqId}, Groups:  {groups}");
        }

        public void displayGroupUpdated(int reqId, string contractInfo)
        {
            WriteMessageToConsole($"DisplayGroupUpdated.  ReqId:  {reqId}, Groups:  {contractInfo}");
        }

        public void error(Exception e)
        {
            LogError(e.Message);
        }

        public void error(string str)
        {
            LogError(str);
        }

        public void error(int id, int errorCode, string errorMsg)
        {
            var message = $"Id: {id}, ErrorCode: {errorCode}, Message:  {errorMsg}";
            LogError(message);
        }

        public void execDetails(int reqId, Contract contract, Execution execution)
        {
            // TODO:  Write out more Contract and Execution details
            WriteMessageToConsole($"ExecDetails.  ReqId:  {reqId}");
        }

        public void execDetailsEnd(int reqId)
        {
            WriteMessageToConsole($"ExecDetailsEnd.  ReqId:  {reqId}");
        }

        public void fundamentalData(int reqId, string data)
        {
            WriteMessageToConsole($"FundamentalData.  ReqId:  {reqId}, Data:  {data}");
        }

        public void historicalData(int reqId, string date, double open, double high, double low, double close,
                                   int volume, int count, double WAP, bool hasGaps)
        {
            WriteMessageToConsole(
                $"HistoricalData.  ReqId:  {reqId}, Date:  {date}, Open:  {open}, High:  {high}, Low:  {low}, Close:  {close}, Volume:  {volume}" +
                $"Count:  {count}, WAP:  {WAP}, HasGaps:  {hasGaps}");
        }

        public void historicalDataEnd(int reqId, string start, string end)
        {
            WriteMessageToConsole($"HistoricalDataEnd.  ReqId:  {reqId}, Start:  {start}, End:  {end}");
        }

        public void managedAccounts(string accountsList)
        {
            WriteMessageToConsole($"ManagedAccountsList.  AccountsList:  {accountsList}");
        }

        public void marketDataType(int reqId, int marketDataType)
        {
            WriteMessageToConsole($"MarketDataType.  ReqId:  {reqId}, MarketDataType:  {marketDataType}");
        }

        public int NextOrderId { get; set; }

        public void nextValidId(int orderId)
        {
            NextOrderId = orderId;
            WriteMessageToConsole($"Connected.  NextValidId:  {orderId}");
        }

        public void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            // TODO:  Write out more order/contract/state details
            WriteMessageToConsole($"OpenOrder.  OrderId:  {orderId}");
        }

        public void openOrderEnd()
        {
            WriteMessageToConsole("OpenOrderEnd");
        }

        public void orderStatus(int orderId, string status, int filled, int remaining, double avgFillPrice, int permId,
                                int parentId, double lastFillPrice, int clientId, string whyHeld)
        {
            WriteMessageToConsole(
                $"OrderStatus.  OrderId:  {orderId}, Status:  {status}, Filled:  {filled}, Remaining:  {remaining}, AvgFillPrice:  {avgFillPrice}, " +
                $"PermId:  {permId}, ParentId:  {parentId}, LastFillPrice:  {lastFillPrice}, ClientId:  {clientId}, WhyHeld:  {whyHeld}");
        }

        public void position(string account, Contract contract, int pos, double avgCost)
        {
            // TODO:  Write contract details
            WriteMessageToConsole($"Position.  Account:  {account}, Pos:  {pos}, AvgCost:  {avgCost}");
        }

        public void positionEnd()
        {
            WriteMessageToConsole("PositionEnd");
        }

        public void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume,
                                double WAP, int count)
        {
            WriteMessageToConsole(
                $"RealtimeBar.  ReqId:  {reqId}, Time:  {time}, Open:  {open}, High:  {high}, Low:  {low}, Close:  {close}, Volume:  {volume}," +
                $"WAP:  {WAP}, Count:  {count}");
        }

        public void receiveFA(int faDataType, string faXmlData)
        {
            WriteMessageToConsole($"ReceiveFA.  FaDataType:  {faDataType}, FaXmlData:  {faXmlData}");
        }

        public void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark,
                                string projection, string legsStr)
        {
            // TODO:  Write out contract details
            WriteMessageToConsole(
                $"ScannerData.  ReqId:  {reqId}, Rank:  {rank}, Distance:  {distance}, Benchmark:  {benchmark}, Projection:  {projection}, LegsStr:  {legsStr}");
        }

        public void scannerDataEnd(int reqId)
        {
            WriteMessageToConsole($"ScannerDataEnd.  ReqId:  {reqId}");
        }

        public void scannerParameters(string xml)
        {
            WriteMessageToConsole($"ScannerParameters.  Xml:  {xml}");
        }

        public void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints,
                            double impliedFuture, int holdDays, string futureExpiry, double dividendImpact,
                            double dividendsToExpiry)
        {
            WriteMessageToConsole(
                $"TickEfp.  TickerId:  {tickerId}, Type:  {tickType}, BasisPoints:  {basisPoints}, FormattedBasisPoints:  {formattedBasisPoints}, ImpliedFuture:  {impliedFuture}," +
                $"HoldDays:  {holdDays}, FutureExpiry:  {futureExpiry}, DividendImpact:  {dividendImpact}, DividendsToExpiry:  {dividendsToExpiry}");
        }

        public void tickGeneric(int tickerId, int field, double value)
        {
            WriteMessageToConsole(
                $"Tick Generic.  TickerId:  {tickerId}, Type:  {TickType.getField(field)}, Value:  {value}");
        }

        public void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta,
                                          double optPrice, double pvDividend, double gamma, double vega, double theta,
                                          double undPrice)
        {
            WriteMessageToConsole(
                $"TickOptionComputation.  TickerId:  {tickerId}, Field:  {field}, ImpliedVolatility:  {impliedVolatility}, Delta:  {delta}, OptPrice:  {optPrice}," +
                $"PvDividend:  {pvDividend}, Gamma:  {gamma}, Vega:  {vega}, Theta:  {theta}, UndPrice:  {undPrice}");
        }

        public void tickPrice(int tickerId, int field, double price, int canAutoExecute)
        {
            WriteMessageToConsole(
                $"Tick Price.  Ticker Id:  {tickerId}, Type:  {TickType.getField(field)}, Price:  {price}");
        }

        public void tickSize(int tickerId, int field, int size)
        {
            WriteMessageToConsole(
                $"Tick Size.  Ticker Id:  {tickerId}, Type:  {TickType.getField(field)}, Size:  {size}");
        }

        public void tickSnapshotEnd(int tickerId)
        {
            WriteMessageToConsole($"TickSnapshotEnd.  TickerId:  {tickerId}");
        }

        public void tickString(int tickerId, int field, string value)
        {
            WriteMessageToConsole(
                $"Tick String.  TickerId:  {tickerId}, Type:  {TickType.getField(field)}, Value:  {value}");
        }

        public void updateAccountTime(string timestamp)
        {
            WriteMessageToConsole($"UpdateAccountTime.  Timestamp:  {timestamp}");
        }

        public void updateAccountValue(string key, string value, string currency, string accountName)
        {
            WriteMessageToConsole(
                $"UpdateAccountValue.  Key:  {key}, Value:  {value}, Currency:  {currency}, AccountName:  {accountName}");
        }

        public void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            WriteMessageToConsole(
                $"UpdateMktDepth.  TickerId:  {tickerId}, Position:  {position}, Operation:  {operation}, Side:  {side}, Price:  {price}, Size:  {size}");
        }

        public void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side,
                                     double price, int size)
        {
            WriteMessageToConsole(
                $"UpdateMktDepthL2.  TickerId:  {tickerId}, Position:  {position}, MarketMaker:  {marketMaker}, Operation:  {operation}, Side:  {side}, Price:  {price}, Size:  {size}");
        }

        public void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            WriteMessageToConsole(
                $"UpdateNewsBulletin.  MsgId:  {msgId}, MsgType:  {msgType}, Message:  {message}, OrigExchange:  {origExchange}");
        }

        public void updatePortfolio(Contract contract, int position, double marketPrice, double marketValue,
                                    double averageCost, double unrealisedPNL, double realisedPNL, string accountName)
        {
            // TODO:  Write out additional contract details
            WriteMessageToConsole(
                $"UpdatePortfolio.  Position:  {position}, MarketPrice:  {marketPrice}, MarketValue:  {marketValue}, AverageCost:  {averageCost}, UnrealizedPNL:  {unrealisedPNL}, RealizedPNL:  {realisedPNL}, AccountName:  {accountName}");
        }

        public void verifyCompleted(bool isSuccessful, string errorText)
        {
            WriteMessageToConsole($"VerifyCompleted.  IsSuccessful:  {isSuccessful}, ErrorText:  {errorText}");
        }

        public void verifyMessageAPI(string apiData)
        {
            WriteMessageToConsole($"VerifyMessageApi.  ApiData:  {apiData}");
        }

        void LogError(string message)
        {
            WriteMessageToConsole($"Error occurred:  {message}");
        }

        void WriteMessageToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}