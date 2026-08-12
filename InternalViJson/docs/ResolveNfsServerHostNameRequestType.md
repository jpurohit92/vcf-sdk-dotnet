# Vcenter.ViJson.OpenApi.Model.ResolveNfsServerHostNameRequestType
The parameters of *HostDatastoreSystem.ResolveNfsServerHostName*.  ***Since:*** vSphere API Release 9.1.0.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | **string** | Host name of the NFS server.  | 
**VolumeName** | **string** | Volume name of the NFS file system.  | [optional] 
**Force** | **bool** | Flag for forced resolution of the host name of the NFS server, even if the volumes are not in APD state. If unset, force flag will be treated as false.  | [optional] 
**IsNFS41** | **bool** | Indicates whether host name is resolved for NFSv41 file system. If unset, host name is resolved for NFSv3 file system.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

