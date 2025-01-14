﻿using System;

namespace BinaryDataSerialization.Test.Value
{
    public class OffsetLengthConverter : IValueConverter
    {
        private const int BaseOffset = 20;

        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            var offset = System.Convert.ToInt32(value) * 4;
            return offset - BaseOffset;
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            var length = System.Convert.ToInt32(value);
            return (int)Math.Ceiling((length + BaseOffset) / 4f);
        }
    }
}
