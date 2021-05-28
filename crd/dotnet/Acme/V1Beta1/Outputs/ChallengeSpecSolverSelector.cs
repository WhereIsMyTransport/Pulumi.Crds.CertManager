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
    public sealed class ChallengeSpecSolverSelector
    {
        /// <summary>
        /// List of DNSNames that this solver will be used to solve. If specified and a match is found, a dnsNames selector will take precedence over a dnsZones selector. If multiple solvers match with the same dnsNames value, the solver with the most matching labels in matchLabels will be selected. If neither has more matches, the solver defined earlier in the list will be selected.
        /// </summary>
        public readonly ImmutableArray<string> DnsNames;
        /// <summary>
        /// List of DNSZones that this solver will be used to solve. The most specific DNS zone match specified here will take precedence over other DNS zone matches, so a solver specifying sys.example.com will be selected over one specifying example.com for the domain www.sys.example.com. If multiple solvers match with the same dnsZones value, the solver with the most matching labels in matchLabels will be selected. If neither has more matches, the solver defined earlier in the list will be selected.
        /// </summary>
        public readonly ImmutableArray<string> DnsZones;
        /// <summary>
        /// A label selector that is used to refine the set of certificate's that this challenge solver will apply to.
        /// </summary>
        public readonly ImmutableDictionary<string, string> MatchLabels;

        [OutputConstructor]
        private ChallengeSpecSolverSelector(
            ImmutableArray<string> dnsNames,

            ImmutableArray<string> dnsZones,

            ImmutableDictionary<string, string> matchLabels)
        {
            DnsNames = dnsNames;
            DnsZones = dnsZones;
            MatchLabels = matchLabels;
        }
    }
}
