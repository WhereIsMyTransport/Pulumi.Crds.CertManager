// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2
{

    [OutputType]
    public sealed class ChallengeSpecSolverDns01Azuredns
    {
        /// <summary>
        /// if both this and ClientSecret are left unset MSI will be used
        /// </summary>
        public readonly string ClientID;
        /// <summary>
        /// if both this and ClientID are left unset MSI will be used
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.ChallengeSpecSolverDns01AzurednsClientSecretSecretRef ClientSecretSecretRef;
        public readonly string Environment;
        public readonly string HostedZoneName;
        public readonly string ResourceGroupName;
        public readonly string SubscriptionID;
        /// <summary>
        /// when specifying ClientID and ClientSecret then this field is also needed
        /// </summary>
        public readonly string TenantID;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Azuredns(
            string clientID,

            Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha2.ChallengeSpecSolverDns01AzurednsClientSecretSecretRef clientSecretSecretRef,

            string environment,

            string hostedZoneName,

            string resourceGroupName,

            string subscriptionID,

            string tenantID)
        {
            ClientID = clientID;
            ClientSecretSecretRef = clientSecretSecretRef;
            Environment = environment;
            HostedZoneName = hostedZoneName;
            ResourceGroupName = resourceGroupName;
            SubscriptionID = subscriptionID;
            TenantID = tenantID;
        }
    }
}
