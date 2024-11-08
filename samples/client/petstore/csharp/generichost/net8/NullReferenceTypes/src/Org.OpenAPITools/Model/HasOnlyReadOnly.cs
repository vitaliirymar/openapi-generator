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
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// HasOnlyReadOnly
    /// </summary>
    public partial class HasOnlyReadOnly : IEquatable<HasOnlyReadOnly?>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasOnlyReadOnly" /> class.
        /// </summary>
        /// <param name="bar">bar</param>
        /// <param name="foo">foo</param>
        [JsonConstructor]
        internal HasOnlyReadOnly(Option<string?> bar = default, Option<string?> foo = default)
        {
            BarOption = bar;
            FooOption = foo;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Bar
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BarOption { get; }

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [JsonPropertyName("bar")]
        public string? Bar { get { return this.BarOption; } }

        /// <summary>
        /// Used to track the state of Foo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FooOption { get; }

        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [JsonPropertyName("foo")]
        public string? Foo { get { return this.FooOption; } }

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
            sb.Append("class HasOnlyReadOnly {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as HasOnlyReadOnly).AreEqual;
        }

        /// <summary>
        /// Returns true if HasOnlyReadOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of HasOnlyReadOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HasOnlyReadOnly? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Bar != null)
                    hashCode = (hashCode * 59) + Bar.GetHashCode();

                if (Foo != null)
                    hashCode = (hashCode * 59) + Foo.GetHashCode();

                hashCode = (hashCode * 59) + AdditionalProperties.GetHashCode();

                return hashCode;
            }
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
    /// A Json converter for type <see cref="HasOnlyReadOnly" />
    /// </summary>
    public class HasOnlyReadOnlyJsonConverter : JsonConverter<HasOnlyReadOnly>
    {
        /// <summary>
        /// Deserializes json to <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HasOnlyReadOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> bar = default;
            Option<string?> foo = default;

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
                        case "bar":
                            bar = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "foo":
                            foo = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (bar.IsSet && bar.Value == null)
                throw new ArgumentNullException(nameof(bar), "Property is not nullable for class HasOnlyReadOnly.");

            if (foo.IsSet && foo.Value == null)
                throw new ArgumentNullException(nameof(foo), "Property is not nullable for class HasOnlyReadOnly.");

            return new HasOnlyReadOnly(bar, foo);
        }

        /// <summary>
        /// Serializes a <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hasOnlyReadOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HasOnlyReadOnly hasOnlyReadOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, hasOnlyReadOnly, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="HasOnlyReadOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hasOnlyReadOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, HasOnlyReadOnly hasOnlyReadOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            if (hasOnlyReadOnly.BarOption.IsSet && hasOnlyReadOnly.Bar == null)
                throw new ArgumentNullException(nameof(hasOnlyReadOnly.Bar), "Property is required for class HasOnlyReadOnly.");

            if (hasOnlyReadOnly.FooOption.IsSet && hasOnlyReadOnly.Foo == null)
                throw new ArgumentNullException(nameof(hasOnlyReadOnly.Foo), "Property is required for class HasOnlyReadOnly.");

            if (hasOnlyReadOnly.BarOption.IsSet)
                writer.WriteString("bar", hasOnlyReadOnly.Bar);

            if (hasOnlyReadOnly.FooOption.IsSet)
                writer.WriteString("foo", hasOnlyReadOnly.Foo);
        }
    }
}
