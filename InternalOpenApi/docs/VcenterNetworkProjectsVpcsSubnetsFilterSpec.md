# Vcenter.Automation.OpenApi.Model.VcenterNetworkProjectsVpcsSubnetsFilterSpec
The Vcenter.Network.Projects.Vpcs.Subnets.FilterSpec schema contains properties used to filter the results when listing subnets. If multiple properties are specified, only subnets matching all of the properties match the filter.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ids** | **List&lt;string&gt;** | Identifiers that subnet must have to match the filter (see *Vcenter.Network.Projects.Vpcs.Subnets.SubnetInfo.id*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, subnets with any ID match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.network.subnet&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.network.subnet&#x60;. | [optional] 
**Names** | **List&lt;string&gt;** | Names that subnet must have to match the filter (see *Vcenter.Network.Projects.Vpcs.Subnets.SubnetInfo.name*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, subnets with any name match the filter. | [optional] 
**ExternalIds** | **List&lt;string&gt;** | External identifiers that subnet must have to match the filter (see *Vcenter.Network.Projects.Vpcs.Subnets.SubnetInfo.external_id*).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, subnets with any external identifier match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

