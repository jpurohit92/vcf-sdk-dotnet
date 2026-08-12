# Vcenter.ViJson.OpenApi.Model.DatastoreCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectoryHierarchySupported** | **bool** | Indicates whether or not directories can be created on this datastore.  | 
**RawDiskMappingsSupported** | **bool** | Indicates whether or not raw disk mappings can be created on this datastore.  | 
**PerFileThinProvisioningSupported** | **bool** | Indicates whether or not the datastore supports thin provisioning on a per file basis.  When thin provisioning is used, backing storage is lazily allocated.  This is supported by VMFS3. VMFS2 always allocates storage eagerly. Thus, this value is false for VMFS2. Most NAS systems always use thin provisioning. They do not support configuring this on a per file basis, so for NAS systems this value is also false.  | 
**StorageIORMSupported** | **bool** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Indicates whether the datastore supports Storage I/O Resource Management.  | 
**NativeSnapshotSupported** | **bool** | Indicates whether the datastore supports native snapshot feature which is based on Copy-On-Write.  | 
**TopLevelDirectoryCreateSupported** | **bool** | Indicates whether the datastore supports traditional top-level directory creation.  See also *DatastoreNamespaceManager*.  | [optional] 
**SeSparseSupported** | **bool** | Indicates whether the datastore supports the Flex-SE(SeSparse) feature.  | [optional] 
**VmfsSparseSupported** | **bool** | Indicates whether the datastore supports the vmfsSparse feature.  True for VMFS3/VMFS5/NFS/NFS41, False for VMFS6. If value is undefined, then it should be read as supported.  | [optional] 
**VsanSparseSupported** | **bool** | Indicates whether the datastore supports the vsanSparse feature.  | [optional] 
**UpitSupported** | **bool** | Deprecated as of vSphere API 8.0, and there is no replacement for it.  Indicates whether the datastore supports the upit feature.  | [optional] 
**VmdkExpandSupported** | **bool** | On certain datastores (e.g.  2016 PMEM datastore) VMDK expand is not supported. This field tells user if VMDK on this datastore can be expanded or not. If value is undefined, then it should be read as supported.  | [optional] 
**ClusteredVmdkSupported** | **bool** | Indicates whether the datastore supports clustered VMDK feature.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

