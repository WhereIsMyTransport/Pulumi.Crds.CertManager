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
    public sealed class ChallengeSpecSolverHttp01IngressIngressTemplate
    {
        /// <summary>
        /// ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolverHttp01IngressIngressTemplateMetadata Metadata;

        [OutputConstructor]
        private ChallengeSpecSolverHttp01IngressIngressTemplate(Pulumi.Kubernetes.Types.Outputs.Acme.V1Alpha3.ChallengeSpecSolverHttp01IngressIngressTemplateMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}
