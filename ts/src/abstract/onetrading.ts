// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

import { implicitReturnType } from '../base/types.js';
import { Exchange as _Exchange } from '../base/Exchange.js';

interface Exchange {
    publicGetCurrencies (params?: {}): Promise<implicitReturnType>;
    publicGetCandlesticksInstrumentCode (params?: {}): Promise<implicitReturnType>;
    publicGetFees (params?: {}): Promise<implicitReturnType>;
    publicGetInstruments (params?: {}): Promise<implicitReturnType>;
    publicGetOrderBookInstrumentCode (params?: {}): Promise<implicitReturnType>;
    publicGetMarketTicker (params?: {}): Promise<implicitReturnType>;
    publicGetMarketTickerInstrumentCode (params?: {}): Promise<implicitReturnType>;
    publicGetPriceTicksInstrumentCode (params?: {}): Promise<implicitReturnType>;
    publicGetTime (params?: {}): Promise<implicitReturnType>;
    privateGetAccountBalances (params?: {}): Promise<implicitReturnType>;
    privateGetAccountDepositCryptoCurrencyCode (params?: {}): Promise<implicitReturnType>;
    privateGetAccountDepositFiatEUR (params?: {}): Promise<implicitReturnType>;
    privateGetAccountDeposits (params?: {}): Promise<implicitReturnType>;
    privateGetAccountDepositsBitpanda (params?: {}): Promise<implicitReturnType>;
    privateGetAccountWithdrawals (params?: {}): Promise<implicitReturnType>;
    privateGetAccountWithdrawalsBitpanda (params?: {}): Promise<implicitReturnType>;
    privateGetAccountFees (params?: {}): Promise<implicitReturnType>;
    privateGetAccountOrders (params?: {}): Promise<implicitReturnType>;
    privateGetAccountOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetAccountOrdersOrderIdTrades (params?: {}): Promise<implicitReturnType>;
    privateGetAccountTrades (params?: {}): Promise<implicitReturnType>;
    privateGetAccountTradesTradeId (params?: {}): Promise<implicitReturnType>;
    privateGetAccountTradingVolume (params?: {}): Promise<implicitReturnType>;
    privatePostAccountDepositCrypto (params?: {}): Promise<implicitReturnType>;
    privatePostAccountWithdrawCrypto (params?: {}): Promise<implicitReturnType>;
    privatePostAccountWithdrawFiat (params?: {}): Promise<implicitReturnType>;
    privatePostAccountFees (params?: {}): Promise<implicitReturnType>;
    privatePostAccountOrders (params?: {}): Promise<implicitReturnType>;
    privateDeleteAccountOrders (params?: {}): Promise<implicitReturnType>;
    privateDeleteAccountOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteAccountOrdersClientClientId (params?: {}): Promise<implicitReturnType>;
}
abstract class Exchange extends _Exchange {}

export default Exchange