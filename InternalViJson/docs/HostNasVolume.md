# Vcenter.ViJson.OpenApi.Model.HostNasVolume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | FileSystemType of this particular file system See *HostFileSystemVolumeFileSystemType_enum*  | 
**Name** | **string** | Name of the file system volume.  | 
**Capacity** | **long** | The capacity of the file system volume, in bytes.  | 
**RemoteHost** | **string** | The host that runs the NFS/CIFS server.  Clients must plan to use remoteHostNames for both NFS v3 as well as NFS v4.1 because this field remoteHost may be deprecated in future.  | 
**RemotePath** | **string** | The remote path of NFS/CIFS mount point.  | 
**UserName** | **string** | In case of CIFS, the user name used while connecting to the server.  | [optional] 
**RemoteHostNames** | **List&lt;string&gt;** | This field will hold host names (or ip addresses) of all remote hosts configured for the datastore.  In case of NFS v3 it will have one hostname which will be the same value as in remoteHost defined above. In case of NFS v4.1 if the NFS Client detects additional hostnames or ip addresses during its negotiations with the NFS server, those additional host names (connections) will be added to this list after the datastore is created. Addition of hostnames to this list is limited to MDS server host names or the IP addresses. In other words, the Data Server host names IP addresses will not be appended to this list.  | [optional] 
**SecurityType** | **string** | Security type the volume is currently using.  See *HostNasVolumeSecurityType_enum*  | [optional] 
**ProtocolEndpoint** | **bool** | Indicates that this NAS volume is protocol endpoint.  This property will be populated if and only if host supports VirtualVolume based Datastore. Check the host capability *HostCapability.virtualVolumeDatastoreSupported*. See *HostProtocolEndpoint*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

