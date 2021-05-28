# Pulumi.Crds.CertManager
C# SDK for Pulumi CertManager resources, generated from CRD

# Use

This is meant to be available as a nuget package.

# Generating the code

The code used here is generated using crd2pulumi

from https://github.com/jetstack/cert-manager/releases/download/v1.3.1/cert-manager.crds.yaml

I modified it slightly so take care if re-generating it.

 -- in KubernetesResources.cs: added

public class CrdsResourceTypeAttribute : ResourceTypeAttribute
{
    public CrdsResourceTypeAttribute(string value)
    :base(value.Split(":")[0],value.Split(":")[1])
    {
            
    }
}

 -- wherever it complained about missing refereences, added 
 
 using Pulumi.Crd;

 (changed crds to Crd namespace too)