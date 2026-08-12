# Vcenter.ViJson.OpenApi.Model.NotSupportedHostInDvs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the unsupported product if available; for example, \&quot;VMware ESX Server\&quot;.  | [optional] 
**ProductVersion** | **string** | The version of the unsupported product; for example, \&quot;1.5.2\&quot;  | [optional] 
**SwitchProductSpec** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | The product spec of the DVS.  This determines which host versions may participate in the DVS; that information may be queried by using *DistributedVirtualSwitchManager.QueryDvsCompatibleHostSpec*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

