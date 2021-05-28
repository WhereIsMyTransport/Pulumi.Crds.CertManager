// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2
{

    [OutputType]
    public sealed class CertificateSpecKeystoresPkcs12
    {
        /// <summary>
        /// Create enables PKCS12 keystore creation for the Certificate. If true, a file named `keystore.p12` will be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef`. The keystore file will only be updated upon re-issuance.
        /// </summary>
        public readonly bool Create;
        /// <summary>
        /// PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the PKCS12 keystore.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2.CertificateSpecKeystoresPkcs12PasswordSecretRef PasswordSecretRef;

        [OutputConstructor]
        private CertificateSpecKeystoresPkcs12(
            bool create,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Alpha2.CertificateSpecKeystoresPkcs12PasswordSecretRef passwordSecretRef)
        {
            Create = create;
            PasswordSecretRef = passwordSecretRef;
        }
    }
}
