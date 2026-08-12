# Vcenter.ViJson.OpenApi.Model.GuestNicInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Name of the virtual switch portgroup or dvPort connected to this adapter.  | [optional] 
**IpAddress** | **List&lt;string&gt;** | Deprecated as of vSphere API 5.0, use ipConfig property.  IP addresses of the adapter.  | [optional] 
**MacAddress** | **string** | MAC address of the adapter.  | [optional] 
**Connected** | **bool** | Flag indicating whether or not the virtual device is connected.  | 
**DeviceConfigId** | **int** | Link to the corresponding virtual device.  | 
**DnsConfig** | [**NetDnsConfigInfo**](NetDnsConfigInfo.md) | DNS configuration of the adapter.  This property is set only when Guest OS supports it. See *GuestStackInfo* dnsConfig for system wide settings.  | [optional] 
**IpConfig** | [**NetIpConfigInfo**](NetIpConfigInfo.md) | IP configuration settings of the adapter See *GuestStackInfo* ipStackConfig for system wide settings.  | [optional] 
**NetBIOSConfig** | [**NetBIOSConfigInfo**](NetBIOSConfigInfo.md) | NetBIOS configuration of the adapter  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

