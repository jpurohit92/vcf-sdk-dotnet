# Vcenter.ViJson.OpenApi.Model.VirtualPCIControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumSCSIControllers** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualSCSIController instances available at any given time in the PCI controller.  The number of VirtualSCSIController instances is also limited by the number of available slots in the PCI controller.  | 
**NumEthernetCards** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualEthernetCard instances available, at any given time, in the PCI controller.  The number of VirtualEthernetCard instances is also limited by the number of available slots in the PCI controller.  | 
**NumVideoCards** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualVideoCard instances available, at any given time, in the PCI controller.  The number of VirtualVideoCard instances is also limited by the number of available slots in the PCI controller.  | 
**NumSoundCards** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualSoundCard instances available, at any given time, in the PCI controller.  The number of VirtualSoundCard instances is also limited by the number of available slots in the PCI controller.  | 
**NumVmiRoms** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualVMIROM instances available, at any given time, in the PCI controller.  This is also limited by the number of available slots in the PCI controller.  | 
**NumVmciDevices** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualVMCIDevice instances available, at any given time, in the PCI controller.  This is also limited by the number of available slots in the PCI controller.  | 
**NumPCIPassthroughDevices** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualPCIPassthrough instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller.  | 
**NumSasSCSIControllers** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualLsiLogicSASController instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported SCSI controllers.  | 
**NumVmxnet3EthernetCards** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualVmxnet3 ethernet card instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported ethernet cards.  | 
**NumParaVirtualSCSIControllers** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of ParaVirtualScsiController instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported SCSI controllers.  | 
**NumSATAControllers** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualSATAController instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported SATA controllers.  | 
**NumNVMEControllers** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualNVMEController instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported NVME controllers.  | [optional] 
**NumVmxnet3VrdmaEthernetCards** | [**IntOption**](IntOption.md) | Defines the minimum, maximum, and default number of VirtualVmxnet3Vrdma ethernet card instances available, at any given time, in the PCI controller.  This is also limited by the number of available PCI Express slots in the PCI controller as well as the total number of supported ethernet cards.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

