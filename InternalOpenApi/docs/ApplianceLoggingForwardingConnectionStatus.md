# Vcenter.Automation.OpenApi.Model.ApplianceLoggingForwardingConnectionStatus
This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | FQDN or IP address of the configured remote logging servers.  This property was added in __vSphere API 6.7__. | 
**State** | **string** | State of the configured remote logging server.  Possible values:   - &#x60;UP&#x60;: The remote logging server is reachable.   - &#x60;DOWN&#x60;: The remote logging server is not reachable.   - &#x60;UNKNOWN&#x60;: The status of remote logging server is unknown.   For more information see: *Appliance.Logging.Forwarding.ConnectionStatus.State*.  This property was added in __vSphere API 6.7__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Message associated with the state of the configured remote logging server.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, there is no message to be shown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

