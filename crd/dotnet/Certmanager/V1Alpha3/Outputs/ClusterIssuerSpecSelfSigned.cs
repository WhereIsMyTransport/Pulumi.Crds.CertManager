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
    public sealed class ClusterIssuerSpecSelfSigned
    {
        /// <summary>
        /// The CRL distribution points is an X.509 v3 certificate extension which identifies the location of the CRL from which the revocation of this certificate can be checked. If not set certificate will be issued without CDP. Values are strings.
        /// </summary>
        public readonly ImmutableArray<string> CrlDistributionPoints;

        [OutputConstructor]
        private ClusterIssuerSpecSelfSigned(ImmutableArray<string> crlDistributionPoints)
        {
            CrlDistributionPoints = crlDistributionPoints;
        }
    }
}
