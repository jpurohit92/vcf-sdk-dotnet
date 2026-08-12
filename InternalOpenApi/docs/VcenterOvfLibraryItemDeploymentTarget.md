# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemDeploymentTarget
The Vcenter.Ovf.LibraryItem.DeploymentTarget schema describes the location (target) where a virtual machine or virtual appliance should be deployed. It is used in the deploy and filter operations. See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourcePoolId** | **string** | Identifier of the resource pool to which the virtual machine or virtual appliance should be attached.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ResourcePool&#x60;. | 
**HostId** | **string** | Identifier of the target host on which the virtual machine or virtual appliance will run. The target host must be a member of the cluster that contains the resource pool identified by *Vcenter.Ovf.LibraryItem.DeploymentTarget.resource_pool_id*.  If missing or &#x60;null&#x60;, the server will automatically select a target host from the resource pool if *Vcenter.Ovf.LibraryItem.DeploymentTarget.resource_pool_id* is a stand-alone host or a cluster with Distributed Resource Scheduling (DRS) enabled.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**FolderId** | **string** | Identifier of the vCenter folder that should contain the virtual machine or virtual appliance. The folder must be virtual machine folder.  If missing or &#x60;null&#x60;, the server will choose the deployment folder.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

