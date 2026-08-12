# Vcenter.ViJson.OpenApi.Model.SolutionsComplianceSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredState** | [**List&lt;SolutionsSolutionConfig&gt;**](SolutionsSolutionConfig.md) | Desired state to be checked for compliance.  May be incomplete if exact solutions to be checked are provided. Empty desired state means all present solutions must be removed.  | [optional] 
**Solutions** | **List&lt;string&gt;** | Specifies exact solutions to be checked for compliance instead of the complete desired state.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Specifies exact hosts to be checked for compliance of all solutions with *SolutionsHostBoundSolutionConfig*.  If omitted - the compliance is checked for all hosts in the cluster.  Refers instances of *HostSystem*.  | [optional] 
**DeploymentUnits** | **List&lt;string&gt;** | Identifiers of the deployment units that to be checked for compliance of all solutions with *SolutionsClusterBoundSolutionConfig*.  The deployment unit represents a single VM instance deployment.  If omitted - the compliance is checked for all deployment units in the cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

