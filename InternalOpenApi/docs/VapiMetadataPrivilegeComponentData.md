# Vcenter.Automation.OpenApi.Model.VapiMetadataPrivilegeComponentData
The Vapi.Metadata.Privilege.ComponentData schema contains the privilege information of the component along with its fingerprint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Info** | [**VapiMetadataPrivilegeComponentInfo**](VapiMetadataPrivilegeComponentInfo.md) | Privilege information of the component. This includes information about all the namespaces in the component. | 
**Fingerprint** | **string** | Fingerprint of the metadata of the component.    Privilege information could change when there is an infrastructure update. Since the data present in *Vapi.Metadata.Privilege.ComponentData.info* could be quite large, fingerprint provides a convenient way to check if the data for a particular component is updated.    You should store the fingerprint associated with a component. After an update, by invoking the *GET /vapi/metadata/privilege/component/{componentId}/fingerprint* operation, you can retrieve the new fingerprint for the component. If the new fingerprint and the previously stored fingerprint do not match, clients can then use the *GET /vapi/metadata/privilege/component/{componentId}* to retrieve the new privilege information for the component. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

