// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi.Crd;

namespace Pulumi.Crds.Acme.V1Alpha2
{
    /// <summary>
    /// Order is a type to represent an Order with an ACME server
    /// </summary>
    [CrdsResourceType("kubernetes:acme.cert-manager.io/v1alpha2:Order")]
    public partial class Order : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.OrderSpec> Spec { get; private set; } = null!;

        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.OrderStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Order resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Order(string name, Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Order", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Order(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Order", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Order(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Order", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderArgs();
            args.ApiVersion = "acme.cert-manager.io/v1alpha2";
            args.Kind = "Order";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Crd.Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Order resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Order Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Order(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2
{

    public class OrderArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderSpecArgs>? Spec { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.OrderStatusArgs>? Status { get; set; }

        public OrderArgs()
        {
        }
    }
}
