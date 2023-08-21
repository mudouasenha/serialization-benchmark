﻿using Serialization.Domain.FlatBuffers.VideoModel;
using Serialization.Domain.Interfaces;

namespace Serialization.Domain.Entities
{
    public class VideoInfo : IFlatBufferSerializable<VideoInfoFlatModel, VideoInfo>
    {
        public int Duration { get; set; }

        public string Description { get; set; }

        public long Size { get; set; }

        public VideoQualityFlatModel[] Qualities { get; set; }

        public static VideoInfo FromSerializationModel(VideoInfoFlatModel serialized) => new()
        {
            Duration = serialized.Duration,
            Description = serialized.Description,
            Size = serialized.Size,
            Qualities = serialized.GetQualitiesArray()
        };
    }
}