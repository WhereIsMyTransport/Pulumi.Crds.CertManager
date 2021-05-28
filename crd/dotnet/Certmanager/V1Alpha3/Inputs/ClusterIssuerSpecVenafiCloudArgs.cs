// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha3
{

    /// <summary>
    /// Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.
    /// </summary>
    public class ClusterIssuerSpecVenafiCloudArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// APITokenSecretRef is a secret key selector for the Venafi Cloud API token.
        /// </summary>
        [Input("apiTokenSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Alpha3.ClusterIssuerSpecVenafiCloudApiTokenSecretRefArgs> ApiTokenSecretRef { get; set; } = null!;

        /// <summary>
        /// URL is the base URL for Venafi Cloud. Defaults to "https://api.venafi.cloud/v1".
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public ClusterIssuerSpecVenafiCloudArgs()
        {
        }
    }
}
