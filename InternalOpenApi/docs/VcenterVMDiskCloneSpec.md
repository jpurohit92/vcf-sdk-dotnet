# Vcenter.Automation.OpenApi.Model.VcenterVMDiskCloneSpec
Document-based disk clone spec.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Destination datastore to clone disk.  This property was added in __vSphere API 7.0.0.0__.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60; disk will be copied to the datastore specified in the *Vcenter.VM.ClonePlacementSpec.datastore* property of *Vcenter.VM.CloneSpec.placement*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

