# Vcenter.ViJson.OpenApi.Model.PbmFetchCapabilitySchemaRequestType
The parameters of *PbmProfileProfileManager.PbmFetchCapabilitySchema*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorUuid** | **string** | Unique identifier for the vendor/owner of capability metadata. If omitted, the server searches all capability metadata registered with the system. The specified vendor ID must match *PbmCapabilitySchemaVendorInfo*.*PbmCapabilitySchemaVendorInfo.vendorUuid*.  | [optional] 
**LineOfService** | **List&lt;string&gt;** | Optional line of service that must match *PbmLineOfServiceInfoLineOfServiceEnum_enum*. If specified, the capability schema objects are returned for the given lineOfServices. If null, then all capability schema objects that may or may not have data service capabilities are returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

