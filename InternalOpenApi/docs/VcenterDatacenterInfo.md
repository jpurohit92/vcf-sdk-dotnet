# Vcenter.Automation.OpenApi.Model.VcenterDatacenterInfo
The Vcenter.Datacenter.Info schema contains information about a datacenter in vCenter Server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the datacenter. | 
**DatastoreFolder** | **string** | The root datastore folder associated with the datacenter.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | 
**HostFolder** | **string** | The root host and cluster folder associated with the datacenter.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | 
**NetworkFolder** | **string** | The root network folder associated with the datacenter.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | 
**VmFolder** | **string** | The root virtual machine folder associated with the datacenter.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

