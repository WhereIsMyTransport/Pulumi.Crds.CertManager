// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3
{

    [OutputType]
    public sealed class IssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata
    {
        /// <summary>
        /// Annotations that should be added to the create ACME HTTP01 solver pods.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// Labels that should be added to the created ACME HTTP01 solver pods.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;

        [OutputConstructor]
        private IssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata(
            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, string> labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}
