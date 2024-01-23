/*
OpenAPI Petstore

This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

API version: 1.0.0
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package petstore

import (
	"encoding/json"
)

// checks if the ClassModel type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ClassModel{}

// ClassModel Model for testing model with \"_class\" property
type ClassModel struct {
	Class *string `json:"_class,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _ClassModel ClassModel

// NewClassModel instantiates a new ClassModel object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewClassModel() *ClassModel {
	this := ClassModel{}
	return &this
}

// NewClassModelWithDefaults instantiates a new ClassModel object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewClassModelWithDefaults() *ClassModel {
	this := ClassModel{}
	return &this
}

// GetClass returns the Class field value if set, zero value otherwise.
func (o *ClassModel) GetClass() string {
	if o == nil || IsNil(o.Class) {
		var ret string
		return ret
	}
	return *o.Class
}

// GetClassOk returns a tuple with the Class field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ClassModel) GetClassOk() (*string, bool) {
	if o == nil || IsNil(o.Class) {
		return nil, false
	}
	return o.Class, true
}

// HasClass returns a boolean if a field has been set.
func (o *ClassModel) HasClass() bool {
	if o != nil && !IsNil(o.Class) {
		return true
	}

	return false
}

// SetClass gets a reference to the given string and assigns it to the Class field.
func (o *ClassModel) SetClass(v string) {
	o.Class = &v
}

func (o ClassModel) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ClassModel) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Class) {
		toSerialize["_class"] = o.Class
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ClassModel) UnmarshalJSON(data []byte) (err error) {
	varClassModel := _ClassModel{}

	err = json.Unmarshal(data, &varClassModel)

	if err != nil {
		return err
	}

	*o = ClassModel(varClassModel)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "_class")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableClassModel struct {
	value *ClassModel
	isSet bool
}

func (v NullableClassModel) Get() *ClassModel {
	return v.value
}

func (v *NullableClassModel) Set(val *ClassModel) {
	v.value = val
	v.isSet = true
}

func (v NullableClassModel) IsSet() bool {
	return v.isSet
}

func (v *NullableClassModel) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableClassModel(val *ClassModel) *NullableClassModel {
	return &NullableClassModel{value: val, isSet: true}
}

func (v NullableClassModel) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableClassModel) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


