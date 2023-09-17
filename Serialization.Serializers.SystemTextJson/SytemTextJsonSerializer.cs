﻿using Serialization.Domain.Entities;
using Serialization.Domain.Interfaces;
using System.Text;
using System.Text.Json;

namespace Serialization.Serializers.SystemTextJson
{
    public class SytemTextJsonSerializer : BaseDirectSerializer<byte[]>
    {
        protected override byte[] Serialize<T>(T original, out long messageSize)
        {
            var jsonString = JsonSerializer.Serialize(original);
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            using var writer = new StreamWriter(stream, Encoding.UTF8);
            writer.Flush();

            messageSize = stream.Position;
            return stream.ToArray();
        }

        protected override ISerializationTarget Deserialize<T>(byte[] buf)
        {
            T copy;
            //using var reader = new StreamReader(buf, Encoding.UTF8);
            var jsonString = Encoding.UTF8.GetString(buf);
            copy = JsonSerializer.Deserialize<T>(jsonString);

            return copy;
        }

        protected override byte[] Serialize(Type type, ISerializationTarget original, out long messageSize)
        {
            var jsonString = JsonSerializer.Serialize(original); // TODO: resolve type
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            using var writer = new StreamWriter(stream, Encoding.UTF8);
            writer.Flush();

            messageSize = stream.Position;
            return stream.ToArray();
        }

        protected override ISerializationTarget Deserialize(Type type, byte[] serializedObject)
        {
            object copy;
            //using var reader = new StreamReader(serializedObject, Encoding.UTF8);
            var jsonString = Encoding.UTF8.GetString(serializedObject);
            copy = JsonSerializer.Deserialize(jsonString, type);

            return (ISerializationTarget)copy;
        }

        public override bool GetSerializationResult(Type type, out object result)
        {
            if (type == typeof(Video))
            {
                result = SerializationResults[typeof(Video)].Result;
                return true;
            }
            if (type == typeof(VideoInfo))
            {
                result = SerializationResults[typeof(VideoInfo)].Result;
                return true;
            }
            if (type == typeof(SocialInfo))
            {
                result = SerializationResults[typeof(SocialInfo)].Result;
                return true;
            }
            if (type == typeof(Channel))
            {
                result = SerializationResults[typeof(Channel)].Result;
                return true;
            }
            throw new NotImplementedException($"Conversion for type {type} not implemented!");
        }

        public override Type GetSerializationOutPutType() => typeof(byte[]);
    }
}