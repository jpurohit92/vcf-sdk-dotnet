# Vcenter.ViJson.OpenApi.Model.VsanFileServiceShareHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallHealth** | **string** | Overall health state for this vSAN file service share.  The possible state of the file service share could be one of the following: - &#39;green&#39; if the file server for this file share is running properly and   all its backing vSAN objects are healthy. - &#39;red&#39; if the file server for this file share is in error state or any of   its backing vSAN objects are degraded.  | [optional] 
**DomainName** | **string** | The name of the domain.  See *VsanDirectoryServerConfig* for more detailed information about vSAN file service domain.  | [optional] 
**ShareUuid** | **string** | The UUID of the file share.  | [optional] 
**ShareName** | **string** | The name of the file share.  | [optional] 
**ObjectHealth** | [**VsanObjectOverallHealth**](VsanObjectOverallHealth.md) | The health status of share&#39;s backing vSAN objects.  If any object is not healthy the overall healthy will be &#39;red&#39;.  | [optional] 
**Description** | **string** | The description of the health status.  It includes the detail of the vSAN objects in error state and the status of file server.  | [optional] 
**Extensible** | **bool** | The extensibility of this file share.  The file share is backed by vSAN objects, and each vSAN object can provide 255GB in maximum. So if the file share needs to grow beyond this limit, more vSAN objects should be provisioned. This item is to check whether the storage policy of this file share can be met by the current cluster for provisioning more backing vSAN objects. If the storage policy cannot be met by the cluster, and the quota of the file share cannot be satisfied by current backing vSAN object, this field will be set to False to indicate this issue. Note: the provisioning of the vSAN object will be impacted by other facts, e.g., network partition. Check the network health and host state first before validating the extensibility of the file share.  | [optional] 
**SpbmProfileUuid** | **string** | UUID of SPBM profile used for the policy of the object when it was applied to vSAN File Service share.  Not set if the share doesn&#39;t use an SPBM managed policy.  | [optional] 
**SpbmProfileGenerationId** | **string** | Generation ID of SPBM profile used for the policy of the object when it was applied to vSAN File Service share.  Not set if the share doesn&#39;t use a SPBM managed policy.  | [optional] 
**SharePolicyMismatch** | **bool** | This field is to check whether the storage policy of this file share mismatches latest version of the SPBM policy.  Whenever SPBM policy is changed, the change needs to be propagated to associated file shares.The mismatch status would be used as a health check when file share is queried.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

