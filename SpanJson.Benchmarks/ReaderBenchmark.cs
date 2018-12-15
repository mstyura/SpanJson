﻿using System;
using BenchmarkDotNet.Attributes;
using SpanJson.Shared.Fixture;

namespace SpanJson.Benchmarks
{  
  // Autogenerated
  // ReSharper disable BuiltInTypeReferenceStyle
  [MemoryDiagnoser]
  [DisassemblyDiagnoser]
  public class ReaderBenchmark
  {
    private static readonly ExpressionTreeFixture ExpressionTreeFixture = new ExpressionTreeFixture();  
  
    private static readonly SByte SByteInput = ExpressionTreeFixture.Create<SByte>();
    private static readonly byte[] SByteInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(SByteInput);
    private static readonly string SByteInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(SByteInput);
  
    private static readonly Int16 Int16Input = ExpressionTreeFixture.Create<Int16>();
    private static readonly byte[] Int16InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(Int16Input);
    private static readonly string Int16InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(Int16Input);
  
    private static readonly Int32 Int32Input = ExpressionTreeFixture.Create<Int32>();
    private static readonly byte[] Int32InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(Int32Input);
    private static readonly string Int32InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(Int32Input);
  
    private static readonly Int64 Int64Input = ExpressionTreeFixture.Create<Int64>();
    private static readonly byte[] Int64InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(Int64Input);
    private static readonly string Int64InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(Int64Input);
  
    private static readonly Byte ByteInput = ExpressionTreeFixture.Create<Byte>();
    private static readonly byte[] ByteInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(ByteInput);
    private static readonly string ByteInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(ByteInput);
  
    private static readonly UInt16 UInt16Input = ExpressionTreeFixture.Create<UInt16>();
    private static readonly byte[] UInt16InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(UInt16Input);
    private static readonly string UInt16InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(UInt16Input);
  
    private static readonly UInt32 UInt32Input = ExpressionTreeFixture.Create<UInt32>();
    private static readonly byte[] UInt32InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(UInt32Input);
    private static readonly string UInt32InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(UInt32Input);
  
    private static readonly UInt64 UInt64Input = ExpressionTreeFixture.Create<UInt64>();
    private static readonly byte[] UInt64InputUtf8 = JsonSerializer.Generic.Utf8.Serialize(UInt64Input);
    private static readonly string UInt64InputUtf16 = JsonSerializer.Generic.Utf16.Serialize(UInt64Input);
  
    private static readonly Single SingleInput = ExpressionTreeFixture.Create<Single>();
    private static readonly byte[] SingleInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(SingleInput);
    private static readonly string SingleInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(SingleInput);
  
    private static readonly Double DoubleInput = ExpressionTreeFixture.Create<Double>();
    private static readonly byte[] DoubleInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(DoubleInput);
    private static readonly string DoubleInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(DoubleInput);
  
    private static readonly Boolean BooleanInput = ExpressionTreeFixture.Create<Boolean>();
    private static readonly byte[] BooleanInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(BooleanInput);
    private static readonly string BooleanInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(BooleanInput);
  
    private static readonly Char CharInput = ExpressionTreeFixture.Create<Char>();
    private static readonly byte[] CharInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(CharInput);
    private static readonly string CharInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(CharInput);
  
    private static readonly DateTime DateTimeInput = ExpressionTreeFixture.Create<DateTime>();
    private static readonly byte[] DateTimeInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(DateTimeInput);
    private static readonly string DateTimeInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(DateTimeInput);
  
    private static readonly DateTimeOffset DateTimeOffsetInput = ExpressionTreeFixture.Create<DateTimeOffset>();
    private static readonly byte[] DateTimeOffsetInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(DateTimeOffsetInput);
    private static readonly string DateTimeOffsetInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(DateTimeOffsetInput);
  
    private static readonly TimeSpan TimeSpanInput = ExpressionTreeFixture.Create<TimeSpan>();
    private static readonly byte[] TimeSpanInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(TimeSpanInput);
    private static readonly string TimeSpanInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(TimeSpanInput);
  
    private static readonly Guid GuidInput = ExpressionTreeFixture.Create<Guid>();
    private static readonly byte[] GuidInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(GuidInput);
    private static readonly string GuidInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(GuidInput);
  
