# Vcenter.Automation.OpenApi.Model.VcenterPhmHardwareSupportManagersManagedHostsListResult
The Vcenter.Phm.HardwareSupportManagers.ManagedHosts.ListResult schema contains a list of managed hosts stored by proactive hardware management, see *GET /vcenter/phm/hardware-support-managers/{key}/managed-hosts*.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagedHosts** | **List&lt;string&gt;** | All managed hosts stored at PHM side.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

