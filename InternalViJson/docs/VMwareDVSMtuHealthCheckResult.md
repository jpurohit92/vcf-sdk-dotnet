# Vcenter.ViJson.OpenApi.Model.VMwareDVSMtuHealthCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UplinkPortKey** | **string** | The uplink port key.  | 
**MtuMismatch** | **bool** | True if the MTU configured in the vSphere Distributed Switch is different from the value configured in the Physical NIC, else false.  If it is true, MTU health check is stopped. In this case, *VMwareDVSMtuHealthCheckResult.vlanSupportSwitchMtu* and *VMwareDVSMtuHealthCheckResult.vlanNotSupportSwitchMtu* will not have values.  | 
**VlanSupportSwitchMtu** | [**List&lt;NumericRange&gt;**](NumericRange.md) | The vlan&#39;s MTU setting on physical switch allows vSphere Distributed Switch max MTU size packets passing.  If the vlan is not a range, but a single Id, both start and end have the same value with the single vlan Id.  | [optional] 
**VlanNotSupportSwitchMtu** | [**List&lt;NumericRange&gt;**](NumericRange.md) | The vlan&#39;s MTU setting on physical switch does not allow vSphere Distributed Switch max MTU size packets passing.  If the vlan is not a range, but a single Id, both start and end have the same value with the single vlan Id.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

