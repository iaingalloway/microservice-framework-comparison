namespace Service;

using System.Text.Json.Serialization;

[JsonSerializable(typeof(Response))]
internal sealed partial class JsonContext : JsonSerializerContext;
