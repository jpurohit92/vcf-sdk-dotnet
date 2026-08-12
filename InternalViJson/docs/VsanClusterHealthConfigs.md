# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthConfigs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableVsanTelemetry** | **bool** | Enable flag to vSAN telemetry collection.  The flag doesn&#39;t take effect any more and the value will be ignored  | [optional] 
**VsanTelemetryInterval** | **int** | The periodical vSAN telemetry collection interval in minutes.  The smaller value will collect vSAN telemetry more frequently but increase the system overhead and vice versa. The default is one week.  | [optional] 
**VsanTelemetryProxy** | [**VsanClusterTelemetryProxyConfig**](VsanClusterTelemetryProxyConfig.md) | The proxy used for sending vSAN telemetry.  The proxy can be either user configured or auto-discovered and will be applied for collecting all of vSAN telemetry data  | [optional] 
**Configs** | [**List&lt;VsanClusterHealthResultKeyValuePair&gt;**](VsanClusterHealthResultKeyValuePair.md) | Any other vSAN cluster health configurations.  Each of configuration is the key/value pair. Currently, no additional configuration will be supported  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

