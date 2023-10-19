/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.19.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace thriftObjects
{

  public partial class Video : TBase
  {
    private string _VideoId;
    private string _Url;
    private global::thriftObjects.Channel _Channel;
    private global::thriftObjects.SocialInfo _SocialInfo;
    private global::thriftObjects.VideoInfo _VideoInfo;

    public string VideoId
    {
      get
      {
        return _VideoId;
      }
      set
      {
        __isset.VideoId = true;
        this._VideoId = value;
      }
    }

    public string Url
    {
      get
      {
        return _Url;
      }
      set
      {
        __isset.Url = true;
        this._Url = value;
      }
    }

    public global::thriftObjects.Channel Channel
    {
      get
      {
        return _Channel;
      }
      set
      {
        __isset.Channel = true;
        this._Channel = value;
      }
    }

    public global::thriftObjects.SocialInfo SocialInfo
    {
      get
      {
        return _SocialInfo;
      }
      set
      {
        __isset.SocialInfo = true;
        this._SocialInfo = value;
      }
    }

    public global::thriftObjects.VideoInfo VideoInfo
    {
      get
      {
        return _VideoInfo;
      }
      set
      {
        __isset.VideoInfo = true;
        this._VideoInfo = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool VideoId;
      public bool Url;
      public bool Channel;
      public bool SocialInfo;
      public bool VideoInfo;
    }

    public Video()
    {
    }

    public Video DeepCopy()
    {
      var tmp23 = new Video();
      if((VideoId != null) && __isset.VideoId)
      {
        tmp23.VideoId = this.VideoId;
      }
      tmp23.__isset.VideoId = this.__isset.VideoId;
      if((Url != null) && __isset.Url)
      {
        tmp23.Url = this.Url;
      }
      tmp23.__isset.Url = this.__isset.Url;
      if((Channel != null) && __isset.Channel)
      {
        tmp23.Channel = (global::thriftObjects.Channel)this.Channel.DeepCopy();
      }
      tmp23.__isset.Channel = this.__isset.Channel;
      if((SocialInfo != null) && __isset.SocialInfo)
      {
        tmp23.SocialInfo = (global::thriftObjects.SocialInfo)this.SocialInfo.DeepCopy();
      }
      tmp23.__isset.SocialInfo = this.__isset.SocialInfo;
      if((VideoInfo != null) && __isset.VideoInfo)
      {
        tmp23.VideoInfo = (global::thriftObjects.VideoInfo)this.VideoInfo.DeepCopy();
      }
      tmp23.__isset.VideoInfo = this.__isset.VideoInfo;
      return tmp23;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                VideoId = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Url = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Channel = new global::thriftObjects.Channel();
                await Channel.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                SocialInfo = new global::thriftObjects.SocialInfo();
                await SocialInfo.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                VideoInfo = new global::thriftObjects.VideoInfo();
                await VideoInfo.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp24 = new TStruct("Video");
        await oprot.WriteStructBeginAsync(tmp24, cancellationToken);
        var tmp25 = new TField();
        if((VideoId != null) && __isset.VideoId)
        {
          tmp25.Name = "VideoId";
          tmp25.Type = TType.String;
          tmp25.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp25, cancellationToken);
          await oprot.WriteStringAsync(VideoId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Url != null) && __isset.Url)
        {
          tmp25.Name = "Url";
          tmp25.Type = TType.String;
          tmp25.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp25, cancellationToken);
          await oprot.WriteStringAsync(Url, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Channel != null) && __isset.Channel)
        {
          tmp25.Name = "Channel";
          tmp25.Type = TType.Struct;
          tmp25.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp25, cancellationToken);
          await Channel.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((SocialInfo != null) && __isset.SocialInfo)
        {
          tmp25.Name = "SocialInfo";
          tmp25.Type = TType.Struct;
          tmp25.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp25, cancellationToken);
          await SocialInfo.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((VideoInfo != null) && __isset.VideoInfo)
        {
          tmp25.Name = "VideoInfo";
          tmp25.Type = TType.Struct;
          tmp25.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp25, cancellationToken);
          await VideoInfo.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is Video other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.VideoId == other.__isset.VideoId) && ((!__isset.VideoId) || (global::System.Object.Equals(VideoId, other.VideoId))))
        && ((__isset.Url == other.__isset.Url) && ((!__isset.Url) || (global::System.Object.Equals(Url, other.Url))))
        && ((__isset.Channel == other.__isset.Channel) && ((!__isset.Channel) || (global::System.Object.Equals(Channel, other.Channel))))
        && ((__isset.SocialInfo == other.__isset.SocialInfo) && ((!__isset.SocialInfo) || (global::System.Object.Equals(SocialInfo, other.SocialInfo))))
        && ((__isset.VideoInfo == other.__isset.VideoInfo) && ((!__isset.VideoInfo) || (global::System.Object.Equals(VideoInfo, other.VideoInfo))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((VideoId != null) && __isset.VideoId)
        {
          hashcode = (hashcode * 397) + VideoId.GetHashCode();
        }
        if((Url != null) && __isset.Url)
        {
          hashcode = (hashcode * 397) + Url.GetHashCode();
        }
        if((Channel != null) && __isset.Channel)
        {
          hashcode = (hashcode * 397) + Channel.GetHashCode();
        }
        if((SocialInfo != null) && __isset.SocialInfo)
        {
          hashcode = (hashcode * 397) + SocialInfo.GetHashCode();
        }
        if((VideoInfo != null) && __isset.VideoInfo)
        {
          hashcode = (hashcode * 397) + VideoInfo.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp26 = new StringBuilder("Video(");
      int tmp27 = 0;
      if((VideoId != null) && __isset.VideoId)
      {
        if(0 < tmp27++) { tmp26.Append(", "); }
        tmp26.Append("VideoId: ");
        VideoId.ToString(tmp26);
      }
      if((Url != null) && __isset.Url)
      {
        if(0 < tmp27++) { tmp26.Append(", "); }
        tmp26.Append("Url: ");
        Url.ToString(tmp26);
      }
      if((Channel != null) && __isset.Channel)
      {
        if(0 < tmp27++) { tmp26.Append(", "); }
        tmp26.Append("Channel: ");
        Channel.ToString(tmp26);
      }
      if((SocialInfo != null) && __isset.SocialInfo)
      {
        if(0 < tmp27++) { tmp26.Append(", "); }
        tmp26.Append("SocialInfo: ");
        SocialInfo.ToString(tmp26);
      }
      if((VideoInfo != null) && __isset.VideoInfo)
      {
        if(0 < tmp27++) { tmp26.Append(", "); }
        tmp26.Append("VideoInfo: ");
        VideoInfo.ToString(tmp26);
      }
      tmp26.Append(')');
      return tmp26.ToString();
    }
  }

}
