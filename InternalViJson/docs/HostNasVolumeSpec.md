# Vcenter.ViJson.OpenApi.Model.HostNasVolumeSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteHost** | **string** | The host that runs the NFS v3 or CIFS server.  For NFS v4.1 and beyond use remoteHostNames defined later. The field remotehost may be deprecated in future for NFS, so clients should plan to use the property remoteHostNames to send in the host name(s) for both NFS v3 and v4.1  | 
**RemotePath** | **string** | The remote path of the NFS mount point.  | 
**LocalPath** | **string** | The localPath refers to the name of the NAS datastore to be created using this specification.  In the case of ESX Server, the datastore name is a component in the file system path at which the NAS volume can be found. For example, if localPath is set to \&quot;nas\\_volume\&quot; the created NAS datastore will be named \&quot;nas\\_volume\&quot; and it can be accessed via the file system path \&quot;/vmfs/volumes/nas\\_volume\&quot;.  In the case of VMware Server, the localPath will also be used as the datastore name, but the datastore name may not necessarily be reflected in the file system path where the NAS volume may be accessed.  | 
**AccessMode** | **string** | Access mode for the mount point.  Mounting in read-write mode would be successful irregardless on how the mount point is exported or access permissions. For example, mounting a volume that is exported as read-only as readWrite will succeed. Hence, that a readWrite mount succeeds should not be taken as an indication that all files on a mount is writable.  If a file system is mounted readOnly, the system cannot create or modify any files on the file system. This is mostly useful for storing ISO images and templates, since a virtual machine cannot be powered on from a readOnly volume.  The access mode of a mounted NFS volume can be obtained at *HostMountInfo.accessMode*.  See also *HostMountMode_enum*.  | 
**Type** | **string** | Specifies the type of the the NAS volume.  Supported types are *CIFS*, *NFS*, *NFS41* If not specified, defaults to *NFS*  | [optional] 
**UserName** | **string** | If type is CIFS, the user name to use when connecting to the CIFS server.  If type is NFS, this field will be ignored.  | [optional] 
**Password** | **string** | If type is CIFS, the password to use when connecting to the CIFS server.  If type is NFS, this field will be ignored.  | [optional] 
**RemoteHostNames** | **List&lt;string&gt;** | Hostnames or IP addresses of remote NFS server.  In case of NFS v4.1 this may have multiple entries. For NFS v3 the input should be same in both remoteHost and remoteHostNames. In case of NFS v4.1, if vmknic binding is enabled, then input can be in format {hostip1:vmknic1, hostip2:vmknic2}.  | [optional] 
**SecurityType** | **string** | Provided during mount indicating what security type, if any, to use See *HostNasVolumeSecurityType_enum*  | [optional] 
**VmknicToBind** | **string** | Name of the vmknic to be used by this mount.  This field will be updated by a client with vmknic that will be used for NAS volume mount operation for vmknic binding.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**VmknicBound** | **bool** | Indicates whether a client wants to bind this mount to vmknic.  This field will be set to true by a client if vmknic should bind during NAS volume mount operation, else it will be set to false.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**Connections** | **int** | Indicates the number of TCP connections for the particular NFS Server during NAS volume mount operation.  If unset or set to 0, it defaults to one connection  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

