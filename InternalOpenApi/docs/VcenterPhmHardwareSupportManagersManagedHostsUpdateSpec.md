# Vcenter.Automation.OpenApi.Model.VcenterPhmHardwareSupportManagersManagedHostsUpdateSpec
The Vcenter.Phm.HardwareSupportManagers.ManagedHosts.UpdateSpec schema specifies a list of managed hosts added or removed by a proactive hardware management, see *PATCH /vcenter/phm/hardware-support-managers/{key}/managed-hosts*.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostsToAdd** | **List&lt;string&gt;** | A list of managed hosts added by an HSM.  This property was added in __vSphere API 8.0.3.0__.  This property may be missing or &#x60;null&#x60; meaning this update does not contain any newly added managed hosts.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**HostsToRemove** | **List&lt;string&gt;** | A list of managed hosts removed by an HSM.  This property was added in __vSphere API 8.0.3.0__.  This property may be missing or &#x60;null&#x60; meaning this update does not contain any removed managed hosts.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

