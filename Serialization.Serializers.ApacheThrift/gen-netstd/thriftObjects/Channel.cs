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

  public partial class Channel : TBase
  {
    private string _Name;
    private int _Subscribers;
    private string _ChannelId;

    public string Name
    {
      get
      {
        return _Name;
      }
      set
      {
        __isset.Name = true;
        this._Name = value;
      }
    }

    public int Subscribers
    {
      get
      {
        return _Subscribers;
      }
      set
      {
        __isset.Subscribers = true;
        this._Subscribers = value;
      }
    }

    public string ChannelId
    {
      get
      {
        return _ChannelId;
      }
      set
      {
        __isset.ChannelId = true;
        this._ChannelId = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool Name;
      public bool Subscribers;
      public bool ChannelId;
    }

    public Channel()
    {
    }

    public Channel DeepCopy()
    {
      var tmp0 = new Channel();
      if((Name != null) && __isset.Name)
      {
        tmp0.Name = this.Name;
      }
      tmp0.__isset.Name = this.__isset.Name;
      if(__isset.Subscribers)
      {
        tmp0.Subscribers = this.Subscribers;
      }
      tmp0.__isset.Subscribers = this.__isset.Subscribers;
      if((ChannelId != null) && __isset.ChannelId)
      {
        tmp0.ChannelId = this.ChannelId;
      }
      tmp0.__isset.ChannelId = this.__isset.ChannelId;
      return tmp0;
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
                Name = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Subscribers = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                ChannelId = await iprot.ReadStringAsync(cancellationToken);
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
        var tmp1 = new TStruct("Channel");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        if((Name != null) && __isset.Name)
        {
          tmp2.Name = "Name";
          tmp2.Type = TType.String;
          tmp2.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.Subscribers)
        {
          tmp2.Name = "Subscribers";
          tmp2.Type = TType.I32;
          tmp2.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async(Subscribers, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ChannelId != null) && __isset.ChannelId)
        {
          tmp2.Name = "ChannelId";
          tmp2.Type = TType.String;
          tmp2.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(ChannelId, cancellationToken);
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
      if (!(that is Channel other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.Name == other.__isset.Name) && ((!__isset.Name) || (global::System.Object.Equals(Name, other.Name))))
        && ((__isset.Subscribers == other.__isset.Subscribers) && ((!__isset.Subscribers) || (global::System.Object.Equals(Subscribers, other.Subscribers))))
        && ((__isset.ChannelId == other.__isset.ChannelId) && ((!__isset.ChannelId) || (global::System.Object.Equals(ChannelId, other.ChannelId))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Name != null) && __isset.Name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if(__isset.Subscribers)
        {
          hashcode = (hashcode * 397) + Subscribers.GetHashCode();
        }
        if((ChannelId != null) && __isset.ChannelId)
        {
          hashcode = (hashcode * 397) + ChannelId.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("Channel(");
      int tmp4 = 0;
      if((Name != null) && __isset.Name)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Name: ");
        Name.ToString(tmp3);
      }
      if(__isset.Subscribers)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("Subscribers: ");
        Subscribers.ToString(tmp3);
      }
      if((ChannelId != null) && __isset.ChannelId)
      {
        if(0 < tmp4++) { tmp3.Append(", "); }
        tmp3.Append("ChannelId: ");
        ChannelId.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}