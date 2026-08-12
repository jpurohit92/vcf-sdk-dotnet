# Vcenter.ViJson.OpenApi.Model.VsanHostCreateVmHealthTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The host name  | 
**State** | **string** | The VM creation test state.  All of possible states are \&quot;error\&quot;, \&quot;timeout\&quot; and \&quot;success\&quot;  | 
**Fault** | [**MethodFault**](MethodFault.md) | The exception fault for the VM creation test, which will be set when the host is disconnected, cannot create virtual machine or timed out when creating VM and any exception throwing from destroying the created VM  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

