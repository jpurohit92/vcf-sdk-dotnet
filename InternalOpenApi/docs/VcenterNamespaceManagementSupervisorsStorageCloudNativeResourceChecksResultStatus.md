# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsStorageCloudNativeResourceChecksResultStatus
The Vcenter.NamespaceManagement.Supervisors.Storage.CloudNative.ResourceChecks.ResultStatus contains predicted state of the Supervisor after executing the queried operation.  Possible values:   - `PASSED`: Resource check passed for the queried operation. There is sufficient resource in the Supervisor to perform the queried operation.   - `DEGRADED`: Resource check passed for the queried operation, but some persistent service instances will run with degraded availability after the operation completes.   - `FAILED`: Resource check failed for the queried operation. If any entity is suggested to be added by resource check result then there is not enough resource in the Supervisor for the given operation. Extra resource is required to make the given operation succeed.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

