//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_asset_registry.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> register
        /// See [`Pallet::register`].
        /// </summary>
        register = 0,
        
        /// <summary>
        /// >> update
        /// See [`Pallet::update`].
        /// </summary>
        update = 1,
        
        /// <summary>
        /// >> register_external
        /// See [`Pallet::register_external`].
        /// </summary>
        register_external = 4,
        
        /// <summary>
        /// >> ban_asset
        /// See [`Pallet::ban_asset`].
        /// </summary>
        ban_asset = 5,
        
        /// <summary>
        /// >> unban_asset
        /// See [`Pallet::unban_asset`].
        /// </summary>
        unban_asset = 6,
    }
    
    /// <summary>
    /// >> 357 - Variant[pallet_asset_registry.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>, Hydration.NetApi.Generated.Model.pallet_asset_registry.types.EnumAssetType, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.hydradx_runtime.xcm.AssetLocation>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_asset_registry.types.EnumAssetType>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.hydradx_runtime.xcm.AssetLocation>>, BaseVoid, BaseVoid, Hydration.NetApi.Generated.Model.hydradx_runtime.xcm.AssetLocation, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
