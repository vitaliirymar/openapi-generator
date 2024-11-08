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
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.dataformat.xml.annotation.*;
import javax.xml.bind.annotation.*;
import javax.xml.bind.annotation.adapters.*;
import io.github.threetenjaxb.core.*;

/**
 * Model for testing model name same as property name
 */
@JsonPropertyOrder({
  Name.JSON_PROPERTY_NAME,
  Name.JSON_PROPERTY_SNAKE_CASE,
  Name.JSON_PROPERTY_PROPERTY,
  Name.JSON_PROPERTY_123NUMBER
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.10.0-SNAPSHOT")
@XmlRootElement(name = "Name")
@XmlAccessorType(XmlAccessType.FIELD)
@JacksonXmlRootElement(localName = "Name")
public class Name {
  public static final String JSON_PROPERTY_NAME = "name";
  @XmlElement(name = "name")
  @javax.annotation.Nonnull
  private Integer name;

  public static final String JSON_PROPERTY_SNAKE_CASE = "snake_case";
  @XmlElement(name = "snake_case")
  @javax.annotation.Nullable
  private Integer snakeCase;

  public static final String JSON_PROPERTY_PROPERTY = "property";
  @XmlElement(name = "property")
  @javax.annotation.Nullable
  private String property;

  public static final String JSON_PROPERTY_123NUMBER = "123Number";
  @XmlElement(name = "123Number")
  @javax.annotation.Nullable
  private Integer _123number;

  public Name() {
  }

  public Name name(@javax.annotation.Nonnull Integer name) {
    
    this.name = name;
    return this;
  }

  /**
   * Get name
   * @return name
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_NAME)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  @JacksonXmlProperty(localName = "name")

  public Integer getName() {
    return name;
  }


  @JsonProperty(JSON_PROPERTY_NAME)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  @JacksonXmlProperty(localName = "name")
  public void setName(@javax.annotation.Nonnull Integer name) {
    this.name = name;
  }

  /**
   * Get snakeCase
   * @return snakeCase
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_SNAKE_CASE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "snake_case")

  public Integer getSnakeCase() {
    return snakeCase;
  }



  public Name property(@javax.annotation.Nullable String property) {
    
    this.property = property;
    return this;
  }

  /**
   * Get property
   * @return property
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_PROPERTY)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "property")

  public String getProperty() {
    return property;
  }


  @JsonProperty(JSON_PROPERTY_PROPERTY)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "property")
  public void setProperty(@javax.annotation.Nullable String property) {
    this.property = property;
  }

  /**
   * Get _123number
   * @return _123number
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_123NUMBER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "123Number")

  public Integer get123number() {
    return _123number;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Name name = (Name) o;
    return Objects.equals(this.name, name.name) &&
        Objects.equals(this.snakeCase, name.snakeCase) &&
        Objects.equals(this.property, name.property) &&
        Objects.equals(this._123number, name._123number);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, snakeCase, property, _123number);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Name {\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    snakeCase: ").append(toIndentedString(snakeCase)).append("\n");
    sb.append("    property: ").append(toIndentedString(property)).append("\n");
    sb.append("    _123number: ").append(toIndentedString(_123number)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

