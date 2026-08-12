# Vcenter.ViJson.OpenApi.Model.VosSetVsanObjectPolicyRequestType
The parameters of *VsanObjectSystem.VosSetVsanObjectPolicy*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** Global.Settings  Refers instance of *ComputeResource*.  | [optional] 
**VsanObjectUuid** | **string** | vSAN object UUID.  | 
**Profile** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | See above description for all possible options.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

