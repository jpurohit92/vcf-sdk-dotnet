# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZoneAssociationsAssociationChangesChange
The Vcenter.ConsumptionDomains.ZoneAssociations.AssociationChanges.Change schema contains the details of a zone-cluster association change.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the change.  Possible values:   - &#x60;ADDED&#x60;: A cluster has been added to a zone.   - &#x60;REMOVING&#x60;: A cluster is being removed from a zone.   - &#x60;REMOVED&#x60;: A cluster has been removed from a zone.   For more information see: *Vcenter.ConsumptionDomains.ZoneAssociations.AssociationChanges.Type*.  This property was added in __vSphere API 9.1.0.0__. | 
**Cluster** | **string** | The identifier of the cluster.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**Zone** | **string** | The identifier of the zone.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

