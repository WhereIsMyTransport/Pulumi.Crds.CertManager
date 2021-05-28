// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1
{

    [OutputType]
    public sealed class ClusterIssuerSpecVenafiCloud
    {
        /// <summary>
        /// APITokenSecretRef is a secret key selector for the Venafi Cloud API token.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecVenafiCloudApiTokenSecretRef ApiTokenSecretRef;
        /// <summary>
        /// URL is the base URL for Venafi Cloud. Defaults to "https://api.venafi.cloud/v1".
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ClusterIssuerSpecVenafiCloud(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecVenafiCloudApiTokenSecretRef apiTokenSecretRef,

            string url)
        {
            ApiTokenSecretRef = apiTokenSecretRef;
            Url = url;
        }
    }
}
