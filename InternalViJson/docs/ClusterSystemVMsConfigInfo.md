# Vcenter.ViJson.OpenApi.Model.ClusterSystemVMsConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedDatastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The only datastores which can be used for System VMs deployment.  Refers instances of *Datastore*.  | [optional] 
**NotAllowedDatastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Datastores which cannot be used for System VMs deployment.  Refers instances of *Datastore*.  | [optional] 
**DsTagCategoriesToExclude** | **List&lt;string&gt;** | Tag categories identifying datastores, which cannot be used for System VMs deployment.  | [optional] 
**DeploymentMode** | **string** | The System VM deployment mode for vSphere clusters.  Supported values are enumerated by the *DeploymentMode* type. An unset value implies SYSTEM\\_MANAGED, unless the cluster is put in \&quot;Retreat Mode\&quot;.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

