# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LookupVpcsResult:
    """
    A collection of values returned by lookupVpcs.
    """
    def __init__(__self__, ids=None, name_regex=None, output_file=None, tag=None, total_count=None, vpcs=None, id=None):
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        __self__.ids = ids
        if name_regex and not isinstance(name_regex, str):
            raise TypeError("Expected argument 'name_regex' to be a str")
        __self__.name_regex = name_regex
        if output_file and not isinstance(output_file, str):
            raise TypeError("Expected argument 'output_file' to be a str")
        __self__.output_file = output_file
        if tag and not isinstance(tag, str):
            raise TypeError("Expected argument 'tag' to be a str")
        __self__.tag = tag
        """
        A tag assigned to VPC.
        """
        if total_count and not isinstance(total_count, float):
            raise TypeError("Expected argument 'total_count' to be a float")
        __self__.total_count = total_count
        """
        Total number of VPC resources that satisfy the condition.
        """
        if vpcs and not isinstance(vpcs, list):
            raise TypeError("Expected argument 'vpcs' to be a list")
        __self__.vpcs = vpcs
        """
        It is a nested type which documented below.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableLookupVpcsResult(LookupVpcsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return LookupVpcsResult(
            ids=self.ids,
            name_regex=self.name_regex,
            output_file=self.output_file,
            tag=self.tag,
            total_count=self.total_count,
            vpcs=self.vpcs,
            id=self.id)

def lookup_vpcs(ids=None,name_regex=None,output_file=None,tag=None,opts=None):
    """
    This data source provides a list of VPC resources according to their VPC ID, name.
    
    :param list ids: A list of VPC IDs, all the VPC resources belong to this region will be retrieved if the ID is `""`.
    :param str name_regex: A regex string to filter resulting VPC resources by name.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/vpcs.html.markdown.
    """
    __args__ = dict()

    __args__['ids'] = ids
    __args__['nameRegex'] = name_regex
    __args__['outputFile'] = output_file
    __args__['tag'] = tag
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('ucloud:vpc/lookupVpcs:lookupVpcs', __args__, opts=opts).value

    return AwaitableLookupVpcsResult(
        ids=__ret__.get('ids'),
        name_regex=__ret__.get('nameRegex'),
        output_file=__ret__.get('outputFile'),
        tag=__ret__.get('tag'),
        total_count=__ret__.get('totalCount'),
        vpcs=__ret__.get('vpcs'),
        id=__ret__.get('id'))
