// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class VpnGateway extends pulumi.CustomResource {
    /**
     * Get an existing VpnGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpnGatewayState, opts?: pulumi.CustomResourceOptions): VpnGateway {
        return new VpnGateway(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ucloud:ipsecvpn/vpnGateway:VpnGateway';

    /**
     * Returns true if the given object is an instance of VpnGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpnGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpnGateway.__pulumiType;
    }

    public readonly chargeType!: pulumi.Output<string>;
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly duration!: pulumi.Output<number | undefined>;
    public readonly eipId!: pulumi.Output<string>;
    public /*out*/ readonly expireTime!: pulumi.Output<string>;
    public readonly grade!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly remark!: pulumi.Output<string>;
    public readonly tag!: pulumi.Output<string | undefined>;
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a VpnGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpnGatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpnGatewayArgs | VpnGatewayState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as VpnGatewayState | undefined;
            inputs["chargeType"] = state ? state.chargeType : undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["eipId"] = state ? state.eipId : undefined;
            inputs["expireTime"] = state ? state.expireTime : undefined;
            inputs["grade"] = state ? state.grade : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["remark"] = state ? state.remark : undefined;
            inputs["tag"] = state ? state.tag : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as VpnGatewayArgs | undefined;
            if (!args || args.eipId === undefined) {
                throw new Error("Missing required property 'eipId'");
            }
            if (!args || args.grade === undefined) {
                throw new Error("Missing required property 'grade'");
            }
            if (!args || args.vpcId === undefined) {
                throw new Error("Missing required property 'vpcId'");
            }
            inputs["chargeType"] = args ? args.chargeType : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["eipId"] = args ? args.eipId : undefined;
            inputs["grade"] = args ? args.grade : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["remark"] = args ? args.remark : undefined;
            inputs["tag"] = args ? args.tag : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["expireTime"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(VpnGateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpnGateway resources.
 */
export interface VpnGatewayState {
    readonly chargeType?: pulumi.Input<string>;
    readonly createTime?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly eipId?: pulumi.Input<string>;
    readonly expireTime?: pulumi.Input<string>;
    readonly grade?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly remark?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VpnGateway resource.
 */
export interface VpnGatewayArgs {
    readonly chargeType?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly eipId: pulumi.Input<string>;
    readonly grade: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly remark?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId: pulumi.Input<string>;
}