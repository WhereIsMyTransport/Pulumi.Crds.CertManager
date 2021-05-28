// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha3
{

    /// <summary>
    /// Desired state of the CertificateRequest resource.
    /// </summary>
    public class CertificateRequestSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The PEM-encoded x509 certificate signing request to be submitted to the CA for signing.
        /// </summary>
        [Input("csr", required: true)]
        public Input<string> Csr { get; set; } = null!;

        /// <summary>
        /// The requested 'duration' (i.e. lifetime) of the Certificate. This option may be ignored/overridden by some issuer types.
        /// </summary>
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        [Input("extra")]
        private InputMap<ImmutableArray<string>>? _extra;

        /// <summary>
        /// Extra contains extra attributes of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.
        /// </summary>
        public InputMap<ImmutableArray<string>> Extra
        {
            get => _extra ?? (_extra = new InputMap<ImmutableArray<string>>());
            set => _extra = value;
        }

        [Input("groups")]
        private InputList<string>? _groups;

        /// <summary>
        /// Groups contains group membership of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.
        /// </summary>
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        /// <summary>
        /// IsCA will request to mark the certificate as valid for certificate signing when submitting to the issuer. This will automatically add the `cert sign` usage to the list of `usages`.
        /// </summary>
        [Input("isCA")]
        public Input<bool>? IsCA { get; set; }

        /// <summary>
        /// IssuerRef is a reference to the issuer for this CertificateRequest.  If the `kind` field is not set, or set to `Issuer`, an Issuer resource with the given name in the same namespace as the CertificateRequest will be used.  If the `kind` field is set to `ClusterIssuer`, a ClusterIssuer with the provided name will be used. The `name` field in this stanza is required at all times. The group field refers to the API group of the issuer which defaults to `cert-manager.io` if empty.
        /// </summary>
        [Input("issuerRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha3.CertificateRequestSpecIssuerRefArgs> IssuerRef { get; set; } = null!;

        /// <summary>
        /// UID contains the uid of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.
        /// </summary>
        [Input("uid")]
        public Input<string>? Uid { get; set; }

        [Input("usages")]
        private InputList<string>? _usages;

        /// <summary>
        /// Usages is the set of x509 usages that are requested for the certificate. Defaults to `digital signature` and `key encipherment` if not specified.
        /// </summary>
        public InputList<string> Usages
        {
            get => _usages ?? (_usages = new InputList<string>());
            set => _usages = value;
        }

        /// <summary>
        /// Username contains the name of the user that created the CertificateRequest. Populated by the cert-manager webhook on creation and immutable.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public CertificateRequestSpecArgs()
        {
        }
    }
}
