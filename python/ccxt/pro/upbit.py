# -*- coding: utf-8 -*-

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

import ccxt.async_support
from ccxt.async_support.base.ws.cache import ArrayCache, ArrayCacheBySymbolById
from ccxt.base.types import Balances, Int, Order, OrderBook, Str, Strings, Ticker, Tickers, Trade
from ccxt.async_support.base.ws.client import Client
from typing import List


class upbit(ccxt.async_support.upbit):

    def describe(self):
        return self.deep_extend(super(upbit, self).describe(), {
            'has': {
                'ws': True,
                'watchOrderBook': True,
                'watchTicker': True,
                'watchTickers': True,
                'watchTrades': True,
                'watchTradesForSymbols': True,
                'watchOrders': True,
                'watchMyTrades': True,
                'watchBalance': True,
            },
            'urls': {
                'api': {
                    'ws': 'wss://{hostname}/websocket/v1',
                },
            },
            'options': {
                'tradesLimit': 1000,
            },
        })

    async def watch_public(self, symbol: str, channel, params={}):
        await self.load_markets()
        market = self.market(symbol)
        symbol = market['symbol']
        marketId = market['id']
        url = self.implode_params(self.urls['api']['ws'], {
            'hostname': self.hostname,
        })
        self.options[channel] = self.safe_value(self.options, channel, {})
        self.options[channel][symbol] = True
        symbols = list(self.options[channel].keys())
        marketIds = self.market_ids(symbols)
        request = [
            {
                'ticket': self.uuid(),
            },
            {
                'type': channel,
                'codes': marketIds,
                # 'isOnlySnapshot': False,
                # 'isOnlyRealtime': False,
            },
        ]
        messageHash = channel + ':' + marketId
        return await self.watch(url, messageHash, request, messageHash)

    async def watch_public_multiple(self, symbols: Strings, channel, params={}):
        await self.load_markets()
        if symbols is None:
            symbols = self.symbols
        symbols = self.market_symbols(symbols)
        marketIds = self.market_ids(symbols)
        url = self.implode_params(self.urls['api']['ws'], {
            'hostname': self.hostname,
        })
        messageHashes = []
        for i in range(0, len(marketIds)):
            messageHashes.append(channel + ':' + marketIds[i])
        request = [
            {
                'ticket': self.uuid(),
            },
            {
                'type': channel,
                'codes': marketIds,
                # 'isOnlySnapshot': False,
                # 'isOnlyRealtime': False,
            },
        ]
        return await self.watch_multiple(url, messageHashes, request, messageHashes)

    async def watch_ticker(self, symbol: str, params={}) -> Ticker:
        """
        watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market

        https://global-docs.upbit.com/reference/websocket-ticker

        :param str symbol: unified symbol of the market to fetch the ticker for
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict: a `ticker structure <https://docs.ccxt.com/#/?id=ticker-structure>`
        """
        return await self.watch_public(symbol, 'ticker')

    async def watch_tickers(self, symbols: Strings = None, params={}) -> Tickers:
        """
        watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market

        https://global-docs.upbit.com/reference/websocket-ticker

 @param symbols
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict: a `ticker structure <https://docs.ccxt.com/#/?id=ticker-structure>`
        """
        newTickers = await self.watch_public_multiple(symbols, 'ticker')
        if self.newUpdates:
            tickers: dict = {}
            tickers[newTickers['symbol']] = newTickers
            return tickers
        return self.filter_by_array(self.tickers, 'symbol', symbols)

    async def watch_trades(self, symbol: str, since: Int = None, limit: Int = None, params={}) -> List[Trade]:
        """
        get the list of most recent trades for a particular symbol

        https://global-docs.upbit.com/reference/websocket-trade

        :param str symbol: unified symbol of the market to fetch trades for
        :param int [since]: timestamp in ms of the earliest trade to fetch
        :param int [limit]: the maximum amount of trades to fetch
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict[]: a list of `trade structures <https://docs.ccxt.com/#/?id=public-trades>`
        """
        return await self.watch_trades_for_symbols([symbol], since, limit, params)

    async def watch_trades_for_symbols(self, symbols: List[str], since: Int = None, limit: Int = None, params={}) -> List[Trade]:
        """
        get the list of most recent trades for a list of symbols

        https://global-docs.upbit.com/reference/websocket-trade

        :param str[] symbols: unified symbol of the market to fetch trades for
        :param int [since]: timestamp in ms of the earliest trade to fetch
        :param int [limit]: the maximum amount of trades to fetch
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict[]: a list of `trade structures <https://docs.ccxt.com/#/?id=public-trades>`
        """
        await self.load_markets()
        symbols = self.market_symbols(symbols, None, False, True, True)
        channel = 'trade'
        messageHashes = []
        url = self.implode_params(self.urls['api']['ws'], {
            'hostname': self.hostname,
        })
        if symbols is not None:
            for i in range(0, len(symbols)):
                market = self.market(symbols[i])
                marketId = market['id']
                symbol = market['symbol']
                self.options[channel] = self.safe_value(self.options, channel, {})
                self.options[channel][symbol] = True
                messageHashes.append(channel + ':' + marketId)
        optionSymbols = list(self.options[channel].keys())
        marketIds = self.market_ids(optionSymbols)
        request = [
            {
                'ticket': self.uuid(),
            },
            {
                'type': channel,
                'codes': marketIds,
                # 'isOnlySnapshot': False,
                # 'isOnlyRealtime': False,
            },
        ]
        trades = await self.watch_multiple(url, messageHashes, request, messageHashes)
        if self.newUpdates:
            first = self.safe_value(trades, 0)
            tradeSymbol = self.safe_string(first, 'symbol')
            limit = trades.getLimit(tradeSymbol, limit)
        return self.filter_by_since_limit(trades, since, limit, 'timestamp', True)

    async def watch_order_book(self, symbol: str, limit: Int = None, params={}) -> OrderBook:
        """
        watches information on open orders with bid(buy) and ask(sell) prices, volumes and other data

        https://global-docs.upbit.com/reference/websocket-orderbook

        :param str symbol: unified symbol of the market to fetch the order book for
        :param int [limit]: the maximum amount of order book entries to return
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict: A dictionary of `order book structures <https://docs.ccxt.com/#/?id=order-book-structure>` indexed by market symbols
        """
        orderbook = await self.watch_public(symbol, 'orderbook')
        return orderbook.limit()

    def handle_ticker(self, client: Client, message):
        # 2020-03-17T23:07:36.511Z "onMessage" <Buffer 7b 22 74 79 70 65 22 3a 22 74 69 63 6b 65 72 22 2c 22 63 6f 64 65 22 3a 22 42 54 43 2d 45 54 48 22 2c 22 6f 70 65 6e 69 6e 67 5f 70 72 69 63 65 22 3a ... >
        # {type: "ticker",
        #   "code": "BTC-ETH",
        #   "opening_price": 0.02295092,
        #   "high_price": 0.02295092,
        #   "low_price": 0.02161249,
        #   "trade_price": 0.02161249,
        #   "prev_closing_price": 0.02185802,
        #   "acc_trade_price": 2.32732482,
        #   "change": "FALL",
        #   "change_price": 0.00024553,
        #   "signed_change_price": -0.00024553,
        #   "change_rate": 0.0112329479,
        #   "signed_change_rate": -0.0112329479,
        #   "ask_bid": "ASK",
        #   "trade_volume": 2.12,
        #   "acc_trade_volume": 106.11798418,
        #   "trade_date": "20200317",
        #   "trade_time": "215843",
        #   "trade_timestamp": 1584482323000,
        #   "acc_ask_volume": 90.16935908,
        #   "acc_bid_volume": 15.9486251,
        #   "highest_52_week_price": 0.03537414,
        #   "highest_52_week_date": "2019-04-08",
        #   "lowest_52_week_price": 0.01614901,
        #   "lowest_52_week_date": "2019-09-06",
        #   "trade_status": null,
        #   "market_state": "ACTIVE",
        #   "market_state_for_ios": null,
        #   "is_trading_suspended": False,
        #   "delisting_date": null,
        #   "market_warning": "NONE",
        #   "timestamp": 1584482323378,
        #   "acc_trade_price_24h": 2.5955306323568927,
        #   "acc_trade_volume_24h": 118.38798416,
        #   "stream_type": "SNAPSHOT"}
        marketId = self.safe_string(message, 'code')
        messageHash = 'ticker:' + marketId
        ticker = self.parse_ticker(message)
        symbol = ticker['symbol']
        self.tickers[symbol] = ticker
        client.resolve(ticker, messageHash)

    def handle_order_book(self, client: Client, message):
        # {type: "orderbook",
        #   "code": "BTC-ETH",
        #   "timestamp": 1584486737444,
        #   "total_ask_size": 16.76384456,
        #   "total_bid_size": 168.9020623,
        #   "orderbook_units":
        #    [{ask_price: 0.02295077,
        #        "bid_price": 0.02161249,
        #        "ask_size": 3.57100696,
        #        "bid_size": 22.5303265},
        #      {ask_price: 0.02295078,
        #        "bid_price": 0.02152658,
        #        "ask_size": 0.52451651,
        #        "bid_size": 2.30355128},
        #      {ask_price: 0.02295086,
        #        "bid_price": 0.02150802,
        #        "ask_size": 1.585,
        #        "bid_size": 5}, ...],
        #   "stream_type": "SNAPSHOT"}
        marketId = self.safe_string(message, 'code')
        symbol = self.safe_symbol(marketId, None, '-')
        type = self.safe_string(message, 'stream_type')
        options = self.safe_value(self.options, 'watchOrderBook', {})
        limit = self.safe_integer(options, 'limit', 15)
        if type == 'SNAPSHOT':
            self.orderbooks[symbol] = self.order_book({}, limit)
        orderbook = self.orderbooks[symbol]
        # upbit always returns a snapshot of 15 topmost entries
        # the "REALTIME" deltas are not incremental
        # therefore we reset the orderbook on each update
        # and reinitialize it again with new bidasks
        orderbook.reset({})
        orderbook['symbol'] = symbol
        bids = orderbook['bids']
        asks = orderbook['asks']
        data = self.safe_value(message, 'orderbook_units', [])
        for i in range(0, len(data)):
            entry = data[i]
            ask_price = self.safe_float(entry, 'ask_price')
            ask_size = self.safe_float(entry, 'ask_size')
            bid_price = self.safe_float(entry, 'bid_price')
            bid_size = self.safe_float(entry, 'bid_size')
            asks.store(ask_price, ask_size)
            bids.store(bid_price, bid_size)
        timestamp = self.safe_integer(message, 'timestamp')
        datetime = self.iso8601(timestamp)
        orderbook['timestamp'] = timestamp
        orderbook['datetime'] = datetime
        messageHash = 'orderbook:' + marketId
        client.resolve(orderbook, messageHash)

    def handle_trades(self, client: Client, message):
        # {type: "trade",
        #   "code": "KRW-BTC",
        #   "timestamp": 1584508285812,
        #   "trade_date": "2020-03-18",
        #   "trade_time": "05:11:25",
        #   "trade_timestamp": 1584508285000,
        #   "trade_price": 6747000,
        #   "trade_volume": 0.06499468,
        #   "ask_bid": "ASK",
        #   "prev_closing_price": 6774000,
        #   "change": "FALL",
        #   "change_price": 27000,
        #   "sequential_id": 1584508285000002,
        #   "stream_type": "REALTIME"}
        trade = self.parse_trade(message)
        symbol = trade['symbol']
        stored = self.safe_value(self.trades, symbol)
        if stored is None:
            limit = self.safe_integer(self.options, 'tradesLimit', 1000)
            stored = ArrayCache(limit)
            self.trades[symbol] = stored
        stored.append(trade)
        marketId = self.safe_string(message, 'code')
        messageHash = 'trade:' + marketId
        client.resolve(stored, messageHash)

    async def authenticate(self, params={}):
        self.check_required_credentials()
        wsOptions: dict = self.safe_dict(self.options, 'ws', {})
        authenticated = self.safe_string(wsOptions, 'token')
        if authenticated is None:
            auth: dict = {
                'access_key': self.apiKey,
                'nonce': self.uuid(),
            }
            token = self.jwt(auth, self.encode(self.secret), 'sha256', False)
            wsOptions['token'] = token
            wsOptions['options'] = {
                'headers': {
                    'authorization': 'Bearer ' + token,
                },
            }
            self.options['ws'] = wsOptions
        url = self.urls['api']['ws'] + '/private'
        client = self.client(url)
        return client

    async def watch_private(self, symbol, channel, messageHash, params={}):
        await self.authenticate()
        request = {
            'type': channel,
        }
        if symbol is not None:
            await self.load_markets()
            market = self.market(symbol)
            symbol = market['symbol']
            symbols = [symbol]
            marketIds = self.market_ids(symbols)
            request['codes'] = marketIds
            messageHash = messageHash + ':' + symbol
        url = self.implode_params(self.urls['api']['ws'], {
            'hostname': self.hostname,
        })
        url += '/private'
        message = [
            {
                'ticket': self.uuid(),
            },
            request,
        ]
        return await self.watch(url, messageHash, message, messageHash)

    async def watch_orders(self, symbol: Str = None, since: Int = None, limit: Int = None, params={}) -> List[Order]:
        """
        watches information on multiple orders made by the user

        https://global-docs.upbit.com/reference/websocket-myorder

        :param str symbol: unified market symbol of the market orders were made in
        :param int [since]: the earliest time in ms to fetch orders for
        :param int [limit]: the maximum number of order structures to retrieve
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict[]: a list of `order structures <https://docs.ccxt.com/#/?id=order-structure>`
        """
        await self.load_markets()
        channel = 'myOrder'
        messageHash = 'myOrder'
        orders = await self.watch_private(symbol, channel, messageHash)
        if self.newUpdates:
            limit = orders.getLimit(symbol, limit)
        return self.filter_by_symbol_since_limit(orders, symbol, since, limit, True)

    async def watch_my_trades(self, symbol: Str = None, since: Int = None, limit: Int = None, params={}) -> List[Trade]:
        """
        watches information on multiple trades made by the user

        https://global-docs.upbit.com/reference/websocket-myorder

        :param str symbol: unified market symbol of the market orders were made in
        :param int [since]: the earliest time in ms to fetch orders for
        :param int [limit]: the maximum number of order structures to retrieve
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict[]: a list of `trade structures <https://docs.ccxt.com/#/?id=trade-structure>`
        """
        await self.load_markets()
        channel = 'myOrder'
        messageHash = 'myTrades'
        trades = await self.watch_private(symbol, channel, messageHash)
        if self.newUpdates:
            limit = trades.getLimit(symbol, limit)
        return self.filter_by_symbol_since_limit(trades, symbol, since, limit, True)

    def parse_ws_order_status(self, status: Str):
        statuses: dict = {
            'wait': 'open',
            'done': 'closed',
            'cancel': 'canceled',
            'watch': 'open',  # not sure what self status means
            'trade': 'open',
        }
        return self.safe_string(statuses, status, status)

    def parse_ws_order(self, order, market=None):
        #
        # {
        #     "type": "myOrder",
        #     "code": "SGD-XRP",
        #     "uuid": "ac2dc2a3-fce9-40a2-a4f6-5987c25c438f",
        #     "ask_bid": "BID",
        #     "order_type": "limit",
        #     "state": "trade",
        #     "price": 0.001453,
        #     "avg_price": 0.00145372,
        #     "volume": 30925891.29839369,
        #     "remaining_volume": 29968038.09235948,
        #     "executed_volume": 30925891.29839369,
        #     "trades_count": 1,
        #     "reserved_fee": 44.23943970238218,
        #     "remaining_fee": 21.77177967409916,
        #     "paid_fee": 22.467660028283017,
        #     "locked": 43565.33112787242,
        #     "executed_funds": 44935.32005656603,
        #     "order_timestamp": 1710751590000,
        #     "timestamp": 1710751597500,
        #     "stream_type": "REALTIME"
        # }
        #
        id = self.safe_string(order, 'uuid')
        side = self.safe_string_lower(order, 'ask_bid')
        if side == 'bid':
            side = 'buy'
        else:
            side = 'sell'
        timestamp = self.parse8601(self.safe_string(order, 'order_timestamp'))
        status = self.parse_ws_order_status(self.safe_string(order, 'state'))
        marketId = self.safe_string(order, 'code')
        market = self.safe_market(marketId, market)
        fee = None
        feeCost = self.safe_string(order, 'paid_fee')
        if feeCost is not None:
            fee = {
                'currency': market['quote'],
                'cost': feeCost,
            }
        return self.safe_order({
            'info': order,
            'id': id,
            'clientOrderId': None,
            'timestamp': timestamp,
            'datetime': self.iso8601(timestamp),
            'lastTradeTimestamp': self.safe_string(order, 'trade_timestamp'),
            'symbol': market['symbol'],
            'type': self.safe_string(order, 'order_type'),
            'timeInForce': self.safe_string(order, 'time_in_force'),
            'postOnly': None,
            'side': side,
            'price': self.safe_string(order, 'price'),
            'stopPrice': None,
            'triggerPrice': None,
            'cost': self.safe_string(order, 'executed_funds'),
            'average': self.safe_string(order, 'avg_price'),
            'amount': self.safe_string(order, 'volume'),
            'filled': self.safe_string(order, 'executed_volume'),
            'remaining': self.safe_string(order, 'remaining_volume'),
            'status': status,
            'fee': fee,
            'trades': None,
        })

    def parse_ws_trade(self, trade, market=None):
        # see: parseWsOrder
        side = self.safe_string_lower(trade, 'ask_bid')
        if side == 'bid':
            side = 'buy'
        else:
            side = 'sell'
        timestamp = self.parse8601(self.safe_string(trade, 'trade_timestamp'))
        marketId = self.safe_string(trade, 'code')
        market = self.safe_market(marketId, market)
        fee = None
        feeCost = self.safe_string(trade, 'paid_fee')
        if feeCost is not None:
            fee = {
                'currency': market['quote'],
                'cost': feeCost,
            }
        return self.safe_trade({
            'id': self.safe_string(trade, 'trade_uuid'),
            'timestamp': timestamp,
            'datetime': self.iso8601(timestamp),
            'symbol': market['symbol'],
            'side': side,
            'price': self.safe_string(trade, 'price'),
            'amount': self.safe_string(trade, 'volume'),
            'cost': self.safe_string(trade, 'executed_funds'),
            'order': self.safe_string(trade, 'uuid'),
            'takerOrMaker': None,
            'type': self.safe_string(trade, 'order_type'),
            'fee': fee,
            'info': trade,
        }, market)

    def handle_my_order(self, client: Client, message):
        # see: parseWsOrder
        tradeId = self.safe_string(message, 'trade_uuid')
        if tradeId is not None:
            self.handle_my_trade(client, message)
        self.handle_order(client, message)

    def handle_my_trade(self, client: Client, message):
        # see: parseWsOrder
        myTrades = self.myTrades
        if myTrades is None:
            limit = self.safe_integer(self.options, 'tradesLimit', 1000)
            myTrades = ArrayCacheBySymbolById(limit)
        trade = self.parse_ws_trade(message)
        myTrades.append(trade)
        messageHash = 'myTrades'
        client.resolve(myTrades, messageHash)
        messageHash = 'myTrades:' + trade['symbol']
        client.resolve(myTrades, messageHash)

    def handle_order(self, client: Client, message):
        parsed = self.parse_ws_order(message)
        symbol = self.safe_string(parsed, 'symbol')
        orderId = self.safe_string(parsed, 'id')
        if self.orders is None:
            limit = self.safe_integer(self.options, 'ordersLimit', 1000)
            self.orders = ArrayCacheBySymbolById(limit)
        cachedOrders = self.orders
        orders = self.safe_value(cachedOrders.hashmap, symbol, {})
        order = self.safe_value(orders, orderId)
        if order is not None:
            fee = self.safe_value(order, 'fee')
            if fee is not None:
                parsed['fee'] = fee
            fees = self.safe_value(order, 'fees')
            if fees is not None:
                parsed['fees'] = fees
            parsed['trades'] = self.safe_value(order, 'trades')
            parsed['timestamp'] = self.safe_integer(order, 'timestamp')
            parsed['datetime'] = self.safe_string(order, 'datetime')
        cachedOrders.append(parsed)
        messageHash = 'myOrder'
        client.resolve(self.orders, messageHash)
        messageHash = messageHash + ':' + symbol
        client.resolve(self.orders, messageHash)

    async def watch_balance(self, params={}) -> Balances:
        """

        https://global-docs.upbit.com/reference/websocket-myasset

        query for balance and get the amount of funds available for trading or funds locked in orders
        :param dict [params]: extra parameters specific to the exchange API endpoint
        :returns dict: a `balance structure <https://docs.ccxt.com/#/?id=balance-structure>`
        """
        await self.load_markets()
        channel = 'myAsset'
        messageHash = 'myAsset'
        return await self.watch_private(None, channel, messageHash)

    def handle_balance(self, client: Client, message):
        #
        # {
        #     "type": "myAsset",
        #     "asset_uuid": "e635f223-1609-4969-8fb6-4376937baad6",
        #     "assets": [
        #       {
        #         "currency": "SGD",
        #         "balance": 1386929.37231066771348207123,
        #         "locked": 10329.670127489597585685
        #       }
        #     ],
        #     "asset_timestamp": 1710146517259,
        #     "timestamp": 1710146517267,
        #     "stream_type": "REALTIME"
        # }
        #
        data = self.safe_list(message, 'assets', [])
        timestamp = self.safe_integer(message, 'timestamp')
        self.balance['timestamp'] = timestamp
        self.balance['datetime'] = self.iso8601(timestamp)
        for i in range(0, len(data)):
            balance = data[i]
            currencyId = self.safe_string(balance, 'currency')
            code = self.safe_currency_code(currencyId)
            available = self.safe_string(balance, 'balance')
            frozen = self.safe_string(balance, 'locked')
            account = self.account()
            account['free'] = available
            account['used'] = frozen
            self.balance[code] = account
            self.balance = self.safe_balance(self.balance)
        messageHash = self.safe_string(message, 'type')
        client.resolve(self.balance, messageHash)

    def handle_message(self, client: Client, message):
        methods: dict = {
            'ticker': self.handle_ticker,
            'orderbook': self.handle_order_book,
            'trade': self.handle_trades,
            'myOrder': self.handle_my_order,
            'myAsset': self.handle_balance,
        }
        methodName = self.safe_string(message, 'type')
        method = self.safe_value(methods, methodName)
        if method:
            method(client, message)