# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZoneAssociationsAssociationChangesFilterSpec
The Vcenter.ConsumptionDomains.ZoneAssociations.AssociationChanges.FilterSpec schema contains properties used to filter the results when querying changes of zone-cluster association, see *POST /vcenter/consumption-domains/zone-associations/association-changes?action=query*.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zones** | **List&lt;string&gt;** | The zone-cluster association changes will be filtered such that each change that is returned will have a zone identifier from this set of specified zone identifiers.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; or empty, zone-cluster association changes will not be filtered based on zone identifiers. Changes with any zone identifier will match this filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

