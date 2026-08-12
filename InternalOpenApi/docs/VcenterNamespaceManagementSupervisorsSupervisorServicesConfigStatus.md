# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesConfigStatus
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.ConfigStatus enumerated type describes the progress of a Supervisor Service toward reaching its desired configuration state.  Possible values:   - `CONFIGURING`: The Supervisor Service is being installed.   - `REMOVING`: The Supervisor Service is being deleted.   - `CONFIGURED`: The Supervisor Service has been configured correctly (i.e. the provided YAML content has been applied successfully to the Supervisor)   - `ERROR`: A failure occurred while reconciling the Supervisor Service. User intervention may be needed.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

