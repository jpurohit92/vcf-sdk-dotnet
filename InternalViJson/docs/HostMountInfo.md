# Vcenter.ViJson.OpenApi.Model.HostMountInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Local file path where file system volume is mounted, if applicable.  This path identifies the file system volume from the point of view of the host.  | [optional] 
**AccessMode** | **string** | Access mode to the underlying file system for this host.  | 
**Mounted** | **bool** | The mount state of this mount point.  For a discovered volume, which is mounted, this is true. When this value is unset, the default value is true.  | [optional] 
**Accessible** | **bool** | Flag that indicates if the datastore is currently accessible from the host.  For the case of a standalone host, this property has the same value as *DatastoreSummary*.*DatastoreSummary.accessible*. You can use the *DatastoreSummary* property if the *HostMountInfo* property is not set. The VirtualCenter Server will always make sure the *DatastoreSummary* property is set correctly.  | [optional] 
**InaccessibleReason** | **string** | This optional property for inaccessible reason is reported only if a datastore becomes inaccessible as reported by *HostMountInfo.accessible* and *DatastoreSummary*.*DatastoreSummary.accessible*.  The values for inaccessible reason are defined in the enum *HostMountInfoInaccessibleReason_enum* This helps to determine host specific reason for datastore inaccessibility. If the datastore becomes accessible following an inaccessible condition, the property *HostMountInfo.inaccessibleReason* will be unset.  | [optional] 
**VmknicName** | **string** | The name of the vmknic used during mount for NFSv3 datastore.  Populated by the vmk control layer if the NAS volume is mounted successfully with a vmknic binding. In case of NFS v4.1, if vmknic binding is enabled successfully, then output will be in format {hostip1:vmknic1, hostip2:vmknic2}. If vmknic binding is not enabled, then vmknicName will have &#39;None&#39; string.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**VmknicActive** | **bool** | Indicates whether vmknic is active or inactive.  This field will be populated by vmk control layer during NAS volume mount, and will be set to true if the vmknic binding is active.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**MountFailedReason** | **string** | The optional property which gives the reason for mount operation failure of NFS datastore.  This field is applicable for only those mounts for which retry mount operation is configured. The values for the mount failed reason are defined in the enum *HostMountInfoMountFailedReason_enum*. If mount operation on NFS volume succeeds in the retry, then the property *HostMountInfo.mountFailedReason* will be unset.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NumTcpConnections** | **int** | Maintained for each Host, it indicates the total number of TCP connections for the NAS datastore  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

