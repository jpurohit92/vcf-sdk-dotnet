# Vcenter.Automation.OpenApi.Model.ApplianceLoggingLiagentLogCollectionConfig
The Appliance.Logging.Liagent.LogCollection.Config schema defines the configurations for loginsight agent to stream vCenter service logs to loginsight server.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Specifies whether log collection is enabled for this unit. If set to &#39;false&#39;, the &#39;content&#39; field will contain the appropriate configuration required to disable log collection for the underlying loginsight agent.  This property was added in __vSphere API 9.1.0.0__. | 
**Unitid** | **string** | A unique identifier for the log collection unit, typically aligned with the component&#39;s logical or infrastructure identity.  This property was added in __vSphere API 9.1.0.0__. | 
**Unittype** | **string** | Value indicating the nature of the component (vCenterServer or ESXi)  Possible values:   - &#x60;VCENTER&#x60;: The vCenter server control unit.   - &#x60;ESX&#x60;: ESXi server unit.   For more information see: *Appliance.Logging.Liagent.LogCollection.UnitType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Content** | **string** | The raw text/string content for the loginsight agent&#39;s configuration.  This property was added in __vSphere API 9.1.0.0__. | 
**Host** | **string** | The hostname of the loginsight server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, host is not required when the liagent is being disabled. | [optional] 
**Port** | **long** | The port number for sending log traffic to the specified loginsight server. Used in conjunction with the &#39;host&#39; field to fully identify the log destination endpoint.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, port is not required when the liagent is being disabled. | [optional] 
**Protocol** | **string** | The protocol used for forwarding logs. Currently supported values are \&quot;cfapi\&quot; and \&quot;syslog\&quot;.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, protocol is not required when the liagent is being disabled. | [optional] 
**Loglevel** | **string** | Desired overall log verbosity for the component.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, loglevel is not required for vcenter, as it will be controlled in the config content. | [optional] 
**Certificates** | **List&lt;string&gt;** | List of PEM-encoded Certificates which will be configured to establish trust with Log insight server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, there is no certificate to be used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

