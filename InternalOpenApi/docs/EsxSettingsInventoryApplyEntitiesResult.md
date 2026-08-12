# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryApplyEntitiesResult
The Esx.Settings.Inventory.ApplyEntitiesResult schema contains the overall results of a com.vmware.esx.settings.repository.Inventory#apply operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatacenterResults** | [**Dictionary&lt;string, EsxSettingsInventoryApplyEntityResult&gt;**](EsxSettingsInventoryApplyEntityResult.md) | Statuses on datacenters.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;Datacenter&#x60;. | 
**FolderResults** | [**Dictionary&lt;string, EsxSettingsInventoryApplyEntityResult&gt;**](EsxSettingsInventoryApplyEntityResult.md) | Statuses on folders.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;Folder&#x60;. | 
**ClusterResults** | [**Dictionary&lt;string, EsxSettingsInventoryApplyEntityResult&gt;**](EsxSettingsInventoryApplyEntityResult.md) | Statuses on clusters.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**HostResults** | [**Dictionary&lt;string, EsxSettingsInventoryApplyEntityResult&gt;**](EsxSettingsInventoryApplyEntityResult.md) | Statuses on hosts.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

