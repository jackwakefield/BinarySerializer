﻿namespace BinaryDataSerialization.Test.Length
{
    public class ConstLengthClass
    {
        [FieldOrder(0)]
        [FieldLength(3)]
        [SerializeAs(SerializedType.TerminatedString)]
        public string Field { get; set; }

        [FieldOrder(1)]
        [FieldLength(3)]
        public string Field2 { get; set; }
    }
}
