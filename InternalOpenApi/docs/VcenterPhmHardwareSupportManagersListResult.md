# Vcenter.Automation.OpenApi.Model.VcenterPhmHardwareSupportManagersListResult
The Vcenter.Phm.HardwareSupportManagers.ListResult schema contains a list of registered hardware support manager keys, see *GET /vcenter/phm/hardware-support-managers*.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegisteredHsmKeys** | **List&lt;string&gt;** | List of registered HSM keys.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.phm.HardwareSupportManager&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.phm.HardwareSupportManager&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

