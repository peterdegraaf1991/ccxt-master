using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testFetchTicker(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "fetchTicker";
        object ticker = await exchange.fetchTicker(symbol);
        testTicker(exchange, skippedProperties, method, ticker, symbol);
    }

}