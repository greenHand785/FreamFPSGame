﻿// Classes and structures being serialized

// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.
using System;
using System.Collections.Generic;

namespace Mine.Nullables
{
    /// <summary>
    /// <para>This class is documented here:</para>
    /// <para>With multiple lines</para>
    /// </summary>
    public partial class MyMessageV1
    {
        /// <summary>This field is important to comment as we just did here</summary>
        public int FieldA { get; set; }

        /// <summary>Values for unknown fields.</summary>
        public List<global::SilentOrbit.ProtocolBuffers.KeyValue> PreservedFields;

    }

}
namespace Yours.Nullables
{
    public partial class MyMessageV2
    {
        public MyMessageV2()
        {
            FieldA = -1;
            FieldB = 4.5;
            FieldC = 5.4f;
            FieldD = -2;
            FieldE = -3;
            FieldF = 4;
            FieldG = 5;
            FieldH = -6;
            FieldI = -7;
            FieldJ = 8;
            FieldK = 9;
            FieldL = -10;
            FieldM = -11;
            FieldN = false;
            FieldO = "test";
            FieldR = Yours.Nullables.MyMessageV2.MyEnum.ETest2;
        }
        public enum MyEnum
        {
            /// <summary>First test</summary>
            ETest1 = 0,
            /// <summary>Second test</summary>
            ETest2 = 3,
            ETest3 = 2,
        }

        public enum AliasedEnum
        {
            Nothing = 0,
            Zero = 0,
            Nada = 0,
            Some = 1,
            ALot = 2,
        }

        public int FieldA { get; set; }

        public double FieldB { get; set; }

        public float FieldC { get; set; }

        public int FieldD { get; set; }

        public long FieldE { get; set; }

        public uint FieldF { get; set; }

        public ulong FieldG { get; set; }

        public int FieldH { get; set; }

        public long FieldI { get; set; }

        public uint FieldJ { get; set; }

        public ulong FieldK { get; set; }

        public int FieldL { get; set; }

        public long FieldM { get; set; }

        public bool FieldN { get; set; }

        public string FieldO { get; set; }

        public byte[] FieldP { get; set; }

        public Yours.Nullables.MyMessageV2.MyEnum FieldQ { get; set; }

        public Yours.Nullables.MyMessageV2.MyEnum? FieldR { get; set; }

        [Obsolete]
        protected string Dummy { get; set; }

        public List<uint> FieldT { get; set; }

        public List<uint> FieldS { get; set; }

        public Theirs.Nullables.TheirMessage FieldU { get; set; }

        public List<Theirs.Nullables.TheirMessage> FieldV { get; set; }

        public int? NullableInt { get; set; }

        public Yours.Nullables.MyMessageV2.AliasedEnum? NullableEnum { get; set; }

    }

}
namespace Theirs.Nullables
{
    public partial class TheirMessage
    {
        public int FieldA { get; set; }

    }

}
namespace Proto.Test.Nullables
{
    /// <summary>Message without any low id(< 16) fields</summary>
    public partial class LongMessage
    {
        public int FieldX1 { get; set; }

        public int FieldX2 { get; set; }

        public int FieldX3 { get; set; }

        public int FieldX4 { get; set; }

    }

    /// <summary>Nested testing</summary>
    public partial class Data
    {
        public double? Somefield { get; set; }

    }

    public partial class Container
    {
        public Proto.Test.Nullables.Container.Nested MyNestedMessage { get; set; }

        /// <summary>Name collision test</summary>
        public Proto.Test.Nullables.Container.Nested NestedField { get; set; }

        public partial class Nested
        {
            public Proto.Test.Nullables.Data NestedData { get; set; }

        }

    }

    public partial class MyMessage
    {
        public int? Foo { get; set; }

        public string Bar { get; set; }

    }

    public enum MyEnum
    {
        FOO = 1,
        BAR = 2,
    }


}
