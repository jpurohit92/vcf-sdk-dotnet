# Vcenter.ViJson.OpenApi.Model.VirtualSriovEthernetCardSriovBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhysicalFunctionBacking** | [**VirtualPCIPassthroughDeviceBackingInfo**](VirtualPCIPassthroughDeviceBackingInfo.md) | Physical function backing for this device.  A specific physical function can be assigned to the device by specifying its id but the VirtualSriovNetworkCard can also be configured for automatic physical function assignment by providing a special value \&quot;Automatic-0000:00:00.0\&quot; as *VirtualPCIPassthroughDeviceBackingInfo.id*. This is supported if there is an associated SR-IOV network device pool for the network specified in *VirtualDevice.backing* - in that case a physical function from the pool, if available, will be assigned to this device during power on. During reconfigure, if an SR-IOV backing is provided, the physical function backing may not be left unset. A value of \&quot;Automatic-\&quot; followed by a valid physical function id in *VirtualPCIPassthroughDeviceBackingInfo.id* indicates that assignment is automatic and the physical function in question is the one that has currently been assigned.  | [optional] 
**VirtualFunctionBacking** | [**VirtualPCIPassthroughDeviceBackingInfo**](VirtualPCIPassthroughDeviceBackingInfo.md) | Virtual function backing for this device.  During reconfigure, if this is unset, any currently assigned virtual function will be overwritten and a new one will be selected. If *VirtualPCIPassthroughDeviceBackingInfo.id* contains a valid id for a virtual function of the currently assigned physical function, this acts as a hint and, if possible, the specified virtual function will be the one allocated for the device. When a virtual function is yet to be assigned to the device (e.g. if the VM has not been powered on yet), the virtual function backing will be unset.  | [optional] 
**VirtualFunctionIndex** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

