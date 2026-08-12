# Vcenter.ViJson.OpenApi.Model.VslmCreateSpecRawDiskMappingBackingSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore managed object where this backing is located.  Refers instance of *Datastore*.  | 
**Path** | **string** | Relative location in the specified datastore where disk needs to be created.  If not specified disk gets created at the default VStorageObject location on the specified datastore.  | [optional] 
**LunUuid** | **string** | Unique identifier of the LUN accessed by the raw disk mapping.  | 
**CompatibilityMode** | **string** | The compatibility mode of the raw disk mapping (RDM).  This must be specified when a new virtual disk with an RDM backing is created.  See also *VirtualDiskCompatibilityMode_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

