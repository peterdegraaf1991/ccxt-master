// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import testBorrowRate from './base/test.borrowRate.js';
async function testFetchBorrowRate(exchange, skippedProperties, code) {
    const method = 'fetchBorrowRate';
    const borrowRate = await exchange.fetchBorrowRate(code);
    testBorrowRate(exchange, skippedProperties, method, borrowRate, code);
}
export default testFetchBorrowRate;