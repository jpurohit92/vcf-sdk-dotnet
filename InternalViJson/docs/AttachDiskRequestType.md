# Vcenter.ViJson.OpenApi.Model.AttachDiskRequestType
The parameters of *VirtualMachine.AttachDisk_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskId** | [**ID**](ID.md) | The ID of the virtual disk to be operated. See *ID*  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the virtual disk is located.  Refers instance of *Datastore*.  | 
**ControllerKey** | **int** | Key of the controller the disk will connect to. It can be unset if there is only one controller (SCSI or SATA) with the available slot in the virtual machine. If there are multiple SCSI or SATA controllers available, user must specify the controller; if there is no available controllers, a *MissingController* fault will be thrown.  | [optional] 
**UnitNumber** | **int** | The unit number of the attached disk on its controller. If unset, the next available slot on the specified controller or the only available controller will be assigned to the attached disk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

