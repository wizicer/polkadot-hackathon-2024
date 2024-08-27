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


namespace Substrate.NetApi.Generated.Model.pallet_lbp
{
    
    /// <summary>
    /// >> 98 - Composite[pallet_lbp.Pool]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Pool : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _start;
        
        /// <summary>
        /// >> end
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _end;
        
        /// <summary>
        /// >> assets
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> _assets;
        
        /// <summary>
        /// >> initial_weight
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _initialWeight;
        
        /// <summary>
        /// >> final_weight
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _finalWeight;
        
        /// <summary>
        /// >> weight_curve
        /// </summary>
        private Substrate.NetApi.Generated.Model.pallet_lbp.EnumWeightCurveType _weightCurve;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> _fee;
        
        /// <summary>
        /// >> fee_collector
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 _feeCollector;
        
        /// <summary>
        /// >> repay_target
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _repayTarget;
        
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
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> Assets
        {
            get
            {
                return this._assets;
            }
            set
            {
                this._assets = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 InitialWeight
        {
            get
            {
                return this._initialWeight;
            }
            set
            {
                this._initialWeight = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 FinalWeight
        {
            get
            {
                return this._finalWeight;
            }
            set
            {
                this._finalWeight = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.pallet_lbp.EnumWeightCurveType WeightCurve
        {
            get
            {
                return this._weightCurve;
            }
            set
            {
                this._weightCurve = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32> Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 FeeCollector
        {
            get
            {
                return this._feeCollector;
            }
            set
            {
                this._feeCollector = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 RepayTarget
        {
            get
            {
                return this._repayTarget;
            }
            set
            {
                this._repayTarget = value;
            }
        }
        
        public override string TypeName()
        {
            return "Pool";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(End.Encode());
            result.AddRange(Assets.Encode());
            result.AddRange(InitialWeight.Encode());
            result.AddRange(FinalWeight.Encode());
            result.AddRange(WeightCurve.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(FeeCollector.Encode());
            result.AddRange(RepayTarget.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            Start.Decode(byteArray, ref p);
            End = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            End.Decode(byteArray, ref p);
            Assets = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>();
            Assets.Decode(byteArray, ref p);
            InitialWeight = new Substrate.NetApi.Model.Types.Primitive.U32();
            InitialWeight.Decode(byteArray, ref p);
            FinalWeight = new Substrate.NetApi.Model.Types.Primitive.U32();
            FinalWeight.Decode(byteArray, ref p);
            WeightCurve = new Substrate.NetApi.Generated.Model.pallet_lbp.EnumWeightCurveType();
            WeightCurve.Decode(byteArray, ref p);
            Fee = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>();
            Fee.Decode(byteArray, ref p);
            FeeCollector = new Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            FeeCollector.Decode(byteArray, ref p);
            RepayTarget = new Substrate.NetApi.Model.Types.Primitive.U128();
            RepayTarget.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
