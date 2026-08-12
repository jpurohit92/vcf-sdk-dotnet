# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchPortConnectee

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectedEntity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The connected entity.  This property should always be set unless the user&#39;s setting does not have System.Read privilege on the object referred to by this property.  Refers instance of *ManagedEntity*.  | [optional] 
**NicKey** | **string** | The key of the virtual NIC that connects to this port.  | [optional] 
**Type** | **string** | The type of the connectee.  See *ConnecteeType* for valid values.  | [optional] 
**AddressHint** | **string** | A hint on address information of the NIC that connects to this port.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

