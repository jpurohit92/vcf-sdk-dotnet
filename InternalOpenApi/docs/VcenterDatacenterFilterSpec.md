# Vcenter.Automation.OpenApi.Model.VcenterDatacenterFilterSpec
The Vcenter.Datacenter.FilterSpec schema contains properties used to filter the results when listing datacenters (see *GET /vcenter/datacenter*). If multiple properties are specified, only datacenters matching all of the properties match the filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenters** | **List&lt;string&gt;** | Identifiers of datacenters that can match the filter.  If missing or &#x60;null&#x60; or empty, datacenters with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional] 
**Names** | **List&lt;string&gt;** | Names that datacenters must have to match the filter (see *Vcenter.Datacenter.Info.name*).  If missing or &#x60;null&#x60; or empty, datacenters with any name match the filter. | [optional] 
**Folders** | **List&lt;string&gt;** | Folders that must contain the datacenters for the datacenter to match the filter.  If missing or &#x60;null&#x60; or empty, datacenters in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

