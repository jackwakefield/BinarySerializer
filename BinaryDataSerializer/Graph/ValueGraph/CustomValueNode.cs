﻿using System;
using System.Threading;
using System.Threading.Tasks;
using BinaryDataSerialization.Graph.TypeGraph;

namespace BinaryDataSerialization.Graph.ValueGraph
{
    internal class CustomValueNode : ObjectValueNode
    {
        public CustomValueNode(ValueNode parent, string name, TypeNode typeNode) : base(parent, name, typeNode)
        {
        }

        protected override void ObjectSerializeOverride(BoundedStream stream, EventShuttle eventShuttle)
        {
            var serializationContext = CreateLazySerializationContext();

            var value = BoundValue;

            if (value == null)
            {
                return;
            }

            if (!(value is IBinaryDataSerializable binarySerializable))
            {
                throw new InvalidOperationException("Must implement IBinaryDataSerializable");
            }

            binarySerializable.Serialize(stream, GetFieldEndianness(), serializationContext);
        }

        protected override void ObjectDeserializeOverride(BoundedStream stream, EventShuttle eventShuttle)
        {
            var serializationContext = CreateLazySerializationContext();
            var binarySerializable = CreateBinarySerializable();
            binarySerializable.Deserialize(stream, GetFieldEndianness(), serializationContext);
            Value = binarySerializable;
        }

        protected override Task ObjectDeserializeOverrideAsync(BoundedStream stream, EventShuttle eventShuttle,
            CancellationToken cancellationToken)
        {
            ObjectDeserializeOverride(stream, eventShuttle);
            return Task.CompletedTask;
        }

        protected override Task ObjectSerializeOverrideAsync(BoundedStream stream, EventShuttle eventShuttle, CancellationToken cancellationToken)
        {
            ObjectSerializeOverride(stream, eventShuttle);
            return Task.CompletedTask;
        }

        private IBinaryDataSerializable CreateBinarySerializable()
        {
            var binarySerializable = (IBinaryDataSerializable)Activator.CreateInstance(TypeNode.Type);
            return binarySerializable;
        }
    }
}
