// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1
{

    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplate
    {
        /// <summary>
        /// ObjectMeta overrides for the pod used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata Metadata;
        /// <summary>
        /// PodSpec defines overrides for the HTTP01 challenge solver pod. Only the 'priorityClassName', 'nodeSelector', 'affinity', 'serviceAccountName' and 'tolerations' fields are supported currently. All other fields will be ignored.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec Spec;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplate(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateMetadata metadata,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}
