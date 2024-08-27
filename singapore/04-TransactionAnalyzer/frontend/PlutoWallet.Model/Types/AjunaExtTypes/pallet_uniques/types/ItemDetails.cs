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


namespace Substrate.NetApi.Generated.Model.pallet_uniques.types
{
    
    
    /// <summary>
    /// >> 341 - Composite[pallet_uniques.types.ItemDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> approved
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32> _approved;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _isFrozen;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32> Approved
        {
            get
            {
                return this._approved;
            }
            set
            {
                this._approved = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool IsFrozen
        {
            get
            {
                return this._isFrozen;
            }
            set
            {
                this._isFrozen = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "ItemDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Approved.Encode());
            result.AddRange(IsFrozen.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Approved = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
            Approved.Decode(byteArray, ref p);
            IsFrozen = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
