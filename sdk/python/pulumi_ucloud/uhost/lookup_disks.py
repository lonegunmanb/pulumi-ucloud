# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LookupDisksResult:
    """
    A collection of values returned by lookupDisks.
    """
    def __init__(__self__, availability_zone=None, disk_type=None, disks=None, ids=None, name_regex=None, output_file=None, total_count=None, id=None):
        if availability_zone and not isinstance(availability_zone, str):
            raise TypeError("Expected argument 'availability_zone' to be a str")
        __self__.availability_zone = availability_zone
        """
        Availability zone where disk is located.
        """
        if disk_type and not isinstance(disk_type, str):
            raise TypeError("Expected argument 'disk_type' to be a str")
        __self__.disk_type = disk_type
        """
        The type of disk.
        """
        if disks and not isinstance(disks, list):
            raise TypeError("Expected argument 'disks' to be a list")
        __self__.disks = disks
        """
        It is a nested type which documented below.
        """
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        __self__.ids = ids
        if name_regex and not isinstance(name_regex, str):
            raise TypeError("Expected argument 'name_regex' to be a str")
        __self__.name_regex = name_regex
        if output_file and not isinstance(output_file, str):
            raise TypeError("Expected argument 'output_file' to be a str")
        __self__.output_file = output_file
        if total_count and not isinstance(total_count, float):
            raise TypeError("Expected argument 'total_count' to be a float")
        __self__.total_count = total_count
        """
        Total number of Disks that satisfy the condition.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableLookupDisksResult(LookupDisksResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return LookupDisksResult(
            availability_zone=self.availability_zone,
            disk_type=self.disk_type,
            disks=self.disks,
            ids=self.ids,
            name_regex=self.name_regex,
            output_file=self.output_file,
            total_count=self.total_count,
            id=self.id)

def lookup_disks(availability_zone=None,disk_type=None,ids=None,name_regex=None,output_file=None,opts=None):
    """
    This data source provides a list of Disk resources according to their Disk ID and disk type.
    
    :param str availability_zone: Availability zone where Disk are located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
    :param str disk_type: The type of disk. Possible values are: `data_disk`as cloud disk, `ssd_data_disk` as SSD cloud disk, `system_disk`as system disk, `ssd_system_disk` as SSD system disk, `rssd_data_disk` as RDMA-SSD cloud disk. 
    :param list ids: A list of Disk IDs, all the Disks belong to this region will be retrieved if the ID is `""`.
    :param str name_regex: A regex string to filter resulting disks by name.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/disks.html.markdown.
    """
    __args__ = dict()

    __args__['availabilityZone'] = availability_zone
    __args__['diskType'] = disk_type
    __args__['ids'] = ids
    __args__['nameRegex'] = name_regex
    __args__['outputFile'] = output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('ucloud:uhost/lookupDisks:lookupDisks', __args__, opts=opts).value

    return AwaitableLookupDisksResult(
        availability_zone=__ret__.get('availabilityZone'),
        disk_type=__ret__.get('diskType'),
        disks=__ret__.get('disks'),
        ids=__ret__.get('ids'),
        name_regex=__ret__.get('nameRegex'),
        output_file=__ret__.get('outputFile'),
        total_count=__ret__.get('totalCount'),
        id=__ret__.get('id'))
