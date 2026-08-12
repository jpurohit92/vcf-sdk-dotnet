# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDocumentStructure
The Esx.Settings.Clusters.Configuration.DocumentStructure enumerated type contains the possible structures of the configuration document.  Possible values:   - `HOST_ORIENTED`: The host-specific portions of the document are stored in the \"host-specific\" object at the top-level with entries for each host, organized by the host's BIOS UUID.   - `PROFILE_ORIENTED`: The host-specific portions of the document are distributed through the \"profile\" object hierarchy. Each property that is host-specific will be an object with entries for each host where the property is defined. The hosts in the object are organized by BIOS UUID.   This enumeration was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

