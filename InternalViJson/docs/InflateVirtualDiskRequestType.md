# Vcenter.ViJson.OpenApi.Model.InflateVirtualDiskRequestType
The parameters of *VirtualDiskManager.InflateVirtualDisk_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the disk, either a datastore path or a URL referring to the virtual disk that should be inflated.  | 
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;name&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;name&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

