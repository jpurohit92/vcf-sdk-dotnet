# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsServiceStatusInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.ServiceStatus.Info schema contains information that describes the status of the service.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service health status.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Service is functioning normally.   - &#x60;WARNING&#x60;: Service is functioning, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Service is not functioning.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.ServiceStatus.Health*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Details regarding the health of the service.    When the service Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.ServiceStatus.Health is not *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.ServiceStatus.Health.OK* or *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.ServiceStatus.Health.NONE*, this member will provide an actionable description of the issues present.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

