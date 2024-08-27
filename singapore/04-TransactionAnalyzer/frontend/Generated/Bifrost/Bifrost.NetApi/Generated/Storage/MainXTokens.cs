//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> XTokensStorage
    /// </summary>
    public sealed class XTokensStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> XTokensStorage Constructor
        /// </summary>
        public XTokensStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    /// <summary>
    /// >> XTokensCalls
    /// </summary>
    public sealed class XTokensCalls
    {
        
        /// <summary>
        /// >> transfer
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Transfer(Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId currency_id, Substrate.NetApi.Model.Types.Primitive.U128 amount, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 0, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiasset
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferMultiasset(Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset asset, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 1, "transfer_multiasset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_with_fee
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferWithFee(Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId currency_id, Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.NetApi.Model.Types.Primitive.U128 fee, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currency_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(fee.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 2, "transfer_with_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiasset_with_fee
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferMultiassetWithFee(Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset asset, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset fee, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(fee.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 3, "transfer_multiasset_with_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multicurrencies
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferMulticurrencies(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>> currencies, Substrate.NetApi.Model.Types.Primitive.U32 fee_item, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(currencies.Encode());
            byteArray.AddRange(fee_item.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 4, "transfer_multicurrencies", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_multiassets
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferMultiassets(Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAssets assets, Substrate.NetApi.Model.Types.Primitive.U32 fee_item, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation dest, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit dest_weight_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(assets.Encode());
            byteArray.AddRange(fee_item.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(dest_weight_limit.Encode());
            return new Method(70, "XTokens", 5, "transfer_multiassets", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> XTokensConstants
    /// </summary>
    public sealed class XTokensConstants
    {
        
        /// <summary>
        /// >> SelfLocation
        ///  Self chain location.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.staging_xcm.v4.location.Location SelfLocation()
        {
            var result = new Bifrost.NetApi.Generated.Model.staging_xcm.v4.location.Location();
            result.Create("0x0000");
            return result;
        }
        
        /// <summary>
        /// >> BaseXcmWeight
        ///  Base XCM weight.
        /// 
        ///  The actually weight for an XCM message is `T::BaseXcmWeight +
        ///  T::Weigher::weight(&msg)`.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight BaseXcmWeight()
        {
            var result = new Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            result.Create("0x02286BEE00");
            return result;
        }
        
        /// <summary>
        /// >> RateLimiterId
        ///  The id of the RateLimiter.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple RateLimiterId()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseTuple();
            result.Create("0x");
            return result;
        }
    }
    
    /// <summary>
    /// >> XTokensErrors
    /// </summary>
    public enum XTokensErrors
    {
        
        /// <summary>
        /// >> AssetHasNoReserve
        /// Asset has no reserve location.
        /// </summary>
        AssetHasNoReserve,
        
        /// <summary>
        /// >> NotCrossChainTransfer
        /// Not cross-chain transfer.
        /// </summary>
        NotCrossChainTransfer,
        
        /// <summary>
        /// >> InvalidDest
        /// Invalid transfer destination.
        /// </summary>
        InvalidDest,
        
        /// <summary>
        /// >> NotCrossChainTransferableCurrency
        /// Currency is not cross-chain transferable.
        /// </summary>
        NotCrossChainTransferableCurrency,
        
        /// <summary>
        /// >> UnweighableMessage
        /// The message's weight could not be determined.
        /// </summary>
        UnweighableMessage,
        
        /// <summary>
        /// >> XcmExecutionFailed
        /// XCM execution failed.
        /// </summary>
        XcmExecutionFailed,
        
        /// <summary>
        /// >> CannotReanchor
        /// Could not re-anchor the assets to declare the fees for the
        /// destination chain.
        /// </summary>
        CannotReanchor,
        
        /// <summary>
        /// >> InvalidAncestry
        /// Could not get ancestry of asset reserve location.
        /// </summary>
        InvalidAncestry,
        
        /// <summary>
        /// >> InvalidAsset
        /// The Asset is invalid.
        /// </summary>
        InvalidAsset,
        
        /// <summary>
        /// >> DestinationNotInvertible
        /// The destination `Location` provided cannot be inverted.
        /// </summary>
        DestinationNotInvertible,
        
        /// <summary>
        /// >> BadVersion
        /// The version of the `Versioned` value used is not able to be
        /// interpreted.
        /// </summary>
        BadVersion,
        
        /// <summary>
        /// >> DistinctReserveForAssetAndFee
        /// We tried sending distinct asset and fee but they have different
        /// reserve chains.
        /// </summary>
        DistinctReserveForAssetAndFee,
        
        /// <summary>
        /// >> ZeroFee
        /// The fee is zero.
        /// </summary>
        ZeroFee,
        
        /// <summary>
        /// >> ZeroAmount
        /// The transfering asset amount is zero.
        /// </summary>
        ZeroAmount,
        
        /// <summary>
        /// >> TooManyAssetsBeingSent
        /// The number of assets to be sent is over the maximum.
        /// </summary>
        TooManyAssetsBeingSent,
        
        /// <summary>
        /// >> AssetIndexNonExistent
        /// The specified index does not exist in a Assets struct.
        /// </summary>
        AssetIndexNonExistent,
        
        /// <summary>
        /// >> FeeNotEnough
        /// Fee is not enough.
        /// </summary>
        FeeNotEnough,
        
        /// <summary>
        /// >> NotSupportedLocation
        /// Not supported Location
        /// </summary>
        NotSupportedLocation,
        
        /// <summary>
        /// >> MinXcmFeeNotDefined
        /// MinXcmFee not registered for certain reserve location
        /// </summary>
        MinXcmFeeNotDefined,
        
        /// <summary>
        /// >> RateLimited
        /// Asset transfer is limited by RateLimiter.
        /// </summary>
        RateLimited,
    }
}
