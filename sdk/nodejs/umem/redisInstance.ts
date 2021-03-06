// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class RedisInstance extends pulumi.CustomResource {
    /**
     * Get an existing RedisInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RedisInstanceState, opts?: pulumi.CustomResourceOptions): RedisInstance {
        return new RedisInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ucloud:umem/redisInstance:RedisInstance';

    /**
     * Returns true if the given object is an instance of RedisInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RedisInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RedisInstance.__pulumiType;
    }

    public readonly availabilityZone!: pulumi.Output<string>;
    public readonly chargeType!: pulumi.Output<string>;
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly duration!: pulumi.Output<number | undefined>;
    public readonly engineVersion!: pulumi.Output<string>;
    public /*out*/ readonly expireTime!: pulumi.Output<string>;
    public readonly instanceType!: pulumi.Output<string>;
    public /*out*/ readonly ipSets!: pulumi.Output<outputs.umem.RedisInstanceIpSet[]>;
    public readonly name!: pulumi.Output<string>;
    public readonly password!: pulumi.Output<string | undefined>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly subnetId!: pulumi.Output<string>;
    public readonly tag!: pulumi.Output<string>;
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a RedisInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RedisInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RedisInstanceArgs | RedisInstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as RedisInstanceState | undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["chargeType"] = state ? state.chargeType : undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["engineVersion"] = state ? state.engineVersion : undefined;
            inputs["expireTime"] = state ? state.expireTime : undefined;
            inputs["instanceType"] = state ? state.instanceType : undefined;
            inputs["ipSets"] = state ? state.ipSets : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["subnetId"] = state ? state.subnetId : undefined;
            inputs["tag"] = state ? state.tag : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as RedisInstanceArgs | undefined;
            if (!args || args.availabilityZone === undefined) {
                throw new Error("Missing required property 'availabilityZone'");
            }
            if (!args || args.instanceType === undefined) {
                throw new Error("Missing required property 'instanceType'");
            }
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["chargeType"] = args ? args.chargeType : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tag"] = args ? args.tag : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["expireTime"] = undefined /*out*/;
            inputs["ipSets"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(RedisInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RedisInstance resources.
 */
export interface RedisInstanceState {
    readonly availabilityZone?: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly createTime?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly engineVersion?: pulumi.Input<string>;
    readonly expireTime?: pulumi.Input<string>;
    readonly instanceType?: pulumi.Input<string>;
    readonly ipSets?: pulumi.Input<pulumi.Input<inputs.umem.RedisInstanceIpSet>[]>;
    readonly name?: pulumi.Input<string>;
    readonly password?: pulumi.Input<string>;
    readonly status?: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RedisInstance resource.
 */
export interface RedisInstanceArgs {
    readonly availabilityZone: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly engineVersion?: pulumi.Input<string>;
    readonly instanceType: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly password?: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId?: pulumi.Input<string>;
}
