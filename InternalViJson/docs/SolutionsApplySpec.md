# Vcenter.ViJson.OpenApi.Model.SolutionsApplySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredState** | [**List&lt;SolutionsSolutionConfig&gt;**](SolutionsSolutionConfig.md) | Complete desired state to be applied on the target entity.  the **solutions** member limits which parts of this desired state to be applied   If the **solutions** member is omitted. - Any solution described in this structure will be applied on the   target entity - Any solution already existing on the target entity, but missing   from this structure, will be deleted from the target entity  | [optional] 
**Solutions** | **List&lt;string&gt;** | If provided, limits the parts of the **desiredState** structure to be applied on the target entity. - solutions that are also present in the **desiredState**   structure will be applied on the target entity. - solutions that are missing from the **desiredState** structure   will be deleted from the target entity.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Specifies exact hosts to apply the desired state to, instead of every host in the cluster.  Applicable only to solutions with *SolutionsHostBoundSolutionConfig*.  Refers instances of *HostSystem*.  | [optional] 
**DeploymentUnits** | **List&lt;string&gt;** | Deployment units on which solutions that are specified by the this structure need to be applied.  Applicable only to solutions with *SolutionsClusterBoundSolutionConfig*.  The deployment unit represents a single VM instance deployment. It is returned by the *Solutions.Compliance* operation.  This filtering is not supported in case of subsequent *Hooks#processDynamicUpdate* is invoked. If omitted - the configured solutions by *SolutionsApplySpec.solutions* are applied on all of the deployment units in the cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

