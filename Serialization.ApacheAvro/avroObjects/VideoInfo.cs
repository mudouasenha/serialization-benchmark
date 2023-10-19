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
	
	public partial class VideoInfo : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""VideoInfo"",""namespace"":""avroObjects"",""fields"":[{""name"":""Duration"",""type"":""long""},{""name"":""Description"",""type"":""string""},{""name"":""Size"",""type"":""long""},{""name"":""Qualities"",""type"":{""type"":""array"",""items"":{""type"":""enum"",""name"":""VideoQualities"",""namespace"":""avroObjects"",""symbols"":[""Undefined"",""Lowest"",""Low"",""Medium"",""SD"",""HD"",""TwoK"",""FourK""]}}}]}");
		private long _Duration;
		private string _Description;
		private long _Size;
		private IList<avroObjects.VideoQualities> _Qualities;
		public virtual Schema Schema
		{
			get
			{
				return VideoInfo._SCHEMA;
			}
		}
		public long Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				this._Duration = value;
			}
		}
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}
		public long Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				this._Size = value;
			}
		}
		public IList<avroObjects.VideoQualities> Qualities
		{
			get
			{
				return this._Qualities;
			}
			set
			{
				this._Qualities = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Duration;
			case 1: return this.Description;
			case 2: return this.Size;
			case 3: return this.Qualities;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Duration = (System.Int64)fieldValue; break;
			case 1: this.Description = (System.String)fieldValue; break;
			case 2: this.Size = (System.Int64)fieldValue; break;
			case 3: this.Qualities = (IList<avroObjects.VideoQualities>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}