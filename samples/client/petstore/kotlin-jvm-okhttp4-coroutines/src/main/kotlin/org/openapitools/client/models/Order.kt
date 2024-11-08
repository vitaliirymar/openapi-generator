/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.models


import com.google.gson.annotations.SerializedName
import java.io.Serializable

/**
 * An order for a pets from the pet store
 *
 * @param id 
 * @param petId 
 * @param quantity 
 * @param shipDate 
 * @param status Order Status
 * @param complete 
 */


data class Order (

    @SerializedName("id")
    val id: kotlin.Long? = null,

    @SerializedName("petId")
    val petId: kotlin.Long? = null,

    @SerializedName("quantity")
    val quantity: kotlin.Int? = null,

    @SerializedName("shipDate")
    val shipDate: java.time.OffsetDateTime? = null,

    /* Order Status */
    @SerializedName("status")
    val status: Order.Status? = null,

    @SerializedName("complete")
    val complete: kotlin.Boolean? = false

) : Serializable {
    companion object {
        private const val serialVersionUID: Long = 123
    }

    /**
     * Order Status
     *
     * Values: placed,approved,delivered
     */
    enum class Status(val value: kotlin.String) {
        @SerializedName(value = "placed") placed("placed"),
        @SerializedName(value = "approved") approved("approved"),
        @SerializedName(value = "delivered") delivered("delivered");
    }

}

