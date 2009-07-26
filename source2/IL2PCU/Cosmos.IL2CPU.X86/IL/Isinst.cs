using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Isinst)]
	public class Isinst: ILOp
	{
		public Isinst(ILOpCode aOpCode):base(aOpCode)
		{
		}

    public override void Execute(uint aMethodUID) {
      throw new Exception("TODO:");
    }

    #region Old code
		// using System;
		// using System.Collections.Generic;
		// using System.IO;
		// using CPU = Indy.IL2CPU.Assembler;
		// using CPUx86 = Indy.IL2CPU.Assembler.X86;
		// using System.Reflection;
		// using Indy.IL2CPU.Assembler;
		// using Indy.IL2CPU.Compiler;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		//     [OpCode(OpCodeEnum.Isinst)]
		//     public class Isinst : Op {
		//         private string mTypeId;
		//         private string mThisLabel;
		//         private string mNextOpLabel;
		//         private int mCurrentILOffset;
		//         private bool mDebugMode;
		// 
		//         //public static void ScanOp(ILReader aReader,
		//         //                          MethodInformation aMethodInfo,
		//         //                          SortedList<string, object> aMethodData) {
		//         //    Type xType = aReader.OperandValueType;
		//         //    if (xType == null) {
		//         //        throw new Exception("Unable to determine Type!");
		//         //    }
		//         //    Engine.RegisterType(xType);
		//         //    Call.ScanOp(Engine.GetMethodBase(typeof(VTablesImpl),
		//         //                                     "IsInstance",
		//         //                                     "System.Int32",
		//         //                                     "System.Int32"));
		//         //    Newobj.ScanOp(typeof(InvalidCastException).GetConstructor(new Type[0]));
		//         //}
		// 
		//         public Isinst(ILReader aReader,
		//                       MethodInformation aMethodInfo)
		//             : base(aReader,
		//                    aMethodInfo) {
		//             Type xType = aReader.OperandValueType;
		//             if (xType == null) {
		//                 throw new Exception("Unable to determine Type!");
		//             }
		//             mTypeDef = xType;
		//             mThisLabel = GetInstructionLabel(aReader.Position);
		//             mNextOpLabel = GetInstructionLabel(aReader.NextPosition);
		//             mCurrentILOffset = (int)aReader.Position;
		//             mDebugMode = aMethodInfo.DebugMode;
		//         }
		//         private Type mTypeDef;
		//         public override void DoAssemble() {
		//             mTypeId = GetService<IMetaDataInfoService>().GetTypeIdLabel(mTypeDef);
		//             string mReturnNullLabel = mThisLabel + "_ReturnNull";
		//             new CPUx86.Move { DestinationReg = CPUx86.Registers.EAX, SourceReg = CPUx86.Registers.ESP, SourceIsIndirect = true };
		//             new CPUx86.Compare { DestinationReg = CPUx86.Registers.EAX, SourceValue = 0 };
		//             new CPUx86.ConditionalJump { Condition = CPUx86.ConditionalTestEnum.Zero, DestinationLabel = mReturnNullLabel };
		//             new CPUx86.Push { DestinationReg = CPUx86.Registers.EAX, DestinationIsIndirect = true };
		//             new CPUx86.Push { DestinationRef = ElementReference.New(mTypeId), DestinationIsIndirect=true };
		//             Assembler.StackContents.Push(new StackContent(4,
		//                                                           typeof(object)));
		//             Assembler.StackContents.Push(new StackContent(4,
		//                                                           typeof(object)));
		//             MethodBase xMethodIsInstance = ReflectionUtilities.GetMethodBase(typeof(VTablesImpl),
		//                                                                 "IsInstance",
		//                                                                 "System.Int32",
		//                                                                 "System.Int32");
		//             Op xOp = new Call(xMethodIsInstance,
		//                               (uint)mCurrentILOffset,
		//                               mDebugMode,
		//                               mThisLabel+ "_After_IsInstance_Call");
		//             xOp.Assembler = Assembler;
		//             xOp.SetServiceProvider(GetServiceProvider());
		//             xOp.Assemble();
		//             new Label(mThisLabel + "_After_IsInstance_Call");
		//             Assembler.StackContents.Pop();
		//             new CPUx86.Pop { DestinationReg = CPUx86.Registers.EAX };
		//             new CPUx86.Compare { DestinationReg = CPUx86.Registers.EAX, SourceValue = 0 };
		//             new CPUx86.ConditionalJump { Condition = CPUx86.ConditionalTestEnum.NotEqual, DestinationLabel = mNextOpLabel };
		//             new CPU.Label(mReturnNullLabel);
		//             new CPUx86.Add { DestinationReg = CPUx86.Registers.ESP, SourceValue = 4 };
		//             new CPUx86.Push { DestinationValue = 0 };
		//         }
		//     }
		// }
		#endregion Old code
	}
}
