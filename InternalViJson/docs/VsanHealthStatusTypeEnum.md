# Vcenter.ViJson.OpenApi.Model.VsanHealthStatusTypeEnum
Defines health status states applicable to various vSAN system entities.  An entity in vSAN health system can have one of the following state. Each state represent the health status of entity in terms of vSAN health perspective. Each system can define its notion of each health status. For example, status 'red' for capacity means cluster is running very close to datastore full but status 'red' for for an object mean it is already 'inaccessible'.  Possible values: - `unknown`: Health status in not known for the entity.      This might imply that : 1. Underlying entity do not support the mechanism to calculate the health status. 2. Status is not yet calculated. - `yellow`: Shows a warning status for the entity.      This might imply that : 1. Entity is currently available but running in degraded mode so some of the functionalities might not be available. 2. Potential configuration issue of recommendation which need user action to be resolved. - `red`: Shows an alert for the system.      This might imply that: 1. Entity is currently running in error state. 2. Potentially harm the cluster status is not fixed soon. - `green`: Shows entity is in healthy state and no issues found. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

