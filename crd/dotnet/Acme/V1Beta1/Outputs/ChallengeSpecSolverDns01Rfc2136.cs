// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Acme.V1Beta1
{

    [OutputType]
    public sealed class ChallengeSpecSolverDns01Rfc2136
    {
        /// <summary>
        /// The IP address or hostname of an authoritative DNS server supporting RFC2136 in the form host:port. If the host is an IPv6 address it must be enclosed in square brackets (e.g [2001:db8::1]) ; port is optional. This field is required.
        /// </summary>
        public readonly string Nameserver;
        /// <summary>
        /// The TSIG Algorithm configured in the DNS supporting RFC2136. Used only when ``tsigSecretSecretRef`` and ``tsigKeyName`` are defined. Supported values are (case-insensitive): ``HMACMD5`` (default), ``HMACSHA1``, ``HMACSHA256`` or ``HMACSHA512``.
        /// </summary>
        public readonly string TsigAlgorithm;
        /// <summary>
        /// The TSIG Key name configured in the DNS. If ``tsigSecretSecretRef`` is defined, this field is required.
        /// </summary>
        public readonly string TsigKeyName;
        /// <summary>
        /// The name of the secret containing the TSIG value. If ``tsigKeyName`` is defined, this field is required.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Beta1.ChallengeSpecSolverDns01Rfc2136TsigSecretSecretRef TsigSecretSecretRef;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Rfc2136(
            string nameserver,

            string tsigAlgorithm,

            string tsigKeyName,

            Pulumi.Kubernetes.Types.Outputs.Acme.V1Beta1.ChallengeSpecSolverDns01Rfc2136TsigSecretSecretRef tsigSecretSecretRef)
        {
            Nameserver = nameserver;
            TsigAlgorithm = tsigAlgorithm;
            TsigKeyName = tsigKeyName;
            TsigSecretSecretRef = tsigSecretSecretRef;
        }
    }
}
