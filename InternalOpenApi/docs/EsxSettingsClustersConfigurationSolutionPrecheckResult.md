# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationSolutionPrecheckResult
This Esx.Settings.Clusters.Configuration.SolutionPrecheckResult schema contains properties that describes the Precheck API result for a cluster solution.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Overall solution precheck status for the cluster solution. Operation is successful when precheck is run for cluster solution successfully with no validation or precheck errors.  Possible values:   - &#x60;RUNNING&#x60;: The task is in-progress.   - &#x60;OK&#x60;: The operation completed successfully.   - &#x60;OK_REVIEW_REQUIRED&#x60;: The operation completed successfully. There are one or more solutions whose results #SolutionPrecheckResult indicate that the remediation of the drift is a destructive operation. Such drifts are specified in #SolutionPrecheckResult#driftReviews property. The #DriftReview need to be provided in the ApplySpec to acknowledge the remediation of these drifts. If the #SolutionPrecheckResult#driftReviews returned by PreCheck API is not provided as input to ApplySpec, these drifts will not be remediated.  This constant was added in __vSphere API 9.1.0.0__.   - &#x60;ERROR&#x60;: The operation failed with errors.   For more information see: *Esx.Settings.Clusters.Configuration.ClusterPrecheckResult.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**DisplayName** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Display name of Cluster Solution.  This property was added in __vSphere API 9.1.0.0__. | 
**Summary** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Summarizing precheck operation for the cluster solution.  This property was added in __vSphere API 9.1.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | This field contains the impact information for a cluster solution to reach the desired configuration state. It shall also contain the errors set during impact operation.  This property was added in __vSphere API 9.1.0.0__.  This field is set if there are no validation errors for cluster solution. The *Esx.Settings.Clusters.Configuration.SolutionPrecheckResult.status* may be OK or ERROR. | [optional] 
**DriftReviews** | [**List&lt;EsxSettingsClustersConfigurationDriftReview&gt;**](EsxSettingsClustersConfigurationDriftReview.md) | This field contains the drifts that need review from the user before apply.  This property was added in __vSphere API 9.1.0.0__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

