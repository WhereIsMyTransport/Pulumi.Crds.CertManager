// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1
{

    /// <summary>
    /// CertificateRequestCondition contains condition information for a CertificateRequest.
    /// </summary>
    public class CertificateRequestStatusConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// LastTransitionTime is the timestamp corresponding to the last status change of this condition.
        /// </summary>
        [Input("lastTransitionTime")]
        public Input<string>? LastTransitionTime { get; set; }

        /// <summary>
        /// Message is a human readable description of the details of the last transition, complementing reason.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Reason is a brief machine readable explanation for the condition's last transition.
        /// </summary>
        [Input("reason")]
        public Input<string>? Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of (`True`, `False`, `Unknown`).
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Type of the condition, known values are (`Ready`, `InvalidRequest`, `Approved`, `Denied`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CertificateRequestStatusConditionsArgs()
        {
        }
    }
}
