# Vcenter.ViJson.OpenApi.Model.HostNetStackInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key of instance For instance which created by host, its value should be *HostNetStackInstanceSystemStackKey_enum*.  | [optional] 
**Name** | **string** | The display name  | [optional] 
**DnsConfig** | [**HostDnsConfig**](HostDnsConfig.md) | DNS configuration  | [optional] 
**IpRouteConfig** | [**HostIpRouteConfig**](HostIpRouteConfig.md) | IP Route configuration  | [optional] 
**RequestedMaxNumberOfConnections** | **int** | The maximum number of socket connection that are requested on this instance  | [optional] 
**CongestionControlAlgorithm** | **string** | The TCP congest control algorithm used by this instance, See *HostNetStackInstanceCongestionControlAlgorithmType_enum* for valid values.  | [optional] 
**IpV6Enabled** | **bool** | Enable or disable IPv6 protocol on this stack instance.  This property is not supported currently.  | [optional] 
**RouteTableConfig** | [**HostIpRouteTableConfig**](HostIpRouteTableConfig.md) |  | [optional] 
**Owner** | **string** | Owner of this stack instance.  It is only valid for showing system net stack instance. The unset means not owned by the system. See *HostConfigChangeOwner_enum* for supported values.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

