# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelUserDefinedType
The Vapi.Metadata.Metamodel.UserDefinedType schema contains the metamodel type information of a typed element whose type is a user defined named type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceType** | **string** | Category of the user defined named type. The named type could be a structure element or an enumeration element.  When clients pass a value of this schema as a parameter, the property must be one of &#x60;com.vmware.vapi.structure&#x60; or &#x60;com.vmware.vapi.enumeration&#x60;. When operations return a value of this schema as a response, the property will be one of &#x60;com.vmware.vapi.structure&#x60; or &#x60;com.vmware.vapi.enumeration&#x60;. | 
**ResourceId** | **string** | Identifier of the user defined named type.  When clients pass a value of this schema as a parameter, the property must be an identifier for one of these resource types: &#x60;com.vmware.vapi.structure&#x60; or &#x60;com.vmware.vapi.enumeration&#x60;. When operations return a value of this schema as a response, the property will be an identifier for one of these resource types: &#x60;com.vmware.vapi.structure&#x60; or &#x60;com.vmware.vapi.enumeration&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

