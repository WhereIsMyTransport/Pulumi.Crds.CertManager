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
    public sealed class ChallengeSpecSolverDns01Webhook
    {
        /// <summary>
        /// Additional configuration that should be passed to the webhook apiserver when challenges are processed. This can contain arbitrary JSON data. Secret values should not be specified in this stanza. If secret values are needed (e.g. credentials for a DNS service), you should use a SecretKeySelector to reference a Secret resource. For details on the schema of this field, consult the webhook provider implementation's documentation.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Config;
        /// <summary>
        /// The API group name that should be used when POSTing ChallengePayload resources to the webhook apiserver. This should be the same as the GroupName specified in the webhook provider implementation.
        /// </summary>
        public readonly string GroupName;
        /// <summary>
        /// The name of the solver to use, as defined in the webhook provider implementation. This will typically be the name of the provider, e.g. 'cloudflare'.
        /// </summary>
        public readonly string SolverName;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Webhook(
            ImmutableDictionary<string, object> config,

            string groupName,

            string solverName)
        {
            Config = config;
            GroupName = groupName;
            SolverName = solverName;
        }
    }
}
