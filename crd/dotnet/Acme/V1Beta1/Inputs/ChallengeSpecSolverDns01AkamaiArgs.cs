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
    /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01AkamaiArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("accessTokenSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Beta1.ChallengeSpecSolverDns01AkamaiAccessTokenSecretRefArgs> AccessTokenSecretRef { get; set; } = null!;

        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("clientSecretSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Beta1.ChallengeSpecSolverDns01AkamaiClientSecretSecretRefArgs> ClientSecretSecretRef { get; set; } = null!;

        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("clientTokenSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1Beta1.ChallengeSpecSolverDns01AkamaiClientTokenSecretRefArgs> ClientTokenSecretRef { get; set; } = null!;

        [Input("serviceConsumerDomain", required: true)]
        public Input<string> ServiceConsumerDomain { get; set; } = null!;

        public ChallengeSpecSolverDns01AkamaiArgs()
        {
        }
    }
}
