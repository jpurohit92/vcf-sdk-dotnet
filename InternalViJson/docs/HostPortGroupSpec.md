# Vcenter.ViJson.OpenApi.Model.HostPortGroupSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the port group.  | 
**VlanId** | **int** | The VLAN ID for ports using this port group.  Possible values: - A value of 0 specifies that you do not want the port group associated   with a VLAN. - A value from 1 to 4094 specifies a VLAN ID for the port group. - A value of 4095 specifies that the port group should use trunk mode,   which allows the guest operating system to manage its own VLAN tags.  | 
**VswitchName** | **string** | The identifier of the virtual switch on which this port group is located.  | 
**Policy** | [**HostNetworkPolicy**](HostNetworkPolicy.md) | Policies on the port group take precedence over the ones specified on the virtual switch.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

