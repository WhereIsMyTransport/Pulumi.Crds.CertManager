// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1
{

    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec
    {
        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity Affinity;
        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public readonly ImmutableDictionary<string, string> NodeSelector;
        /// <summary>
        /// If specified, the pod's priorityClassName.
        /// </summary>
        public readonly string PriorityClassName;
        /// <summary>
        /// If specified, the pod's service account
        /// </summary>
        public readonly string ServiceAccountName;
        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerations> Tolerations;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpec(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity affinity,

            ImmutableDictionary<string, string> nodeSelector,

            string priorityClassName,

            string serviceAccountName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversHttp01IngressPodTemplateSpecTolerations> tolerations)
        {
            Affinity = affinity;
            NodeSelector = nodeSelector;
            PriorityClassName = priorityClassName;
            ServiceAccountName = serviceAccountName;
            Tolerations = tolerations;
        }
    }
}
