# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""


import unittest
import datetime

import petstore_api
from petstore_api.models.additional_properties_class import AdditionalPropertiesClass  # noqa: E501
from petstore_api.rest import ApiException

class TestAdditionalPropertiesClass(unittest.TestCase):
    """AdditionalPropertiesClass unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test AdditionalPropertiesClass
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `AdditionalPropertiesClass`
        """
        model = petstore_api.models.additional_properties_class.AdditionalPropertiesClass()  # noqa: E501
        if include_optional :
            return AdditionalPropertiesClass(
                map_property = {
                    'key' : ''
                    }, 
                map_of_map_property = {
                    'key' : {
                        'key' : ''
                        }
                    }
            )
        else :
            return AdditionalPropertiesClass(
        )
        """

    def testAdditionalPropertiesClass(self):
        """Test AdditionalPropertiesClass"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
