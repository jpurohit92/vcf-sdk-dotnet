# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingProxyTestResult
The Appliance.Networking.Proxy.TestResult schema contains information about the test operation done on a proxy server.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the proxy server indicating whether the proxy server is reachable.  Possible values:   - &#x60;SERVER_REACHABLE&#x60;: Server is reachable.   - &#x60;SERVER_UNREACHABLE&#x60;: Server is unreachable.   For more information see: *Appliance.Networking.Proxy.ServerStatus*.  This property was added in __vSphere API 6.7__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Message associated with status.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

