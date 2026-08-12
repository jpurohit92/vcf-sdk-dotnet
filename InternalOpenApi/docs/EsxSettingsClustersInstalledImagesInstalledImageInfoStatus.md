# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersInstalledImagesInstalledImageInfoStatus
The Esx.Settings.Clusters.InstalledImages.InstalledImageInfo.Status enumerated type is used to convey the status of the extract installed images task. For example, whether it was successful or whether some issue occurred during its execution.  Possible values:   - `UNAVAILABLE`: Indicates that the status of the task is unknown. This could be because the task failed before the eligibility check had the chance to run. Another reason could be if the cluster has no hosts or if every host in the cluster is running a base image version < 7.0.2.   - `ELIGIBILITY_CHECK_FAILURE`: Indicates there was either an error during the execution of the eligibility check or the cluster is not eligible for vLCM management. In either case an error will be present in the #notifications field of the InstalledImageInfo schema.   - `EXTRACT_INSTALLED_IMAGE_FAILURE`: Indicates there was an error during the execution of the extract installed images task. If this is the case an error will be present in the #notifications property of the InstalledImageInfo schema.   - `SUCCESS`: Indicates the extract installed images task completed without error.   This enumeration was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

