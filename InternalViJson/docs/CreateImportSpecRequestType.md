# Vcenter.ViJson.OpenApi.Model.CreateImportSpecRequestType
The parameters of *OvfManager.CreateImportSpec*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OvfDescriptor** | **string** | The OVF descriptor of the entity.  | 
**ResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool to import the entity to. May be a vApp.  ***Required privileges:*** VApp.Import  Refers instance of *ResourcePool*.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore on which to create the inventory objects of the entity, for example \&quot;storage1\&quot;. The privilege Datastore.AllocateSpace is required on the datastore.  ***Required privileges:*** Datastore.AllocateSpace  Refers instance of *Datastore*.  | 
**Cisp** | [**OvfCreateImportSpecParams**](OvfCreateImportSpecParams.md) | Additional parameters to the method, bundled in an instance of CreateImportSpecParams.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

