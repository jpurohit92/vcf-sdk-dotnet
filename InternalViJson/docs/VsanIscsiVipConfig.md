# Vcenter.ViJson.OpenApi.Model.VsanIscsiVipConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether virtual IP (VIP) is enabled or not, disabled if it is not specified.  | [optional] 
**V4NetworkConfig** | [**VsanVipNetworkConfig**](VsanVipNetworkConfig.md) | IPv4 network configurations for Virtual IP.  If provided, Virtual IP will use IPv4 network. At least one of v4NetworkConfig and v6NetworkConfig should be provided for Virtual IP enablement.  | [optional] 
**V6NetworkConfig** | [**VsanVipNetworkConfig**](VsanVipNetworkConfig.md) | IPv6 network configurations for Virtual IP.  If provided, Virtual IP will use IPv6 network. At least one of v4NetworkConfig and v6NetworkConfig should be provided for Virtual IP enablement.  | [optional] 
**VswitchConfig** | [**VsanIscsiVipVswitchConfig**](VsanIscsiVipVswitchConfig.md) | The standard vSwitch configuration for Virtual IP vmkernal adapter.  You can specify this property only if you do no specify *VsanIscsiVipConfigSpec.distributedSwitchConfig*.  | [optional] 
**DistributedSwitchConfig** | [**VsanIscsiVipDVswitchConfig**](VsanIscsiVipDVswitchConfig.md) | The distributed vSwitch configuration for Virtual IP vmkernal adapter.  You can specify this property only if you do no specify *VsanIscsiVipConfigSpec.vswitchConfig*.  | [optional] 
**VmknicName** | **string** | The name of vmkernel adapter that is used by virtual IP.  | [optional] 
**Owner** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host with Virtual IP assigned to its vmknic by vSAN iSCSI service.  Refers instance of *HostSystem*.  | [optional] 
**OwnerHostUuid** | **string** | The uuid of host which currently holds this Virtual IP.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

