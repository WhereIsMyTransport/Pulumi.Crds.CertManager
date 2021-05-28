// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1Beta1
{

    [OutputType]
    public sealed class CertificateSpecPrivateKey
    {
        /// <summary>
        /// Algorithm is the private key algorithm of the corresponding private key for this certificate. If provided, allowed values are either `RSA` or `ECDSA` If `algorithm` is specified and `size` is not provided, key size of 256 will be used for `ECDSA` key algorithm and key size of 2048 will be used for `RSA` key algorithm.
        /// </summary>
        public readonly string Algorithm;
        /// <summary>
        /// The private key cryptography standards (PKCS) encoding for this certificate's private key to be encoded in. If provided, allowed values are `PKCS1` and `PKCS8` standing for PKCS#1 and PKCS#8, respectively. Defaults to `PKCS1` if not specified.
        /// </summary>
        public readonly string Encoding;
        /// <summary>
        /// RotationPolicy controls how private keys should be regenerated when a re-issuance is being processed. If set to Never, a private key will only be generated if one does not already exist in the target `spec.secretName`. If one does exists but it does not have the correct algorithm or size, a warning will be raised to await user intervention. If set to Always, a private key matching the specified requirements will be generated whenever a re-issuance occurs. Default is 'Never' for backward compatibility.
        /// </summary>
        public readonly string RotationPolicy;
        /// <summary>
        /// Size is the key bit size of the corresponding private key for this certificate. If `algorithm` is set to `RSA`, valid values are `2048`, `4096` or `8192`, and will default to `2048` if not specified. If `algorithm` is set to `ECDSA`, valid values are `256`, `384` or `521`, and will default to `256` if not specified. No other values are allowed.
        /// </summary>
        public readonly int Size;

        [OutputConstructor]
        private CertificateSpecPrivateKey(
            string algorithm,

            string encoding,

            string rotationPolicy,

            int size)
        {
            Algorithm = algorithm;
            Encoding = encoding;
            RotationPolicy = rotationPolicy;
            Size = size;
        }
    }
}
