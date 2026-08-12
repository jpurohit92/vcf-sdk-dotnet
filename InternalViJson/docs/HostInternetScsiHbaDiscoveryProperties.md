# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaDiscoveryProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ISnsDiscoveryEnabled** | **bool** | True if iSNS is currently enabled  | 
**ISnsDiscoveryMethod** | **string** | The iSNS discovery method in use when iSNS is enabled.  Must be one of the values of *InternetScsiSnsDiscoveryMethod_enum*  | [optional] 
**ISnsHost** | **string** | For STATIC iSNS, this is the iSNS server address  | [optional] 
**SlpDiscoveryEnabled** | **bool** | True if SLP is enabled  | 
**SlpDiscoveryMethod** | **string** | The current SLP discovery method when SLP is enabled.  Must be one of the values of *SlpDiscoveryMethod_enum*  | [optional] 
**SlpHost** | **string** | When the SLP discovery method is set to MANUAL, this property reflects the hostname, and optionally port number of the SLP DA.  | [optional] 
**StaticTargetDiscoveryEnabled** | **bool** | True if static target discovery is enabled  | 
**SendTargetsDiscoveryEnabled** | **bool** | True if send targets discovery is enabled  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

