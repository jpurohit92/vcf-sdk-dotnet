# Vcenter.ViJson.OpenApi.Model.VirtualNVDIMMBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** | Filename for the host file used in this backing.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the datastore managed object where this file is stored.  If the file is not located on a datastore, then this reference is null. This is not used for configuration.  Refers instance of *Datastore*.  | [optional] 
**BackingObjectId** | **string** | Backing object&#39;s durable and unmutable identifier.  Each backing object has a unique identifier which is not settable.  | [optional] 
**Parent** | [**VirtualNVDIMMBackingInfo**](VirtualNVDIMMBackingInfo.md) | Parent object in snapshot chain.  | [optional] 
**ChangeId** | **string** | The change ID of the virtual NVDIMM for the corresponding snapshot of virtual machine.  This can be used to track incremental changes. See *VirtualMachine.QueryChangedDiskAreas*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

