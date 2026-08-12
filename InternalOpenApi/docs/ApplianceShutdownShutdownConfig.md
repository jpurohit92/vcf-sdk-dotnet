# Vcenter.Automation.OpenApi.Model.ApplianceShutdownShutdownConfig
Appliance.Shutdown.ShutdownConfig schema Structure that defines shutdown configuration returned by the Shutdown.get operation  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShutdownTime** | **DateTime** | Shutdown time.  This property was added in __vSphere API 6.7__.  shutdownTime Optional value of pending shutdown time | [optional] 
**Action** | **string** | The pending shutdown operation. The string values for pending operations can be &#39;poweroff&#39;, &#39;reboot&#39; or &#39;&#39;.  This property was added in __vSphere API 6.7__. | 
**Reason** | **string** | The reason behind the shutdown action  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

