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
    /// Keystores configures additional keystore output formats stored in the `secretName` Secret resource.
    /// </summary>
    public class CertificateSpecKeystoresArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// JKS configures options for storing a JKS keystore in the `spec.secretName` Secret resource.
        /// </summary>
        [Input("jks")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecKeystoresJksArgs>? Jks { get; set; }

        /// <summary>
        /// PKCS12 configures options for storing a PKCS12 keystore in the `spec.secretName` Secret resource.
        /// </summary>
        [Input("pkcs12")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1Beta1.CertificateSpecKeystoresPkcs12Args>? Pkcs12 { get; set; }

        public CertificateSpecKeystoresArgs()
        {
        }
    }
}
