# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZoneAssociationsAssociationChangesListResult
The Vcenter.ConsumptionDomains.ZoneAssociations.AssociationChanges.ListResult schema contains a list of zone-cluster association changes and a token for the next call to *POST /vcenter/consumption-domains/zone-associations/association-changes?action=query*.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Changes** | [**List&lt;VcenterConsumptionDomainsZoneAssociationsAssociationChangesChange&gt;**](VcenterConsumptionDomainsZoneAssociationsAssociationChangesChange.md) | List of zone-cluster association changes.  This property was added in __vSphere API 9.1.0.0__. | 
**Token** | **string** | An opaque token identifying the next zone-cluster association change to be read from the #list. Clients should use this returned token in the subsequent calls to #list to fetch new changes only.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

