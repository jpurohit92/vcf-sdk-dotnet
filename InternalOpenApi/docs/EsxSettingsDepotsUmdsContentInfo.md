# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsUmdsContentInfo
The Esx.Settings.Depots.Umds.Content.Info schema contains fields that describe the information of metadata bundles of the UMDS depot.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataBundles** | **Dictionary&lt;string, List&lt;EsxSettingsDepotsMetadataInfo&gt;&gt;** | A list of metadata bundles contained in the depot. The key is vendor of metadata bundle.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.vendor&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.vendor&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

