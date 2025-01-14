﻿using System;

namespace BinaryDataSerialization.Test.Endianness
{
    public class EndiannessConverter : IValueConverter
    {
        public const uint LittleEndiannessMagic = 0x1A2B3C4D;
        public const uint BigEndiannessMagic = 0x4D3C2B1A;

        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            if (value == null)
                return BinaryDataSerialization.Endianness.Little;

            var indicator = System.Convert.ToUInt32(value);

            if (indicator == LittleEndiannessMagic)
                return BinaryDataSerialization.Endianness.Little;

            if (indicator == BigEndiannessMagic)
                return BinaryDataSerialization.Endianness.Big;

            throw new InvalidOperationException("Invalid endian magic");
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            throw new NotSupportedException();
        }
    }
}
