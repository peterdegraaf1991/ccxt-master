namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

public class  Gate: gate { public Gate(object args = null) : base(args) { } }
public partial class gate
{
    /// <summary>
    /// Create an order on the exchange
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-place"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-place"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>price</term>
    /// <description>
    /// float : *ignored in "market" orders* the price at which the order is to be fulfilled at in units of the quote currency
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object :  extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stopPrice</term>
    /// <description>
    /// float : The price at which a trigger order is triggered at
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.timeInForce</term>
    /// <description>
    /// string : "GTC", "IOC", or "PO"
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stopLossPrice</term>
    /// <description>
    /// float : The price at which a stop loss order is triggered at
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.takeProfitPrice</term>
    /// <description>
    /// float : The price at which a take profit order is triggered at
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.marginMode</term>
    /// <description>
    /// string : 'cross' or 'isolated' - marginMode for margin trading if not provided this.options['defaultMarginMode'] is used
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.iceberg</term>
    /// <description>
    /// int : Amount to display for the iceberg order, Null or 0 for normal orders, Set to -1 to hide the order completely
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.text</term>
    /// <description>
    /// string : User defined information
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.account</term>
    /// <description>
    /// string : *spot and margin only* "spot", "margin" or "cross_margin"
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.auto_borrow</term>
    /// <description>
    /// bool : *margin only* Used in margin or cross margin trading to allow automatic loan of insufficient amount if balance is not enough
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.settle</term>
    /// <description>
    /// string : *contract only* Unified Currency Code for settle currency
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.reduceOnly</term>
    /// <description>
    /// bool : *contract only* Indicates if this order is to reduce the size of a position
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.close</term>
    /// <description>
    /// bool : *contract only* Set as true to close the position, with size set to 0
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.auto_size</term>
    /// <description>
    /// bool : *contract only* Set side to close dual-mode position, close_long closes the long side, while close_short the short one, size also needs to be set to 0
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.price_type</term>
    /// <description>
    /// int : *contract only* 0 latest deal price, 1 mark price, 2 index price
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
    /// <returns> <term>undefined</term> undefined.</returns>
    public async Task<Order> CreateOrderWs(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.createOrderWs(symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// create a list of trade orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-batch-place"/>  <br/>
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
    public async Task<List<Order>> CreateOrdersWs(List<OrderRequest> orders, Dictionary<string, object> parameters = null)
    {
        var res = await this.createOrdersWs(orders, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// cancel all open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#cancel-all-open-orders-matched"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-cancel-all-with-specified-currency-pair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.channel</term>
    /// <description>
    /// string : the channel to use, defaults to spot.order_cancel_cp or futures.order_cancel_cp
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> CancelAllOrdersWs(string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelAllOrdersWs(symbol, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// Cancels an open order
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-cancel"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-cancel"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : Parameters specified by the exchange api
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// bool : True if the order to be cancelled is a trigger order
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>undefined</term> undefined.</returns>
    public async Task<Order> CancelOrderWs(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrderWs(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// edit a trade order, gate currently only supports the modification of the price or amount fields
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-amend"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-amend"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>price</term>
    /// <description>
    /// float : the price at which the order is to be fulfilled, in units of the quote currency, ignored in market orders
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
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> EditOrderWs(string id, string symbol, string type, string side, double? amount2 = 0, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var amount = amount2 == 0 ? null : (object)amount2;
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.editOrderWs(id, symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// Retrieves information on an order
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-status"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-status"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : Parameters specified by the exchange api
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// bool : True if the order being fetched is a trigger order
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.marginMode</term>
    /// <description>
    /// string : 'cross' or 'isolated' - marginMode for margin trading if not provided this.options['defaultMarginMode'] is used
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.type</term>
    /// <description>
    /// string : 'spot', 'swap', or 'future', if not provided this.options['defaultMarginMode'] is used
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.settle</term>
    /// <description>
    /// string : 'btc' or 'usdt' - settle currency for perpetual swap and future - market settle currency is used if symbol !== undefined, default="usdt" for swap and "btc" for future
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>undefined</term> undefined.</returns>
    public async Task<Order> FetchOrderWs(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchOrderWs(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// fetch all unfilled currently open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-list"/>  <br/>
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
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchOpenOrdersWs(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOpenOrdersWs(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple closed orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#order-list"/>  <br/>
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
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchClosedOrdersWs(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchClosedOrdersWs(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    public async Task<Dictionary<string, object>> FetchOrdersByStatusWs(string status, string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrdersByStatusWs(status, symbol, since, limit, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
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
    public async Task<ccxt.pro.IOrderBook> WatchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOrderBook(symbol, limit, parameters);
        return ((ccxt.pro.IOrderBook) res).Copy();
    }
    /// <summary>
    /// watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#tickers-channel"/>  <br/>
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
    public async Task<Ticker> WatchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.watchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for all markets of a specific list
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#tickers-channel"/>  <br/>
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
    public async Task<Tickers> WatchTickers(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.watchTickers(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// watches best bid & ask for symbols
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#best-bid-or-ask-price"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/apiv4/ws/en/#order-book-channel"/>  <br/>
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
    public async Task<Tickers> WatchBidsAsks(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.watchBidsAsks(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
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
    /// <returns> <term>object[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> WatchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
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
    /// <returns> <term>object[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> WatchTradesForSymbols(List<string> symbols, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchTradesForSymbols(symbols, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// watches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
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
    public async Task<List<OHLCV>> WatchOHLCV(string symbol, string timeframe = "1m", Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOHLCV(symbol, timeframe, since, limit, parameters);
        return ((IList<object>)res).Select(item => new OHLCV(item)).ToList<OHLCV>();
    }
    /// <summary>
    /// watches information on multiple trades made by the user
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
    /// int : the maximum number of trade structures to retrieve
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
    public async Task<List<Trade>> WatchMyTrades(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchMyTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// watch balance and get the amount of funds available for trading or funds locked in orders
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
    public async Task<Balances> WatchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.watchBalance(parameters);
        return new Balances(res);
    }
    /// <summary>
    /// watch all open positions
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#positions-subscription"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/delivery/ws/en/#positions-subscription"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/options/ws/en/#positions-channel"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch positions for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of positions to retrieve
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [position structure]{@link https://docs.ccxt.com/en/latest/manual.html#position-structure}.</returns>
    public async Task<List<Position>> WatchPositions(List<String> symbols = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchPositions(symbols, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Position(item)).ToList<Position>();
    }
    /// <summary>
    /// watches information on multiple orders made by the user
    /// </summary>
    /// <remarks>
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
    /// <term>params.type</term>
    /// <description>
    /// string : spot, margin, swap, future, or option. Required if listening to all symbols.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.isInverse</term>
    /// <description>
    /// boolean : if future, listen to inverse or linear contracts
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> WatchOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// watch the public liquidations of a trading pair
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#liquidates-api"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/delivery/ws/en/#liquidates-api"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/options/ws/en/#liquidates-channel"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch liquidations for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of liquidation structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : exchange specific parameters for the bitmex api endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an array of [liquidation structures]{@link https://github.com/ccxt/ccxt/wiki/Manual#liquidation-structure}.</returns>
    public async Task<List<Liquidation>> WatchMyLiquidations(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchMyLiquidations(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Liquidation(item)).ToList<Liquidation>();
    }
    /// <summary>
    /// watch the private liquidations of a trading pair
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.gate.io/docs/developers/futures/ws/en/#liquidates-api"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/delivery/ws/en/#liquidates-api"/>  <br/>
    /// See <see href="https://www.gate.io/docs/developers/options/ws/en/#liquidates-channel"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch liquidations for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of liquidation structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : exchange specific parameters for the gate api endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an array of [liquidation structures]{@link https://github.com/ccxt/ccxt/wiki/Manual#liquidation-structure}.</returns>
    public async Task<List<Liquidation>> WatchMyLiquidationsForSymbols(List<string> symbols = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchMyLiquidationsForSymbols(symbols, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Liquidation(item)).ToList<Liquidation>();
    }
}