# Vcenter.ViJson.OpenApi.Model.FeatureRequirementsNotMet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeatureRequirement** | [**List&lt;VirtualMachineFeatureRequirement&gt;**](VirtualMachineFeatureRequirement.md) | The feature requirements that were not met.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine whose feature requirements were not met.  Refers instance of *VirtualMachine*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host whose capabilities did not meet the virtual machine&#39;s feature requirements.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

