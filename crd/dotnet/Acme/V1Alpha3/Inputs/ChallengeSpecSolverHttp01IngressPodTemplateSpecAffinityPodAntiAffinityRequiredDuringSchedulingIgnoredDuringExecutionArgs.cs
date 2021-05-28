// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha3
{

    /// <summary>
    /// Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running
    /// </summary>
    public class ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A label query over a set of resources, in this case pods.
        /// </summary>
        [Input("labelSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Alpha3.ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorArgs>? LabelSelector { get; set; }

        [Input("namespaces")]
        private InputList<string>? _namespaces;

        /// <summary>
        /// namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
        /// </summary>
        public InputList<string> Namespaces
        {
            get => _namespaces ?? (_namespaces = new InputList<string>());
            set => _namespaces = value;
        }

        /// <summary>
        /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
        /// </summary>
        [Input("topologyKey", required: true)]
        public Input<string> TopologyKey { get; set; } = null!;

        public ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs()
        {
        }
    }
}
