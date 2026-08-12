# Vcenter.ViJson.OpenApi.Model.HostPortGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | [optional] 
**Port** | [**List&lt;HostPortGroupPort&gt;**](HostPortGroupPort.md) | The ports that currently exist and are used on this port group.  | [optional] 
**Vswitch** | **string** | The virtual switch that contains this port group.  | [optional] 
**ComputedPolicy** | [**HostNetworkPolicy**](HostNetworkPolicy.md) | Computed network policies that are applicable for a port group.  The inheritance scheme for PortGroup requires knowledge about the NetworkPolicy for a port group and its parent virtual switch as well as the logic for computing the results. This information is provided as a convenience so that callers need not duplicate the inheritance logic to determine the proper values for a network policy.  See the description of the *NetworkPolicy* data object type for more information.  | 
**Spec** | [**HostPortGroupSpec**](HostPortGroupSpec.md) | The specification of a port group.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

