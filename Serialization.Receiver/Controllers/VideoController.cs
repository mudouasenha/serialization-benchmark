﻿using Microsoft.AspNetCore.Mvc;
using Serialization.Domain.Interfaces;
using Serialization.Serializers.FlatBuffers;
using Serialization.Serializers.MessagePack;

namespace Serialization.Receiver.Controllers
{
    [ApiController]
    [Route("receiver/[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly ILogger<VideoController> _logger;
        private readonly IVideoService _videoService;
        private readonly ISerializer serializer;
        private readonly Dictionary<string, ISerializer> serializers = new()
        {
            {  "flatbuffers", new VideoFlatBuffersSerializer() } ,
            //{  "systemtextjson", new SytemTextJsonSerializer() } ,
            {  "messagepack", new MessagePackCSharpSerializer() } ,
        };

        public VideoController(ILogger<VideoController> logger, ISerializer serializer, IVideoService videoService)
        {
            _logger = logger;
            this.serializer = serializer;
            _videoService = videoService;
        }

        [HttpGet]
        public IActionResult GetVideos()
        {
            try
            {
                var vid = _videoService.CreateVideo();
                var size = vid.Serialize(serializer);

                if (serializer.GetDeserializationResult(vid.GetType(), out var result))
                {
                    Response.ContentType = "application/octet-stream";
                    Response.Headers.Add("Content-Length", size.ToString());

                    return Ok(new FileContentResult((byte[])(object)result, "application/octet-stream"));
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return Problem();
            }
        }

        [HttpPost("flatbuffers")]
        public IActionResult PostFlatBuffers([FromBody] ISerializationTarget requestData)
        {
            try
            {
                requestData.Deserialize(serializer);
                var size = requestData.Serialize(serializer);

                if (serializer.GetDeserializationResult(requestData.GetType(), out var result))
                {
                    Response.ContentType = "application/octet-stream";
                    Response.Headers.Add("Content-Length", size.ToString());

                    return Ok(new FileContentResult((byte[])(object)result, "application/octet-stream"));
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return Problem();
            }
        }

        [HttpPost("messagepack")]
        public IActionResult PostMessagePack([FromBody] ISerializationTarget requestData)
        {
            try
            {
                requestData.Deserialize(serializer);
                var size = requestData.Serialize(serializer);

                if (serializer.GetDeserializationResult(requestData.GetType(), out var result))
                {
                    Response.ContentType = "application/octet-stream";
                    Response.Headers.Add("Content-Length", size.ToString());

                    return Ok(new FileContentResult((byte[])(object)result, "application/octet-stream"));
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return Problem();
            }
        }

        [HttpPost("systemtextjson")]
        public IActionResult PostSystemTextJson([FromBody] ISerializationTarget requestData)
        {
            try
            {
                requestData.Deserialize(serializer);
                var size = requestData.Serialize(serializer);

                if (serializer.GetDeserializationResult(requestData.GetType(), out var result))
                {
                    Response.ContentType = "application/octet-stream";
                    Response.Headers.Add("Content-Length", size.ToString());

                    return Ok(new FileContentResult((byte[])(object)result, "application/octet-stream"));
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return Problem();
            }
        }
    }
}