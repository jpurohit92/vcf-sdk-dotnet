# Vcenter.ViJson.OpenApi.Model.ClearVStorageObjectControlFlagsRequestType
The parameters of *VcenterVStorageObjectManager.ClearVStorageObjectControlFlags*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the source virtual storage object is located.  ***Required privileges:*** Datastore.FileManagement  Refers instance of *Datastore*.  | 
**ControlFlags** | **List&lt;string&gt;** | control flags enum array to be cleared on the VStorageObject. All control flags not included in the array remain intact.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

