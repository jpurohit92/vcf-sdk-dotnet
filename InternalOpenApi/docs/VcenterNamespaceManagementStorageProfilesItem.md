# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementStorageProfilesItem
The Vcenter.NamespaceManagement.Storage.Profiles.Item schema contains the datastores and vSphere Zone which they are in.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | The vSphere Zones the datastore are in.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Datastores** | **List&lt;string&gt;** | The datastores in the zone.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datastore&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

