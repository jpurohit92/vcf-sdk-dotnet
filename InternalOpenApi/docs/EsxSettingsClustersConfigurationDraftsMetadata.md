# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsMetadata
The Esx.Settings.Clusters.Configuration.Drafts.Metadata schema defines the metadata information about configuration draft.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The draft identifier  This property was added in __vSphere API 8.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. | 
**ParentId** | **string** | The identifier of the parent commit.  This property was added in __vSphere API 8.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**Owner** | **string** | Owner of the configuration draft.  This property was added in __vSphere API 8.0.2.0__. | 
**State** | **string** | State of the configuration draft.  Possible values:   - &#x60;VALID&#x60;: Configuration draft is valid.   - &#x60;INVALID&#x60;: Configuration draft is invalid.   For more information see: *Esx.Settings.Clusters.Configuration.Drafts.State*.  This property was added in __vSphere API 8.0.2.0__. | 
**Revision** | **long** | The current revision of this draft. Any updates to the draft will increment this value. This value should be included in calls to *POST /esx/settings/clusters/{cluster}/configuration/drafts/{draft}?action&#x3D;update* so that concurrent changes can be detected.  This property was added in __vSphere API 8.0.2.0__. | 
**CreationTime** | **DateTime** | Creation time of the configuration draft.  This property was added in __vSphere API 8.0.2.0__. | 
**ModifiedTime** | **DateTime** | Last modified time of the configuration draft.  This property was added in __vSphere API 8.0.2.0__. | 
**PrecheckTask** | **string** | The ID of the precheck task that was last run for this draft.  This property was added in __vSphere API 8.0.2.0__.  This field is missing or &#x60;null&#x60; if precheck has not been done since the last modification.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 
**ImageReferenceHost** | **string** | The ID of the host that is used as a reference for the cluster image.  This property was added in __vSphere API 8.0.3.0__.  This field is missing or &#x60;null&#x60; if the cluster is managed by VLCM.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

