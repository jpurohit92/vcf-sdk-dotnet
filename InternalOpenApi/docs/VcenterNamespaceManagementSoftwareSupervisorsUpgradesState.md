# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesState
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.State enumerated type describes the state of the upgrade.  Possible values:   - `INPROGRESS`: Upgrade is in progress.   - `READY`: The Supervisor is ready for an upgrade. This state indicates that either:       - No upgrade has been initiated yet, or      - The most recent upgrade has completed successfully.   This is the default state when the Supervisor is idle or post-upgrade.   - `ERROR`: Upgrade has failed and needs user intervention.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

