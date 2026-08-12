# Vcenter.Automation.OpenApi.Model.ApplianceSystemStorageStorageMapping
The Appliance.System.Storage.StorageMapping schema describes the mapping between VCSA partitions and the Hard disk numbers visible in the vSphere Web Client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | **string** | The disk number in the vSphere Web Client.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.system.storage&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.system.storage&#x60;. | 
**Partition** | **string** | Storage partition name. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of partition  This property was added in __vSphere API 6.7__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

