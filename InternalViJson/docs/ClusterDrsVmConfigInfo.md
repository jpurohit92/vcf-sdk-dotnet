# Vcenter.ViJson.OpenApi.Model.ClusterDrsVmConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the virtual machine.  Refers instance of *VirtualMachine*.  | 
**Enabled** | **bool** | Flag to indicate whether or not VirtualCenter is allowed to perform any DRS migration or initial placement recommendations for this virtual machine.  If this flag is false, the virtual machine is effectively excluded from DRS.  If no individual DRS specification exists for a virtual machine, this property defaults to true.  | [optional] 
**Behavior** | **DrsBehaviorEnum** | Specifies the particular DRS behavior for this virtual machine.  See also *ClusterDrsConfigInfo*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

