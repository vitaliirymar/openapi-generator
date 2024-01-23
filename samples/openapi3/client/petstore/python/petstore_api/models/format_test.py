# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

    The version of the OpenAPI document: 1.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import date, datetime
from decimal import Decimal
from pydantic import BaseModel, Field, StrictBytes, StrictInt, StrictStr, field_validator
from typing import Any, ClassVar, Dict, List, Optional, Union
from typing_extensions import Annotated
from typing import Optional, Set
from typing_extensions import Self

class FormatTest(BaseModel):
    """
    FormatTest
    """ # noqa: E501
    integer: Optional[Annotated[int, Field(le=100, strict=True, ge=10)]] = None
    int32: Optional[Annotated[int, Field(le=200, strict=True, ge=20)]] = None
    int64: Optional[StrictInt] = None
    number: Annotated[float, Field(le=543.2, strict=True, ge=32.1)]
    var_float: Optional[Annotated[float, Field(le=987.6, strict=True, ge=54.3)]] = Field(default=None, alias="float")
    double: Optional[Annotated[float, Field(le=123.4, strict=True, ge=67.8)]] = None
    decimal: Optional[Decimal] = None
    string: Optional[Annotated[str, Field(strict=True)]] = None
    string_with_double_quote_pattern: Optional[Annotated[str, Field(strict=True)]] = None
    byte: Optional[Union[StrictBytes, StrictStr]] = None
    binary: Optional[Union[StrictBytes, StrictStr]] = None
    var_date: date = Field(alias="date")
    date_time: Optional[datetime] = Field(default=None, alias="dateTime")
    uuid: Optional[StrictStr] = None
    password: Annotated[str, Field(min_length=10, strict=True, max_length=64)]
    pattern_with_digits: Optional[Annotated[str, Field(strict=True)]] = Field(default=None, description="A string that is a 10 digit number. Can have leading zeros.")
    pattern_with_digits_and_delimiter: Optional[Annotated[str, Field(strict=True)]] = Field(default=None, description="A string starting with 'image_' (case insensitive) and one to three digits following i.e. Image_01.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["integer", "int32", "int64", "number", "float", "double", "decimal", "string", "string_with_double_quote_pattern", "byte", "binary", "date", "dateTime", "uuid", "password", "pattern_with_digits", "pattern_with_digits_and_delimiter"]

    @field_validator('string')
    def string_validate_regular_expression(cls, value):
        """Validates the regular expression"""
        if value is None:
            return value

        if not re.match(r"[a-z]", value ,re.IGNORECASE):
            raise ValueError(r"must validate the regular expression /[a-z]/i")
        return value

    @field_validator('string_with_double_quote_pattern')
    def string_with_double_quote_pattern_validate_regular_expression(cls, value):
        """Validates the regular expression"""
        if value is None:
            return value

        if not re.match(r"this is \"something\"", value):
            raise ValueError(r"must validate the regular expression /this is \"something\"/")
        return value

    @field_validator('pattern_with_digits')
    def pattern_with_digits_validate_regular_expression(cls, value):
        """Validates the regular expression"""
        if value is None:
            return value

        if not re.match(r"^\d{10}$", value):
            raise ValueError(r"must validate the regular expression /^\d{10}$/")
        return value

    @field_validator('pattern_with_digits_and_delimiter')
    def pattern_with_digits_and_delimiter_validate_regular_expression(cls, value):
        """Validates the regular expression"""
        if value is None:
            return value

        if not re.match(r"^image_\d{1,3}$", value ,re.IGNORECASE):
            raise ValueError(r"must validate the regular expression /^image_\d{1,3}$/i")
        return value

    model_config = {
        "populate_by_name": True,
        "validate_assignment": True,
        "protected_namespaces": (),
    }


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of FormatTest from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of FormatTest from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "integer": obj.get("integer"),
            "int32": obj.get("int32"),
            "int64": obj.get("int64"),
            "number": obj.get("number"),
            "float": obj.get("float"),
            "double": obj.get("double"),
            "decimal": obj.get("decimal"),
            "string": obj.get("string"),
            "string_with_double_quote_pattern": obj.get("string_with_double_quote_pattern"),
            "byte": obj.get("byte"),
            "binary": obj.get("binary"),
            "date": obj.get("date"),
            "dateTime": obj.get("dateTime"),
            "uuid": obj.get("uuid"),
            "password": obj.get("password"),
            "pattern_with_digits": obj.get("pattern_with_digits"),
            "pattern_with_digits_and_delimiter": obj.get("pattern_with_digits_and_delimiter")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


