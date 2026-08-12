# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionInfoStatus
The Esx.Settings.Clusters.Enablement.Configuration.Transition.Info.Status enumerated type contains the possible status codes describing the transition state of the cluster.  Possible values:   - `ENABLED`: Transition has completed successfully and the cluster is managed through the desired configuration management platform.   - `ENABLE_IN_PROGRESS`: Transition has started and *POST /esx/settings/clusters/{cluster}/enablement/configuration/transition?action=enable* task is running on the cluster.   - `NOT_ALLOWED_IN_CURRENT_STATE`: Cluster is not in a state to transition to desired configuration management platform. The cluster ends up in this state if another user identified by *Esx.Settings.Clusters.Enablement.Configuration.Transition.State.author* has already started transition.   - `NOT_STARTED`: Transition has not started on the cluster.   - `SOFTWARE_SPECIFICATION_NOT_SET`: Desired software specification is not set on the cluster. This is a pre-requisite to transition a cluster to desired configuration management platform.   - `STARTED`: Transition has started on the cluster.   This enumeration was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

