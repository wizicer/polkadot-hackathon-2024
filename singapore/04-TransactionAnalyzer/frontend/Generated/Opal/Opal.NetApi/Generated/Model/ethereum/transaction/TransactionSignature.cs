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


namespace Opal.NetApi.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> 343 - Composite[ethereum.transaction.TransactionSignature]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TransactionSignature : BaseType
    {
        
        /// <summary>
        /// >> v
        /// </summary>
        public Opal.NetApi.Generated.Model.ethereum.transaction.TransactionRecoveryId V { get; set; }
        /// <summary>
        /// >> r
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.H256 R { get; set; }
        /// <summary>
        /// >> s
        /// </summary>
        public Opal.NetApi.Generated.Model.primitive_types.H256 S { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TransactionSignature";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(V.Encode());
            result.AddRange(R.Encode());
            result.AddRange(S.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            V = new Opal.NetApi.Generated.Model.ethereum.transaction.TransactionRecoveryId();
            V.Decode(byteArray, ref p);
            R = new Opal.NetApi.Generated.Model.primitive_types.H256();
            R.Decode(byteArray, ref p);
            S = new Opal.NetApi.Generated.Model.primitive_types.H256();
            S.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
