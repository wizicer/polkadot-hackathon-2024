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


namespace Bajun.NetApi.Generated.Model.staging_xcm_executor.traits.asset_transfer
{
    
    
    /// <summary>
    /// >> TransferType
    /// </summary>
    public enum TransferType
    {
        
        /// <summary>
        /// >> Teleport
        /// </summary>
        Teleport = 0,
        
        /// <summary>
        /// >> LocalReserve
        /// </summary>
        LocalReserve = 1,
        
        /// <summary>
        /// >> DestinationReserve
        /// </summary>
        DestinationReserve = 2,
        
        /// <summary>
        /// >> RemoteReserve
        /// </summary>
        RemoteReserve = 3,
    }
    
    /// <summary>
    /// >> 386 - Variant[staging_xcm_executor.traits.asset_transfer.TransferType]
    /// </summary>
    public sealed class EnumTransferType : BaseEnumExt<TransferType, BaseVoid, BaseVoid, BaseVoid, Bajun.NetApi.Generated.Model.xcm.EnumVersionedLocation>
    {
    }
}
