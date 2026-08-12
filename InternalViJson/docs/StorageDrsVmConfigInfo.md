# Vcenter.ViJson.OpenApi.Model.StorageDrsVmConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the virtual machine.  Can be NULL during initial placement.  Refers instance of *VirtualMachine*.  | [optional] 
**Enabled** | **bool** | Flag to indicate whether or not VirtualCenter is allowed to perform any storage migration or initial placement recommendations for this virtual machine on the pod *StoragePod*.  If this flag is false, the virtual machine is effectively excluded from storage DRS.  If no individual DRS specification exists for a virtual machine, this property defaults to true.  | [optional] 
**Behavior** | **string** | Specifies the particular storage DRS behavior for this virtual machine.  For supported values, see *StorageDrsPodConfigInfoBehavior_enum*.  | [optional] 
**IntraVmAffinity** | **bool** | Specifies whether or not to have the affinity rule for the virtual disks of this virtual machine.  If not set, the default value is derived from the pod-wide default *StorageDrsPodConfigInfo.defaultIntraVmAffinity*.  | [optional] 
**IntraVmAntiAffinity** | [**VirtualDiskAntiAffinityRuleSpec**](VirtualDiskAntiAffinityRuleSpec.md) | Deprecated as of vSphere API 7.0.  Specifies the disks for this virtual machine that should be placed on different datastores.  A VM cannot have both an affinity and an anti-affinity rule at the same time. Virtual machine disks that are not in this rule are unconstrained and can be placed either on the same datastore or on a different datastore as other disks from this virtual machine.  | [optional] 
**VirtualDiskRules** | [**List&lt;VirtualDiskRuleSpec&gt;**](VirtualDiskRuleSpec.md) | List of the virtual disk rules that can be overridden/created.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

