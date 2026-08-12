# Vcenter.ViJson.OpenApi.Model.ReleaseManagedSnapshotRequestType
The parameters of *VirtualDiskManager.ReleaseManagedSnapshot*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vdisk** | **string** | \\- The name of the disk to release, either a datastore path or a URL referring to the virtual disk.  | 
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;vdisk&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;vdisk&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

