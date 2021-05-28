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
    public sealed class ClusterIssuerSpecAcmeSolversDns01
    {
        /// <summary>
        /// Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Acmedns Acmedns;
        /// <summary>
        /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Akamai Akamai;
        /// <summary>
        /// Use the Microsoft Azure DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Azuredns Azuredns;
        /// <summary>
        /// Use the Google Cloud DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Clouddns Clouddns;
        /// <summary>
        /// Use the Cloudflare API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Cloudflare Cloudflare;
        /// <summary>
        /// CNAMEStrategy configures how the DNS01 provider should handle CNAME records when found in DNS zones.
        /// </summary>
        public readonly string CnameStrategy;
        /// <summary>
        /// Use the DigitalOcean DNS API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Digitalocean Digitalocean;
        /// <summary>
        /// Use RFC2136 ("Dynamic Updates in the Domain Name System") (https://datatracker.ietf.org/doc/rfc2136/) to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Rfc2136 Rfc2136;
        /// <summary>
        /// Use the AWS Route53 API to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Route53 Route53;
        /// <summary>
        /// Configure an external webhook based DNS01 challenge solver to manage DNS01 challenge records.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Webhook Webhook;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversDns01(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Acmedns acmedns,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Akamai akamai,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Azuredns azuredns,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Clouddns clouddns,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Cloudflare cloudflare,

            string cnameStrategy,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Digitalocean digitalocean,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Rfc2136 rfc2136,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Route53 route53,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha3.ClusterIssuerSpecAcmeSolversDns01Webhook webhook)
        {
            Acmedns = acmedns;
            Akamai = akamai;
            Azuredns = azuredns;
            Clouddns = clouddns;
            Cloudflare = cloudflare;
            CnameStrategy = cnameStrategy;
            Digitalocean = digitalocean;
            Rfc2136 = rfc2136;
            Route53 = route53;
            Webhook = webhook;
        }
    }
}
