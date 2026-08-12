# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.Summary schema contains properties that summarize a provider.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Name of the provider.    A unique string chosen by the client.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.kms.Provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.kms.Provider&#x60;. | 
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Health of the provider in the cluster.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Health is normal.   - &#x60;WARNING&#x60;: Health is normal, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Not healthy.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

