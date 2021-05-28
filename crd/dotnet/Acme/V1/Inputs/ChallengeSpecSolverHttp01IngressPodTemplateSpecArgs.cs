// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1
{

    /// <summary>
    /// PodSpec defines overrides for the HTTP01 challenge solver pod. Only the 'priorityClassName', 'nodeSelector', 'affinity', 'serviceAccountName' and 'tolerations' fields are supported currently. All other fields will be ignored.
    /// </summary>
    public class ChallengeSpecSolverHttp01IngressPodTemplateSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1.ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityArgs>? Affinity { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        /// <summary>
        /// If specified, the pod's priorityClassName.
        /// </summary>
        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        /// <summary>
        /// If specified, the pod's service account
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Acme.V1.ChallengeSpecSolverHttp01IngressPodTemplateSpecTolerationsArgs>? _tolerations;

        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Acme.V1.ChallengeSpecSolverHttp01IngressPodTemplateSpecTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Acme.V1.ChallengeSpecSolverHttp01IngressPodTemplateSpecTolerationsArgs>());
            set => _tolerations = value;
        }

        public ChallengeSpecSolverHttp01IngressPodTemplateSpecArgs()
        {
        }
    }
}
