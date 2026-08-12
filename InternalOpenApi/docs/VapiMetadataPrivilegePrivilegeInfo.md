# Vcenter.Automation.OpenApi.Model.VapiMetadataPrivilegePrivilegeInfo
The Vapi.Metadata.Privilege.PrivilegeInfo schema contains the privilege information for a parameter element in an operation element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyPath** | **string** | The property_path points to an entity that is used in the operation element. An entity can either be present in one of the parameter elements or if a parameter is a structure element, it could also be present in one of the field elements.    If the privilege is assigned to an entity used in the parameter, property_path will just contain the name of the parameter field. If the privilege is assigned to an entity in one of the field elements of a parameter element that is a structure element, then property_path will contain a path to the field element starting from the parameter name. | 
**Privileges** | **List&lt;string&gt;** | List of privileges assigned to the entity that is being referred by *Vapi.Metadata.Privilege.PrivilegeInfo.property_path*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

