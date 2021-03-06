// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ulb

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Load Balancer SSL certificate resource.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-ucloud/blob/master/website/docs/r/lb_ssl.html.markdown.
type LbSsl struct {
	pulumi.CustomResourceState

	// The content of the CA certificate about ssl certificate.
	CaCert pulumi.StringPtrOutput `pulumi:"caCert"`
	// The time of creation for lb ssl, formatted in RFC3339 time string.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	Name       pulumi.StringOutput `pulumi:"name"`
	// The content of the private key about ssl certificate.
	PrivateKey pulumi.StringOutput `pulumi:"privateKey"`
	// The content of the user certificate about ssl certificate.
	UserCert pulumi.StringOutput `pulumi:"userCert"`
}

// NewLbSsl registers a new resource with the given unique name, arguments, and options.
func NewLbSsl(ctx *pulumi.Context,
	name string, args *LbSslArgs, opts ...pulumi.ResourceOption) (*LbSsl, error) {
	if args == nil || args.PrivateKey == nil {
		return nil, errors.New("missing required argument 'PrivateKey'")
	}
	if args == nil || args.UserCert == nil {
		return nil, errors.New("missing required argument 'UserCert'")
	}
	if args == nil {
		args = &LbSslArgs{}
	}
	var resource LbSsl
	err := ctx.RegisterResource("ucloud:ulb/lbSsl:LbSsl", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLbSsl gets an existing LbSsl resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLbSsl(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LbSslState, opts ...pulumi.ResourceOption) (*LbSsl, error) {
	var resource LbSsl
	err := ctx.ReadResource("ucloud:ulb/lbSsl:LbSsl", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LbSsl resources.
type lbSslState struct {
	// The content of the CA certificate about ssl certificate.
	CaCert *string `pulumi:"caCert"`
	// The time of creation for lb ssl, formatted in RFC3339 time string.
	CreateTime *string `pulumi:"createTime"`
	Name       *string `pulumi:"name"`
	// The content of the private key about ssl certificate.
	PrivateKey *string `pulumi:"privateKey"`
	// The content of the user certificate about ssl certificate.
	UserCert *string `pulumi:"userCert"`
}

type LbSslState struct {
	// The content of the CA certificate about ssl certificate.
	CaCert pulumi.StringPtrInput
	// The time of creation for lb ssl, formatted in RFC3339 time string.
	CreateTime pulumi.StringPtrInput
	Name       pulumi.StringPtrInput
	// The content of the private key about ssl certificate.
	PrivateKey pulumi.StringPtrInput
	// The content of the user certificate about ssl certificate.
	UserCert pulumi.StringPtrInput
}

func (LbSslState) ElementType() reflect.Type {
	return reflect.TypeOf((*lbSslState)(nil)).Elem()
}

type lbSslArgs struct {
	// The content of the CA certificate about ssl certificate.
	CaCert *string `pulumi:"caCert"`
	Name   *string `pulumi:"name"`
	// The content of the private key about ssl certificate.
	PrivateKey string `pulumi:"privateKey"`
	// The content of the user certificate about ssl certificate.
	UserCert string `pulumi:"userCert"`
}

// The set of arguments for constructing a LbSsl resource.
type LbSslArgs struct {
	// The content of the CA certificate about ssl certificate.
	CaCert pulumi.StringPtrInput
	Name   pulumi.StringPtrInput
	// The content of the private key about ssl certificate.
	PrivateKey pulumi.StringInput
	// The content of the user certificate about ssl certificate.
	UserCert pulumi.StringInput
}

func (LbSslArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*lbSslArgs)(nil)).Elem()
}
