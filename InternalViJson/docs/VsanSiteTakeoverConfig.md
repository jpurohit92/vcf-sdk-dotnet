# Vcenter.ViJson.OpenApi.Model.VsanSiteTakeoverConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TakeoverTimestamp** | **long** | The site takeover operation timestamp.  After a site has completed the takeover operation, all hosts in the recovered site will have a new unified takeover timestamp used to prevent object corruption from stale I/Os. A host has to be rebooted when its site takeover timestamp is older than the one from the recovered site. If a host newly joins the cluster, it will have the takeover timestamp from the recovered site automatically.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

