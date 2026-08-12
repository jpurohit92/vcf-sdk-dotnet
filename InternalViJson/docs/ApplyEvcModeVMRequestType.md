# Vcenter.ViJson.OpenApi.Model.ApplyEvcModeVMRequestType
The parameters of *VirtualMachine.ApplyEvcModeVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mask** | [**List&lt;HostFeatureMask&gt;**](HostFeatureMask.md) | The feature masks to apply to the virtual machine. An empty set of masks will clear EVC settings.  | [optional] 
**CompleteMasks** | **bool** | Defaults to true if not set. A true value implies that any unspecified feature will not be exposed to the guest. A false value will expose any unspecified feature to the guest with the value of the host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

