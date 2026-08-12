# Vcenter.ViJson.OpenApi.Model.VslmServiceInstanceContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AboutInfo** | [**VslmAboutInfo**](VslmAboutInfo.md) | Contains information that identifies the Storage Lifecycle Management service.  | 
**SessionManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | *VslmSessionManager* contains login APIs to connect to VSLM service.  Refers instance of *VslmSessionManager*.  | 
**VStorageObjectManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | *VslmVStorageObjectManager* contains virtual storage object APIs.  Refers instance of *VslmVStorageObjectManager*.  | 
**StorageLifecycleManager** | [**ManagedObjectReference**](ManagedObjectReference.md) | *VslmStorageLifecycleManager* contains callback APIs to VSLM service.  Refers instance of *VslmStorageLifecycleManager*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

