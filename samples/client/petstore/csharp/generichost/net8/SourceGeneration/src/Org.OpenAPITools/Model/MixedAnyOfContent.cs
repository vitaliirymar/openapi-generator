// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Mixed anyOf types for testing
    /// </summary>
    public partial class MixedAnyOfContent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedAnyOfContent" /> class.
        /// </summary>
        /// <param name="string"></param>
        /// <param name="bool"></param>
        /// <param name="int"></param>
        /// <param name="decimal"></param>
        /// <param name="mixedSubId"></param>
        public MixedAnyOfContent(Option<string?> @string, Option<bool?> @bool, Option<int?> @int, Option<decimal?> @decimal, Option<MixedSubId?> mixedSubId)
        {
            StringOption = @string;
            BoolOption = @bool;
            IntOption = @int;
            DecimalOption = @decimal;
            MixedSubIdOption = mixedSubId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of String
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StringOption { get; private set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        public string? String { get { return this.StringOption; } set { this.StringOption = new(value); } }

        /// <summary>
        /// Used to track the state of Bool
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> BoolOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bool
        /// </summary>
        public bool? Bool { get { return this.BoolOption; } set { this.BoolOption = new(value); } }

        /// <summary>
        /// Used to track the state of Int
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> IntOption { get; private set; }

        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        public int? Int { get { return this.IntOption; } set { this.IntOption = new(value); } }

        /// <summary>
        /// Used to track the state of Decimal
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> DecimalOption { get; private set; }

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        public decimal? Decimal { get { return this.DecimalOption; } set { this.DecimalOption = new(value); } }

        /// <summary>
        /// Used to track the state of MixedSubId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<MixedSubId?> MixedSubIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets MixedSubId
        /// </summary>
        public MixedSubId? MixedSubId { get { return this.MixedSubIdOption; } set { this.MixedSubIdOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MixedAnyOfContent {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MixedAnyOfContent" />
    /// </summary>
    public class MixedAnyOfContentJsonConverter : JsonConverter<MixedAnyOfContent>
    {
        /// <summary>
        /// Deserializes json to <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedAnyOfContent Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? varString = default;
            bool? varBool = default;
            int? varInt = default;
            decimal? varDecimal = default;
            MixedSubId? mixedSubId = default;

            Utf8JsonReader utf8JsonReaderAnyOf = utf8JsonReader;
            while (utf8JsonReaderAnyOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (utf8JsonReaderAnyOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderAnyOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderString = utf8JsonReader;
                    ClientUtils.TryDeserialize<string?>(ref utf8JsonReaderString, jsonSerializerOptions, out varString);

                    Utf8JsonReader utf8JsonReaderBool = utf8JsonReader;
                    ClientUtils.TryDeserialize<bool?>(ref utf8JsonReaderBool, jsonSerializerOptions, out varBool);

                    Utf8JsonReader utf8JsonReaderInt = utf8JsonReader;
                    ClientUtils.TryDeserialize<int?>(ref utf8JsonReaderInt, jsonSerializerOptions, out varInt);

                    Utf8JsonReader utf8JsonReaderDecimal = utf8JsonReader;
                    ClientUtils.TryDeserialize<decimal?>(ref utf8JsonReaderDecimal, jsonSerializerOptions, out varDecimal);

                    Utf8JsonReader utf8JsonReaderMixedSubId = utf8JsonReader;
                    ClientUtils.TryDeserialize<MixedSubId?>(ref utf8JsonReaderMixedSubId, jsonSerializerOptions, out mixedSubId);
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            Option<string?> varStringParsedValue = varString == null
                ? default
                : new Option<string?>(varString);
            Option<bool?> varBoolParsedValue = varBool == null
                ? default
                : new Option<bool?>(varBool);
            Option<int?> varIntParsedValue = varInt == null
                ? default
                : new Option<int?>(varInt);
            Option<decimal?> varDecimalParsedValue = varDecimal == null
                ? default
                : new Option<decimal?>(varDecimal);
            Option<MixedSubId?> mixedSubIdParsedValue = mixedSubId == null
                ? default
                : new Option<MixedSubId?>(mixedSubId);

            return new MixedAnyOfContent(varStringParsedValue, varBoolParsedValue, varIntParsedValue, varDecimalParsedValue, mixedSubIdParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedAnyOfContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedAnyOfContent mixedAnyOfContent, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (mixedAnyOfContent.StringOption.IsSet && mixedAnyOfContent.StringOption.Value != null)
                writer.WriteString("content", mixedAnyOfContent.StringOption.Value);

            if (mixedAnyOfContent.BoolOption.IsSet && mixedAnyOfContent.BoolOption.Value != null)
                writer.WriteBoolean("content", mixedAnyOfContent.BoolOption.Value.Value);

            if (mixedAnyOfContent.IntOption.IsSet && mixedAnyOfContent.IntOption.Value != null)
                writer.WriteNumber("content", mixedAnyOfContent.IntOption.Value.Value);

            if (mixedAnyOfContent.DecimalOption.IsSet && mixedAnyOfContent.DecimalOption.Value != null)
                writer.WriteNumber("content", mixedAnyOfContent.DecimalOption.Value.Value);

            if (mixedAnyOfContent.MixedSubIdOption.IsSet && mixedAnyOfContent.MixedSubIdOption.Value != null)
            {
                MixedSubIdJsonConverter MixedSubIdJsonConverter = (MixedSubIdJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.MixedSubIdOption.Value.GetType()));
                MixedSubIdJsonConverter.WriteProperties(writer, mixedAnyOfContent.MixedSubIdOption.Value, jsonSerializerOptions);
            }

            WriteProperties(writer, mixedAnyOfContent, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedAnyOfContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MixedAnyOfContent mixedAnyOfContent, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }

    /// <summary>
    /// The MixedAnyOfContentSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(MixedAnyOfContent))]
    public partial class MixedAnyOfContentSerializationContext : JsonSerializerContext { }
}
