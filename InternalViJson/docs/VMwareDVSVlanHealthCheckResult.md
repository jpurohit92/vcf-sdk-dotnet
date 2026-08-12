# Vcenter.ViJson.OpenApi.Model.VMwareDVSVlanHealthCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UplinkPortKey** | **string** | The uplink port key.  | 
**TrunkedVlan** | [**List&lt;NumericRange&gt;**](NumericRange.md) | The vlans which are trunked by the physical switch connected to the uplink port.  If the vlan is not a range, but a single Id, both start and end have the same value with the single vlan Id.  | [optional] 
**UntrunkedVlan** | [**List&lt;NumericRange&gt;**](NumericRange.md) | The vlans which are not trunked by the physical switch connected to the uplink port.  If the vlan is not a range, but a single Id, both start and end have the same value with the single vlan Id.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

