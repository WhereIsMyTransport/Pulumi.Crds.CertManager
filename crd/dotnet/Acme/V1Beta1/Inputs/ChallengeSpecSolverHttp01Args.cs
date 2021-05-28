// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1Beta1
{

    /// <summary>
    /// Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.
    /// </summary>
    public class ChallengeSpecSolverHttp01Args : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ingress based HTTP01 challenge solver will solve challenges by creating or modifying Ingress resources in order to route requests for '/.well-known/acme-challenge/XYZ' to 'challenge solver' pods that are provisioned by cert-manager for each Challenge to be completed.
        /// </summary>
        [Input("ingress")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Beta1.ChallengeSpecSolverHttp01IngressArgs>? Ingress { get; set; }

        public ChallengeSpecSolverHttp01Args()
        {
        }
    }
}
