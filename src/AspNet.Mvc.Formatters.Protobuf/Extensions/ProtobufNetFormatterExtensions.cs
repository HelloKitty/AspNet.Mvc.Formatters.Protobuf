using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using AspNet.Mvc.Formatters.Protobuf;

//I know we shouldn't hijack Microsoft namespaces but it's so much easier for consumers
//to access these extensions this way
namespace Microsoft.AspNet.Builder
{
	/// <summary>
	/// Extensions for Fluent MvcBuilder interfaces.
	/// </summary>
	public static class ProtobufNetFormatterExtensions
	{
		/// <summary>
		/// Adds the <see cref="ProtobufNetInputFormatter"/> and <see cref="ProtobufNetOutputFormatter"/> to the known formatters.
		/// Also registers the Protobuf-net media header to map to these formatters.
		/// </summary>
		/// <param name="builder">Builder to chain off.</param>
		/// <returns>The fluent <see cref="IMvcCoreBuilder"/> instance.</returns>
		public static IMvcCoreBuilder AddProtobufNetFormatters(this IMvcCoreBuilder builder)
		{
			//Add the formatters to the options.
			return builder.AddMvcOptions(options =>
			{
				options.InputFormatters.Add(new ProtobufNetInputFormatter());
				options.OutputFormatters.Add(new ProtobufNetOutputFormatter());
				options.FormatterMappings.SetMediaTypeMappingForFormat("ProtobufNet", MediaTypeHeaderValue.Parse("application/Protobuf-Net"));
			});
		}

		/// <summary>
		/// Adds the <see cref="ProtobufNetInputFormatter"/> and <see cref="ProtobufNetOutputFormatter"/> to the known formatters.
		/// Also registers the Protobuf-net media header to map to these formatters.
		/// </summary>
		/// <param name="builder">Builder to chain off.</param>
		/// <returns>The fluent <see cref="IMvcBuilder"/> instance.</returns>
		public static IMvcBuilder AddProtobufNetFormatters(this IMvcBuilder builder)
		{
			//Add the formatters to the options.
			return builder.AddMvcOptions(options =>
			{
				options.InputFormatters.Add(new ProtobufNetInputFormatter());
				options.OutputFormatters.Add(new ProtobufNetOutputFormatter());
				options.FormatterMappings.SetMediaTypeMappingForFormat("ProtobufNet", MediaTypeHeaderValue.Parse("application/Protobuf-Net"));
			});
		}
	}
}
