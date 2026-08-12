# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksNetworkSegment
Vcenter.NamespaceManagement.Supervisors.Networks.NetworkSegment schema represents a layer 2 broadcast domain.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Networks** | **List&lt;string&gt;** | List of Standard Port Groups or Distributed Virtual Port Groups or Opaque Network identifiers that are part of the same layer 2 broadcast domain.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Network&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

