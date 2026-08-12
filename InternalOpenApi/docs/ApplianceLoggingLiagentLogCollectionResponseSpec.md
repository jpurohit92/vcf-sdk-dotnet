# Vcenter.Automation.OpenApi.Model.ApplianceLoggingLiagentLogCollectionResponseSpec
The Appliance.Logging.Liagent.LogCollection.ResponseSpec schema describes the loginsight agent configuration in vCenter.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Specifies whether log collection is enabled for this unit.  This property was added in __vSphere API 9.1.0.0__. | 
**Unitid** | **string** | A unique identifier for the log collection unit, typically aligned with the component&#39;s logical or infrastructure identity.  This property was added in __vSphere API 9.1.0.0__. | 
**Unittype** | **string** | Value indicating the nature of the component (vCenterServer or ESXi)  Possible values:   - &#x60;VCENTER&#x60;: The vCenter server control unit.   - &#x60;ESX&#x60;: ESXi server unit.   For more information see: *Appliance.Logging.Liagent.LogCollection.UnitType*.  This property was added in __vSphere API 9.1.0.0__. | 
**Status** | **string** | Status indicates the configuration status of loginsight in vCenter. This can have the values : \&quot;NOT_CONFIGURED\&quot;, \&quot;CONFIGURED\&quot; or \&quot;FAILED\&quot;  Possible values:   - &#x60;NOT_CONFIGURED&#x60;: Log insight agent is not configured.   - &#x60;CONFIGURED&#x60;: Configuration was received and applied.   - &#x60;FAILED&#x60;: Failed to apply the configuration.   For more information see: *Appliance.Logging.Liagent.LogCollection.ResponseSpec.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**Message** | **string** | Error or success message, post configuration of loginsight. Example : \&quot;An unexpected error occurred while applying the configuration.\&quot; or \&quot;Configuration was received and applied.\&quot;  This property was added in __vSphere API 9.1.0.0__. | 
**Content** | **string** | The raw text/string content of the loginsight agent configuration configured within vCenter.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, there is no content to be shown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

