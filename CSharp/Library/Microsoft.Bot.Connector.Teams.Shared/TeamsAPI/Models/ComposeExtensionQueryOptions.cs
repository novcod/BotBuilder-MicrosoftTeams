// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Compose extensions query options
    /// </summary>
    public partial class ComposeExtensionQueryOptions
    {
        /// <summary>
        /// Initializes a new instance of the ComposeExtensionQueryOptions
        /// class.
        /// </summary>
        public ComposeExtensionQueryOptions() { }

        /// <summary>
        /// Initializes a new instance of the ComposeExtensionQueryOptions
        /// class.
        /// </summary>
        /// <param name="skip">Number of entities to skip</param>
        /// <param name="count">Number of entities to fetch</param>
        public ComposeExtensionQueryOptions(int? skip = default(int?), int? count = default(int?))
        {
            Skip = skip;
            Count = count;
        }

        /// <summary>
        /// Gets or sets number of entities to skip
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or sets number of entities to fetch
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

    }
}