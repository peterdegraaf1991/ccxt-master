// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class mexc : Exchange
{
    public mexc (object args = null): base(args) {}

    public async Task<object> spotPublicGetPing (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetPing",parameters);
    }

    public async Task<object> spotPublicGetTime (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTime",parameters);
    }

    public async Task<object> spotPublicGetExchangeInfo (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetExchangeInfo",parameters);
    }

    public async Task<object> spotPublicGetDepth (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetDepth",parameters);
    }

    public async Task<object> spotPublicGetTrades (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTrades",parameters);
    }

    public async Task<object> spotPublicGetHistoricalTrades (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetHistoricalTrades",parameters);
    }

    public async Task<object> spotPublicGetAggTrades (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetAggTrades",parameters);
    }

    public async Task<object> spotPublicGetKlines (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetKlines",parameters);
    }

    public async Task<object> spotPublicGetAvgPrice (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetAvgPrice",parameters);
    }

    public async Task<object> spotPublicGetTicker24hr (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTicker24hr",parameters);
    }

    public async Task<object> spotPublicGetTickerPrice (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTickerPrice",parameters);
    }

    public async Task<object> spotPublicGetTickerBookTicker (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTickerBookTicker",parameters);
    }

    public async Task<object> spotPublicGetEtfInfo (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetEtfInfo",parameters);
    }

    public async Task<object> spotPrivateGetOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetOrder",parameters);
    }

    public async Task<object> spotPrivateGetOpenOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetOpenOrders",parameters);
    }

    public async Task<object> spotPrivateGetAllOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetAllOrders",parameters);
    }

    public async Task<object> spotPrivateGetAccount (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetAccount",parameters);
    }

    public async Task<object> spotPrivateGetMyTrades (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMyTrades",parameters);
    }

    public async Task<object> spotPrivateGetSubAccountList (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetSubAccountList",parameters);
    }

    public async Task<object> spotPrivateGetSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetSubAccountApiKey",parameters);
    }

    public async Task<object> spotPrivateGetCapitalConfigGetall (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalConfigGetall",parameters);
    }

    public async Task<object> spotPrivateGetCapitalDepositHisrec (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalDepositHisrec",parameters);
    }

    public async Task<object> spotPrivateGetCapitalWithdrawHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalWithdrawHistory",parameters);
    }

    public async Task<object> spotPrivateGetCapitalWithdrawAddress (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalWithdrawAddress",parameters);
    }

    public async Task<object> spotPrivateGetCapitalDepositAddress (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalDepositAddress",parameters);
    }

    public async Task<object> spotPrivateGetCapitalTransfer (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalTransfer",parameters);
    }

    public async Task<object> spotPrivateGetCapitalTransferTranId (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalTransferTranId",parameters);
    }

    public async Task<object> spotPrivateGetCapitalTransferInternal (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalTransferInternal",parameters);
    }

    public async Task<object> spotPrivateGetCapitalSubAccountUniversalTransfer (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalSubAccountUniversalTransfer",parameters);
    }

    public async Task<object> spotPrivateGetCapitalConvert (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalConvert",parameters);
    }

    public async Task<object> spotPrivateGetCapitalConvertList (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetCapitalConvertList",parameters);
    }

    public async Task<object> spotPrivateGetMarginLoan (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginLoan",parameters);
    }

    public async Task<object> spotPrivateGetMarginAllOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginAllOrders",parameters);
    }

    public async Task<object> spotPrivateGetMarginMyTrades (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginMyTrades",parameters);
    }

    public async Task<object> spotPrivateGetMarginOpenOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginOpenOrders",parameters);
    }

    public async Task<object> spotPrivateGetMarginMaxTransferable (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginMaxTransferable",parameters);
    }

    public async Task<object> spotPrivateGetMarginPriceIndex (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginPriceIndex",parameters);
    }

    public async Task<object> spotPrivateGetMarginOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginOrder",parameters);
    }

    public async Task<object> spotPrivateGetMarginIsolatedAccount (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginIsolatedAccount",parameters);
    }

    public async Task<object> spotPrivateGetMarginMaxBorrowable (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginMaxBorrowable",parameters);
    }

    public async Task<object> spotPrivateGetMarginRepay (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginRepay",parameters);
    }

    public async Task<object> spotPrivateGetMarginIsolatedPair (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginIsolatedPair",parameters);
    }

    public async Task<object> spotPrivateGetMarginForceLiquidationRec (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginForceLiquidationRec",parameters);
    }

    public async Task<object> spotPrivateGetMarginIsolatedMarginData (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginIsolatedMarginData",parameters);
    }

    public async Task<object> spotPrivateGetMarginIsolatedMarginTier (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMarginIsolatedMarginTier",parameters);
    }

    public async Task<object> spotPrivateGetRebateTaxQuery (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateTaxQuery",parameters);
    }

    public async Task<object> spotPrivateGetRebateDetail (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateDetail",parameters);
    }

    public async Task<object> spotPrivateGetRebateDetailKickback (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateDetailKickback",parameters);
    }

    public async Task<object> spotPrivateGetRebateReferCode (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateReferCode",parameters);
    }

    public async Task<object> spotPrivateGetRebateAffiliateCommission (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateAffiliateCommission",parameters);
    }

    public async Task<object> spotPrivateGetRebateAffiliateWithdraw (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateAffiliateWithdraw",parameters);
    }

    public async Task<object> spotPrivateGetRebateAffiliateCommissionDetail (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetRebateAffiliateCommissionDetail",parameters);
    }

    public async Task<object> spotPrivateGetMxDeductEnable (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetMxDeductEnable",parameters);
    }

    public async Task<object> spotPrivateGetUserDataStream (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetUserDataStream",parameters);
    }

    public async Task<object> spotPrivateGetSelfSymbols (object parameters = null)
    {
        return await this.callAsync ("spotPrivateGetSelfSymbols",parameters);
    }

    public async Task<object> spotPrivatePostOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrder",parameters);
    }

    public async Task<object> spotPrivatePostOrderTest (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrderTest",parameters);
    }

    public async Task<object> spotPrivatePostSubAccountVirtualSubAccount (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubAccountVirtualSubAccount",parameters);
    }

    public async Task<object> spotPrivatePostSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubAccountApiKey",parameters);
    }

    public async Task<object> spotPrivatePostSubAccountFutures (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubAccountFutures",parameters);
    }

    public async Task<object> spotPrivatePostSubAccountMargin (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubAccountMargin",parameters);
    }

    public async Task<object> spotPrivatePostBatchOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostBatchOrders",parameters);
    }

    public async Task<object> spotPrivatePostCapitalWithdrawApply (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalWithdrawApply",parameters);
    }

    public async Task<object> spotPrivatePostCapitalWithdraw (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalWithdraw",parameters);
    }

    public async Task<object> spotPrivatePostCapitalTransfer (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalTransfer",parameters);
    }

    public async Task<object> spotPrivatePostCapitalTransferInternal (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalTransferInternal",parameters);
    }

    public async Task<object> spotPrivatePostCapitalDepositAddress (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalDepositAddress",parameters);
    }

    public async Task<object> spotPrivatePostCapitalSubAccountUniversalTransfer (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalSubAccountUniversalTransfer",parameters);
    }

    public async Task<object> spotPrivatePostCapitalConvert (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCapitalConvert",parameters);
    }

    public async Task<object> spotPrivatePostMxDeductEnable (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostMxDeductEnable",parameters);
    }

    public async Task<object> spotPrivatePostUserDataStream (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostUserDataStream",parameters);
    }

    public async Task<object> spotPrivatePutUserDataStream (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePutUserDataStream",parameters);
    }

    public async Task<object> spotPrivateDeleteOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteOrder",parameters);
    }

    public async Task<object> spotPrivateDeleteOpenOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteOpenOrders",parameters);
    }

    public async Task<object> spotPrivateDeleteSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteSubAccountApiKey",parameters);
    }

    public async Task<object> spotPrivateDeleteMarginOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteMarginOrder",parameters);
    }

    public async Task<object> spotPrivateDeleteMarginOpenOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteMarginOpenOrders",parameters);
    }

    public async Task<object> spotPrivateDeleteUserDataStream (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteUserDataStream",parameters);
    }

    public async Task<object> spotPrivateDeleteCapitalWithdraw (object parameters = null)
    {
        return await this.callAsync ("spotPrivateDeleteCapitalWithdraw",parameters);
    }

    public async Task<object> contractPublicGetPing (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetPing",parameters);
    }

    public async Task<object> contractPublicGetDetail (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetDetail",parameters);
    }

    public async Task<object> contractPublicGetSupportCurrencies (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetSupportCurrencies",parameters);
    }

    public async Task<object> contractPublicGetDepthSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetDepthSymbol",parameters);
    }

    public async Task<object> contractPublicGetDepthCommitsSymbolLimit (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetDepthCommitsSymbolLimit",parameters);
    }

    public async Task<object> contractPublicGetIndexPriceSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetIndexPriceSymbol",parameters);
    }

    public async Task<object> contractPublicGetFairPriceSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetFairPriceSymbol",parameters);
    }

    public async Task<object> contractPublicGetFundingRateSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetFundingRateSymbol",parameters);
    }

    public async Task<object> contractPublicGetKlineSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetKlineSymbol",parameters);
    }

    public async Task<object> contractPublicGetKlineIndexPriceSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetKlineIndexPriceSymbol",parameters);
    }

    public async Task<object> contractPublicGetKlineFairPriceSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetKlineFairPriceSymbol",parameters);
    }

    public async Task<object> contractPublicGetDealsSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetDealsSymbol",parameters);
    }

    public async Task<object> contractPublicGetTicker (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetTicker",parameters);
    }

    public async Task<object> contractPublicGetRiskReverse (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetRiskReverse",parameters);
    }

    public async Task<object> contractPublicGetRiskReverseHistory (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetRiskReverseHistory",parameters);
    }

    public async Task<object> contractPublicGetFundingRateHistory (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetFundingRateHistory",parameters);
    }

    public async Task<object> contractPrivateGetAccountAssets (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccountAssets",parameters);
    }

    public async Task<object> contractPrivateGetAccountAssetCurrency (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccountAssetCurrency",parameters);
    }

    public async Task<object> contractPrivateGetAccountTransferRecord (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccountTransferRecord",parameters);
    }

    public async Task<object> contractPrivateGetPositionListHistoryPositions (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPositionListHistoryPositions",parameters);
    }

    public async Task<object> contractPrivateGetPositionOpenPositions (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPositionOpenPositions",parameters);
    }

    public async Task<object> contractPrivateGetPositionFundingRecords (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPositionFundingRecords",parameters);
    }

    public async Task<object> contractPrivateGetPositionPositionMode (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPositionPositionMode",parameters);
    }

    public async Task<object> contractPrivateGetOrderListOpenOrdersSymbol (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderListOpenOrdersSymbol",parameters);
    }

    public async Task<object> contractPrivateGetOrderListHistoryOrders (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderListHistoryOrders",parameters);
    }

    public async Task<object> contractPrivateGetOrderExternalSymbolExternalOid (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderExternalSymbolExternalOid",parameters);
    }

    public async Task<object> contractPrivateGetOrderGetOrderId (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderGetOrderId",parameters);
    }

    public async Task<object> contractPrivateGetOrderBatchQuery (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderBatchQuery",parameters);
    }

    public async Task<object> contractPrivateGetOrderDealDetailsOrderId (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderDealDetailsOrderId",parameters);
    }

    public async Task<object> contractPrivateGetOrderListOrderDeals (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrderListOrderDeals",parameters);
    }

    public async Task<object> contractPrivateGetPlanorderListOrders (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPlanorderListOrders",parameters);
    }

    public async Task<object> contractPrivateGetStoporderListOrders (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetStoporderListOrders",parameters);
    }

    public async Task<object> contractPrivateGetStoporderOrderDetailsStopOrderId (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetStoporderOrderDetailsStopOrderId",parameters);
    }

    public async Task<object> contractPrivateGetAccountRiskLimit (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccountRiskLimit",parameters);
    }

    public async Task<object> contractPrivateGetAccountTieredFeeRate (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccountTieredFeeRate",parameters);
    }

    public async Task<object> contractPrivateGetPositionLeverage (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetPositionLeverage",parameters);
    }

    public async Task<object> contractPrivatePostPositionChangeMargin (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPositionChangeMargin",parameters);
    }

    public async Task<object> contractPrivatePostPositionChangeLeverage (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPositionChangeLeverage",parameters);
    }

    public async Task<object> contractPrivatePostPositionChangePositionMode (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPositionChangePositionMode",parameters);
    }

    public async Task<object> contractPrivatePostOrderSubmit (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrderSubmit",parameters);
    }

    public async Task<object> contractPrivatePostOrderSubmitBatch (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrderSubmitBatch",parameters);
    }

    public async Task<object> contractPrivatePostOrderCancel (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrderCancel",parameters);
    }

    public async Task<object> contractPrivatePostOrderCancelWithExternal (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrderCancelWithExternal",parameters);
    }

    public async Task<object> contractPrivatePostOrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrderCancelAll",parameters);
    }

    public async Task<object> contractPrivatePostAccountChangeRiskLevel (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostAccountChangeRiskLevel",parameters);
    }

    public async Task<object> contractPrivatePostPlanorderPlace (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPlanorderPlace",parameters);
    }

    public async Task<object> contractPrivatePostPlanorderCancel (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPlanorderCancel",parameters);
    }

    public async Task<object> contractPrivatePostPlanorderCancelAll (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostPlanorderCancelAll",parameters);
    }

    public async Task<object> contractPrivatePostStoporderCancel (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostStoporderCancel",parameters);
    }

    public async Task<object> contractPrivatePostStoporderCancelAll (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostStoporderCancelAll",parameters);
    }

    public async Task<object> contractPrivatePostStoporderChangePrice (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostStoporderChangePrice",parameters);
    }

    public async Task<object> contractPrivatePostStoporderChangePlanPrice (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostStoporderChangePlanPrice",parameters);
    }

    public async Task<object> spot2PublicGetMarketSymbols (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketSymbols",parameters);
    }

    public async Task<object> spot2PublicGetMarketCoinList (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketCoinList",parameters);
    }

    public async Task<object> spot2PublicGetCommonTimestamp (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetCommonTimestamp",parameters);
    }

    public async Task<object> spot2PublicGetCommonPing (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetCommonPing",parameters);
    }

    public async Task<object> spot2PublicGetMarketTicker (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketTicker",parameters);
    }

    public async Task<object> spot2PublicGetMarketDepth (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketDepth",parameters);
    }

    public async Task<object> spot2PublicGetMarketDeals (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketDeals",parameters);
    }

    public async Task<object> spot2PublicGetMarketKline (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketKline",parameters);
    }

    public async Task<object> spot2PublicGetMarketApiDefaultSymbols (object parameters = null)
    {
        return await this.callAsync ("spot2PublicGetMarketApiDefaultSymbols",parameters);
    }

    public async Task<object> spot2PrivateGetAccountInfo (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAccountInfo",parameters);
    }

    public async Task<object> spot2PrivateGetOrderOpenOrders (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetOrderOpenOrders",parameters);
    }

    public async Task<object> spot2PrivateGetOrderList (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetOrderList",parameters);
    }

    public async Task<object> spot2PrivateGetOrderQuery (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetOrderQuery",parameters);
    }

    public async Task<object> spot2PrivateGetOrderDeals (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetOrderDeals",parameters);
    }

    public async Task<object> spot2PrivateGetOrderDealDetail (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetOrderDealDetail",parameters);
    }

    public async Task<object> spot2PrivateGetAssetDepositAddressList (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetDepositAddressList",parameters);
    }

    public async Task<object> spot2PrivateGetAssetDepositList (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetDepositList",parameters);
    }

    public async Task<object> spot2PrivateGetAssetAddressList (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetAddressList",parameters);
    }

    public async Task<object> spot2PrivateGetAssetWithdrawList (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetWithdrawList",parameters);
    }

    public async Task<object> spot2PrivateGetAssetInternalTransferRecord (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetInternalTransferRecord",parameters);
    }

    public async Task<object> spot2PrivateGetAccountBalance (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAccountBalance",parameters);
    }

    public async Task<object> spot2PrivateGetAssetInternalTransferInfo (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetAssetInternalTransferInfo",parameters);
    }

    public async Task<object> spot2PrivateGetMarketApiSymbols (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateGetMarketApiSymbols",parameters);
    }

    public async Task<object> spot2PrivatePostOrderPlace (object parameters = null)
    {
        return await this.callAsync ("spot2PrivatePostOrderPlace",parameters);
    }

    public async Task<object> spot2PrivatePostOrderPlaceBatch (object parameters = null)
    {
        return await this.callAsync ("spot2PrivatePostOrderPlaceBatch",parameters);
    }

    public async Task<object> spot2PrivatePostOrderAdvancedPlaceBatch (object parameters = null)
    {
        return await this.callAsync ("spot2PrivatePostOrderAdvancedPlaceBatch",parameters);
    }

    public async Task<object> spot2PrivatePostAssetWithdraw (object parameters = null)
    {
        return await this.callAsync ("spot2PrivatePostAssetWithdraw",parameters);
    }

    public async Task<object> spot2PrivatePostAssetInternalTransfer (object parameters = null)
    {
        return await this.callAsync ("spot2PrivatePostAssetInternalTransfer",parameters);
    }

    public async Task<object> spot2PrivateDeleteOrderCancel (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateDeleteOrderCancel",parameters);
    }

    public async Task<object> spot2PrivateDeleteOrderCancelBySymbol (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateDeleteOrderCancelBySymbol",parameters);
    }

    public async Task<object> spot2PrivateDeleteAssetWithdraw (object parameters = null)
    {
        return await this.callAsync ("spot2PrivateDeleteAssetWithdraw",parameters);
    }

    public async Task<object> brokerPrivateGetSubAccountUniversalTransfer (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetSubAccountUniversalTransfer",parameters);
    }

    public async Task<object> brokerPrivateGetSubAccountList (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetSubAccountList",parameters);
    }

    public async Task<object> brokerPrivateGetSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetSubAccountApiKey",parameters);
    }

    public async Task<object> brokerPrivateGetCapitalDepositSubAddress (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetCapitalDepositSubAddress",parameters);
    }

    public async Task<object> brokerPrivateGetCapitalDepositSubHisrec (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetCapitalDepositSubHisrec",parameters);
    }

    public async Task<object> brokerPrivateGetCapitalDepositSubHisrecGetall (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateGetCapitalDepositSubHisrecGetall",parameters);
    }

    public async Task<object> brokerPrivatePostSubAccountVirtualSubAccount (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostSubAccountVirtualSubAccount",parameters);
    }

    public async Task<object> brokerPrivatePostSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostSubAccountApiKey",parameters);
    }

    public async Task<object> brokerPrivatePostCapitalDepositSubAddress (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostCapitalDepositSubAddress",parameters);
    }

    public async Task<object> brokerPrivatePostCapitalWithdrawApply (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostCapitalWithdrawApply",parameters);
    }

    public async Task<object> brokerPrivatePostSubAccountUniversalTransfer (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostSubAccountUniversalTransfer",parameters);
    }

    public async Task<object> brokerPrivatePostSubAccountFutures (object parameters = null)
    {
        return await this.callAsync ("brokerPrivatePostSubAccountFutures",parameters);
    }

    public async Task<object> brokerPrivateDeleteSubAccountApiKey (object parameters = null)
    {
        return await this.callAsync ("brokerPrivateDeleteSubAccountApiKey",parameters);
    }

}