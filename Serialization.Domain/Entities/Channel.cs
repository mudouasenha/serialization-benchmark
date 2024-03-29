﻿using Avro.Specific;
using Capnp;
using Google.Protobuf;
using MessagePack;
using ProtoBuf;
using Serialization.Domain.Interfaces;
using Thrift.Protocol;

namespace Serialization.Domain.Entities
{
    [MessagePackObject]
    [Serializable]
    [ProtoContract]
    public class Channel : ISerializationTarget
    {
        [NonSerialized]
        private IMessage<ProtoObjects.Channel> protoObject;

        [NonSerialized]
        private thriftObjects.Channel thriftObject;

        [NonSerialized]
        private avroObjects.Channel avroObject;

        [NonSerialized]
        private ICapnpSerializable capnpObject;

        public Channel()
        { }

        public Channel(string name, int subscribers, string channelId)
        {
            Name = name;
            Subscribers = subscribers;
            ChannelId = channelId;
        }

        [Key(0)]
        [ProtoMember(1)]
        public string Name { get; set; }

        [Key(1)]
        [ProtoMember(2)]
        public int Subscribers { get; set; }

        [Key(2)]
        [ProtoMember(4)]
        public string ChannelId { get; set; }

        public long Serialize(ISerializer serializer) => serializer.BenchmarkSerialize(this);

        public long Deserialize(ISerializer serializer) => serializer.BenchmarkDeserialize(this);

        public bool Equals(Channel other) => Name.Equals(other.Name) && Subscribers.Equals(other.Subscribers) && ChannelId.Equals(other.ChannelId);

        public bool Equals(ISerializationTarget other) => other is Channel otherChannel && Equals(otherChannel);

        public override string ToString()
        {
            return "Channel";
        }

        public void CreateProtobufMessage()
        {
            protoObject = new ProtoObjects.Channel()
            {
                ChannelId = ChannelId,
                Name = Name,
                Subscribers = (uint)Subscribers
            };
        }

        public IMessage GetProtobufMessage()
        {
            return protoObject;
        }

        public TBase GetThriftMessage()
        {
            return thriftObject;
        }

        public void CreateThriftMessage()
        {
            thriftObject = new thriftObjects.Channel()
            {
                ChannelId = ChannelId,
                Name = Name,
                Subscribers = Subscribers
            };
        }

        public ISpecificRecord GetAvroMessage()
        {
            return avroObject;
        }

        public void CreateAvroMessage()
        {
            avroObject = new avroObjects.Channel()
            {
                ChannelId = ChannelId,
                Name = Name,
                Subscribers = Subscribers
            };
        }

        public ICapnpSerializable GetCapnProtoMessage()
        {
            return capnpObject;
        }

        public void CreateCapnProtoMessage()
        {
            capnpObject = new CapnpGen.Channel()
            {
                ChannelId = ChannelId,
                Name = Name,
                Subscribers = (uint)Subscribers
            };
        }
    }
}