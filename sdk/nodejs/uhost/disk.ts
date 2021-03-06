// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Disk extends pulumi.CustomResource {
    /**
     * Get an existing Disk resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiskState, opts?: pulumi.CustomResourceOptions): Disk {
        return new Disk(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ucloud:uhost/disk:Disk';

    /**
     * Returns true if the given object is an instance of Disk.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Disk {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Disk.__pulumiType;
    }

    public readonly availabilityZone!: pulumi.Output<string>;
    public readonly chargeType!: pulumi.Output<string>;
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly diskSize!: pulumi.Output<number>;
    public readonly diskType!: pulumi.Output<string | undefined>;
    public readonly duration!: pulumi.Output<number | undefined>;
    public /*out*/ readonly expireTime!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly tag!: pulumi.Output<string | undefined>;

    /**
     * Create a Disk resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiskArgs | DiskState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DiskState | undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["chargeType"] = state ? state.chargeType : undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["diskSize"] = state ? state.diskSize : undefined;
            inputs["diskType"] = state ? state.diskType : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["expireTime"] = state ? state.expireTime : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["tag"] = state ? state.tag : undefined;
        } else {
            const args = argsOrState as DiskArgs | undefined;
            if (!args || args.availabilityZone === undefined) {
                throw new Error("Missing required property 'availabilityZone'");
            }
            if (!args || args.diskSize === undefined) {
                throw new Error("Missing required property 'diskSize'");
            }
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["chargeType"] = args ? args.chargeType : undefined;
            inputs["diskSize"] = args ? args.diskSize : undefined;
            inputs["diskType"] = args ? args.diskType : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tag"] = args ? args.tag : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["expireTime"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Disk.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Disk resources.
 */
export interface DiskState {
    readonly availabilityZone?: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly createTime?: pulumi.Input<string>;
    readonly diskSize?: pulumi.Input<number>;
    readonly diskType?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly expireTime?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly status?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Disk resource.
 */
export interface DiskArgs {
    readonly availabilityZone: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly diskSize: pulumi.Input<number>;
    readonly diskType?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly name?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
}
