# Vcenter.ViJson.OpenApi.Model.PbmPersistenceBasedDataServiceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineOfService** | **string** | *PbmLineOfServiceInfoLineOfServiceEnum_enum* - must be one of the values for enum *PbmLineOfServiceInfoLineOfServiceEnum_enum*.  | 
**Name** | [**PbmExtendedElementDescription**](PbmExtendedElementDescription.md) | Name of the service - for informational purposes only.  | 
**Description** | [**PbmExtendedElementDescription**](PbmExtendedElementDescription.md) | Description of the service - for informational purposes only.  | [optional] 
**CompatiblePersistenceSchemaNamespace** | **List&lt;string&gt;** | This property should be set with compatible schema namespaces exposed by the vendor provider.  If not specified, vSphere assumes all Data Service provider schemas are compatible with all persistence provider namespaces advertised by the VASA provider.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

