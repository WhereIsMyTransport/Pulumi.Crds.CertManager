// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha2
{

    /// <summary>
    /// Status of the CertificateRequest. This is set and managed automatically.
    /// </summary>
    public class CertificateRequestStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The PEM encoded x509 certificate of the signer, also known as the CA (Certificate Authority). This is set on a best-effort basis by different issuers. If not set, the CA is assumed to be unknown/not available.
        /// </summary>
        [Input("ca")]
        public Input<string>? Ca { get; set; }

        /// <summary>
        /// The PEM encoded x509 certificate resulting from the certificate signing request. If not set, the CertificateRequest has either not been completed or has failed. More information on failure can be found by checking the `conditions` field.
        /// </summary>
        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha2.CertificateRequestStatusConditionsArgs>? _conditions;

        /// <summary>
        /// List of status conditions to indicate the status of a CertificateRequest. Known condition types are `Ready` and `InvalidRequest`.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha2.CertificateRequestStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha2.CertificateRequestStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// FailureTime stores the time that this CertificateRequest failed. This is used to influence garbage collection and back-off.
        /// </summary>
        [Input("failureTime")]
        public Input<string>? FailureTime { get; set; }

        public CertificateRequestStatusArgs()
        {
        }
    }
}
