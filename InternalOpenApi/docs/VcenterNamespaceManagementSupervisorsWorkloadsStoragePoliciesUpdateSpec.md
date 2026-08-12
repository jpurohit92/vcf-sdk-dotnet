# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsStoragePoliciesUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Workloads.Storage.Policies.UpdateSpec schema contains the specification required to update workload storage policies for the given Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EphemeralStoragePolicy** | **string** | Identifier of the storage policy associated with ephemeral disks of all the vSphere Pods in the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, storage policy associated with ephemeral disks of all the Kubernetes Pods will not be modified.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | [optional] 
**ImageStoragePolicy** | **string** | Identifier of the storage policy associated with vSphere Pod container images.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the image storage policy associated with the Supervisor will not be modified.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

