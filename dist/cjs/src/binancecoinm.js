'use strict';

var binance = require('./binance.js');

//  ---------------------------------------------------------------------------
//  ---------------------------------------------------------------------------
class binancecoinm extends binance {
    describe() {
        return this.deepExtend(super.describe(), {
            'id': 'binancecoinm',
            'name': 'Binance COIN-M',
            'urls': {
                'logo': 'https://github.com/user-attachments/assets/387cfc4e-5f33-48cd-8f5c-cd4854dabf0c',
                'doc': [
                    'https://binance-docs.github.io/apidocs/delivery/en/',
                    'https://binance-docs.github.io/apidocs/spot/en',
                    'https://developers.binance.com/en',
                ],
            },
            'has': {
                'CORS': undefined,
                'spot': false,
                'margin': false,
                'swap': true,
                'future': true,
                'option': undefined,
                'createStopMarketOrder': true,
            },
            'options': {
                'fetchMarkets': ['inverse'],
                'defaultSubType': 'inverse',
                'leverageBrackets': undefined,
            },
        });
    }
    async transferIn(code, amount, params = {}) {
        // transfer from spot wallet to coinm futures wallet
        return await this.futuresTransfer(code, amount, 3, params);
    }
    async transferOut(code, amount, params = {}) {
        // transfer from coinm futures wallet to spot wallet
        return await this.futuresTransfer(code, amount, 4, params);
    }
}

module.exports = binancecoinm;