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
    public sealed class IssuerStatusConditions
    {
        /// <summary>
        /// LastTransitionTime is the timestamp corresponding to the last status change of this condition.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Message is a human readable description of the details of the last transition, complementing reason.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// If set, this represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the Issuer.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// Reason is a brief machine readable explanation for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status of the condition, one of (`True`, `False`, `Unknown`).
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of the condition, known values are (`Ready`).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private IssuerStatusConditions(
            string lastTransitionTime,

            string message,

            int observedGeneration,

            string reason,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            ObservedGeneration = observedGeneration;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
