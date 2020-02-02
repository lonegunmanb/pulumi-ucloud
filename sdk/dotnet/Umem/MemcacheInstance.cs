// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ucloud.umem
{
    /// <summary>
    /// The UCloud Memcache instance is a key-value online storage service compatible with the Memcached protocol.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/r/memcache_instance.html.markdown.
    /// </summary>
    public partial class MemcacheInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// Availability zone where Memcache instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// The charge type of Memcache instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Output("chargeType")]
        public Output<string> ChargeType { get; private set; } = null!;

        /// <summary>
        /// The creation time of Memcache instance, formatted by RFC3339 time string.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// The duration that you will buy the Memcache instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Output("duration")]
        public Output<int?> Duration { get; private set; } = null!;

        /// <summary>
        /// The expiration time of Memcache instance, formatted by RFC3339 time string.
        /// </summary>
        [Output("expireTime")]
        public Output<string> ExpireTime { get; private set; } = null!;

        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// ip_set is a nested type. ip_set documented below.
        /// </summary>
        [Output("ipSets")]
        public Output<ImmutableArray<Outputs.MemcacheInstanceIpSets>> IpSets { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The status of KV Memcache instance.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The ID of subnet linked to the Memcache instance.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// A tag assigned to Memcache instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Output("tag")]
        public Output<string> Tag { get; private set; } = null!;

        /// <summary>
        /// The ID of VPC linked to the Memcache instance.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a MemcacheInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MemcacheInstance(string name, MemcacheInstanceArgs args, CustomResourceOptions? options = null)
            : base("ucloud:umem/memcacheInstance:MemcacheInstance", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private MemcacheInstance(string name, Input<string> id, MemcacheInstanceState? state = null, CustomResourceOptions? options = null)
            : base("ucloud:umem/memcacheInstance:MemcacheInstance", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MemcacheInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MemcacheInstance Get(string name, Input<string> id, MemcacheInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new MemcacheInstance(name, id, state, options);
        }
    }

    public sealed class MemcacheInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Availability zone where Memcache instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        /// <summary>
        /// The charge type of Memcache instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// The duration that you will buy the Memcache instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Input("duration")]
        public Input<int>? Duration { get; set; }

        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of subnet linked to the Memcache instance.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// A tag assigned to Memcache instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// The ID of VPC linked to the Memcache instance.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public MemcacheInstanceArgs()
        {
        }
    }

    public sealed class MemcacheInstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Availability zone where Memcache instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// The charge type of Memcache instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// The creation time of Memcache instance, formatted by RFC3339 time string.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// The duration that you will buy the Memcache instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Input("duration")]
        public Input<int>? Duration { get; set; }

        /// <summary>
        /// The expiration time of Memcache instance, formatted by RFC3339 time string.
        /// </summary>
        [Input("expireTime")]
        public Input<string>? ExpireTime { get; set; }

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("ipSets")]
        private InputList<Inputs.MemcacheInstanceIpSetsGetArgs>? _ipSets;

        /// <summary>
        /// ip_set is a nested type. ip_set documented below.
        /// </summary>
        public InputList<Inputs.MemcacheInstanceIpSetsGetArgs> IpSets
        {
            get => _ipSets ?? (_ipSets = new InputList<Inputs.MemcacheInstanceIpSetsGetArgs>());
            set => _ipSets = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The status of KV Memcache instance.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The ID of subnet linked to the Memcache instance.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// A tag assigned to Memcache instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// The ID of VPC linked to the Memcache instance.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public MemcacheInstanceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class MemcacheInstanceIpSetsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The virtual ip of Memcache instance.
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        /// <summary>
        /// The port on which Memcache instance accepts connections, it is 6379 by default.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        public MemcacheInstanceIpSetsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class MemcacheInstanceIpSets
    {
        /// <summary>
        /// The virtual ip of Memcache instance.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// The port on which Memcache instance accepts connections, it is 6379 by default.
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private MemcacheInstanceIpSets(
            string ip,
            int port)
        {
            Ip = ip;
            Port = port;
        }
    }
    }
}