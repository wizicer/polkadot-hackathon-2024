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


namespace Polkadot.NetApi.Generated.Model.pallet_offences.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// Events type.
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Offence
        /// There is an offence reported of the given `kind` happened at the `session_index` and
        /// (kind-specific) time slot. This event is not deposited for duplicate slashes.
        /// \[kind, timeslot\].
        /// </summary>
        Offence = 0,
    }
    
    /// <summary>
    /// >> 47 - Variant[pallet_offences.pallet.Event]
    /// Events type.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Polkadot.NetApi.Generated.Types.Base.Arr16U8, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>
    {
    }
}
