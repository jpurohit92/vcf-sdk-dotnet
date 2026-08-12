# Vcenter.ViJson.OpenApi.Model.LifecycleFaultDomainDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPreferredFaultDomain** | **bool** | Whether this is the preferred fault domain.  | [optional] 
**Name** | **string** | The fault domain name.  Optional when hosts are fault domains.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The list of hosts in the fault domain.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

