// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1
{

    /// <summary>
    /// Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.
    /// </summary>
    public class IssuerSpecVenafiCloudArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// APITokenSecretRef is a secret key selector for the Venafi Cloud API token.
        /// </summary>
        [Input("apiTokenSecretRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecVenafiCloudApiTokenSecretRefArgs> ApiTokenSecretRef { get; set; } = null!;

        /// <summary>
        /// URL is the base URL for Venafi Cloud. Defaults to "https://api.venafi.cloud/v1".
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public IssuerSpecVenafiCloudArgs()
        {
        }
    }
}
