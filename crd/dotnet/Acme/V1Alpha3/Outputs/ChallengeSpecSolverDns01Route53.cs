// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3
{

    [OutputType]
    public sealed class ChallengeSpecSolverDns01Route53
    {
        /// <summary>
        /// The AccessKeyID is used for authentication. If not set we fall-back to using env vars, shared credentials file or AWS Instance metadata see: https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials
        /// </summary>
        public readonly string AccessKeyID;
        /// <summary>
        /// If set, the provider will manage only this zone in Route53 and will not do an lookup using the route53:ListHostedZonesByName api call.
        /// </summary>
        public readonly string HostedZoneID;
        /// <summary>
        /// Always set the region when using AccessKeyID and SecretAccessKey
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Role is a Role ARN which the Route53 provider will assume using either the explicit credentials AccessKeyID/SecretAccessKey or the inferred credentials from environment variables, shared credentials file or AWS Instance metadata
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The SecretAccessKey is used for authentication. If not set we fall-back to using env vars, shared credentials file or AWS Instance metadata https://docs.aws.amazon.com/sdk-for-go/v1/developer-guide/configuring-sdk.html#specifying-credentials
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolverDns01Route53SecretAccessKeySecretRef SecretAccessKeySecretRef;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Route53(
            string accessKeyID,

            string hostedZoneID,

            string region,

            string role,

            Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolverDns01Route53SecretAccessKeySecretRef secretAccessKeySecretRef)
        {
            AccessKeyID = accessKeyID;
            HostedZoneID = hostedZoneID;
            Region = region;
            Role = role;
            SecretAccessKeySecretRef = secretAccessKeySecretRef;
        }
    }
}
