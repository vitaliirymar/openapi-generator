/*
 * Echo Server API
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.math.BigDecimal;

/**
 * NumberPropertiesOnly
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.10.0-SNAPSHOT")
public class NumberPropertiesOnly {
  public static final String SERIALIZED_NAME_NUMBER = "number";
  @SerializedName(SERIALIZED_NAME_NUMBER)
  @javax.annotation.Nullable
  private BigDecimal number;

  public static final String SERIALIZED_NAME_FLOAT = "float";
  @SerializedName(SERIALIZED_NAME_FLOAT)
  @javax.annotation.Nullable
  private Float _float;

  public static final String SERIALIZED_NAME_DOUBLE = "double";
  @SerializedName(SERIALIZED_NAME_DOUBLE)
  @javax.annotation.Nullable
  private Double _double;

  public NumberPropertiesOnly() {
  }

  public NumberPropertiesOnly number(@javax.annotation.Nullable BigDecimal number) {
    
    this.number = number;
    return this;
  }

  /**
   * Get number
   * @return number
   */
  @javax.annotation.Nullable

  public BigDecimal getNumber() {
    return number;
  }


  public void setNumber(@javax.annotation.Nullable BigDecimal number) {
    this.number = number;
  }


  public NumberPropertiesOnly _float(@javax.annotation.Nullable Float _float) {
    
    this._float = _float;
    return this;
  }

  /**
   * Get _float
   * @return _float
   */
  @javax.annotation.Nullable

  public Float getFloat() {
    return _float;
  }


  public void setFloat(@javax.annotation.Nullable Float _float) {
    this._float = _float;
  }


  public NumberPropertiesOnly _double(@javax.annotation.Nullable Double _double) {
    
    this._double = _double;
    return this;
  }

  /**
   * Get _double
   * minimum: 0.8
   * maximum: 50.2
   * @return _double
   */
  @javax.annotation.Nullable

  public Double getDouble() {
    return _double;
  }


  public void setDouble(@javax.annotation.Nullable Double _double) {
    this._double = _double;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NumberPropertiesOnly numberPropertiesOnly = (NumberPropertiesOnly) o;
    return Objects.equals(this.number, numberPropertiesOnly.number) &&
        Objects.equals(this._float, numberPropertiesOnly._float) &&
        Objects.equals(this._double, numberPropertiesOnly._double);
  }

  @Override
  public int hashCode() {
    return Objects.hash(number, _float, _double);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NumberPropertiesOnly {\n");
    sb.append("    number: ").append(toIndentedString(number)).append("\n");
    sb.append("    _float: ").append(toIndentedString(_float)).append("\n");
    sb.append("    _double: ").append(toIndentedString(_double)).append("\n");
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

