<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
include_once PATH_TO_CCXT . '/test/exchange/base/test_account.php';

function test_fetch_accounts($exchange, $skipped_properties) {
    $method = 'fetchAccounts';
    $accounts = $exchange->fetch_accounts();
    assert_non_emtpy_array($exchange, $skipped_properties, $method, $accounts);
    for ($i = 0; $i < count($accounts); $i++) {
        test_account($exchange, $skipped_properties, $method, $accounts[$i]);
    }
}