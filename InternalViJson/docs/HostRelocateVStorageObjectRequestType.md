# Vcenter.ViJson.OpenApi.Model.HostRelocateVStorageObjectRequestType
The parameters of *HostVStorageObjectManager.HostRelocateVStorageObject_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the source virtual storage object is located.  Refers instance of *Datastore*.  | 
**Spec** | [**VslmRelocateSpec**](VslmRelocateSpec.md) | The specification for relocation of the virtual storage object.  | 
**IsLcParentAttached** | **bool** | ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

