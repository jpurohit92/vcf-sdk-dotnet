# Vcenter.ViJson.OpenApi.Model.CloneVAppRequestType
The parameters of *VirtualApp.CloneVApp_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the new vApp.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The parent entity of the new vApp. Must be of type *ResourcePool* or *VirtualApp*.  Refers instance of *ResourcePool*.  | 
**Spec** | [**VAppCloneSpec**](VAppCloneSpec.md) | Specifies how to clone the vApp.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

