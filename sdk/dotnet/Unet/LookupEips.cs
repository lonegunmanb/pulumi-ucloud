// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ucloud.unet
{
    public static partial class Invokes
    {
        /// <summary>
        /// This data source provides a list of EIP resources (Elastic IP address) according to their EIP ID.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/eips.html.markdown.
        /// </summary>
        public static Task<LookupEipsResult> LookupEips(LookupEipsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<LookupEipsResult>("ucloud:unet/lookupEips:lookupEips", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class LookupEipsArgs : Pulumi.InvokeArgs
    {
        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Elastic IP IDs, all the EIPs belong to this region will be retrieved if the ID is `""`.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter resulting eips by name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        public LookupEipsArgs()
        {
        }
    }

    [OutputType]
    public sealed class LookupEipsResult
    {
        /// <summary>
        /// It is a nested type which documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.LookupEipsEipsResult> Eips;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly string? OutputFile;
        /// <summary>
        /// Total number of Elastic IPs that satisfy the condition.
        /// </summary>
        public readonly int TotalCount;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private LookupEipsResult(
            ImmutableArray<Outputs.LookupEipsEipsResult> eips,
            ImmutableArray<string> ids,
            string? nameRegex,
            string? outputFile,
            int totalCount,
            string id)
        {
            Eips = eips;
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
    public sealed class LookupEipsEipsIpSetsResult
    {
        /// <summary>
        /// Type of Elastic IP routes.
        /// </summary>
        public readonly string InternetType;
        /// <summary>
        /// Elastic IP address.
        /// </summary>
        public readonly string Ip;

        [OutputConstructor]
        private LookupEipsEipsIpSetsResult(
            string internetType,
            string ip)
        {
            InternetType = internetType;
            Ip = ip;
        }
    }

    [OutputType]
    public sealed class LookupEipsEipsResult
    {
        /// <summary>
        /// Maximum bandwidth to the elastic public network, measured in Mbps.
        /// </summary>
        public readonly int Bandwidth;
        /// <summary>
        /// The charge mode of Elastic IP. Possible values are: `traffic` as pay by traffic, `bandwidth` as pay by bandwidth.
        /// </summary>
        public readonly string ChargeMode;
        /// <summary>
        /// The charge type of Elastic IP. Possible values are: `year` as pay by year, `month` as pay by month, `dynamic` as pay by hour.
        /// </summary>
        public readonly string ChargeType;
        /// <summary>
        /// The creation time of Elastic IP, formatted in RFC3339 time string.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The expiration time for Elastic IP, formatted in RFC3339 time string.
        /// </summary>
        public readonly string ExpireTime;
        /// <summary>
        /// It is a nested type which documented below.
        /// </summary>
        public readonly ImmutableArray<LookupEipsEipsIpSetsResult> IpSets;
        /// <summary>
        /// The name of Elastic IP.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The remarks of Elastic IP.
        /// </summary>
        public readonly string Remark;
        /// <summary>
        /// Elastic IP status. Possible values are: `used` as in use, `free` as available and `freeze` as associating.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// A tag assigned to Elastic IP.
        /// </summary>
        public readonly string Tag;

        [OutputConstructor]
        private LookupEipsEipsResult(
            int bandwidth,
            string chargeMode,
            string chargeType,
            string createTime,
            string expireTime,
            ImmutableArray<LookupEipsEipsIpSetsResult> ipSets,
            string name,
            string remark,
            string status,
            string tag)
        {
            Bandwidth = bandwidth;
            ChargeMode = chargeMode;
            ChargeType = chargeType;
            CreateTime = createTime;
            ExpireTime = expireTime;
            IpSets = ipSets;
            Name = name;
            Remark = remark;
            Status = status;
            Tag = tag;
        }
    }
    }
}
