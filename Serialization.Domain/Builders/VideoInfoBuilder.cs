﻿using AutoBogus;
using Bogus;
using Serialization.Domain.Entities;
using Serialization.Domain.FlatBuffers.VideoModel;

namespace Serialization.Domain.Builders
{
    public class VideoInfoBuilder : AutoFaker<VideoInfo>
    {
        public VideoInfoBuilder()
        {
            var faker = new Faker();
            RuleFor(v => v.Description, f => faker.Lorem.Paragraph(30));
            RuleFor(v => v.Duration, f => faker.Random.Number(0));
            RuleFor(v => v.Size, f => faker.Random.Long(0));
            RuleFor(v => v.Qualities, f => f.Make(f.Random.Number(1, 5), () => f.Random.Enum<VideoQualityFlatModel>()).ToArray());
        }


        public VideoInfoBuilder WithDescription(string descritpion)
        {
            RuleFor(x => x.Description, descritpion);
            return this;
        }

        public VideoInfoBuilder WithDuration(int duration)
        {
            RuleFor(x => x.Duration, duration);
            return this;
        }

        public VideoInfoBuilder WithSize(long size)
        {
            RuleFor(x => x.Size, size);
            return this;
        }

        public VideoInfoBuilder WithComments(VideoQualityFlatModel[] qualities)
        {
            RuleFor(x => x.Qualities, qualities);
            return this;
        }
    }
}