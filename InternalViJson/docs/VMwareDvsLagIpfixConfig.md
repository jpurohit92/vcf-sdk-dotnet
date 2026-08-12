# Vcenter.ViJson.OpenApi.Model.VMwareDvsLagIpfixConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpfixEnabled** | **bool** | True if ipfix monitoring is enabled in the Link Aggregation Control Protocol group.  If set, this property will override the ipfix configuration of Uplink Ports in the Link Aggregation Control Protocol group. Thus they are no longer inheriting ipfix configuration from their Uplink Port Group. Setting this property would require *VMwareDVSPortgroupPolicy.ipfixOverrideAllowed* of all the Uplink Port Groups to be true, otherwise ConflictingConfiguration fault will be raised.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

