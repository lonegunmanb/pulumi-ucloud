// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ulb

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// This data source provides a list of Load Balancer resources according to their Load Balancer ID, VPC ID and Subnet ID.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/lbs.html.markdown.
func LookupLbs(ctx *pulumi.Context, args *LookupLbsArgs) (*LookupLbsResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["ids"] = args.Ids
		inputs["nameRegex"] = args.NameRegex
		inputs["outputFile"] = args.OutputFile
		inputs["subnetId"] = args.SubnetId
		inputs["vpcId"] = args.VpcId
	}
	outputs, err := ctx.Invoke("ucloud:ulb/lookupLbs:lookupLbs", inputs)
	if err != nil {
		return nil, err
	}
	return &LookupLbsResult{
		Ids:        outputs["ids"],
		Lbs:        outputs["lbs"],
		NameRegex:  outputs["nameRegex"],
		OutputFile: outputs["outputFile"],
		SubnetId:   outputs["subnetId"],
		TotalCount: outputs["totalCount"],
		VpcId:      outputs["vpcId"],
		Id:         outputs["id"],
	}, nil
}

// A collection of arguments for invoking lookupLbs.
type LookupLbsArgs struct {
	// A list of Load Balancer IDs, all the LBs belong to this region will be retrieved if the ID is `""`.
	Ids interface{}
	// A regex string to filter resulting lbs by name.
	NameRegex  interface{}
	OutputFile interface{}
	// The ID of subnet that intrant load balancer belongs to.
	SubnetId interface{}
	// The ID of the VPC linked to the Load Balancers.
	VpcId interface{}
}

// A collection of values returned by lookupLbs.
type LookupLbsResult struct {
	Ids interface{}
	// It is a nested type which documented below.
	Lbs        interface{}
	NameRegex  interface{}
	OutputFile interface{}
	// (Optional) The ID of subnet that intrant load balancer belongs to.
	SubnetId interface{}
	// Total number of Load Balancers that satisfy the condition.
	TotalCount interface{}
	// The ID of the VPC linked to the Load Balancers.
	VpcId interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}