// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Microsoft.Graph.DeveloperProxy.Plugins;

public class GenericErrorResponse {
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }
    [JsonPropertyName("headers")]
    public Dictionary<string, string>? Headers { get; set; }
    [JsonPropertyName("body")]
    public dynamic? Body { get; set; }
    [JsonPropertyName("addDynamicRetryAfter")]
    public bool? AddDynamicRetryAfter { get; set; } = false;
}