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


namespace Bifrost.NetApi.Generated.Model.bifrost_vstoken_conversion.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotEnoughBalance
        /// </summary>
        NotEnoughBalance = 0,
        
        /// <summary>
        /// >> NotSupportTokenType
        /// </summary>
        NotSupportTokenType = 1,
        
        /// <summary>
        /// >> CalculationOverflow
        /// </summary>
        CalculationOverflow = 2,
    }
    
    /// <summary>
    /// >> 803 - Variant[bifrost_vstoken_conversion.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