    private static readonly String StringInput = ExpressionTreeFixture.Create<String>();
    private static readonly byte[] StringInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(StringInput);
    private static readonly string StringInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(StringInput);
  
    private static readonly Decimal DecimalInput = ExpressionTreeFixture.Create<Decimal>();
    private static readonly byte[] DecimalInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(DecimalInput);
    private static readonly string DecimalInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(DecimalInput);
  
    private static readonly Version VersionInput = ExpressionTreeFixture.Create<Version>();
    private static readonly byte[] VersionInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(VersionInput);
    private static readonly string VersionInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(VersionInput);
  
    private static readonly Uri UriInput = ExpressionTreeFixture.Create<Uri>();
    private static readonly byte[] UriInputUtf8 = JsonSerializer.Generic.Utf8.Serialize(UriInput);
    private static readonly string UriInputUtf16 = JsonSerializer.Generic.Utf16.Serialize(UriInput);
  
    [Benchmark]
    public void ReadUtf8SByte()
    {
        var reader = new JsonReader<Byte>(SByteInputUtf8);
        reader.ReadUtf8SByte();
    }
  
    [Benchmark]
    public void ReadUtf16SByte()
    {
        var reader = new JsonReader<Char>(SByteInputUtf16);
        reader.ReadUtf16SByte();
    }
  
    [Benchmark]
    public void ReadUtf8Int16()
    {
        var reader = new JsonReader<Byte>(Int16InputUtf8);
        reader.ReadUtf8Int16();
    }
  
    [Benchmark]
    public void ReadUtf16Int16()
    {
        var reader = new JsonReader<Char>(Int16InputUtf16);
        reader.ReadUtf16Int16();
    }
  
    [Benchmark]
    public void ReadUtf8Int32()
    {
        var reader = new JsonReader<Byte>(Int32InputUtf8);
        reader.ReadUtf8Int32();
    }
  
    [Benchmark]
    public void ReadUtf16Int32()
    {
        var reader = new JsonReader<Char>(Int32InputUtf16);
        reader.ReadUtf16Int32();
    }
  
    [Benchmark]
    public void ReadUtf8Int64()
    {
        var reader = new JsonReader<Byte>(Int64InputUtf8);
        reader.ReadUtf8Int64();
    }
  
    [Benchmark]
    public void ReadUtf16Int64()
    {
        var reader = new JsonReader<Char>(Int64InputUtf16);
        reader.ReadUtf16Int64();
    }
  
    [Benchmark]
    public void ReadUtf8Byte()
    {
        var reader = new JsonReader<Byte>(ByteInputUtf8);
        reader.ReadUtf8Byte();
    }
  
    [Benchmark]
    public void ReadUtf16Byte()
    {
        var reader = new JsonReader<Char>(ByteInputUtf16);
        reader.ReadUtf16Byte();
    }
  
    [Benchmark]
    public void ReadUtf8UInt16()
    {
        var reader = new JsonReader<Byte>(UInt16InputUtf8);
        reader.ReadUtf8UInt16();
    }
  
    [Benchmark]
    public void ReadUtf16UInt16()
    {
        var reader = new JsonReader<Char>(UInt16InputUtf16);
        reader.ReadUtf16UInt16();
    }
  
    [Benchmark]
    public void ReadUtf8UInt32()
    {
        var reader = new JsonReader<Byte>(UInt32InputUtf8);
        reader.ReadUtf8UInt32();
    }
  
    [Benchmark]
    public void ReadUtf16UInt32()
    {
        var reader = new JsonReader<Char>(UInt32InputUtf16);
        reader.ReadUtf16UInt32();
    }
  
    [Benchmark]
    public void ReadUtf8UInt64()
    {
        var reader = new JsonReader<Byte>(UInt64InputUtf8);
        reader.ReadUtf8UInt64();
    }
  
    [Benchmark]
    public void ReadUtf16UInt64()
    {
        var reader = new JsonReader<Char>(UInt64InputUtf16);
        reader.ReadUtf16UInt64();
    }
  
    [Benchmark]
    public void ReadUtf8Single()
    {
        var reader = new JsonReader<Byte>(SingleInputUtf8);
        reader.ReadUtf8Single();
    }
  
    [Benchmark]
    public void ReadUtf16Single()
    {
        var reader = new JsonReader<Char>(SingleInputUtf16);
        reader.ReadUtf16Single();
    }
  
