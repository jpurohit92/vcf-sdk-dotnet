# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZonesFilterSpec
The Vcenter.ConsumptionDomains.Zones.FilterSpec schema contains properties used to filter the results when listing configured zones, see *GET /vcenter/consumption-domains/zones*.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zones** | **List&lt;string&gt;** | Matches all zones corresponding to the specified set of zone identifiers.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60; or empty, results will not be filtered for specific zone identifiers.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

