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
    /// Use the Cloudflare API to manage DNS01 challenge records.
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversDns01CloudflareArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.
        /// </summary>
        [Input("apiKeySecretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversDns01CloudflareApiKeySecretRefArgs>? ApiKeySecretRef { get; set; }

        /// <summary>
        /// API token used to authenticate with Cloudflare.
        /// </summary>
        [Input("apiTokenSecretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversDns01CloudflareApiTokenSecretRefArgs>? ApiTokenSecretRef { get; set; }

        /// <summary>
        /// Email of the account, only required when using API key based authentication.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        public ClusterIssuerSpecAcmeSolversDns01CloudflareArgs()
        {
        }
    }
}
