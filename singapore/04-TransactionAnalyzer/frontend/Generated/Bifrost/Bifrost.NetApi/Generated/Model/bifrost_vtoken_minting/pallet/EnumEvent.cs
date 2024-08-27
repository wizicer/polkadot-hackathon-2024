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


namespace Bifrost.NetApi.Generated.Model.bifrost_vtoken_minting.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Minted
        /// </summary>
        Minted = 0,
        
        /// <summary>
        /// >> Redeemed
        /// </summary>
        Redeemed = 1,
        
        /// <summary>
        /// >> RedeemSuccess
        /// </summary>
        RedeemSuccess = 2,
        
        /// <summary>
        /// >> Rebonded
        /// </summary>
        Rebonded = 3,
        
        /// <summary>
        /// >> RebondedByUnlockId
        /// </summary>
        RebondedByUnlockId = 4,
        
        /// <summary>
        /// >> UnlockDurationSet
        /// </summary>
        UnlockDurationSet = 5,
        
        /// <summary>
        /// >> MinimumMintSet
        /// </summary>
        MinimumMintSet = 6,
        
        /// <summary>
        /// >> MinimumRedeemSet
        /// </summary>
        MinimumRedeemSet = 7,
        
        /// <summary>
        /// >> SupportRebondTokenAdded
        /// </summary>
        SupportRebondTokenAdded = 8,
        
        /// <summary>
        /// >> SupportRebondTokenRemoved
        /// </summary>
        SupportRebondTokenRemoved = 9,
        
        /// <summary>
        /// >> FeeSet
        /// Several fees has been set.
        /// </summary>
        FeeSet = 10,
        
        /// <summary>
        /// >> HookIterationLimitSet
        /// </summary>
        HookIterationLimitSet = 11,
        
        /// <summary>
        /// >> UnlockingTotalSet
        /// </summary>
        UnlockingTotalSet = 12,
        
        /// <summary>
        /// >> MinTimeUnitSet
        /// </summary>
        MinTimeUnitSet = 13,
        
        /// <summary>
        /// >> FastRedeemFailed
        /// </summary>
        FastRedeemFailed = 14,
        
        /// <summary>
        /// >> CurrencyTimeUnitRecreated
        /// </summary>
        CurrencyTimeUnitRecreated = 15,
        
        /// <summary>
        /// >> IncentivizedMinting
        /// </summary>
        IncentivizedMinting = 16,
        
        /// <summary>
        /// >> VtokenIncentiveCoefSet
        /// </summary>
        VtokenIncentiveCoefSet = 17,
        
        /// <summary>
        /// >> VtokenIncentiveLockBlocksSet
        /// </summary>
        VtokenIncentiveLockBlocksSet = 18,
    }
    
    /// <summary>
    /// >> 466 - Variant[bifrost_vtoken_minting.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_vtoken_minting.traits.EnumRedeemTo, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, Bifrost.NetApi.Generated.Model.sp_runtime.EnumDispatchError, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>
    {
    }
}
