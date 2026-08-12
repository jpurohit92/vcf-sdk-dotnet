# Vcenter.ViJson.OpenApi.Model.VsanFaultDomainUpdateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of hosts that will participate in the newly created fault domain.  Refers instances of *HostSystem*.  | [optional] 
**Name** | **string** | The name of the fault domain.  | 
**Operation** | **string** | The operation requested to this specific vSAN site fault domain, identified by *VimClusterVsanFaultDomainSpec.name*, allowed values please check *ArrayUpdateOperation_enum*: - add: Add specified hosts into the existing fault domain incrementally - remove: Remove the given set of hosts from specified fault domain - edit: Overwrite the associated members with given set of hosts  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

