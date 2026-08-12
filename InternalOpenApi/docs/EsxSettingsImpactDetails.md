# Vcenter.Automation.OpenApi.Model.EsxSettingsImpactDetails
The Esx.Settings.ImpactDetails schema contains information that provides more details about the compliance impact.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemoryReservation** | [**EsxSettingsMemoryReservation**](EsxSettingsMemoryReservation.md) | Memory reservation that accompany the partial maintenance mode. If missing or &#x60;null&#x60;, there is no elevated memory usage during and after the remediation.  This property was added in __vSphere API 8.0.3.0__. | [optional] 
**PartialMaintenanceModeName** | **string** | Flavor of the partial maintenance mode. If missing or &#x60;null&#x60;, partial maintenance mode doesn&#39;t apply.  This property was added in __vSphere API 8.0.3.0__. | [optional] 
**PartialMaintenanceModeUpgradeActions** | **List&lt;string&gt;** | Upgrade actions to be performed before exiting partial maintenance mode. If missing or &#x60;null&#x60;, no upgrade action is needed before exiting maintenance mode.  This property was added in __vSphere API 8.0.3.0__. | [optional] 
**SolutionImpacts** | **Dictionary&lt;string, string&gt;** | Partial or full maintenance mode required on host to reach the desired solution state. The key is affected solution name for solution-only remediation, and the value is maintenance mode string of vim.host.PartialMaintenanceModeId or \&quot;fullMaintenanceMode\&quot;: for example: {\&quot;com.vmware.vsphere-wcp\&quot; : \&quot;sphereletPartialMM\&quot;, \&quot;com.vmware.vsphere-nsx\&quot; : \&quot;fullMaintenanceMode\&quot;} If this string value is an unknown enum the behaviour defaults to full maintenance mode. The impact will have an value that is the same or more severe than the maintenance mode (e.g. a reboot) contained in this property.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. | 
**MaintenanceActions** | [**List&lt;EsxSettingsOptionValue&gt;**](EsxSettingsOptionValue.md) | Maintenance actions to be performed when entering the partial maintenance mode flavor.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

