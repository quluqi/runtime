// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Abs.Vector64.Byte"] = Abs_Vector64_Byte,
                ["Abs.Vector64.UInt16"] = Abs_Vector64_UInt16,
                ["Abs.Vector64.UInt32"] = Abs_Vector64_UInt32,
                ["Abs.Vector64.Single"] = Abs_Vector64_Single,
                ["Abs.Vector128.Byte"] = Abs_Vector128_Byte,
                ["Abs.Vector128.Single"] = Abs_Vector128_Single,
                ["Abs.Vector128.UInt16"] = Abs_Vector128_UInt16,
                ["Abs.Vector128.UInt32"] = Abs_Vector128_UInt32,
                ["AbsoluteCompareGreaterThan.Vector64.Single"] = AbsoluteCompareGreaterThan_Vector64_Single,
                ["AbsoluteCompareGreaterThanOrEqual.Vector64.Single"] = AbsoluteCompareGreaterThanOrEqual_Vector64_Single,
                ["AbsoluteCompareLessThan.Vector64.Single"] = AbsoluteCompareLessThan_Vector64_Single,
                ["AbsoluteCompareLessThanOrEqual.Vector64.Single"] = AbsoluteCompareLessThanOrEqual_Vector64_Single,
                ["AbsoluteCompareGreaterThan.Vector128.Single"] = AbsoluteCompareGreaterThan_Vector128_Single,
                ["AbsoluteCompareGreaterThanOrEqual.Vector128.Single"] = AbsoluteCompareGreaterThanOrEqual_Vector128_Single,
                ["AbsoluteCompareLessThan.Vector128.Single"] = AbsoluteCompareLessThan_Vector128_Single,
                ["AbsoluteCompareLessThanOrEqual.Vector128.Single"] = AbsoluteCompareLessThanOrEqual_Vector128_Single,
                ["AbsScalar.Vector64.Single"] = AbsScalar_Vector64_Single,
                ["Add.Vector64.Byte"] = Add_Vector64_Byte,
                ["Add.Vector64.Int16"] = Add_Vector64_Int16,
                ["Add.Vector64.Int32"] = Add_Vector64_Int32,
                ["Add.Vector64.SByte"] = Add_Vector64_SByte,
                ["Add.Vector64.Single"] = Add_Vector64_Single,
                ["Add.Vector64.UInt16"] = Add_Vector64_UInt16,
                ["Add.Vector64.UInt32"] = Add_Vector64_UInt32,
                ["Add.Vector128.Byte"] = Add_Vector128_Byte,
                ["Add.Vector128.Int16"] = Add_Vector128_Int16,
                ["Add.Vector128.Int32"] = Add_Vector128_Int32,
                ["Add.Vector128.Int64"] = Add_Vector128_Int64,
                ["Add.Vector128.SByte"] = Add_Vector128_SByte,
                ["Add.Vector128.Single"] = Add_Vector128_Single,
                ["Add.Vector128.UInt16"] = Add_Vector128_UInt16,
                ["Add.Vector128.UInt32"] = Add_Vector128_UInt32,
                ["Add.Vector128.UInt64"] = Add_Vector128_UInt64,
                ["AddScalar.Vector64.Single"] = AddScalar_Vector64_Single,
                ["BitwiseSelect.Vector64.Byte"] = BitwiseSelect_Vector64_Byte,
                ["BitwiseSelect.Vector64.Int16"] = BitwiseSelect_Vector64_Int16,
                ["BitwiseSelect.Vector64.Int32"] = BitwiseSelect_Vector64_Int32,
                ["BitwiseSelect.Vector64.SByte"] = BitwiseSelect_Vector64_SByte,
                ["BitwiseSelect.Vector64.Single"] = BitwiseSelect_Vector64_Single,
                ["BitwiseSelect.Vector64.UInt16"] = BitwiseSelect_Vector64_UInt16,
                ["BitwiseSelect.Vector64.UInt32"] = BitwiseSelect_Vector64_UInt32,
                ["BitwiseSelect.Vector128.Byte"] = BitwiseSelect_Vector128_Byte,
                ["BitwiseSelect.Vector128.Double"] = BitwiseSelect_Vector128_Double,
                ["BitwiseSelect.Vector128.Int16"] = BitwiseSelect_Vector128_Int16,
                ["BitwiseSelect.Vector128.Int32"] = BitwiseSelect_Vector128_Int32,
                ["BitwiseSelect.Vector128.Int64"] = BitwiseSelect_Vector128_Int64,
                ["BitwiseSelect.Vector128.SByte"] = BitwiseSelect_Vector128_SByte,
                ["BitwiseSelect.Vector128.Single"] = BitwiseSelect_Vector128_Single,
                ["BitwiseSelect.Vector128.UInt16"] = BitwiseSelect_Vector128_UInt16,
                ["BitwiseSelect.Vector128.UInt32"] = BitwiseSelect_Vector128_UInt32,
                ["BitwiseSelect.Vector128.UInt64"] = BitwiseSelect_Vector128_UInt64,
                ["CompareEqual.Vector64.Byte"] = CompareEqual_Vector64_Byte,
                ["CompareEqual.Vector64.Int16"] = CompareEqual_Vector64_Int16,
                ["CompareEqual.Vector64.Int32"] = CompareEqual_Vector64_Int32,
                ["CompareEqual.Vector64.SByte"] = CompareEqual_Vector64_SByte,
                ["CompareEqual.Vector64.Single"] = CompareEqual_Vector64_Single,
                ["CompareEqual.Vector64.UInt16"] = CompareEqual_Vector64_UInt16,
                ["CompareEqual.Vector64.UInt32"] = CompareEqual_Vector64_UInt32,
                ["CompareEqual.Vector128.Byte"] = CompareEqual_Vector128_Byte,
                ["CompareEqual.Vector128.Int16"] = CompareEqual_Vector128_Int16,
                ["CompareEqual.Vector128.Int32"] = CompareEqual_Vector128_Int32,
                ["CompareEqual.Vector128.SByte"] = CompareEqual_Vector128_SByte,
                ["CompareEqual.Vector128.Single"] = CompareEqual_Vector128_Single,
                ["CompareEqual.Vector128.UInt16"] = CompareEqual_Vector128_UInt16,
                ["CompareEqual.Vector128.UInt32"] = CompareEqual_Vector128_UInt32,
                ["CompareGreaterThan.Vector64.Byte"] = CompareGreaterThan_Vector64_Byte,
                ["CompareGreaterThan.Vector64.Int16"] = CompareGreaterThan_Vector64_Int16,
                ["CompareGreaterThan.Vector64.Int32"] = CompareGreaterThan_Vector64_Int32,
                ["CompareGreaterThan.Vector64.SByte"] = CompareGreaterThan_Vector64_SByte,
                ["CompareGreaterThan.Vector64.Single"] = CompareGreaterThan_Vector64_Single,
                ["CompareGreaterThan.Vector64.UInt16"] = CompareGreaterThan_Vector64_UInt16,
                ["CompareGreaterThan.Vector64.UInt32"] = CompareGreaterThan_Vector64_UInt32,
                ["CompareGreaterThan.Vector128.Byte"] = CompareGreaterThan_Vector128_Byte,
                ["CompareGreaterThan.Vector128.Int16"] = CompareGreaterThan_Vector128_Int16,
                ["CompareGreaterThan.Vector128.Int32"] = CompareGreaterThan_Vector128_Int32,
                ["CompareGreaterThan.Vector128.SByte"] = CompareGreaterThan_Vector128_SByte,
                ["CompareGreaterThan.Vector128.Single"] = CompareGreaterThan_Vector128_Single,
                ["CompareGreaterThan.Vector128.UInt16"] = CompareGreaterThan_Vector128_UInt16,
                ["CompareGreaterThan.Vector128.UInt32"] = CompareGreaterThan_Vector128_UInt32,
                ["CompareGreaterThanOrEqual.Vector64.Byte"] = CompareGreaterThanOrEqual_Vector64_Byte,
                ["CompareGreaterThanOrEqual.Vector64.Int16"] = CompareGreaterThanOrEqual_Vector64_Int16,
                ["CompareGreaterThanOrEqual.Vector64.Int32"] = CompareGreaterThanOrEqual_Vector64_Int32,
                ["CompareGreaterThanOrEqual.Vector64.SByte"] = CompareGreaterThanOrEqual_Vector64_SByte,
                ["CompareGreaterThanOrEqual.Vector64.Single"] = CompareGreaterThanOrEqual_Vector64_Single,
                ["CompareGreaterThanOrEqual.Vector64.UInt16"] = CompareGreaterThanOrEqual_Vector64_UInt16,
                ["CompareGreaterThanOrEqual.Vector64.UInt32"] = CompareGreaterThanOrEqual_Vector64_UInt32,
                ["CompareGreaterThanOrEqual.Vector128.Byte"] = CompareGreaterThanOrEqual_Vector128_Byte,
                ["CompareGreaterThanOrEqual.Vector128.Int16"] = CompareGreaterThanOrEqual_Vector128_Int16,
                ["CompareGreaterThanOrEqual.Vector128.Int32"] = CompareGreaterThanOrEqual_Vector128_Int32,
                ["CompareGreaterThanOrEqual.Vector128.SByte"] = CompareGreaterThanOrEqual_Vector128_SByte,
                ["CompareGreaterThanOrEqual.Vector128.Single"] = CompareGreaterThanOrEqual_Vector128_Single,
                ["CompareGreaterThanOrEqual.Vector128.UInt16"] = CompareGreaterThanOrEqual_Vector128_UInt16,
                ["CompareGreaterThanOrEqual.Vector128.UInt32"] = CompareGreaterThanOrEqual_Vector128_UInt32,
                ["CompareLessThan.Vector64.Byte"] = CompareLessThan_Vector64_Byte,
                ["CompareLessThan.Vector64.Int16"] = CompareLessThan_Vector64_Int16,
                ["CompareLessThan.Vector64.Int32"] = CompareLessThan_Vector64_Int32,
                ["CompareLessThan.Vector64.SByte"] = CompareLessThan_Vector64_SByte,
                ["CompareLessThan.Vector64.Single"] = CompareLessThan_Vector64_Single,
                ["CompareLessThan.Vector64.UInt16"] = CompareLessThan_Vector64_UInt16,
                ["CompareLessThan.Vector64.UInt32"] = CompareLessThan_Vector64_UInt32,
                ["CompareLessThan.Vector128.Byte"] = CompareLessThan_Vector128_Byte,
                ["CompareLessThan.Vector128.Int16"] = CompareLessThan_Vector128_Int16,
                ["CompareLessThan.Vector128.Int32"] = CompareLessThan_Vector128_Int32,
                ["CompareLessThan.Vector128.SByte"] = CompareLessThan_Vector128_SByte,
                ["CompareLessThan.Vector128.Single"] = CompareLessThan_Vector128_Single,
                ["CompareLessThan.Vector128.UInt16"] = CompareLessThan_Vector128_UInt16,
                ["CompareLessThan.Vector128.UInt32"] = CompareLessThan_Vector128_UInt32,
                ["CompareLessThanOrEqual.Vector64.Byte"] = CompareLessThanOrEqual_Vector64_Byte,
                ["CompareLessThanOrEqual.Vector64.Int16"] = CompareLessThanOrEqual_Vector64_Int16,
                ["CompareLessThanOrEqual.Vector64.Int32"] = CompareLessThanOrEqual_Vector64_Int32,
                ["CompareLessThanOrEqual.Vector64.SByte"] = CompareLessThanOrEqual_Vector64_SByte,
                ["CompareLessThanOrEqual.Vector64.Single"] = CompareLessThanOrEqual_Vector64_Single,
                ["CompareLessThanOrEqual.Vector64.UInt16"] = CompareLessThanOrEqual_Vector64_UInt16,
                ["CompareLessThanOrEqual.Vector64.UInt32"] = CompareLessThanOrEqual_Vector64_UInt32,
                ["CompareLessThanOrEqual.Vector128.Byte"] = CompareLessThanOrEqual_Vector128_Byte,
                ["CompareLessThanOrEqual.Vector128.Int16"] = CompareLessThanOrEqual_Vector128_Int16,
                ["CompareLessThanOrEqual.Vector128.Int32"] = CompareLessThanOrEqual_Vector128_Int32,
                ["CompareLessThanOrEqual.Vector128.SByte"] = CompareLessThanOrEqual_Vector128_SByte,
                ["CompareLessThanOrEqual.Vector128.Single"] = CompareLessThanOrEqual_Vector128_Single,
                ["CompareLessThanOrEqual.Vector128.UInt16"] = CompareLessThanOrEqual_Vector128_UInt16,
                ["CompareLessThanOrEqual.Vector128.UInt32"] = CompareLessThanOrEqual_Vector128_UInt32,
                ["CompareTest.Vector64.Byte"] = CompareTest_Vector64_Byte,
                ["CompareTest.Vector64.Int16"] = CompareTest_Vector64_Int16,
                ["CompareTest.Vector64.Int32"] = CompareTest_Vector64_Int32,
                ["CompareTest.Vector64.SByte"] = CompareTest_Vector64_SByte,
                ["CompareTest.Vector64.Single"] = CompareTest_Vector64_Single,
                ["CompareTest.Vector64.UInt16"] = CompareTest_Vector64_UInt16,
                ["CompareTest.Vector64.UInt32"] = CompareTest_Vector64_UInt32,
                ["CompareTest.Vector128.Byte"] = CompareTest_Vector128_Byte,
                ["CompareTest.Vector128.Int16"] = CompareTest_Vector128_Int16,
                ["CompareTest.Vector128.Int32"] = CompareTest_Vector128_Int32,
                ["CompareTest.Vector128.SByte"] = CompareTest_Vector128_SByte,
                ["CompareTest.Vector128.Single"] = CompareTest_Vector128_Single,
                ["CompareTest.Vector128.UInt16"] = CompareTest_Vector128_UInt16,
                ["CompareTest.Vector128.UInt32"] = CompareTest_Vector128_UInt32,
                ["LeadingSignCount.Vector64.Int16"] = LeadingSignCount_Vector64_Int16,
                ["LeadingSignCount.Vector64.Int32"] = LeadingSignCount_Vector64_Int32,
                ["LeadingSignCount.Vector64.SByte"] = LeadingSignCount_Vector64_SByte,
                ["LeadingSignCount.Vector128.Int16"] = LeadingSignCount_Vector128_Int16,
                ["LeadingSignCount.Vector128.Int32"] = LeadingSignCount_Vector128_Int32,
                ["LeadingSignCount.Vector128.SByte"] = LeadingSignCount_Vector128_SByte,
                ["LeadingZeroCount.Vector64.Byte"] = LeadingZeroCount_Vector64_Byte,
                ["LeadingZeroCount.Vector64.Int16"] = LeadingZeroCount_Vector64_Int16,
                ["LeadingZeroCount.Vector64.Int32"] = LeadingZeroCount_Vector64_Int32,
                ["LeadingZeroCount.Vector64.SByte"] = LeadingZeroCount_Vector64_SByte,
                ["LeadingZeroCount.Vector64.UInt16"] = LeadingZeroCount_Vector64_UInt16,
                ["LeadingZeroCount.Vector64.UInt32"] = LeadingZeroCount_Vector64_UInt32,
                ["LeadingZeroCount.Vector128.Byte"] = LeadingZeroCount_Vector128_Byte,
                ["LeadingZeroCount.Vector128.Int16"] = LeadingZeroCount_Vector128_Int16,
                ["LeadingZeroCount.Vector128.Int32"] = LeadingZeroCount_Vector128_Int32,
                ["LeadingZeroCount.Vector128.SByte"] = LeadingZeroCount_Vector128_SByte,
                ["LeadingZeroCount.Vector128.UInt16"] = LeadingZeroCount_Vector128_UInt16,
                ["LeadingZeroCount.Vector128.UInt32"] = LeadingZeroCount_Vector128_UInt32,
                ["LoadVector64.Byte"] = LoadVector64_Byte,
                ["LoadVector64.Int16"] = LoadVector64_Int16,
                ["LoadVector64.Int32"] = LoadVector64_Int32,
                ["LoadVector64.SByte"] = LoadVector64_SByte,
                ["LoadVector64.Single"] = LoadVector64_Single,
                ["LoadVector64.UInt16"] = LoadVector64_UInt16,
                ["LoadVector64.UInt32"] = LoadVector64_UInt32,
                ["LoadVector128.Byte"] = LoadVector128_Byte,
                ["LoadVector128.Double"] = LoadVector128_Double,
                ["LoadVector128.Int16"] = LoadVector128_Int16,
                ["LoadVector128.Int32"] = LoadVector128_Int32,
                ["LoadVector128.Int64"] = LoadVector128_Int64,
                ["LoadVector128.SByte"] = LoadVector128_SByte,
                ["LoadVector128.Single"] = LoadVector128_Single,
                ["LoadVector128.UInt16"] = LoadVector128_UInt16,
                ["LoadVector128.UInt32"] = LoadVector128_UInt32,
                ["LoadVector128.UInt64"] = LoadVector128_UInt64,
                ["PopCount.Vector64.Byte"] = PopCount_Vector64_Byte,
                ["PopCount.Vector64.SByte"] = PopCount_Vector64_SByte,
                ["PopCount.Vector128.Byte"] = PopCount_Vector128_Byte,
                ["PopCount.Vector128.SByte"] = PopCount_Vector128_SByte,
            };
        }
    }
}
