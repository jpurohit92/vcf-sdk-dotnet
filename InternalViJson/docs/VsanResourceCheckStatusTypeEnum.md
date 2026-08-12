# Vcenter.ViJson.OpenApi.Model.VsanResourceCheckStatusTypeEnum
Enumeration of the types for resource check status.  Possible values: - `resourceCheckUninitialized`: The resource check has never run yet, or it just starts but the task has not been launched yet (i.e.      still in initialization stage). - `resourceCheckRunning`: The resource check is currently running. - `resourceCheckFailed`: The resource check has failed. - `resourceCheckCancelled`: The resource check has been cancelled by user. - `resourceCheckCompleted`: The resource check has completed successfully. - `resourceCheckNoRecentValue`: The last resource check completed successfully but then it has not run again for a while (e.g.      60 min) and the result of the last check becomes stale. - `resourceCheckNotSupported`: The resource check is not supported by one or more host in cluster. - `ResourceCheckStatusType_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

