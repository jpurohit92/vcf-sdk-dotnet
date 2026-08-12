# Vcenter.ViJson.OpenApi.Model.VsanHclQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeOnlyVsanControllers** | **bool** | True to only include controllers used by vSAN.  False will include all controllers in host. The default is True.  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to be validated.  If it&#39;s specified, the result for all hosts within the same cluster will be returned. If both cluster and hosts are provided, only the result of provided hosts will be returned.  Refers instance of *ComputeResource*.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The hosts to be validated.  Instead of returning the result of whole cluster, it&#39;s supported to check against a list of hosts.  Refers instances of *HostSystem*.  | [optional] 
**VsanStoragePoolEligibleDisksOnly** | **bool** | True indicates only the disks which are eligible for use by vSAN storage pool will be returned.  The default is False.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

