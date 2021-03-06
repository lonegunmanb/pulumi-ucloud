# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LookupSubnetsResult:
    """
    A collection of values returned by lookupSubnets.
    """
    def __init__(__self__, ids=None, name_regex=None, output_file=None, subnets=None, tag=None, total_count=None, vpc_id=None, id=None):
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        __self__.ids = ids
        if name_regex and not isinstance(name_regex, str):
            raise TypeError("Expected argument 'name_regex' to be a str")
        __self__.name_regex = name_regex
        if output_file and not isinstance(output_file, str):
            raise TypeError("Expected argument 'output_file' to be a str")
        __self__.output_file = output_file
        if subnets and not isinstance(subnets, list):
            raise TypeError("Expected argument 'subnets' to be a list")
        __self__.subnets = subnets
        """
        It is a nested type which documented below.
        """
        if tag and not isinstance(tag, str):
            raise TypeError("Expected argument 'tag' to be a str")
        __self__.tag = tag
        """
        A tag assigned to Subnet.
        """
        if total_count and not isinstance(total_count, float):
            raise TypeError("Expected argument 'total_count' to be a float")
        __self__.total_count = total_count
        """
        Total number of Subnet resources that satisfy the condition.
        """
        if vpc_id and not isinstance(vpc_id, str):
            raise TypeError("Expected argument 'vpc_id' to be a str")
        __self__.vpc_id = vpc_id
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableLookupSubnetsResult(LookupSubnetsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return LookupSubnetsResult(
            ids=self.ids,
            name_regex=self.name_regex,
            output_file=self.output_file,
            subnets=self.subnets,
            tag=self.tag,
            total_count=self.total_count,
            vpc_id=self.vpc_id,
            id=self.id)

def lookup_subnets(ids=None,name_regex=None,output_file=None,tag=None,vpc_id=None,opts=None):
    """
    This data source provides a list of Subnet resources according to their Subnet ID, name and the VPC they belong to.
    
    :param list ids: A list of Subnet IDs, all the Subnet resources belong to this region will be retrieved if the ID is `""`.
    :param str name_regex: A regex string to filter resulting Subnet resources by name.
    :param str vpc_id: The id of the VPC that the desired Subnet belongs to.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/subnets.html.markdown.
    """
    __args__ = dict()

    __args__['ids'] = ids
    __args__['nameRegex'] = name_regex
    __args__['outputFile'] = output_file
    __args__['tag'] = tag
    __args__['vpcId'] = vpc_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('ucloud:vpc/lookupSubnets:lookupSubnets', __args__, opts=opts).value

    return AwaitableLookupSubnetsResult(
        ids=__ret__.get('ids'),
        name_regex=__ret__.get('nameRegex'),
        output_file=__ret__.get('outputFile'),
        subnets=__ret__.get('subnets'),
        tag=__ret__.get('tag'),
        total_count=__ret__.get('totalCount'),
        vpc_id=__ret__.get('vpcId'),
        id=__ret__.get('id'))
