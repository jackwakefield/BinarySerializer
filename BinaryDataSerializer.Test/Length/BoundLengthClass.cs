﻿namespace BinaryDataSerialization.Test.Length
{
    public class BoundLengthClass<T>
    {
        public BoundLengthClass()
        {
            TrailingData = "trailing data";
        }

        [FieldOrder(0)]
        public ushort FieldLengthField { get; set; }

        [FieldOrder(1)]
        [FieldLength(nameof(FieldLengthField))]
        public T Field { get; set; }

        [FieldOrder(2)]
        public string TrailingData { get; set; }
    }
}
