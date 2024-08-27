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


namespace Hydration.NetApi.Generated.Model.pallet_treasury
{
    
    
    /// <summary>
    /// >> 278 - Composite[pallet_treasury.Proposal]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Proposal : BaseType
    {
        
        /// <summary>
        /// >> proposer
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32 Proposer { get; set; }
        /// <summary>
        /// >> value
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Value { get; set; }
        /// <summary>
        /// >> beneficiary
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32 Beneficiary { get; set; }
        /// <summary>
        /// >> bond
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Bond { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Proposal";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Proposer.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Beneficiary.Encode());
            result.AddRange(Bond.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Proposer = new Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Proposer.Decode(byteArray, ref p);
            Value = new Substrate.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            Beneficiary = new Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Beneficiary.Decode(byteArray, ref p);
            Bond = new Substrate.NetApi.Model.Types.Primitive.U128();
            Bond.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
