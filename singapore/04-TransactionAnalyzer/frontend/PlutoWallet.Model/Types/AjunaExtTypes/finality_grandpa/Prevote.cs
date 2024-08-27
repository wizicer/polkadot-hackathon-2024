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


namespace Substrate.NetApi.Generated.Model.finality_grandpa
{
    
    
    /// <summary>
    /// >> 220 - Composite[finality_grandpa.Prevote]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Prevote : BaseType
    {
        
        /// <summary>
        /// >> target_hash
        /// </summary>
        private Substrate.NetApi.Generated.Model.primitive_types.H256 _targetHash;
        
        /// <summary>
        /// >> target_number
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _targetNumber;
        
        public Substrate.NetApi.Generated.Model.primitive_types.H256 TargetHash
        {
            get
            {
                return this._targetHash;
            }
            set
            {
                this._targetHash = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 TargetNumber
        {
            get
            {
                return this._targetNumber;
            }
            set
            {
                this._targetNumber = value;
            }
        }
        
        public override string TypeName()
        {
            return "Prevote";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TargetHash.Encode());
            result.AddRange(TargetNumber.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TargetHash = new Substrate.NetApi.Generated.Model.primitive_types.H256();
            TargetHash.Decode(byteArray, ref p);
            TargetNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            TargetNumber.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
