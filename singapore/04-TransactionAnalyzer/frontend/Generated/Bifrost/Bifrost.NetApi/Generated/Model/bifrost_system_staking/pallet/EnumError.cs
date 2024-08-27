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


namespace Bifrost.NetApi.Generated.Model.bifrost_system_staking.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InvalidTokenConfig
        /// Invalid token config params
        /// </summary>
        InvalidTokenConfig = 0,
        
        /// <summary>
        /// >> ExceedMaxTokenLen
        /// exceed max token len
        /// </summary>
        ExceedMaxTokenLen = 1,
        
        /// <summary>
        /// >> ExceedMaxFarmingPoolidLen
        /// exceed max poolid len
        /// </summary>
        ExceedMaxFarmingPoolidLen = 2,
        
        /// <summary>
        /// >> TokenInfoNotFound
        /// Token info not found
        /// </summary>
        TokenInfoNotFound = 3,
        
        /// <summary>
        /// >> PayoutFailed
        /// payout error
        /// </summary>
        PayoutFailed = 4,
    }
    
    /// <summary>
    /// >> 825 - Variant[bifrost_system_staking.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
