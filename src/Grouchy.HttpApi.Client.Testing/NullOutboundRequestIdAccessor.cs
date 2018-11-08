using Grouchy.HttpApi.Client.Abstractions.Tagging;

namespace Grouchy.HttpApi.Client.Testing
{
   public class NullOutboundRequestIdAccessor : IOutboundRequestIdAccessor
   {
      public string OutboundRequestId { get; set; } = null;
   }
}