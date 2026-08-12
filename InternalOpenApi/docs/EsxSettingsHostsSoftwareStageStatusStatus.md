# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareStageStatusStatus
The Esx.Settings.Hosts.Software.StageStatus.Status enumerated type contains the possible different status codes that can be returned while trying to *POST /esx/settings/hosts/{host}/software?action=stage* the desired software specification to a host.  Possible values:   - `RUNNING`: The operation is in progress.   - `OK`: The operation completed successfully.   - `SKIPPED`: The operation was skipped.   - `TIMED_OUT`: The operation timed out.   - `ERROR`: The operation encountered an unspecified error.   - `RETRY_PENDING`: The operation is being scheduled for retry.   This enumeration was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

