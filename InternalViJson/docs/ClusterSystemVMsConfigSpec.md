# Vcenter.ViJson.OpenApi.Model.ClusterSystemVMsConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedDatastores** | [**List&lt;ClusterDatastoreUpdateSpec&gt;**](ClusterDatastoreUpdateSpec.md) | The only datastores which can be used for System VMs deployment.  | [optional] 
**NotAllowedDatastores** | [**List&lt;ClusterDatastoreUpdateSpec&gt;**](ClusterDatastoreUpdateSpec.md) | Datastores which cannot be used for System VMs deployment.  | [optional] 
**DsTagCategoriesToExclude** | [**List&lt;ClusterTagCategoryUpdateSpec&gt;**](ClusterTagCategoryUpdateSpec.md) | Tag categories identifying datastores, which cannot be used for System VMs deployment.  | [optional] 
**DeploymentMode** | **string** | The System VM deployment mode for vSphere clusters.  Supported values are enumerated by the *DeploymentMode* type. Providing an unset value does not modify deploymentMode.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

