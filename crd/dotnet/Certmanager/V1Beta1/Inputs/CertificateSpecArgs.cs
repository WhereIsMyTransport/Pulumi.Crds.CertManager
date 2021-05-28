// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1
{

    /// <summary>
    /// Desired state of the Certificate resource.
    /// </summary>
    public class CertificateSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CommonName is a common name to be used on the Certificate. The CommonName should have a length of 64 characters or fewer to avoid generating invalid CSRs. This value is ignored by TLS clients when any subject alt name is set. This is x509 behaviour: https://tools.ietf.org/html/rfc6125#section-6.4.4
        /// </summary>
        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        [Input("dnsNames")]
        private InputList<string>? _dnsNames;

        /// <summary>
        /// DNSNames is a list of DNS subjectAltNames to be set on the Certificate.
        /// </summary>
        public InputList<string> DnsNames
        {
            get => _dnsNames ?? (_dnsNames = new InputList<string>());
            set => _dnsNames = value;
        }

        /// <summary>
        /// The requested 'duration' (i.e. lifetime) of the Certificate. This option may be ignored/overridden by some issuer types. If overridden and `renewBefore` is greater than the actual certificate duration, the certificate will be automatically renewed 2/3rds of the way through the certificate's duration.
        /// </summary>
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        [Input("emailSANs")]
        private InputList<string>? _emailSANs;

        /// <summary>
        /// EmailSANs is a list of email subjectAltNames to be set on the Certificate.
        /// </summary>
        public InputList<string> EmailSANs
        {
            get => _emailSANs ?? (_emailSANs = new InputList<string>());
            set => _emailSANs = value;
        }

        /// <summary>
        /// EncodeUsagesInRequest controls whether key usages should be present in the CertificateRequest
        /// </summary>
        [Input("encodeUsagesInRequest")]
        public Input<bool>? EncodeUsagesInRequest { get; set; }

        [Input("ipAddresses")]
        private InputList<string>? _ipAddresses;

        /// <summary>
        /// IPAddresses is a list of IP address subjectAltNames to be set on the Certificate.
        /// </summary>
        public InputList<string> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<string>());
            set => _ipAddresses = value;
        }

        /// <summary>
        /// IsCA will mark this Certificate as valid for certificate signing. This will automatically add the `cert sign` usage to the list of `usages`.
        /// </summary>
        [Input("isCA")]
        public Input<bool>? IsCA { get; set; }

        /// <summary>
        /// IssuerRef is a reference to the issuer for this certificate. If the `kind` field is not set, or set to `Issuer`, an Issuer resource with the given name in the same namespace as the Certificate will be used. If the `kind` field is set to `ClusterIssuer`, a ClusterIssuer with the provided name will be used. The `name` field in this stanza is required at all times.
        /// </summary>
        [Input("issuerRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecIssuerRefArgs> IssuerRef { get; set; } = null!;

        /// <summary>
        /// Keystores configures additional keystore output formats stored in the `secretName` Secret resource.
        /// </summary>
        [Input("keystores")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecKeystoresArgs>? Keystores { get; set; }

        /// <summary>
        /// Options to control private keys used for the Certificate.
        /// </summary>
        [Input("privateKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecPrivateKeyArgs>? PrivateKey { get; set; }

        /// <summary>
        /// The amount of time before the currently issued certificate's `notAfter` time that cert-manager will begin to attempt to renew the certificate. If this value is greater than the total duration of the certificate (i.e. notAfter - notBefore), it will be automatically renewed 2/3rds of the way through the certificate's duration.
        /// </summary>
        [Input("renewBefore")]
        public Input<string>? RenewBefore { get; set; }

        /// <summary>
        /// revisionHistoryLimit is the maximum number of CertificateRequest revisions that are maintained in the Certificate's history. Each revision represents a single `CertificateRequest` created by this Certificate, either when it was created, renewed, or Spec was changed. Revisions will be removed by oldest first if the number of revisions exceeds this number. If set, revisionHistoryLimit must be a value of `1` or greater. If unset (`nil`), revisions will not be garbage collected. Default value is `nil`.
        /// </summary>
        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        /// <summary>
        /// SecretName is the name of the secret resource that will be automatically created and managed by this Certificate resource. It will be populated with a private key and certificate, signed by the denoted issuer.
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        /// <summary>
        /// Full X509 name specification (https://golang.org/pkg/crypto/x509/pkix/#Name).
        /// </summary>
        [Input("subject")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecSubjectArgs>? Subject { get; set; }

        [Input("uriSANs")]
        private InputList<string>? _uriSANs;

        /// <summary>
        /// URISANs is a list of URI subjectAltNames to be set on the Certificate.
        /// </summary>
        public InputList<string> UriSANs
        {
            get => _uriSANs ?? (_uriSANs = new InputList<string>());
            set => _uriSANs = value;
        }

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

        public CertificateSpecArgs()
        {
        }
    }
}
