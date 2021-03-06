// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3
{

    [OutputType]
    public sealed class ChallengeSpec
    {
        /// <summary>
        /// AuthzURL is the URL to the ACME Authorization resource that this challenge is a part of.
        /// </summary>
        public readonly string AuthzURL;
        /// <summary>
        /// DNSName is the identifier that this challenge is for, e.g. example.com. If the requested DNSName is a 'wildcard', this field MUST be set to the non-wildcard domain, e.g. for `*.example.com`, it must be `example.com`.
        /// </summary>
        public readonly string DnsName;
        /// <summary>
        /// IssuerRef references a properly configured ACME-type Issuer which should be used to create this Challenge. If the Issuer does not exist, processing will be retried. If the Issuer is not an 'ACME' Issuer, an error will be returned and the Challenge will be marked as failed.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecIssuerRef IssuerRef;
        /// <summary>
        /// Key is the ACME challenge key for this challenge For HTTP01 challenges, this is the value that must be responded with to complete the HTTP01 challenge in the format: `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;`. For DNS01 challenges, this is the base64 encoded SHA256 sum of the `&lt;private key JWK thumbprint&gt;.&lt;key from acme server for challenge&gt;` text that must be set as the TXT record content.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Solver contains the domain solving configuration that should be used to solve this challenge resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolver Solver;
        /// <summary>
        /// Token is the ACME challenge token for this challenge. This is the raw value returned from the ACME server.
        /// </summary>
        public readonly string Token;
        /// <summary>
        /// Type is the type of ACME challenge this resource represents. One of "http-01" or "dns-01".
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// URL is the URL of the ACME Challenge resource for this challenge. This can be used to lookup details about the status of this challenge.
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// Wildcard will be true if this challenge is for a wildcard identifier, for example '*.example.com'.
        /// </summary>
        public readonly bool Wildcard;

        [OutputConstructor]
        private ChallengeSpec(
            string authzURL,

            string dnsName,

            Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecIssuerRef issuerRef,

            string key,

            Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolver solver,

            string token,

            string type,

            string url,

            bool wildcard)
        {
            AuthzURL = authzURL;
            DnsName = dnsName;
            IssuerRef = issuerRef;
            Key = key;
            Solver = solver;
            Token = token;
            Type = type;
            Url = url;
            Wildcard = wildcard;
        }
    }
}
