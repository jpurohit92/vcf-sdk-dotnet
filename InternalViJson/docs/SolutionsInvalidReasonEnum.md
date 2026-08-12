# Vcenter.ViJson.OpenApi.Model.SolutionsInvalidReasonEnum
Reasons solution is not valid for application.  Possible values: - `INVALID_OVF_DESCRIPTOR`: The OVF descriptor provided in the VM source is invalid. - `INACCESSBLE_VM_SOURCE`: The provided VM source is inaccessible from ESX Agent Manager. - `INVALID_NETWORKS`: The provided networks are not suitable for application purposes. - `INVALID_DATASTORES`: The provided datastores are not suitable for application purposes. - `INVALID_RESOURCE_POOL`: The provided resource pool is not accessible or part of the cluster. - `INVALID_FOLDER`: The provided folder is inaccessible or not part of the same datacenter   with the cluster. - `INVALID_PROPERTIES`: The provided OVF properties are insufficient to satisfy the required   user configurable properties in the VM described in the vmSource. - `INVALID_TRANSITION`: The legacy agency requested for transition is not valid/cannot be   mapped to system Virtual Machines solution. - `INVALID_CLUSTER_TRANSITION`: The LCCM agency requested for cluster transition is invalid because it   cannot be mapped to the desired state specification or has a different   scope than the cluster for transition. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

