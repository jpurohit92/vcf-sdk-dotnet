# Vcenter.ViJson.OpenApi.Model.VMwareDvsLacpGroupConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The generated key as the identifier for the Link Aggregation group.  | [optional] 
**Name** | **string** | The display name.  | [optional] 
**Mode** | **string** | The mode of Link Aggregation Control Protocol.  See *VMwareUplinkLacpMode_enum* for valid values.  | [optional] 
**UplinkNum** | **int** | The number of uplink ports.  | [optional] 
**LoadbalanceAlgorithm** | **string** | Load balance policy.  See *VMwareDvsLacpLoadBalanceAlgorithm_enum* for valid values.  | [optional] 
**Vlan** | [**VMwareDvsLagVlanConfig**](VMwareDvsLagVlanConfig.md) | The VLAN Specification of the Uplink Ports in the Link Aggregation group.  | [optional] 
**Ipfix** | [**VMwareDvsLagIpfixConfig**](VMwareDvsLagIpfixConfig.md) | Deprecated as of vSphere API 9.1.  Ipfix configuration of the Link Aggregation Control Protocol group.  Since the 9.1 release, ipfix monitoring can not be enabled on Link Aggregation group anymore. Because *VMwareDVSPortgroupPolicy.ipfixOverrideAllowed* can not be set to True on uplink portgroups.  | [optional] 
**UplinkName** | **List&lt;string&gt;** | Names for the Uplink Ports in the group.  This property is ignored in an update operation.  | [optional] 
**UplinkPortKey** | **List&lt;string&gt;** | Keys for the Uplink Ports in the group.  This property is ignored in an update operation.  | [optional] 
**TimeoutMode** | **string** | The timeout mode of LACP group.  See *VMwareUplinkLacpTimeoutMode_enum* for valid values.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

