# Vcenter.ViJson.OpenApi.Model.VimClusterVSANStretchedClusterFaultDomainConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstFdName** | **string** | User friendly Fault Domain name of site A.  The length of name should not exceed 256 characters.  | 
**FirstFdHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | vSAN data hosts to be put in site A.  Hosts are expected to reside in vSAN cluster.  Refers instances of *HostSystem*.  | 
**SecondFdName** | **string** | User friendly Fault Domain name of site B.  The length of name should not exceed 256 characters.  | 
**SecondFdHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | vSAN data hosts to be put in site B.  Hosts are expected to reside in vSAN cluster.  Refers instances of *HostSystem*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

