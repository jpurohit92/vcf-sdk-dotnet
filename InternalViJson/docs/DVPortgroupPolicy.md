# Vcenter.ViJson.OpenApi.Model.DVPortgroupPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockOverrideAllowed** | **bool** | Allow the *DVPortSetting.blocked* setting of an individual port to override the setting in *DVPortgroupConfigInfo.defaultPortConfig* of a portgroup.  | 
**ShapingOverrideAllowed** | **bool** | Allow the *DVPortSetting.inShapingPolicy* or *DVPortSetting.outShapingPolicy* settings of an individual port to override the setting in *DVPortgroupConfigInfo.defaultPortConfig* of a portgroup.  | 
**VendorConfigOverrideAllowed** | **bool** | Allow the *DVPortSetting.vendorSpecificConfig* setting of an individual port to override the setting in *DVPortgroupConfigInfo.defaultPortConfig* of a portgroup.  | 
**LivePortMovingAllowed** | **bool** | Allow a live port to be moved in and out of the portgroup.  | 
**PortConfigResetAtDisconnect** | **bool** | If true, reset the port network setting back to the portgroup setting (thus removing the per-port setting) when the port is disconnected from the connectee.  | 
**NetworkResourcePoolOverrideAllowed** | **bool** | Allow the setting of *DVPortSetting.networkResourcePoolKey* of an individual port to override the setting in *DVPortgroupConfigInfo.defaultPortConfig* of a portgroup.  | [optional] 
**TrafficFilterOverrideAllowed** | **bool** | Allow the setting of *DVPortSetting.filterPolicy*, for an individual port to override the setting in *DVPortgroupConfigInfo.defaultPortConfig* of a portgroup.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

