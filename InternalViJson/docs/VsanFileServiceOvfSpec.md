# Vcenter.ViJson.OpenApi.Model.VsanFileServiceOvfSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The release version of the vSAN file services OVF.  In vCenter, it will keep at most one instance of the OVF for each version. Besides the version number, the build number will be attached in this field.  | [optional] 
**UpdateTime** | **DateTime** | The update time tracks the time when this vSAN file service OVF is installed into the repository of the vCenter.  | [optional] 
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The task tracking the vSAN file service OVF download operation.  If the task is not present, it means that the OVF has been uploaded successfully.  Refers instance of *Task*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

