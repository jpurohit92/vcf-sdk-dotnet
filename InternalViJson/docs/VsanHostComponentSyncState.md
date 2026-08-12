# Vcenter.ViJson.OpenApi.Model.VsanHostComponentSyncState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Represents the uuid of component.  | 
**DiskUuid** | **string** | Represents the uuid of disk on which component resides.  | 
**HostUuid** | **string** | Represents the uuid of host on which component resides.  | 
**BytesToSync** | **long** | Indicates how many bytes need to be synced for this component.  | 
**RecoveryETA** | **long** | The estimated time in seconds to complete recovery.  This attribute will be not returned if no data has been synced.  | [optional] 
**Reasons** | **List&lt;string&gt;** | The list of reasons indicate why the component went into syncing state.  The API returns full list of reasons for background. However, sometimes it&#39;s userful to generate an aggregate reason, in which case the following priorities could be used: - P0: \&quot;evacuate\&quot; - P1: \&quot;dying\\_evacuate\&quot; - P2: \&quot;rebalance\&quot; - P3: \&quot;repair\&quot;, \&quot;reconfigure\&quot; - P4: \&quot;stale\&quot;, \&quot;merge\\_concat\&quot;    See also *VsanSyncReason_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

