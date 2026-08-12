# Vcenter.ViJson.OpenApi.Model.VirtualLsiLogicController
VirtualLsiLogicController is the data object that represents a LSI Logic SCSI controller. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HotAddRemove** | **bool** | All SCSI controllers support hot adding and removing of devices.  This support can&#39;t be toggled in the current implementation. Therefore, this option is ignored when reconfiguring a SCSI controller and is always set to \&quot;true\&quot; when reading an existing configuration.  | [optional] 
**SharedBus** | **VirtualSCSISharingEnum** | Mode for sharing the SCSI bus.  The modes are physicalSharing, virtualSharing, and noSharing. See the *Sharing* data object type for an explanation of these modes.  | 
**ScsiCtlrUnitNumber** | **int** | The unit number of the SCSI controller.  The SCSI controller sits on its own bus, so this field defines which slot the controller is using.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

