// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

// @ts-nocheck
import { strictEqual } from 'assert';
import { Exchange, functions } from '../../../../ccxt.js';
const { index, aggregate, unCamelCase } = functions;
const equal = strictEqual;
function testLegacyHas() {
    const exchange = new Exchange({
        'id': 'mock',
        'has': {
            'CORS': true,
            'publicAPI': false,
            'fetchDepositAddress': 'emulated'
        }
    });
    equal(exchange.hasCORS, true);
    equal(exchange.hasPublicAPI, false);
    equal(exchange.hasFetchDepositAddress, true);
}
export default testLegacyHas;