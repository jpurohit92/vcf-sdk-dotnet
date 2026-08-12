# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelComponentData
The Vapi.Metadata.Metamodel.ComponentData schema contains the metamodel metadata information of a component element along with its fingerprint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Info** | [**VapiMetadataMetamodelComponentInfo**](VapiMetadataMetamodelComponentInfo.md) | Metamodel information of the component element. This includes information about all the package elements contained in this component element.    The metamodel information about a component could be quite large if there are a lot of package elements contained in this component. | 
**Fingerprint** | **string** | Fingerprint of the metamodel metadata of the component component.    Metamodel information could change when there is an infrastructure update and new functionality is added to an existing component.    Since the data present in *Vapi.Metadata.Metamodel.ComponentData.info* could be quite large, fingerprint provides a convenient way to check if the data for a particular component is updated.    You should store the fingerprint associated with a component. After an update, by invoking the *GET /vapi/metadata/metamodel/component/{componentId}/fingerprint* operation, you can retrieve the new fingerprint for the component. If the new fingerprint and the previously stored fingerprint do not match, clients can use the *GET /vapi/metadata/metamodel/component/{componentId}* to retrieve the new metamodel information for the component. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

