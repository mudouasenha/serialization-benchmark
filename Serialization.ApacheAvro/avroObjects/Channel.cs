// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace avroObjects
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class Channel : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"Channel\",\"namespace\":\"avroObjects\",\"fields\":[{\"name\":\"Na" +
				"me\",\"type\":\"string\"},{\"name\":\"Subscribers\",\"type\":\"int\"},{\"name\":\"ChannelId\",\"ty" +
				"pe\":\"string\"}]}");
		private string _Name;
		private int _Subscribers;
		private string _ChannelId;
		public virtual Schema Schema
		{
			get
			{
				return Channel._SCHEMA;
			}
		}
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}
		public int Subscribers
		{
			get
			{
				return this._Subscribers;
			}
			set
			{
				this._Subscribers = value;
			}
		}
		public string ChannelId
		{
			get
			{
				return this._ChannelId;
			}
			set
			{
				this._ChannelId = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Name;
			case 1: return this.Subscribers;
			case 2: return this.ChannelId;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Name = (System.String)fieldValue; break;
			case 1: this.Subscribers = (System.Int32)fieldValue; break;
			case 2: this.ChannelId = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}