using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace AspNet.Mvc.Formatters.Protobuf
{
	/// <summary>
	/// Output formatter for the Protobuf-Net specification.
	/// </summary>
	public class ProtobufNetOutputFormatter : OutputFormatter
	{
		public ProtobufNetOutputFormatter()
		{
			SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/x-protobuf"));
			SupportedEncodings.Add(Encoding.GetEncoding("utf-8"));
		}

		/// <summary>
		/// Formats and writes the response body based on the Protobuf-Net specifications.
		/// </summary>
		/// <param name="context">Formatter context.</param>
		/// <returns>Waitable writing <see cref="Task"/></returns>
		public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
		{
			//Serializes the Object into the response stream
			ProtoBuf.Serializer.Serialize(context.HttpContext.Response.Body, context.Object);
			return Task.FromResult(context.HttpContext.Response);
		}

		/// <summary>
		/// Determines if the <see cref="ProtobufNetOutputFormatter"/> can write/format the result
		/// in the context.
		/// </summary>
		/// <param name="context">Formatter context.</param>
		/// <returns>True if the formatter can write/format the context.</returns>
		public override bool CanWriteResult(OutputFormatterCanWriteContext context)
		{
			context.ContentType = MediaTypeHeaderValue.Parse("application/Protobuf-Net");
			//Checks if the typemodel can serialize the requested object Type
			return ProtoBuf.Meta.RuntimeTypeModel.Default.CanSerialize(context.ObjectType);
		}
	}
}