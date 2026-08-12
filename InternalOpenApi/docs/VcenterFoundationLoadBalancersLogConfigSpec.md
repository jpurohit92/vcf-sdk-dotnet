# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersLogConfigSpec
The Vcenter.FoundationLoadBalancers.LogConfigSpec schema defines the load balancer log configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogVerbosity** | **string** | Node log level for logging specified events.  Possible values:   - &#x60;DEBUG&#x60;: Debug level.   - &#x60;INFO&#x60;: Info level.   - &#x60;NOTICE&#x60;: Notice level.   - &#x60;WARNING&#x60;: Warning level.   - &#x60;ERROR&#x60;: Error level.   - &#x60;CRITICAL&#x60;: Critical level.   - &#x60;FATAL&#x60;: Fatal level.   For more information see: *Vcenter.FoundationLoadBalancers.LogConfigSpec.LogLevel*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the default value is INFO. | [optional] 
**SyslogServer** | **string** | Syslog server forwarding configuration, its format follows protocol://hostname|ipv4[:port]. The protocol can be tcp, udp or tls. &#39;tcp&#39; means transmission of log to server via TCP channel, &#39;udp&#39; means transmission log to server via UDP channel, &#39;tls&#39; means transmission via a TLS-encrypted channel.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the default value is empty, it won&#39;t forward log to syslog server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

