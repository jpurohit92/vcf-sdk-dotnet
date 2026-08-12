# Vcenter.ViJson.OpenApi.Model.VirtualBusLogicControllerOption
This data object contains the options for a BusLogic SCSI controller. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumSCSIDisks** | [**IntOption**](IntOption.md) | Three properties (numSCSIDisks.min, numSCSIDisks.max, and numSCSIDisks.defaultValue) define the minimum, maximum, and default number of SCSI VirtualDisk instances available at any given time in the SCSI controller.  The number of SCSI VirtualDisk instances is also limited by the number of available slots in the SCSI controller.  | 
**NumSCSICdroms** | [**IntOption**](IntOption.md) | Three properties (numSCSICdroms.min, numSCSICdroms.max, and numSCSICdroms.defaultValue) define the minimum, maximum, and default number of SCSI VirtualCdrom instances available in the SCSI controller.  The number of SCSI VirtualCdrom instances is also limited by the number of available slots in the SCSI controller.  | 
**NumSCSIPassthrough** | [**IntOption**](IntOption.md) | Three properties (numSCSIPassthrough.min, numSCSIPassthrough.max, and numSCSIPassthrough.defaultValue) define the minimum, maximum, and default number of VirtualSCSIPassthrough instances available have at any given time in the SCSI controller.  The number of VirtualSCSIPassthrough instances is also limited by the number of available slots in the SCSI controller.  | 
**Sharing** | [**List&lt;VirtualSCSISharingEnum&gt;**](VirtualSCSISharingEnum.md) | Supported shared bus modes.  | 
**DefaultSharedIndex** | **int** | Index into sharing array specifying the default value.  | 
**HotAddRemove** | [**BoolOption**](BoolOption.md) | All SCSI controllers support hot adding and removing of devices.  This support can&#39;t be toggled in the current implementation. Therefore, this option is ignored when reconfiguring a SCSI controller and is always set to \&quot;true\&quot; when reading an existing configuration.  | 
**ScsiCtlrUnitNumber** | **int** | The unit number of the SCSI controller.  The SCSI controller sits on its own bus, so that this field defines which slot the controller will use.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

