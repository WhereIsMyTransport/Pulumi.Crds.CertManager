// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Acme.V1
{

    /// <summary>
    /// Use the DigitalOcean DNS API to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01DigitaloceanArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("tokenSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Acme.V1.ChallengeSpecSolverDns01DigitaloceanTokenSecretRefArgs> TokenSecretRef { get; set; } = null!;

        public ChallengeSpecSolverDns01DigitaloceanArgs()
        {
        }
    }
}
