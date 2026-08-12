# Vcenter.ViJson.OpenApi.Model.PbmCapabilitySchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorInfo** | [**PbmCapabilitySchemaVendorInfo**](PbmCapabilitySchemaVendorInfo.md) |  | 
**NamespaceInfo** | [**PbmCapabilityNamespaceInfo**](PbmCapabilityNamespaceInfo.md) |  | 
**LineOfService** | [**PbmLineOfServiceInfo**](PbmLineOfServiceInfo.md) | Service type for the schema.  Do not use Category as each service needs to have its own schema version.  If omitted, this schema specifies persistence capabilities.  | [optional] 
**CapabilityMetadataPerCategory** | [**List&lt;PbmCapabilityMetadataPerCategory&gt;**](PbmCapabilityMetadataPerCategory.md) | Capability metadata organized by category  | 
**CapabilityCategory** | **string** | The category of the capabilities in this schema.  See *PbmCapabilitySchemaCapabilityCategory_enum* for the list of supported types. If omitted this specifies *datastoreSpecific* unless the *PbmCapabilitySchema.lineOfService* is of type *PbmVaioDataServiceInfo*. If *PbmCapabilitySchema.lineOfService* is of type *PbmVaioDataServiceInfo* then this schema is of *common* type.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

