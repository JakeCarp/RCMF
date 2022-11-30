using System.Text.Json.Serialization;
namespace Rcmf.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ShirtSize
{
  XS,
  Small,
  Medium,
  Large,
  XL,
  XXL,
  XXXL
}