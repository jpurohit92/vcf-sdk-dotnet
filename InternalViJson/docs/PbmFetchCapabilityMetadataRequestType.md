# Vcenter.ViJson.OpenApi.Model.PbmFetchCapabilityMetadataRequestType
The parameters of *PbmProfileProfileManager.PbmFetchCapabilityMetadata*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceType** | [**PbmProfileResourceType**](PbmProfileResourceType.md) | Type of profile resource. The Server supports the \&quot;STORAGE\&quot; resource type only. If not specified, this method will return capability metadata for the storage resources. Any other &lt;code&gt;resourceType&lt;/code&gt; is considered invalid.  | [optional] 
**VendorUuid** | **string** | Unique identifier for the vendor/owner of capability metadata. The specified vendor ID must match *PbmCapabilitySchemaVendorInfo*.*PbmCapabilitySchemaVendorInfo.vendorUuid*. If omitted, the Server searches all capability metadata registered with the system. If a &lt;code&gt;vendorUuid&lt;/code&gt; unknown to the Server is specified, empty results will be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

