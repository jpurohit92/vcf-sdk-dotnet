# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureKmsServicesFilterSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.Kms.Services.FilterSpec schema contains the data necessary for identifying a Key Provider Service instance  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Services** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A set of IDs by which to filter the services.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by ID.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.kms.Service&#x60;. | [optional] 
**Address** | [**List&lt;VcenterTrustedInfrastructureNetworkAddress&gt;**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A set of address by which to filter.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by address. | [optional] 
**Group** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group determines the Attestation Service instances this Key Provider Service can accept reports from.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the Services will not be filtered by group. | [optional] 
**TrustAuthorityCluster** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The cluster specifies the Trust Authority Cluster this Key Provider Service belongs to.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the Services will not be filtered by trustAuthorityCluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

