namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class okcoin
{
    /// <summary>
    /// fetches the current integer timestamp in milliseconds from the exchange server
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int</term> the current integer timestamp in milliseconds from the exchange server.</returns>
    public async Task<Int64> FetchTime(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTime(parameters);
        return (Int64)res;
    }
    /// <summary>
    /// retrieves data on all markets for okcoin
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-public-data-get-instruments"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> an array of objects representing market data.</returns>
    public async Task<List<MarketInterface>> FetchMarkets(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarkets(parameters);
        return ((IList<object>)res).Select(item => new MarketInterface(item)).ToList<MarketInterface>();
    }
    /// <summary>
    /// fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-order-book"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<OrderBook> FetchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderBook(symbol, limit, parameters);
        return new OrderBook(res);
    }
    /// <summary>
    /// fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-ticker"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Ticker> FetchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// fetches price tickers for multiple markets, statistical information calculated over the past 24 hours for each market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-tickers"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Tickers> FetchTickers(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTickers(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-trades"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-trades-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest trade to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of trades to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> FetchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-candlesticks"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-market-data-get-candlesticks-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest candle to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of candles to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int[][]</term> A list of candles ordered as timestamp, open, high, low, close, volume.</returns>
    public async Task<List<OHLCV>> FetchOHLCV(string symbol, string timeframe = "1m", Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOHLCV(symbol, timeframe, since, limit, parameters);
        return ((IList<object>)res).Select(item => new OHLCV(item)).ToList<OHLCV>();
    }
    /// <summary>
    /// query for balance and get the amount of funds available for trading or funds locked in orders
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}.</returns>
    public async Task<Balances> FetchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchBalance(parameters);
        return new Balances(res);
    }
    /// <summary>
    /// create a market buy order by providing the symbol and cost
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-place-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CreateMarketBuyOrderWithCost(string symbol, double cost, Dictionary<string, object> parameters = null)
    {
        var res = await this.createMarketBuyOrderWithCost(symbol, cost, parameters);
        return new Order(res);
    }
    /// <summary>
    /// create a trade order
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-place-order"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-place-algo-order"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-place-multiple-orders"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-advance-algo-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.reduceOnly</term>
    /// <description>
    /// bool : MARGIN orders only, or swap/future orders in net mode
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.postOnly</term>
    /// <description>
    /// bool : true to place a post only order
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.triggerPrice</term>
    /// <description>
    /// float : conditional orders only, the price at which the order is to be triggered
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.takeProfit</term>
    /// <description>
    /// object : *takeProfit object in params* containing the triggerPrice at which the attached take profit order will be triggered (perpetual swap markets only)
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stopLoss</term>
    /// <description>
    /// object : *stopLoss object in params* containing the triggerPrice at which the attached stop loss order will be triggered (perpetual swap markets only)
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.cost</term>
    /// <description>
    /// float : *spot market buy only* the quote quantity that can be used as an alternative for the amount
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CreateOrder(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.createOrder(symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    public Dictionary<string, object> CreateOrderRequest(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = this.createOrderRequest(symbol, type, side, amount, price, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// cancels an open order
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-order"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-algo-order"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-advance-algo-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// bool : True if cancel trigger or conditional orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.advanced</term>
    /// <description>
    /// bool : True if canceling advanced orders only
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Dictionary<string, object>> CancelOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrder(id, symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// cancel multiple orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-multiple-orders"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-algo-order"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-cancel-advance-algo-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> CancelOrders(object ids, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrders(ids, symbol, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on an order made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-order-details"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-algo-order-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> FetchOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// fetch all unfilled currently open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-order-list"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-algo-order-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch open orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of  open orders structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// bool : True if fetching trigger or conditional orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.ordType</term>
    /// <description>
    /// string : "conditional", "oco", "trigger", "move_order_stop", "iceberg", or "twap"
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchOpenOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOpenOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple closed orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-algo-order-history"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-order-history-last-3-months"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-order-history-last-7-days"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// bool : True if fetching trigger or conditional orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.ordType</term>
    /// <description>
    /// string : "conditional", "oco", "trigger", "move_order_stop", "iceberg", or "twap"
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchClosedOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchClosedOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetch the deposit address for a currency associated with this account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okx.com/docs-v5/en/#funding-account-rest-api-get-deposit-address"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}.</returns>
    public async Task<DepositAddress> FetchDepositAddress(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDepositAddress(code, parameters);
        return new DepositAddress(res);
    }
    /// <summary>
    /// fetch a dictionary of addresses for a currency, indexed by network
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okx.com/docs-v5/en/#funding-account-rest-api-get-deposit-address"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a dictionary of [address structures]{@link https://docs.ccxt.com/#/?id=address-structure} indexed by the network.</returns>
    public async Task<List<DepositAddress>> FetchDepositAddressesByNetwork(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDepositAddressesByNetwork(code, parameters);
        return ((IList<object>)res).Select(item => new DepositAddress(item)).ToList<DepositAddress>();
    }
    /// <summary>
    /// transfer currency internally between wallets on the same account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-funding-funds-transfer"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}.</returns>
    public async Task<TransferEntry> Transfer(string code, double amount, string fromAccount, string toAccount, Dictionary<string, object> parameters = null)
    {
        var res = await this.transfer(code, amount, fromAccount, toAccount, parameters);
        return new TransferEntry(res);
    }
    /// <summary>
    /// make a withdrawal
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-funding-withdrawal"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<Transaction> Withdraw(string code, double amount, string address, object tag = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.withdraw(code, amount, address, tag, parameters);
        return new Transaction(res);
    }
    /// <summary>
    /// fetch all deposits made to an account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-funding-get-deposit-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch deposits for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of deposits structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchDeposits(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchDeposits(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch all withdrawals made from an account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-funding-get-withdrawal-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch withdrawals for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of withdrawals structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchWithdrawals(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchWithdrawals(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch all trades made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-transaction-details-last-3-days"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-trade-get-transaction-details-last-3-months"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch trades for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of trades structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}.</returns>
    public async Task<List<Trade>> FetchMyTrades(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchMyTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch all the trades made from a single order
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch trades for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of trades to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}.</returns>
    public async Task<List<Trade>> FetchOrderTrades(string id, string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderTrades(id, symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch the history of changes, actions done by the user or operations that altered the balance of the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-funding-asset-bills-details"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-account-get-bills-details-last-7-days"/>  <br/>
    /// See <see href="https://www.okcoin.com/docs-v5/en/#rest-api-account-get-bills-details-last-3-months"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>code</term>
    /// <description>
    /// string : unified currency code, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest ledger entry, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : max number of ledger entries to return, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ledger structure]{@link https://docs.ccxt.com/#/?id=ledger-structure}.</returns>
    public async Task<List<LedgerEntry>> FetchLedger(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchLedger(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new LedgerEntry(item)).ToList<LedgerEntry>();
    }
}