    [Benchmark]
    public void ReadUtf8Double()
    {
        var reader = new JsonReader<Byte>(DoubleInputUtf8);
        reader.ReadUtf8Double();
    }
  
    [Benchmark]
    public void ReadUtf16Double()
    {
        var reader = new JsonReader<Char>(DoubleInputUtf16);
        reader.ReadUtf16Double();
    }
  
    [Benchmark]
    public void ReadUtf8Boolean()
    {
        var reader = new JsonReader<Byte>(BooleanInputUtf8);
        reader.ReadUtf8Boolean();
    }
  
    [Benchmark]
    public void ReadUtf16Boolean()
    {
        var reader = new JsonReader<Char>(BooleanInputUtf16);
        reader.ReadUtf16Boolean();
    }
  
    [Benchmark]
    public void ReadUtf8Char()
    {
        var reader = new JsonReader<Byte>(CharInputUtf8);
        reader.ReadUtf8Char();
    }
  
    [Benchmark]
    public void ReadUtf16Char()
    {
        var reader = new JsonReader<Char>(CharInputUtf16);
        reader.ReadUtf16Char();
    }
  
    [Benchmark]
    public void ReadUtf8DateTime()
    {
        var reader = new JsonReader<Byte>(DateTimeInputUtf8);
        reader.ReadUtf8DateTime();
    }
  
    [Benchmark]
    public void ReadUtf16DateTime()
    {
        var reader = new JsonReader<Char>(DateTimeInputUtf16);
        reader.ReadUtf16DateTime();
    }
  
    [Benchmark]
    public void ReadUtf8DateTimeOffset()
    {
        var reader = new JsonReader<Byte>(DateTimeOffsetInputUtf8);
        reader.ReadUtf8DateTimeOffset();
    }
  
    [Benchmark]
    public void ReadUtf16DateTimeOffset()
    {
        var reader = new JsonReader<Char>(DateTimeOffsetInputUtf16);
        reader.ReadUtf16DateTimeOffset();
    }
  
    [Benchmark]
    public void ReadUtf8TimeSpan()
    {
        var reader = new JsonReader<Byte>(TimeSpanInputUtf8);
        reader.ReadUtf8TimeSpan();
    }
  
    [Benchmark]
    public void ReadUtf16TimeSpan()
    {
        var reader = new JsonReader<Char>(TimeSpanInputUtf16);
        reader.ReadUtf16TimeSpan();
    }
  
    [Benchmark]
    public void ReadUtf8Guid()
    {
        var reader = new JsonReader<Byte>(GuidInputUtf8);
        reader.ReadUtf8Guid();
    }
  
    [Benchmark]
    public void ReadUtf16Guid()
    {
        var reader = new JsonReader<Char>(GuidInputUtf16);
        reader.ReadUtf16Guid();
    }
  
    [Benchmark]
    public void ReadUtf8String()
    {
        var reader = new JsonReader<Byte>(StringInputUtf8);
        reader.ReadUtf8String();
    }
  
    [Benchmark]
    public void ReadUtf16String()
    {
        var reader = new JsonReader<Char>(StringInputUtf16);
        reader.ReadUtf16String();
    }
  
    [Benchmark]
    public void ReadUtf8Decimal()
    {
        var reader = new JsonReader<Byte>(DecimalInputUtf8);
        reader.ReadUtf8Decimal();
    }
  
    [Benchmark]
    public void ReadUtf16Decimal()
    {
        var reader = new JsonReader<Char>(DecimalInputUtf16);
        reader.ReadUtf16Decimal();
    }
  
    [Benchmark]
    public void ReadUtf8Version()
    {
        var reader = new JsonReader<Byte>(VersionInputUtf8);
        reader.ReadUtf8Version();
    }
  
    [Benchmark]
    public void ReadUtf16Version()
    {
        var reader = new JsonReader<Char>(VersionInputUtf16);
        reader.ReadUtf16Version();
    }
  
    [Benchmark]
    public void ReadUtf8Uri()
    {
        var reader = new JsonReader<Byte>(UriInputUtf8);
        reader.ReadUtf8Uri();
    }
  
    [Benchmark]
    public void ReadUtf16Uri()
    {
        var reader = new JsonReader<Char>(UriInputUtf16);
        reader.ReadUtf16Uri();
    }
 
  }
}