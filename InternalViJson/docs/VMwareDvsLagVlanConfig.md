# Vcenter.ViJson.OpenApi.Model.VMwareDvsLagVlanConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VlanId** | [**List&lt;NumericRange&gt;**](NumericRange.md) | The VlanId range for the Uplink Ports in the Link Aggregation Control Protocol group.  The valid VlanId range is from 0 to 4094. Overlapping ranges are allowed. If set, this property will override the VLAN configuration of Uplink Ports in the Link Aggregation Control Protocol group. Thus they are no longer inheriting VLAN configuration from their Uplink Port Group. Setting this property would require *VMwareDVSPortgroupPolicy.vlanOverrideAllowed* of all the Uplink Port Groups to be true, otherwise ConflictingConfiguration fault will be raised.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

