# Vcenter.ViJson.OpenApi.Model.DistributedVirtualPortgroupNsxPortgroupOperationResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portgroups** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The management object of NSX port group.  For add operation, it indicates the port groups created successfully. For reconfigure operation, it indicates the port groups updated successfully. For delete operation, it indicates the port groups failed deleted.  Refers instances of *DistributedVirtualPortgroup*.  | [optional] 
**Problems** | [**List&lt;DistributedVirtualPortgroupProblem&gt;**](DistributedVirtualPortgroupProblem.md) | The failed port group operation details.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

