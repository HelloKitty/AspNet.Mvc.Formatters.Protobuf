using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Formatters;
using System.Collections.Generic;
using Microsoft.Net.Http.Headers;
using System.Linq;

namespace AspNet.Mvc.Formatters.Protobuf
{
	/// <summary>
	/// Input formatter for the Protobuf-Net specification.
	/// </summary>
	public class ProtobufNetInputFormatter : InputFormatter
	{
		/// <summary>
		/// Determines if the <see cref="ProtobufNetInputFormatter"/> can read the request
		/// in the context.
		/// </summary>
		/// <param name="context">Formatter context.</param>
		/// <returns>True if the formatter can format the context.</returns>
		public override bool CanRead(InputFormatterContext context)
		{
			//This parses the Content-Type from the HTML header
			//It looks for Protobuf-Net
			IList<MediaTypeHeaderValue> mediaTypes = null;
			MediaTypeHeaderValue.TryParseList(context.HttpContext.Request.ContentType.Split(','), out mediaTypes);

			//If it has Protobuf-Net then we can probably read it
			return mediaTypes.Select(x => x.MediaType).Contains("application/Protobuf-Net");
		}

		/// <summary>
		/// Reads and formats the request body based on the Protobuf-Net specifications.
		/// </summary>
		/// <param name="context">Formatter context.</param>
		/// <returns>Waitable formatter result.</returns>
		public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
		{
			try
			{
				return InputFormatterResult.SuccessAsync(ProtoBuf.Serializer.Deserialize(context.ModelType, context.HttpContext.Request.Body));
			}
			catch (Exception)
			{
				return InputFormatterResult.FailureAsync();
			}

		}
	}
}