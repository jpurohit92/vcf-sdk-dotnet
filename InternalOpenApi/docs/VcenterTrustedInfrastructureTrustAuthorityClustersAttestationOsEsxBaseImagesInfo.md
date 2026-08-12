# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersAttestationOsEsxBaseImagesInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Os.Esx.BaseImages.Info schema contains information that describes an ESX base image.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A unique ESX version formatted for display.  This property was added in __vSphere API 7.0.0.0__. | 
**LastAttestedTime** | **DateTime** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The last time that an attestation completed successfully using this ESX base image.  This property was added in __vSphere API 8.0.1.0__.  If missing or &#x60;null&#x60;, then there is no known last attestation time using this ESX base image. | [optional] 
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A health indicator which indicates whether each host in the cluster has this version of the ESX base image.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Each host in the cluster is in consistent state with the rest hosts in the cluster.   - &#x60;WARNING&#x60;: Attestation is functioning, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Not all hosts in the cluster are in consistent state.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Os.Esx.BaseImages.Health*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Details regarding the health.    When the Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Os.Esx.BaseImages.Health is not *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Os.Esx.BaseImages.Health.OK* or *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Os.Esx.BaseImages.Health.NONE*, this member will provide an actionable description of the issues present.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

