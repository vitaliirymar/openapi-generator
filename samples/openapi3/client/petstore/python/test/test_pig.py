# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import petstore_api
from petstore_api.models.pig import Pig  # noqa: E501
from petstore_api.rest import ApiException

class TestPig(unittest.TestCase):
    """Pig unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testPig(self):
        """Test Pig"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
