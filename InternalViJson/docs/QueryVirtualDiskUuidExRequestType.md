# Vcenter.ViJson.OpenApi.Model.QueryVirtualDiskUuidExRequestType
The parameters of *VcenterVStorageObjectManager.QueryVirtualDiskUuidEx*.  ***Since:*** vSphere API Release 8.0.3.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the disk, either a datastore path or a URL referring to the virtual disk whose uuid for the DDB entry needs to be queried. A datastore path has the form &gt; \\[_datastore_\\] _path_  where - _datastore_ is the datastore name. - _path_ is a slash-delimited path from the root of the datastore.  An example datastore path is \&quot;\\[storage\\] path/to/file.extension\&quot;.  | 
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;name&lt;/code&gt; is a datastore path, the datacenter for that datastore path is mandatory. Not needed when invoked directly on ESX. If not specified on a call from VirtualCenter, &lt;code&gt;name&lt;/code&gt; must be a URL.  Refers instance of *Datacenter*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

