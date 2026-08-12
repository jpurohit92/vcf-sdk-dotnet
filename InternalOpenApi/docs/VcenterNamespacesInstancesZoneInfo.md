# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesZoneInfo
The Vcenter.Namespaces.Instances.ZoneInfo schema contains the information for a vSphere Zone related to a Supervisor  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of the vSphere Zone  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Type** | **string** | Identifier of the Type of the vSphere Zone  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisors.zones.Bindings.Type&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisors.zones.Bindings.Type&#x60;. | 
**MarkedForRemoval** | **bool** | &#x60;True&#x60; if the vSphere Zone has been marked for removal  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

