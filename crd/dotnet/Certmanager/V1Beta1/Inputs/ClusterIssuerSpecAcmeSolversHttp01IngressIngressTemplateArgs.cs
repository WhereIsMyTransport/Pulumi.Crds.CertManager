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
    /// Optional ingress template used to configure the ACME challenge solver ingress used for HTTP01 challenges
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ObjectMeta overrides for the ingress used to solve HTTP01 challenges. Only the 'labels' and 'annotations' fields may be set. If labels or annotations overlap with in-built values, the values here will override the in-built values.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplateMetadataArgs>? Metadata { get; set; }

        public ClusterIssuerSpecAcmeSolversHttp01IngressIngressTemplateArgs()
        {
        }
    }
}
