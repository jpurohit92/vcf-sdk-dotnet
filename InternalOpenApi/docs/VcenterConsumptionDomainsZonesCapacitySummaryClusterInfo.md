# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZonesCapacitySummaryClusterInfo
The Vcenter.ConsumptionDomains.Zones.Capacity.Summary.ClusterInfo schema contains information about resource capacity in a vSphere Zone for each cluster which is in associated state with the vSphere Zone.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterInfos** | [**Dictionary&lt;string, VcenterConsumptionDomainsZonesCapacitySummaryInfo&gt;**](VcenterConsumptionDomainsZonesCapacitySummaryInfo.md) | Capacity info for each cluster  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

