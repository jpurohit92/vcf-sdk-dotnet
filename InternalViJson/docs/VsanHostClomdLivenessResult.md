# Vcenter.ViJson.OpenApi.Model.VsanHostClomdLivenessResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Name of a vSAN host  | 
**ClomdStat** | **string** | Indicate CLOMD state on the vSAN host.  The possible states are &#39;alive&#39;, &#39;abnormal&#39; (if any error occurred during checking the ClOMD state) and &#39;unknown&#39; (if vSAN health service is not installed on the host)  | 
**Error** | [**MethodFault**](MethodFault.md) | Error output for checking CLOMD state on the vSAN host  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

