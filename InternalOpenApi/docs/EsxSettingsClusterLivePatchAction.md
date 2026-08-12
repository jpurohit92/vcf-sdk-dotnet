# Vcenter.Automation.OpenApi.Model.EsxSettingsClusterLivePatchAction
The Esx.Settings.ClusterLivePatchAction schema contains properties that describe how Live Patch is performed.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LivePatchMode** | **string** | Live Patch mode of the cluster.  Possible values:   - &#x60;DISABLE_LIVE_PATCH&#x60;: Disable Live Patch.   - &#x60;AUTO_LIVE_PATCH&#x60;: Perform Live Patch when possible. Use full maintenance mode for hosts that cannot perform Live Patch.   - &#x60;ENFORCE_LIVE_PATCH&#x60;: Enforce Live Patch. Disallow remediation if there is a host that cannot perform Live Patch.   For more information see: *Esx.Settings.ClusterLivePatchAction.LivePatchMode*.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

