# Vcenter.ViJson.OpenApi.Model.VmPortGroupProfile
The *VmPortGroupProfile* data object represents the subprofile for a port group that will be used by virtual machines.  Use the *ApplyProfile.policy* list for access to configuration data for the virtual machine port group profile. Use the *ApplyProfile.property* list for access to subprofiles, if any.  vSphere Servers use *Network* managed objects to represent virtual machine port groups in the vSphere inventory. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Linkable identifier.  | 
**Name** | **string** | Name of the portgroup.  | 
**Vlan** | [**VlanProfile**](VlanProfile.md) | VLAN identifier for the port group.  | 
**Vswitch** | [**VirtualSwitchSelectionProfile**](VirtualSwitchSelectionProfile.md) | Virtual switch to which the port group is connected.  | 
**NetworkPolicy** | [**NetworkPolicyProfile**](NetworkPolicyProfile.md) | The network policy/policies applicable on the port group.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

