# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationClusterPrecheckResultStatus
The Esx.Settings.Clusters.Configuration.ClusterPrecheckResult.Status enumerated type contains the possible statuses of the Precheck API on the cluster.  Possible values:   - `RUNNING`: The task is in-progress.   - `OK`: The operation completed successfully.   - `OK_REVIEW_REQUIRED`: The operation completed successfully. There are one or more solutions whose results #SolutionPrecheckResult indicate that the remediation of the drift is a destructive operation. Such drifts are specified in #SolutionPrecheckResult#driftReviews property. The #DriftReview need to be provided in the ApplySpec to acknowledge the remediation of these drifts. If the #SolutionPrecheckResult#driftReviews returned by PreCheck API is not provided as input to ApplySpec, these drifts will not be remediated.  This constant was added in __vSphere API 9.1.0.0__.   - `ERROR`: The operation failed with errors.   This enumeration was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

