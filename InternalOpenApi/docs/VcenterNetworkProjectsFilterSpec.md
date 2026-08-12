# Vcenter.Automation.OpenApi.Model.VcenterNetworkProjectsFilterSpec
The Vcenter.Network.Projects.FilterSpec schema contains properties used to filter the results when listing projects. If multiple properties are specified, only projects matching all of the properties match the filter.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ids** | **List&lt;string&gt;** | Identifiers that projects must have to match the filter (see *Vcenter.Network.Projects.ProjectInfo.id*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, projects with any ID match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.network.project&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.network.project&#x60;. | [optional] 
**Names** | **List&lt;string&gt;** | Names that projects must have to match the filter (see *Vcenter.Network.Projects.ProjectInfo.name*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, projects with any name match the filter. | [optional] 
**ExternalIds** | **List&lt;string&gt;** | External identifiers that projects must have to match the filter (see *Vcenter.Network.Projects.ProjectInfo.external_id*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, projects with any external identifier match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

