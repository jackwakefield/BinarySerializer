﻿namespace BinaryDataSerialization.Test.Value
{
    public class FieldSha256Class
    {
        [FieldOrder(0)]
        public int Length { get; set; }

        [FieldOrder(1)]
        [FieldLength(nameof(Length))]
        [FieldSha256(nameof(Hash))]
        public string Value { get; set; }

        [FieldOrder(2)]
        public byte[] Hash { get; set; }
    }
}
