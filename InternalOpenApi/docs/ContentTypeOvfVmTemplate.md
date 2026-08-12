# Vcenter.Automation.OpenApi.Model.ContentTypeOvfVmTemplate
Provide template VM information in an OVF template (see OvfTemplate#type). The template VM provide the information about the operation system, CPU, memory, disks and NICs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmName** | **string** | Name of the VM | 
**OsType** | **string** | OS type of the VM  A VM template is not required to specify an OS. | [optional] 
**OsDescription** | **string** | OS description  A VM template is not required to specify an OS. | [optional] 
**Cpu** | [**ContentTypeOvfCpu**](ContentTypeOvfCpu.md) | CPU information of the VM  A VM template is not required to specify a CPU. | [optional] 
**Memory** | [**ContentTypeOvfMemory**](ContentTypeOvfMemory.md) | memory information of the VM  A VM template is not required to specify memory. | [optional] 
**Disks** | [**List&lt;ContentTypeOvfDisk&gt;**](ContentTypeOvfDisk.md) | All hard disks on the VM  A VM template is not required to specify a list of disks. | [optional] 
**Nics** | [**List&lt;ContentTypeOvfNic&gt;**](ContentTypeOvfNic.md) | All NICs on the VM  A VM template is not required to specify a list of network interfaces. | [optional] 
**VideoCards** | [**List&lt;ContentTypeOvfVideoCard&gt;**](ContentTypeOvfVideoCard.md) | Video cards of the VM  A VM template is not required to specify a list of video cards. | [optional] 
**Drives** | [**List&lt;ContentTypeOvfDrive&gt;**](ContentTypeOvfDrive.md) | CD / DVD drives of the VM  A VM template is not required to specify a list of drives. | [optional] 
**Floppies** | [**List&lt;ContentTypeOvfFloppy&gt;**](ContentTypeOvfFloppy.md) | floppy drives of the VM  A VM template is not required to specify a list of floppy drives. | [optional] 
**DiskControllers** | [**List&lt;ContentTypeOvfDiskController&gt;**](ContentTypeOvfDiskController.md) | Disk Controllers  A VM template is not required to specify a list of disk controllers. | [optional] 
**UsbControllers** | [**List&lt;ContentTypeOvfUSBController&gt;**](ContentTypeOvfUSBController.md) | USB Controllers  A VM template is not required to specify a list of USB controllers. | [optional] 
**StoragePolicies** | [**List&lt;ContentTypeOvfPolicyStoragePolicy&gt;**](ContentTypeOvfPolicyStoragePolicy.md) | Storage policies of the VM.  A VM template is not required to specify a list of storage policies. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

