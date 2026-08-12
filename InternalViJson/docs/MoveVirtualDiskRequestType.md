# Vcenter.ViJson.OpenApi.Model.MoveVirtualDiskRequestType
The parameters of *VirtualDiskManager.MoveVirtualDisk_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceName** | **string** | The name of the source, either a datastore path or a URL referring to the virtual disk to be moved.  | 
**SourceDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;sourceName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;sourceName&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 
**DestName** | **string** | The name of the destination, either a datastore path or a URL referring to the destination virtual disk.  | 
**DestDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;destName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, it is assumed that the destination path belongs to the source datacenter.  Refers instance of *Datacenter*.  | [optional] 
**Force** | **bool** | If true, overwrite any identically named disk at the destination. If not specified, it is assumed to be false  | [optional] 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | User can specify new set of profile when moving virtual disk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

