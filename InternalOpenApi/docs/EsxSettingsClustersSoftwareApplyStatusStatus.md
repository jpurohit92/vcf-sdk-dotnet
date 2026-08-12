# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareApplyStatusStatus
The Esx.Settings.Clusters.Software.ApplyStatus.Status enumerated type contains the possible different status codes that can be returned while trying to *POST /esx/settings/clusters/{cluster}/software?action=apply* the desired software specification to hosts within the cluster.  Possible values:   - `RUNNING`: The operation is in progress.  This constant was added in __vSphere API 7.0.1.0__.   - `OK`: The operation completed successfully.   - `SKIPPED`: The operation was skipped.   - `TIMED_OUT`: The operation timed out.   - `ERROR`: The operation encountered an unspecified error.   - `RETRY_PENDING`: The operation is being scheduled for retry.  This constant was added in __vSphere API 7.0.2.1__.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

