# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersKmsServicesSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Kms.Services.Summary schema contains basic information about a registered Key Provider Service instance that is configured for a cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s unique identifier.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. | 
**Address** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s address.  This property was added in __vSphere API 7.0.0.0__. | 
**Group** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group determines the Attestation Service instances this Key Provider Service can accept reports from.  This property was added in __vSphere API 7.0.0.0__. | 
**TrustAuthorityCluster** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The cluster specifies the Trust Authority Cluster this Key Provider Service belongs to.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

