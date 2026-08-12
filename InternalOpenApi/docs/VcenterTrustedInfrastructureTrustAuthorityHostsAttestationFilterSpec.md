# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityHostsAttestationFilterSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityHosts.Attestation.FilterSpec schema contains the data necessary for identifying a Attestation Service  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A set of host IDs by which to filter the services.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by the hosts on which they run.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Clusters** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A set of cluster IDs by which to filter the services.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by the clusters on which they run.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Address** | [**List&lt;VcenterTrustedInfrastructureNetworkAddress&gt;**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s address.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by address. | [optional] 
**Groups** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group IDs determines which Attestation Service instances this Attestation Service can communicate with.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the services will not be filtered by groupId. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

