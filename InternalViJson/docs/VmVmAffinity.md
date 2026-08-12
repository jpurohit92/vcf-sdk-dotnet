# Vcenter.ViJson.OpenApi.Model.VmVmAffinity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffinedVmsTag** | [**TagId**](TagId.md) | Name of the vSphere tag identifying the VMs that need to be affined with each other.  When this type of placement policy is specified for a VM (via *VirtualMachineConfigSpec.vmPlacementPolicies* or *VirtualMachineRelocateSpec.vmPlacementPolicies*), then that VM is affined with all the other VMs that have *VmVmAffinity.affinedVmsTag* a vSphere tag. This means that DRS will attempt to place all the VMs with *VmVmAffinity.affinedVmsTag* on the same target host/cluster/vSphereZone (where the topology of the target is specified by *VmVmAffinity.policyTopology*).  Example: VmVmAffinity placement policy with *VmVmAffinity.affinedVmsTag* equal to \&quot;test-workloads\&quot; would mean that all the VMs that have a vSphere tag with the name \&quot;test-workloads\&quot; should be placed on the same target host/cluster/vSphereZone (as indicated by *VmVmAffinity.policyTopology*).  | 
**PolicyStrictness** | **string** | Specifies the strictness of this VmVmAffinity placement policy while placing a VM for which this policy is specified.  For details, see *VmPlacementPolicyVmPlacementPolicyStrictness_enum*  If this field is left unset, then the default value of *PreferredDuringPlacementPreferredDuringExecution* will be assumed.  | [optional] 
**PolicyTopology** | **string** | Specifies the topology for enforcing this VmVmAffinity placement policy while placing a VM for which this policy is specified.  For possible values, see *VmPlacementPolicyVmPlacementPolicyTopology_enum*.  For example: \\- If this is set to *VSphereZone*, the VMs that have *VmVmAffinity.affinedVmsTag* tag attached to them should be placed in the same vSphere Zone. \\- If this is set to *Host*, the VMs that have *VmVmAffinity.affinedVmsTag* tag attached to them should be placed on the same ESXi host.  If this field is left unset, then the default value of *Host* will be assumed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

