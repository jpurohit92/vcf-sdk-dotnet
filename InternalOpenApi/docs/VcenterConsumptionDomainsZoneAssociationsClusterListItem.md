# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZoneAssociationsClusterListItem
The Vcenter.ConsumptionDomains.ZoneAssociations.Cluster.ListItem schema describes a zone-cluster association.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of the zone.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Cluster** | **string** | Identifier of the cluster.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**State** | **string** | Association state of the cluster to the vSphere Zone.  Possible values:   - &#x60;ASSOCIATED&#x60;: A cluster is associated with the vSphere Zone.   - &#x60;REMOVING&#x60;: A cluster is being removed from a vSphere Zone.   For more information see: *Vcenter.ConsumptionDomains.ZoneAssociations.Cluster.AssociationState*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**RemoveTask** | **string** | The identifier of the cluster removal task. At the completion of this task, the cluster will be removed from the vSphere Zone.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of state is *Vcenter.ConsumptionDomains.ZoneAssociations.Cluster.AssociationState.REMOVING*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

