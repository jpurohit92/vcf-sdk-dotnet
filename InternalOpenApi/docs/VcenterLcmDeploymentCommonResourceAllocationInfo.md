# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonResourceAllocationInfo
The Vcenter.Lcm.Deployment.Common.ResourceAllocationInfo schema contains resource allocation information for a VM.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reservation** | **long** | Amount of resource that is guaranteed available to the virtual machine. Reserved resources are not wasted if they are not used. If the utilization is less than the reservation, the resources can be utilized by other running virtual machines. Units are MB for memory, and MHz for CPU.  This property was added in __vSphere API 9.0.0.0__. | 
**Allocate** | **string** | Possible values:   - &#x60;ON_DEPLOYMENT&#x60;: On deployment of a new VM allocate the resource.   - &#x60;ON_SUCCESSFUL_UPGRADE&#x60;: On successful upgrade of the VC allocate the resource to the VM deployed as part of the upgrade.   For more information see: *Vcenter.Lcm.Deployment.Common.AllocateResource*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; will allocate resource at VM deployment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

