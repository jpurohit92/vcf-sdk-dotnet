# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsDeploymentInfoStatus
The Esx.Settings.Clusters.Vms.Solutions.DeploymentInfo.Status enumerated type defines how well a deployment conforms to the desired specification that is specified by the solution_info.  Possible values:   - `NOT_APPLIED`: The desired specification of the solution has never been applied.   - `IN_PROGRESS`: The system is actively working to reach the desired specification.   - `COMPLIANT`: The deployment is in full compliance with the desired specification.   - `ISSUE`: The system has hit issues that do not allow the deployment to reach the desired specification. See *Esx.Settings.Clusters.Vms.Solutions.DeploymentInfo.issues*.   - `IN_LIFECYCLE_HOOK`: The system is waiting on an activated VM lifecycle hook to be processed by the solution in order to continue attempting to reach the desired specification. See *Esx.Settings.Clusters.Vms.Solutions.DeploymentInfo.lifecycle_hook*.   - `BLOCKED`: The system is blocked from reaching the desired specification. For example, this can occur if *Esx.Settings.Clusters.Vms.RemediationPolicy.SEQUENTIAL* is set and another deployment is in ISSUE status.  This constant was added in __vSphere API 9.1.0.0__.   - `OBSOLETE_SPEC`: The current desired specification of the solution is newer than the applied.   This state should take precedence over:      - BLOCKED      - IN_PROGRESS      - ISSUE      - IN_LIFECYCLE_HOOK     This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

