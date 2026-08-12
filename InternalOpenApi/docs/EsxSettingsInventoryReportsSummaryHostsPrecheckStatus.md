# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryHostsPrecheckStatus
The Esx.Settings.Inventory.Reports.Summary.Hosts.PrecheckStatus enumerated type defines the status result for a particular precheck. Note: This is patterned after values of com.vmware.esx.settings.hosts#Status enumeration.  Possible values:   - `OK`: The precheck indicates a success.   - `WARNING`: The precheck indicates a warning.   - `TIMEOUT`: The precheck did not return in a timely manner.   - `ERROR`: The precheck indicates an error.   - `RETRY`: The precheck failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health precheck before considering the precheck as failed.   - `UNKNOWN`: The precheck is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

