# Vcenter.ViJson.OpenApi.Model.CopyVirtualDiskRequestType
The parameters of *VirtualDiskManager.CopyVirtualDisk_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceName** | **string** | The name of the source, either a datastore path or a URL referring to the virtual disk to be copied.  | 
**SourceDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;sourceName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;sourceName&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 
**DestName** | **string** | The name of the destination, either a datastore path or a URL referring to the virtual disk to be created.  | 
**DestDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;destName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, it is assumed that the destination path belongs to the source datacenter.  Refers instance of *Datacenter*.  | [optional] 
**DestSpec** | [**VirtualDiskSpec**](VirtualDiskSpec.md) | The specification of the virtual disk to be created. If not specified, a preallocated format and busLogic adapter type is assumed.  | [optional] 
**Force** | **bool** | The force flag is currently ignored. The FileAlreadyExists fault is thrown if the destination file already exists.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

