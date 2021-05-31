// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi.Crds;

namespace Pulumi.Crds.Acme.V1Alpha2
{
    /// <summary>
    /// Challenge is a type to represent a Challenge request with an ACME server
    /// </summary>
    [CrdsResourceType("kubernetes:acme.cert-manager.io/v1alpha2:Challenge")]
    public partial class Challenge : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.ChallengeSpec> Spec { get; private set; } = null!;

        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.ChallengeStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Challenge resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Challenge(string name, Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Challenge", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Challenge(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Challenge", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Challenge(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:acme.cert-manager.io/v1alpha2:Challenge", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeArgs();
            args.ApiVersion = "acme.cert-manager.io/v1alpha2";
            args.Kind = "Challenge";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Crds.Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Challenge resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Challenge Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Challenge(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2
{

    public class ChallengeArgs : Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeSpecArgs>? Spec { get; set; }

        [Input("status")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha2.ChallengeStatusArgs>? Status { get; set; }

        public ChallengeArgs()
        {
        }
    }
}
