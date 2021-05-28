// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2
{

    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversHttp01
    {
        /// <summary>
        /// The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2.ClusterIssuerSpecAcmeSolversHttp01Ingress Ingress;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversHttp01(Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2.ClusterIssuerSpecAcmeSolversHttp01Ingress ingress)
        {
            Ingress = ingress;
        }
    }
}
