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
    /// Drawing
    /// </summary>
    public partial class Drawing : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawing" /> class.
        /// </summary>
        /// <param name="mainShape">mainShape</param>
        /// <param name="nullableShape">nullableShape</param>
        /// <param name="shapeOrNull">shapeOrNull</param>
        /// <param name="shapes">shapes</param>
        [JsonConstructor]
        public Drawing(Option<Shape?> mainShape = default, Option<NullableShape?> nullableShape = default, Option<ShapeOrNull?> shapeOrNull = default, Option<List<Shape>?> shapes = default)
        {
            MainShapeOption = mainShape;
            NullableShapeOption = nullableShape;
            ShapeOrNullOption = shapeOrNull;
            ShapesOption = shapes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of MainShape
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Shape?> MainShapeOption { get; private set; }

        /// <summary>
        /// Gets or Sets MainShape
        /// </summary>
        [JsonPropertyName("mainShape")]
        public Shape? MainShape { get { return this.MainShapeOption; } set { this.MainShapeOption = new(value); } }

        /// <summary>
        /// Used to track the state of NullableShape
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<NullableShape?> NullableShapeOption { get; private set; }

        /// <summary>
        /// Gets or Sets NullableShape
        /// </summary>
        [JsonPropertyName("nullableShape")]
        public NullableShape? NullableShape { get { return this.NullableShapeOption; } set { this.NullableShapeOption = new(value); } }

        /// <summary>
        /// Used to track the state of ShapeOrNull
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ShapeOrNull?> ShapeOrNullOption { get; private set; }

        /// <summary>
        /// Gets or Sets ShapeOrNull
        /// </summary>
        [JsonPropertyName("shapeOrNull")]
        public ShapeOrNull? ShapeOrNull { get { return this.ShapeOrNullOption; } set { this.ShapeOrNullOption = new(value); } }

        /// <summary>
        /// Used to track the state of Shapes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Shape>?> ShapesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Shapes
        /// </summary>
        [JsonPropertyName("shapes")]
        public List<Shape>? Shapes { get { return this.ShapesOption; } set { this.ShapesOption = new(value); } }

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
            sb.Append("class Drawing {\n");
            sb.Append("  MainShape: ").Append(MainShape).Append("\n");
            sb.Append("  NullableShape: ").Append(NullableShape).Append("\n");
            sb.Append("  ShapeOrNull: ").Append(ShapeOrNull).Append("\n");
            sb.Append("  Shapes: ").Append(Shapes).Append("\n");
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
    /// A Json converter for type <see cref="Drawing" />
    /// </summary>
    public class DrawingJsonConverter : JsonConverter<Drawing>
    {
        /// <summary>
        /// Deserializes json to <see cref="Drawing" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Drawing Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Shape?> mainShape = default;
            Option<NullableShape?> nullableShape = default;
            Option<ShapeOrNull?> shapeOrNull = default;
            Option<List<Shape>?> shapes = default;

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
                        case "mainShape":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mainShape = new Option<Shape?>(JsonSerializer.Deserialize<Shape>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "nullableShape":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                nullableShape = new Option<NullableShape?>(JsonSerializer.Deserialize<NullableShape>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "shapeOrNull":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shapeOrNull = new Option<ShapeOrNull?>(JsonSerializer.Deserialize<ShapeOrNull>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "shapes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shapes = new Option<List<Shape>?>(JsonSerializer.Deserialize<List<Shape>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (mainShape.IsSet && mainShape.Value == null)
                throw new ArgumentNullException(nameof(mainShape), "Property is not nullable for class Drawing.");

            if (shapes.IsSet && shapes.Value == null)
                throw new ArgumentNullException(nameof(shapes), "Property is not nullable for class Drawing.");

            return new Drawing(mainShape, nullableShape, shapeOrNull, shapes);
        }

        /// <summary>
        /// Serializes a <see cref="Drawing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drawing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Drawing drawing, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, drawing, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Drawing" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drawing"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Drawing drawing, JsonSerializerOptions jsonSerializerOptions)
        {
            if (drawing.MainShapeOption.IsSet && drawing.MainShape == null)
                throw new ArgumentNullException(nameof(drawing.MainShape), "Property is required for class Drawing.");

            if (drawing.ShapesOption.IsSet && drawing.Shapes == null)
                throw new ArgumentNullException(nameof(drawing.Shapes), "Property is required for class Drawing.");

            if (drawing.MainShapeOption.IsSet)
            {
                writer.WritePropertyName("mainShape");
                JsonSerializer.Serialize(writer, drawing.MainShape, jsonSerializerOptions);
            }
            if (drawing.NullableShapeOption.IsSet)
                if (drawing.NullableShapeOption.Value != null)
                {
                    writer.WritePropertyName("nullableShape");
                    JsonSerializer.Serialize(writer, drawing.NullableShape, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("nullableShape");
            if (drawing.ShapeOrNullOption.IsSet)
                if (drawing.ShapeOrNullOption.Value != null)
                {
                    writer.WritePropertyName("shapeOrNull");
                    JsonSerializer.Serialize(writer, drawing.ShapeOrNull, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("shapeOrNull");
            if (drawing.ShapesOption.IsSet)
            {
                writer.WritePropertyName("shapes");
                JsonSerializer.Serialize(writer, drawing.Shapes, jsonSerializerOptions);
            }
        }
    }
}
