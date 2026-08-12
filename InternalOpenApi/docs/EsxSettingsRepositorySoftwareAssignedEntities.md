# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareAssignedEntities
The Esx.Settings.Repository.Software.AssignedEntities schema contains the list of entities assigned to a software specification in the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | [**List&lt;EsxSettingsRepositorySoftwareClusterInfo&gt;**](EsxSettingsRepositorySoftwareClusterInfo.md) | List of clusters. For a software specification that is not associated with any cluster, this list will be empty.  This property was added in __vSphere API 9.0.0.0__. | 
**Hosts** | [**List&lt;EsxSettingsRepositorySoftwareHostInfo&gt;**](EsxSettingsRepositorySoftwareHostInfo.md) | List of hosts. For a software specification that is not associated with any host, this list will be empty.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

