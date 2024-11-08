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

package org.openapitools.client.apis

import io.kotlintest.shouldBe
import io.kotlintest.specs.ShouldSpec

import org.openapitools.client.apis.PetApi
import org.openapitools.client.models.ModelApiResponse
import org.openapitools.client.models.Pet

class PetApiTest : ShouldSpec() {
    init {
        // uncomment below to create an instance of PetApi
        //val apiInstance = PetApi()

        // to test addPet
        should("test addPet") {
            // uncomment below to test addPet
            //val body : Pet =  // Pet | Pet object that needs to be added to the store
            //apiInstance.addPet(body)
        }

        // to test deletePet
        should("test deletePet") {
            // uncomment below to test deletePet
            //val petId : kotlin.Long = 789 // kotlin.Long | Pet id to delete
            //val apiKey : kotlin.String = apiKey_example // kotlin.String | 
            //apiInstance.deletePet(petId, apiKey)
        }

        // to test findPetsByStatus
        should("test findPetsByStatus") {
            // uncomment below to test findPetsByStatus
            //val status : kotlin.collections.List<kotlin.String> =  // kotlin.collections.List<kotlin.String> | Status values that need to be considered for filter
            //val result : kotlin.collections.List<Pet> = apiInstance.findPetsByStatus(status)
            //result shouldBe ("TODO")
        }

        // to test findPetsByTags
        should("test findPetsByTags") {
            // uncomment below to test findPetsByTags
            //val tags : kotlin.collections.List<kotlin.String> =  // kotlin.collections.List<kotlin.String> | Tags to filter by
            //val result : kotlin.collections.List<Pet> = apiInstance.findPetsByTags(tags)
            //result shouldBe ("TODO")
        }

        // to test getPetById
        should("test getPetById") {
            // uncomment below to test getPetById
            //val petId : kotlin.Long = 789 // kotlin.Long | ID of pet to return
            //val result : Pet = apiInstance.getPetById(petId)
            //result shouldBe ("TODO")
        }

        // to test updatePet
        should("test updatePet") {
            // uncomment below to test updatePet
            //val body : Pet =  // Pet | Pet object that needs to be added to the store
            //apiInstance.updatePet(body)
        }

        // to test updatePetWithForm
        should("test updatePetWithForm") {
            // uncomment below to test updatePetWithForm
            //val petId : kotlin.Long = 789 // kotlin.Long | ID of pet that needs to be updated
            //val name : kotlin.String = name_example // kotlin.String | Updated name of the pet
            //val status : kotlin.String = status_example // kotlin.String | Updated status of the pet
            //apiInstance.updatePetWithForm(petId, name, status)
        }

        // to test uploadFile
        should("test uploadFile") {
            // uncomment below to test uploadFile
            //val petId : kotlin.Long = 789 // kotlin.Long | ID of pet to update
            //val additionalMetadata : kotlin.String = additionalMetadata_example // kotlin.String | Additional data to pass to server
            //val file : io.ktor.client.request.forms.InputProvider = BINARY_DATA_HERE // io.ktor.client.request.forms.InputProvider | file to upload
            //val result : ModelApiResponse = apiInstance.uploadFile(petId, additionalMetadata, file)
            //result shouldBe ("TODO")
        }

    }
}
