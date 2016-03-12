using Microsoft.AspNet.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.Formatters.Protobuf
{
	/// <summary>
	/// An <see cref="ObjectResult"/> with a Protobuf-net Content-Type header.
	/// </summary>
	public class ProtobufNetObjectResult : ObjectResult
	{
		/// <summary>
		/// Creates an <see cref="ObjectResult"/> object with a Protobuf-Net content header.
		/// </summary>
		/// <param name="value">Protobuf-Net serializable object value.</param>
		public ProtobufNetObjectResult(object value)
			: base(value)
		{
			//Writes the content types to be only the protobuf-net content type
			this.ContentTypes.Clear();
			ContentTypes.Add(new MediaTypeHeaderValue("application/Protobuf-Net"));
		}
	}
}
