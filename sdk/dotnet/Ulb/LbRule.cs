// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ucloud.ulb
{
    /// <summary>
    /// Provides a Load Balancer Rule resource to add content forwarding policies for Load Balancer backend resource.
    ///  
    /// &gt; **Note** The Load Balancer Rule can only be define while the `protocol` of lb listener is one of HTTP and HTTPS. In addition, should set one of `domain` and `path` if defined.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/r/lb_rule.html.markdown.
    /// </summary>
    public partial class LbRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The IDs of the backend servers where rule applies, this argument is populated base on the `backend_id` responded from `lb_attachment` create.
        /// </summary>
        [Output("backendIds")]
        public Output<ImmutableArray<string>> BackendIds { get; private set; } = null!;

        /// <summary>
        /// The domain of content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Output("domain")]
        public Output<string?> Domain { get; private set; } = null!;

        /// <summary>
        /// The ID of a listener server.
        /// </summary>
        [Output("listenerId")]
        public Output<string> ListenerId { get; private set; } = null!;

        /// <summary>
        /// The ID of a load balancer.
        /// </summary>
        [Output("loadBalancerId")]
        public Output<string> LoadBalancerId { get; private set; } = null!;

        /// <summary>
        /// The path of Content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Output("path")]
        public Output<string?> Path { get; private set; } = null!;


        /// <summary>
        /// Create a LbRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LbRule(string name, LbRuleArgs args, CustomResourceOptions? options = null)
            : base("ucloud:ulb/lbRule:LbRule", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private LbRule(string name, Input<string> id, LbRuleState? state = null, CustomResourceOptions? options = null)
            : base("ucloud:ulb/lbRule:LbRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LbRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LbRule Get(string name, Input<string> id, LbRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new LbRule(name, id, state, options);
        }
    }

    public sealed class LbRuleArgs : Pulumi.ResourceArgs
    {
        [Input("backendIds", required: true)]
        private InputList<string>? _backendIds;

        /// <summary>
        /// The IDs of the backend servers where rule applies, this argument is populated base on the `backend_id` responded from `lb_attachment` create.
        /// </summary>
        public InputList<string> BackendIds
        {
            get => _backendIds ?? (_backendIds = new InputList<string>());
            set => _backendIds = value;
        }

        /// <summary>
        /// The domain of content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The ID of a listener server.
        /// </summary>
        [Input("listenerId", required: true)]
        public Input<string> ListenerId { get; set; } = null!;

        /// <summary>
        /// The ID of a load balancer.
        /// </summary>
        [Input("loadBalancerId", required: true)]
        public Input<string> LoadBalancerId { get; set; } = null!;

        /// <summary>
        /// The path of Content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        public LbRuleArgs()
        {
        }
    }

    public sealed class LbRuleState : Pulumi.ResourceArgs
    {
        [Input("backendIds")]
        private InputList<string>? _backendIds;

        /// <summary>
        /// The IDs of the backend servers where rule applies, this argument is populated base on the `backend_id` responded from `lb_attachment` create.
        /// </summary>
        public InputList<string> BackendIds
        {
            get => _backendIds ?? (_backendIds = new InputList<string>());
            set => _backendIds = value;
        }

        /// <summary>
        /// The domain of content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The ID of a listener server.
        /// </summary>
        [Input("listenerId")]
        public Input<string>? ListenerId { get; set; }

        /// <summary>
        /// The ID of a load balancer.
        /// </summary>
        [Input("loadBalancerId")]
        public Input<string>? LoadBalancerId { get; set; }

        /// <summary>
        /// The path of Content forward matching fields. `path` and `domain` cannot coexist. `path` and `domain` must be filled in one.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        public LbRuleState()
        {
        }
    }
}
