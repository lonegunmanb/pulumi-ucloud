// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class DbInstance extends pulumi.CustomResource {
    /**
     * Get an existing DbInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DbInstanceState, opts?: pulumi.CustomResourceOptions): DbInstance {
        return new DbInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ucloud:udb/dbInstance:DbInstance';

    /**
     * Returns true if the given object is an instance of DbInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DbInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DbInstance.__pulumiType;
    }

    public readonly availabilityZone!: pulumi.Output<string>;
    public readonly backupBeginTime!: pulumi.Output<number>;
    public readonly backupBlackLists!: pulumi.Output<string[]>;
    public readonly backupCount!: pulumi.Output<number | undefined>;
    public readonly backupDate!: pulumi.Output<string>;
    public readonly chargeType!: pulumi.Output<string>;
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly duration!: pulumi.Output<number | undefined>;
    public readonly engine!: pulumi.Output<string>;
    public readonly engineVersion!: pulumi.Output<string>;
    public /*out*/ readonly expireTime!: pulumi.Output<string>;
    public readonly instanceStorage!: pulumi.Output<number>;
    public readonly instanceType!: pulumi.Output<string>;
    public /*out*/ readonly modifyTime!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly password!: pulumi.Output<string>;
    public readonly port!: pulumi.Output<number>;
    public /*out*/ readonly privateIp!: pulumi.Output<string>;
    public readonly standbyZone!: pulumi.Output<string | undefined>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly subnetId!: pulumi.Output<string>;
    public readonly tag!: pulumi.Output<string>;
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a DbInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DbInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DbInstanceArgs | DbInstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DbInstanceState | undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["backupBeginTime"] = state ? state.backupBeginTime : undefined;
            inputs["backupBlackLists"] = state ? state.backupBlackLists : undefined;
            inputs["backupCount"] = state ? state.backupCount : undefined;
            inputs["backupDate"] = state ? state.backupDate : undefined;
            inputs["chargeType"] = state ? state.chargeType : undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["engine"] = state ? state.engine : undefined;
            inputs["engineVersion"] = state ? state.engineVersion : undefined;
            inputs["expireTime"] = state ? state.expireTime : undefined;
            inputs["instanceStorage"] = state ? state.instanceStorage : undefined;
            inputs["instanceType"] = state ? state.instanceType : undefined;
            inputs["modifyTime"] = state ? state.modifyTime : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["port"] = state ? state.port : undefined;
            inputs["privateIp"] = state ? state.privateIp : undefined;
            inputs["standbyZone"] = state ? state.standbyZone : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["subnetId"] = state ? state.subnetId : undefined;
            inputs["tag"] = state ? state.tag : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as DbInstanceArgs | undefined;
            if (!args || args.availabilityZone === undefined) {
                throw new Error("Missing required property 'availabilityZone'");
            }
            if (!args || args.engine === undefined) {
                throw new Error("Missing required property 'engine'");
            }
            if (!args || args.engineVersion === undefined) {
                throw new Error("Missing required property 'engineVersion'");
            }
            if (!args || args.instanceStorage === undefined) {
                throw new Error("Missing required property 'instanceStorage'");
            }
            if (!args || args.instanceType === undefined) {
                throw new Error("Missing required property 'instanceType'");
            }
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["backupBeginTime"] = args ? args.backupBeginTime : undefined;
            inputs["backupBlackLists"] = args ? args.backupBlackLists : undefined;
            inputs["backupCount"] = args ? args.backupCount : undefined;
            inputs["backupDate"] = args ? args.backupDate : undefined;
            inputs["chargeType"] = args ? args.chargeType : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["engine"] = args ? args.engine : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["instanceStorage"] = args ? args.instanceStorage : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["port"] = args ? args.port : undefined;
            inputs["standbyZone"] = args ? args.standbyZone : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tag"] = args ? args.tag : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["expireTime"] = undefined /*out*/;
            inputs["modifyTime"] = undefined /*out*/;
            inputs["privateIp"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DbInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DbInstance resources.
 */
export interface DbInstanceState {
    readonly availabilityZone?: pulumi.Input<string>;
    readonly backupBeginTime?: pulumi.Input<number>;
    readonly backupBlackLists?: pulumi.Input<pulumi.Input<string>[]>;
    readonly backupCount?: pulumi.Input<number>;
    readonly backupDate?: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly createTime?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly engine?: pulumi.Input<string>;
    readonly engineVersion?: pulumi.Input<string>;
    readonly expireTime?: pulumi.Input<string>;
    readonly instanceStorage?: pulumi.Input<number>;
    readonly instanceType?: pulumi.Input<string>;
    readonly modifyTime?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly password?: pulumi.Input<string>;
    readonly port?: pulumi.Input<number>;
    readonly privateIp?: pulumi.Input<string>;
    readonly standbyZone?: pulumi.Input<string>;
    readonly status?: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DbInstance resource.
 */
export interface DbInstanceArgs {
    readonly availabilityZone: pulumi.Input<string>;
    readonly backupBeginTime?: pulumi.Input<number>;
    readonly backupBlackLists?: pulumi.Input<pulumi.Input<string>[]>;
    readonly backupCount?: pulumi.Input<number>;
    readonly backupDate?: pulumi.Input<string>;
    readonly chargeType?: pulumi.Input<string>;
    readonly duration?: pulumi.Input<number>;
    readonly engine: pulumi.Input<string>;
    readonly engineVersion: pulumi.Input<string>;
    readonly instanceStorage: pulumi.Input<number>;
    readonly instanceType: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly password?: pulumi.Input<string>;
    readonly port?: pulumi.Input<number>;
    readonly standbyZone?: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tag?: pulumi.Input<string>;
    readonly vpcId?: pulumi.Input<string>;
}
