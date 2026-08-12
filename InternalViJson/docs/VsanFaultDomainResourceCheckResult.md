# Vcenter.ViJson.OpenApi.Model.VsanFaultDomainResourceCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The friendly name for this entity.  This is the name specified by user when the entity is created or updated.  | [optional] 
**Uuid** | **string** | The vSAN UUID of the entity.  | [optional] 
**IsNew** | **bool** | The flag indicates whether this is a new resource entity that is recommended to be added for more resources in order to make the operation succeed.  For example, for a disk group entity the flag indicates whether this is a new disk group that is recommended to be added for more resources in order to make the operation succeed.  | [optional] 
**Capacity** | **long** | The total physical capacity of the entity in bytes.  For example, host capacity will be sum of all disk-group&#39;s capacity on the host. If *EntityResourceCheckDetails.isNew* is true, the currentUsage is set to 0 since this a recommendation for adding new resource.  | [optional] 
**PostOperationCapacity** | **long** | The predicted total physical capacity of the resource entity in bytes after the operation is done.  For example, if the resource check is for host enter maintenance mode operation the capacity which host was contributing will be removed from the fault domain&#39;s total physical capacity.  | [optional] 
**UsedCapacity** | **long** | The current physical usage of the entity in bytes.  If *EntityResourceCheckDetails.isNew* is true, the currentUsage is set to 0.  | [optional] 
**PostOperationUsedCapacity** | **long** | The predicted physical usage of the resource entity in bytes after the operation is done.  For example, if the resource check is for host enter maintenance mode operation, vSAN will simulate the disk usage after the given host enters maintenance mode. If vSAN deduplication and compression is enabled during the operation, vSAN simulation will not take this into consideration and thus will make a conservative estimation of the post-operation disk usage with data non-deduplicated and uncompressed. If vSAN deduplication and compression is disabled during the operation, vSAN simulation will use the average of current deduplication/compression rate of all disk-groups in the cluster to estimate the inflation of data for a rough calculation of the post-operation disk usage.  | [optional] 
**AdditionalRequiredCapacity** | **long** | vSAN&#39;s recommendation for additional capacity for this entity to be added in order to make the operation succeed.  This will be sum of all child entitie&#39;s additionalRequiredCapacity required. For example, host&#39;s additional capacity will be sum of all disk-group&#39;s additional capacity on the host.  | [optional] 
**MaxComponents** | **long** | Number of maximum vSAN components this entity can hold.  | [optional] 
**Components** | **long** | Predicted number of vSAN components on this entity post operation.  | [optional] 
**Hosts** | [**List&lt;VsanHostResourceCheckResult&gt;**](VsanHostResourceCheckResult.md) | The detailed resource check result for hosts in the fault domain.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

