# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersAttestationServicesFilterSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.FilterSpec schema contains the data necessary for identifying a Attestation service instance.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Services** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A set of IDs by which to filter the services.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by ID.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.attestation.Service&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.attestation.Service&#x60;. | [optional] 
**Address** | [**List&lt;VcenterTrustedInfrastructureNetworkAddress&gt;**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s address.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by address. | [optional] 
**Group** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group specifies the Key Provider Service instances can accept reports issued by this Attestation Service instance.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by group. | [optional] 
**TrustAuthorityCluster** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The cluster specifies the Trust Authority Cluster this Attestation Service instance belongs to.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by trustAuthorityCluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

