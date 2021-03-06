// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ucloud.umem
{
    /// <summary>
    /// The UCloud Redis instance is a key-value online storage service compatible with the Redis protocol.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/r/redis_instance.html.markdown.
    /// </summary>
    public partial class RedisInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// Availability zone where Redis instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// The charge type of Redis instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Output("chargeType")]
        public Output<string> ChargeType { get; private set; } = null!;

        /// <summary>
        /// The creation time of Redis instance, formatted by RFC3339 time string.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// The duration that you will buy the Redis instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Output("duration")]
        public Output<int?> Duration { get; private set; } = null!;

        /// <summary>
        /// The version of engine of active-standby Redis. Possible values are: 3.0, 3.2 and 4.0.
        /// </summary>
        [Output("engineVersion")]
        public Output<string> EngineVersion { get; private set; } = null!;

        /// <summary>
        /// The expiration time of Redis instance, formatted by RFC3339 time string.
        /// </summary>
        [Output("expireTime")]
        public Output<string> ExpireTime { get; private set; } = null!;

        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// ip_set is a nested type. ip_set documented below.
        /// </summary>
        [Output("ipSets")]
        public Output<ImmutableArray<Outputs.RedisInstanceIpSets>> IpSets { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password for  active-standby Redis instance which should have 6-36 characters. It must contain at least 3 items of Capital letters, small letter, numbers and special characters. The special characters include `-_`. 
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The status of KV Redis instance.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The ID of subnet linked to the Redis instance.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// A tag assigned to Redis instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Output("tag")]
        public Output<string> Tag { get; private set; } = null!;

        /// <summary>
        /// The ID of VPC linked to the Redis instance.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a RedisInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RedisInstance(string name, RedisInstanceArgs args, CustomResourceOptions? options = null)
            : base("ucloud:umem/redisInstance:RedisInstance", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private RedisInstance(string name, Input<string> id, RedisInstanceState? state = null, CustomResourceOptions? options = null)
            : base("ucloud:umem/redisInstance:RedisInstance", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RedisInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RedisInstance Get(string name, Input<string> id, RedisInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new RedisInstance(name, id, state, options);
        }
    }

    public sealed class RedisInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Availability zone where Redis instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        /// <summary>
        /// The charge type of Redis instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// The duration that you will buy the Redis instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Input("duration")]
        public Input<int>? Duration { get; set; }

        /// <summary>
        /// The version of engine of active-standby Redis. Possible values are: 3.0, 3.2 and 4.0.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password for  active-standby Redis instance which should have 6-36 characters. It must contain at least 3 items of Capital letters, small letter, numbers and special characters. The special characters include `-_`. 
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The ID of subnet linked to the Redis instance.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// A tag assigned to Redis instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// The ID of VPC linked to the Redis instance.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public RedisInstanceArgs()
        {
        }
    }

    public sealed class RedisInstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Availability zone where Redis instance is located. Such as: "cn-bj2-02". You may refer to [list of availability zone](https://docs.ucloud.cn/api/summary/regionlist)
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// The charge type of Redis instance, possible values are: `year`, `month` and `dynamic` as pay by hour (specific permission required). (Default: `month`).
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// The creation time of Redis instance, formatted by RFC3339 time string.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// The duration that you will buy the Redis instance (Default: `1`). The value is `0` when pay by month and the instance will be valid till the last day of that month. It is not required when `dynamic` (pay by hour).
        /// </summary>
        [Input("duration")]
        public Input<int>? Duration { get; set; }

        /// <summary>
        /// The version of engine of active-standby Redis. Possible values are: 3.0, 3.2 and 4.0.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        /// <summary>
        /// The expiration time of Redis instance, formatted by RFC3339 time string.
        /// </summary>
        [Input("expireTime")]
        public Input<string>? ExpireTime { get; set; }

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("ipSets")]
        private InputList<Inputs.RedisInstanceIpSetsGetArgs>? _ipSets;

        /// <summary>
        /// ip_set is a nested type. ip_set documented below.
        /// </summary>
        public InputList<Inputs.RedisInstanceIpSetsGetArgs> IpSets
        {
            get => _ipSets ?? (_ipSets = new InputList<Inputs.RedisInstanceIpSetsGetArgs>());
            set => _ipSets = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password for  active-standby Redis instance which should have 6-36 characters. It must contain at least 3 items of Capital letters, small letter, numbers and special characters. The special characters include `-_`. 
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The status of KV Redis instance.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The ID of subnet linked to the Redis instance.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// A tag assigned to Redis instance, which contains at most 63 characters and only support Chinese, English, numbers, '-', '_', and '.'. If it is not filled in or a empty string is filled in, then default tag will be assigned. (Default: `Default`).
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// The ID of VPC linked to the Redis instance.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public RedisInstanceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class RedisInstanceIpSetsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The virtual ip of Redis instance.
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        /// <summary>
        /// The port on which Redis instance accepts connections, it is 6379 by default.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        public RedisInstanceIpSetsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class RedisInstanceIpSets
    {
        /// <summary>
        /// The virtual ip of Redis instance.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// The port on which Redis instance accepts connections, it is 6379 by default.
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private RedisInstanceIpSets(
            string ip,
            int port)
        {
            Ip = ip;
            Port = port;
        }
    }
    }
}
