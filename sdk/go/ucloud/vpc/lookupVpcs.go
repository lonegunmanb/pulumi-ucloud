// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// This data source provides a list of VPC resources according to their VPC ID, name.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/d/vpcs.html.markdown.
func LookupVpcs(ctx *pulumi.Context, args *LookupVpcsArgs) (*LookupVpcsResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["ids"] = args.Ids
		inputs["nameRegex"] = args.NameRegex
		inputs["outputFile"] = args.OutputFile
		inputs["tag"] = args.Tag
	}
	outputs, err := ctx.Invoke("ucloud:vpc/lookupVpcs:lookupVpcs", inputs)
	if err != nil {
		return nil, err
	}
	return &LookupVpcsResult{
		Ids:        outputs["ids"],
		NameRegex:  outputs["nameRegex"],
		OutputFile: outputs["outputFile"],
		Tag:        outputs["tag"],
		TotalCount: outputs["totalCount"],
		Vpcs:       outputs["vpcs"],
		Id:         outputs["id"],
	}, nil
}

// A collection of arguments for invoking lookupVpcs.
type LookupVpcsArgs struct {
	// A list of VPC IDs, all the VPC resources belong to this region will be retrieved if the ID is `""`.
	Ids interface{}
	// A regex string to filter resulting VPC resources by name.
	NameRegex  interface{}
	OutputFile interface{}
	Tag        interface{}
}

// A collection of values returned by lookupVpcs.
type LookupVpcsResult struct {
	Ids        interface{}
	NameRegex  interface{}
	OutputFile interface{}
	// A tag assigned to VPC.
	Tag interface{}
	// Total number of VPC resources that satisfy the condition.
	TotalCount interface{}
	// It is a nested type which documented below.
	Vpcs interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}