# Vcenter.ViJson.OpenApi.Model.VirtualMachineRelocateSpecDiskLocator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskId** | **int** | Device ID of the virtual disk.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target datastore.  Refers instance of *Datastore*.  | 
**DiskMoveType** | **string** | Manner in which to move the virtual disk to the *target datastore*.  The set of possible values is described in *VirtualMachineRelocateDiskMoveOptions_enum*.  This property can only be set if *HostCapability.deltaDiskBackingsSupported* is true.  If left unset then *moveAllDiskBackingsAndDisallowSharing* is assumed.  | [optional] 
**DiskBackingInfo** | [**VirtualDeviceBackingInfo**](VirtualDeviceBackingInfo.md) | Backing information for the virtual disk at the destination.  This can be used, for instance, to change the format of the virtual disk. If the specified backing is invalid or not supported at the destination, *InvalidDeviceBacking* is thrown. Specific property changes may be ignored if they are not supported.  Supported BackingInfo types and properties: - *VirtualDiskFlatVer2BackingInfo*   - thinProvisioned   - eagerlyScrub - *VirtualDiskSeSparseBackingInfo*   (ESX 5.1 or later)  | [optional] 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual Disk Profile requirement.  Profiles are solution specific. Profile Based Storage Management is a vSphere server extension. The API users who want to provision VMs using Storage Profiles, need to interact with it. This is an optional parameter and if user doesn&#39;t specify profile, the default behavior will apply.  | [optional] 
**Backing** | [**VirtualMachineRelocateSpecDiskLocatorBackingSpec**](VirtualMachineRelocateSpecDiskLocatorBackingSpec.md) | Cryptographic option of the current disk.  | [optional] 
**FilterSpec** | [**List&lt;VirtualMachineBaseIndependentFilterSpec&gt;**](VirtualMachineBaseIndependentFilterSpec.md) | List of independent filters *VirtualMachineIndependentFilterSpec* to be configured on the virtual disk after the relocate.  ***Since:*** vSphere API Release 7.0.2.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

