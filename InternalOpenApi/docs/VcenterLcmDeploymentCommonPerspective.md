# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonPerspective
The Vcenter.Lcm.Deployment.Common.Perspective enumerated type defines perspectives which are supported/used by SDDC manager to trigger the set of prechecks.  Possible values:   - `GENERAL_UPGRADE_READINESS`: General upgrade readiness perspective defines the general readiness of the appliance any time regardless of upgrade being planned.   - `UPGRADE_PLANNING`: Planning perspective defines the phase where planning for the upgrade is being done.   - `UPGRADE_COMMIT`: Commit perspective defines the phase when the upgrade has been planned already and now is the time to dry run the upgrade.   - `UPGRADE_REALIZE_PRE_FLIGHT`: Preflight perspective is the phase before the upgrade starts.   - `UPGRADE_REALIZE_POST_FLIGHT`: Post flight perspective is the phase after the upgrade successfully completes.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

