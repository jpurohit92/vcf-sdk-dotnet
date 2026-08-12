# Vcenter.ViJson.OpenApi.Model.SetVirtualDiskUuidRequestType
The parameters of *VirtualDiskManager.SetVirtualDiskUuid*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the disk, either a datastore path or a URL referring to the virtual disk whose SCSI inquiry page 0x83 data should be set.  | 
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;name&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;name&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 
**Uuid** | **string** | The hex representation of the unique ID for this virtual disk.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

