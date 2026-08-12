# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZonesCapacitySummaryInfo
The Vcenter.ConsumptionDomains.Zones.Capacity.Summary.Info schema contains information about capacity of a resource in a vSphere Zone.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cpu** | [**VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo**](VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo.md) | CPU capacity information of the vSphere Zone, units are MHz.  This property was added in __vSphere API 9.1.0.0__. | 
**Memory** | [**VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo**](VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo.md) | Memory capacity information of the vSphere Zone, units are MiB.  This property was added in __vSphere API 9.1.0.0__. | 
**VmResourceProfiles** | [**Dictionary&lt;string, VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo&gt;**](VcenterConsumptionDomainsZonesCapacitySummaryCapacityInfo.md) | VmResourceProfile capacity information of the vSphere Zone, units are in number of instances.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vcenter.VmResourceProfile&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vcenter.VmResourceProfile&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

