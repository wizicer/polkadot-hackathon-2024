//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 427 - Composite[pallet_nfts.types.ItemDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 Owner { get; set; }
        /// <summary>
        /// >> approvals
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMap Approvals { get; set; }
        /// <summary>
        /// >> deposit
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.ItemDeposit Deposit { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ItemDetails";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Approvals.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Approvals = new PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMap();
            Approvals.Decode(byteArray, ref p);
            Deposit = new PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.ItemDeposit();
            Deposit.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
