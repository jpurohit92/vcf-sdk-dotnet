# Vcenter.ViJson.OpenApi.Model.HostDatastoreSystemCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NfsMountCreationRequired** | **bool** | Indicates whether mounting the NFS volume is required to be done as part of NAS datastore creation.  If this is set to true, then NAS datastores cannot be created for currently mounted NFS volumes.  | 
**NfsMountCreationSupported** | **bool** | Indicates whether mounting an NFS volume is supported when a NAS datastore is created.  If this option is false, then NAS datastores corresponding to NFS volumes can be created only for already mounted NFS volumes.  | 
**LocalDatastoreSupported** | **bool** | Indicates whether local datastores are supported.  | 
**VmfsExtentExpansionSupported** | **bool** | Indicates whether vmfs extent expansion is supported.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

