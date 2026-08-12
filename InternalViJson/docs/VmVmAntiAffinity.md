# Vcenter.ViJson.OpenApi.Model.VmVmAntiAffinity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntiAffinedVmsTag** | [**TagId**](TagId.md) | Name of the vSphere tag identifying the VMs that need to be anti-affined with each other.  When this type of placement policy is specified for a VM, (via *VirtualMachineConfigSpec.vmPlacementPolicies* or *VirtualMachineRelocateSpec.vmPlacementPolicies*), then that VM is anti-affined to all the other VMs that have *VmVmAntiAffinity.antiAffinedVmsTag*. This means that DRS will attempt to place all the VMs with *VmVmAntiAffinity.antiAffinedVmsTag* tag on different target hosts/clusters/ vSphereZones (where the topology of the target is specified by *VmVmAntiAffinity.policyTopology*).  For example - VmVmAntiAffinity placement policy with *VmVmAntiAffinity.antiAffinedVmsTag* equal to \&quot;prod-workloads\&quot; would mean that all the VMs that have a vSphere tag with the name \&quot;prod-workloads\&quot; should be placed on different target hosts/clusters/vSphereZones (as indicated by *VmVmAntiAffinity.policyTopology*).  | 
**PolicyStrictness** | **string** | Specifies the strictness of this VmVmAntiAffinity placement policy while placing a VM for which this policy is specified.  For details, see *VmPlacementPolicyVmPlacementPolicyStrictness_enum*  If this field is left unset, then the default value of *PreferredDuringPlacementPreferredDuringExecution* will be assumed.  | [optional] 
**PolicyTopology** | **string** | Specifies the topology for enforcing this VmVmAntiAffinity placement policy while placing a VM for which this policy is specified.  For possible values, see *VmPlacementPolicyVmPlacementPolicyTopology_enum*.  For example: \\- If this is set to *VSphereZone*, the VMs that have *VmVmAntiAffinity.antiAffinedVmsTag* tag attached to them should be placed in different vSphere Zones. \\- If this is set to *Host*, the VMs that have *VmVmAntiAffinity.antiAffinedVmsTag* tag attached to them should be placed on different ESXi hosts (but they may be placed in the same vSphere Zone).  If this field is left unset, then the default value of *Host* will be assumed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

