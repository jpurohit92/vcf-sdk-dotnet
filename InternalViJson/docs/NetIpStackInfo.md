# Vcenter.ViJson.OpenApi.Model.NetIpStackInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Neighbor** | [**List&lt;NetIpStackInfoNetToMedia&gt;**](NetIpStackInfoNetToMedia.md) | Zero, one or more entries of neighbors discovered using ARP or NDP.  This information is used to help diagnose connectivity or performance issues. This property maps to RFC 4293 ipNetToPhysicalTable.  | [optional] 
**DefaultRouter** | [**List&lt;NetIpStackInfoDefaultRouter&gt;**](NetIpStackInfoDefaultRouter.md) | Zero one or more entries of discovered IP routers that are directly reachable from an interface on this system.  This property maps to RFC 4293 ipDefaultRouterTable.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

