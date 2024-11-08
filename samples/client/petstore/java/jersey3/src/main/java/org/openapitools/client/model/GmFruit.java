/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import java.math.BigDecimal;
import java.util.Arrays;
import org.openapitools.client.model.Apple;
import org.openapitools.client.model.Banana;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import jakarta.validation.constraints.*;
import jakarta.validation.Valid;
import org.openapitools.client.JSON;


import jakarta.ws.rs.core.GenericType;
import jakarta.ws.rs.core.Response;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.core.JsonParser;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.DeserializationContext;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.fasterxml.jackson.databind.deser.std.StdDeserializer;
import com.fasterxml.jackson.databind.ser.std.StdSerializer;
import org.openapitools.client.JSON;

@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.10.0-SNAPSHOT")
@JsonDeserialize(using=GmFruit.GmFruitDeserializer.class)
@JsonSerialize(using = GmFruit.GmFruitSerializer.class)
public class GmFruit extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(GmFruit.class.getName());

    public static class GmFruitSerializer extends StdSerializer<GmFruit> {
        public GmFruitSerializer(Class<GmFruit> t) {
            super(t);
        }

        public GmFruitSerializer() {
            this(null);
        }

        @Override
        public void serialize(GmFruit value, JsonGenerator jgen, SerializerProvider provider) throws IOException, JsonProcessingException {
            jgen.writeObject(value.getActualInstance());
        }
    }

    public static class GmFruitDeserializer extends StdDeserializer<GmFruit> {
        public GmFruitDeserializer() {
            this(GmFruit.class);
        }

        public GmFruitDeserializer(Class<?> vc) {
            super(vc);
        }

        @Override
        public GmFruit deserialize(JsonParser jp, DeserializationContext ctxt) throws IOException, JsonProcessingException {
            JsonNode tree = jp.readValueAsTree();

            Object deserialized = null;
            // deserialize Apple (nullable)
            try {
                deserialized = tree.traverse(jp.getCodec()).readValueAs(Apple.class);
                GmFruit ret = new GmFruit();
                ret.setActualInstance(deserialized);
                return ret;
            } catch (Exception e) {
                // deserialization failed, continue, log to help debugging
                log.log(Level.FINER, "Input data does not match 'GmFruit'", e);
            }

            // deserialize Banana
            try {
                deserialized = tree.traverse(jp.getCodec()).readValueAs(Banana.class);
                GmFruit ret = new GmFruit();
                ret.setActualInstance(deserialized);
                return ret;
            } catch (Exception e) {
                // deserialization failed, continue, log to help debugging
                log.log(Level.FINER, "Input data does not match 'GmFruit'", e);
            }

            throw new IOException(String.format("Failed deserialization for GmFruit: no match found"));
        }

        /**
         * Handle deserialization of the 'null' value.
         */
        @Override
        public GmFruit getNullValue(DeserializationContext ctxt) throws JsonMappingException {
            throw new JsonMappingException(ctxt.getParser(), "GmFruit cannot be null");
        }
    }

    // store a list of schema names defined in anyOf
    public static final Map<String, GenericType<?>> schemas = new HashMap<>();

    public GmFruit() {
        super("anyOf", Boolean.FALSE);
    }

    public GmFruit(Apple o) {
        super("anyOf", Boolean.TRUE);
        setActualInstance(o);
    }

    public GmFruit(Banana o) {
        super("anyOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("Apple", new GenericType<Apple>() {
        });
        schemas.put("Banana", new GenericType<Banana>() {
        });
        JSON.registerDescendants(GmFruit.class, Collections.unmodifiableMap(schemas));
    }

    @Override
    public Map<String, GenericType<?>> getSchemas() {
        return GmFruit.schemas;
    }

    /**
     * Set the instance that matches the anyOf child schema, check
     * the instance parameter is valid against the anyOf child schemas:
     * Apple, Banana
     *
     * It could be an instance of the 'anyOf' schemas.
     * The anyOf child schemas may themselves be a composed schema (allOf, anyOf, anyOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (JSON.isInstanceOf(Apple.class, instance, new HashSet<>())) {
            super.setActualInstance(instance);
            return;
        }

        if (JSON.isInstanceOf(Banana.class, instance, new HashSet<>())) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be Apple, Banana");
    }

    /**
     * Get the actual instance, which can be the following:
     * Apple, Banana
     *
     * @return The actual instance (Apple, Banana)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `Apple`. If the actual instance is not `Apple`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `Apple`
     * @throws ClassCastException if the instance is not `Apple`
     */
    public Apple getApple() throws ClassCastException {
        return (Apple)super.getActualInstance();
    }

    /**
     * Get the actual instance of `Banana`. If the actual instance is not `Banana`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `Banana`
     * @throws ClassCastException if the instance is not `Banana`
     */
    public Banana getBanana() throws ClassCastException {
        return (Banana)super.getActualInstance();
    }

}

