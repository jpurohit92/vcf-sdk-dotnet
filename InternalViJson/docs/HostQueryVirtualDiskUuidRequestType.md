# Vcenter.ViJson.OpenApi.Model.HostQueryVirtualDiskUuidRequestType
The parameters of *HostVStorageObjectManager.HostQueryVirtualDiskUuid*.  ***Since:*** vSphere API Release 8.0.3.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the disk, either a datastore path or a URL referring to the virtual disk whose uuid for the DDB entry needs to be queried. A URL has the form &gt; _scheme_://_authority_/folder/_path_?dsName&#x3D;_dsName_  where - _scheme_ is &lt;code&gt;http&lt;/code&gt; or &lt;code&gt;https&lt;/code&gt;. - _authority_ specifies the hostname or IP address of the VirtualCenter or   ESX server and optionally the port. - _dsName_ is the name of the Datastore. - _path_ is a slash-delimited path from the root of the datastore.  A datastore path has the form &gt; \\[_datastore_\\] _path_  where - _datastore_ is the datastore name. - _path_ is a slash-delimited path from the root of the datastore.  An example datastore path is \&quot;\\[storage\\] path/to/file.extension\&quot;.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

