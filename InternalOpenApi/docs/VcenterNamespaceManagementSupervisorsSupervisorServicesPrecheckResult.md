# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesPrecheckResult
This schema contains the result of the last valid *POST /vcenter/namespace-management/supervisors/{supervisor}/supervisor-services/{supervisorService}?action=precheck* operation for installing or upgrading to a Supervisor Service version on a specific Supervisor.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetVersion** | **string** | Identifier of the target Supervisor Service version that the prechecks were running for.  This property was added in __vSphere API 8.0.3.0__. | 
**OriginalVersion** | **string** | Identifier of the version of the Supervisor Service installed on the Supervisor at the time when the prechecks were performed. It should always match the version of the Supervisor Service currently installed on the Supervisor. If the Supervisor Service on the Supervisor has been upgraded or deleted since the last prechecks, the stale results will be purged.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, there was no version installed when the prechecks were performed. | [optional] 
**Status** | **string** | Status of the last precheck result.  Possible values:   - &#x60;COMPATIBLE&#x60;: The target version is compatible with the Supervisor.   - &#x60;INCOMPATIBLE&#x60;: The target version is incompatible with the Supervisor.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.PrecheckResult.Status*.  This property was added in __vSphere API 8.0.3.0__. | 
**StatusMessages** | [**List&lt;VcenterNamespaceManagementSupervisorsSupervisorServicesMessage&gt;**](VcenterNamespaceManagementSupervisorsSupervisorServicesMessage.md) | A set of messages that provide additional details of the last valid precheck result, including errors and warnings for potential incompatibility.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, the target version is compatible with the Supervisor. | [optional] 
**PrecheckFinishTime** | **DateTime** | The timestamp at which the compatibility pre-check finished  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

