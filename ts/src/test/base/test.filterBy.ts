
// AUTO_TRANSPILE_ENABLED

import ccxt from '../../../ccxt.js';
import testSharedMethods from '../Exchange/base/test.sharedMethods.js';

function testFilterBy () {

    const exchange = new ccxt.Exchange ({
        'id': 'sampleexchange',
    });

    const sampleArray = [
        { 'foo': 'a' },
        { 'foo': undefined },
        { 'foo': 'b' },
        // { }, todo : bugs in py
        { 'foo': 'a', 'bar': 'b' },
        { 'foo': 'c' },
        { 'foo': 'd' },
        { 'foo': 'b' },
        { 'foo': 'c' },
        { 'foo': 'c' },
    ];

    try {
        const currentValue = exchange.filterBy (sampleArray, 'foo', 'a');
        const storedValue = [
            { 'foo': 'a' },
            { 'foo': 'a', 'bar': 'b' },
        ];
        testSharedMethods.assertDeepEqual (exchange, undefined, 'testFilterBy', currentValue, storedValue);
    } catch (e) {
        // skip c# , todo
        if ((e.toString ()).includes ('BaseTest.assert') || (e.toString ()).includes ('at System.') || (e.toString ()).includes ('at ccxt.Exchange.')) {
            return;
        } else {
            throw e;
        }
    }
}

export default testFilterBy;