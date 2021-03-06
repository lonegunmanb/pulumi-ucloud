// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ucloud.uhost
{
    public static partial class Invokes
    {
        /// <summary>
        /// This data source provides a list of Disk resources according to their Disk ID and disk type.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/disks.html.markdown.
        /// </summary>
        public static Task<LookupDisksResult> LookupDisks(LookupDisksArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<LookupDisksResult>("ucloud:uhost/lookupDisks:lookupDisks", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class LookupDisksArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Availability zone where Disk are located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        /// <summary>
        /// The type of disk. Possible values are: `data_disk`as cloud disk, `ssd_data_disk` as SSD cloud disk, `system_disk`as system disk, `ssd_system_disk` as SSD system disk, `rssd_data_disk` as RDMA-SSD cloud disk. 
        /// </summary>
        [Input("diskType")]
        public string? DiskType { get; set; }

        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Disk IDs, all the Disks belong to this region will be retrieved if the ID is `""`.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter resulting disks by name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        public LookupDisksArgs()
        {
        }
    }

    [OutputType]
    public sealed class LookupDisksResult
    {
        /// <summary>
        /// Availability zone where disk is located.
        /// </summary>
        public readonly string? AvailabilityZone;
        /// <summary>
        /// The type of disk.
        /// </summary>
        public readonly string? DiskType;
        /// <summary>
        /// It is a nested type which documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.LookupDisksDisksResult> Disks;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly string? OutputFile;
        /// <summary>
        /// Total number of Disks that satisfy the condition.
        /// </summary>
        public readonly int TotalCount;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private LookupDisksResult(
            string? availabilityZone,
            string? diskType,
            ImmutableArray<Outputs.LookupDisksDisksResult> disks,
            ImmutableArray<string> ids,
            string? nameRegex,
            string? outputFile,
            int totalCount,
            string id)
        {
            AvailabilityZone = availabilityZone;
            DiskType = diskType;
            Disks = disks;
            Ids = ids;
            NameRegex = nameRegex;
            OutputFile = outputFile;
            TotalCount = totalCount;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class LookupDisksDisksResult
    {
        /// <summary>
        /// Availability zone where Disk are located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        public readonly string AvailabilityZone;
        /// <summary>
        /// The charge type of disk. Possible values are: `year` as pay by year, `month` as pay by month, `dynamic` as pay by hour.
        /// </summary>
        public readonly string ChargeType;
        /// <summary>
        /// The creation time of Disk, formatted in RFC3339 time string.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The size of disk. Purchase the size of disk in GB.
        /// </summary>
        public readonly int DiskSize;
        /// <summary>
        /// The type of disk. Possible values are: `data_disk`as cloud disk, `ssd_data_disk` as SSD cloud disk, `system_disk`as system disk, `ssd_system_disk` as SSD system disk, `rssd_data_disk` as RDMA-SSD cloud disk. 
        /// </summary>
        public readonly string DiskType;
        /// <summary>
        /// The expiration time of disk, formatted in RFC3339 time string.
        /// </summary>
        public readonly string ExpireTime;
        /// <summary>
        /// The ID of Disk.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of Disk.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The status of disk. Possible values are: `Available`, `InUse`, `Detaching`, `Initializating`, `Failed`, `Cloning`, `Restoring`, `RestoreFailed`.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// A tag assigned to Disk.
        /// </summary>
        public readonly string Tag;

        [OutputConstructor]
        private LookupDisksDisksResult(
            string availabilityZone,
            string chargeType,
            string createTime,
            int diskSize,
            string diskType,
            string expireTime,
            string id,
            string name,
            string status,
            string tag)
        {
            AvailabilityZone = availabilityZone;
            ChargeType = chargeType;
            CreateTime = createTime;
            DiskSize = diskSize;
            DiskType = diskType;
            ExpireTime = expireTime;
            Id = id;
            Name = name;
            Status = status;
            Tag = tag;
        }
    }
    }
}
