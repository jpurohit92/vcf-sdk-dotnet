# Vcenter.ViJson.OpenApi.Model.VmDiskFileQueryFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskType** | **List&lt;string&gt;** | If this optional property is set, only the virtual disk primary files that match one of the specified disk types are selected.  If no disk types are specified, this search criteria is ignored.  The specified disk type is one of the backing information types for a virtual disk.  See also *VirtualDisk*.  | [optional] 
**MatchHardwareVersion** | **List&lt;int&gt;** | If this optional property is set, only virtual disk primary files that match one of the specified hardware versions are selected.  If no versions are specified, this search criteria is ignored.  | [optional] 
**ControllerType** | **List&lt;string&gt;** | Deprecated as of vSphere API 5.0, this property is no longer relevant and should not be used. With the current state of emulation, we don&#39;t care about the adapter type a disk is connected to, as disks may be shuffled around. For example, a disk may be unplugged from a buslogic controller and plugged into an lsilogic controller.  If this optional property is set, only virtual disk files that have a controller type that matches one of the controller types specified are returned.  If no controller types are specified, this search criteria is ignored.  The specified controller type is one of the controller types for a virtual disk.  See also *VirtualIDEController*, *VirtualSCSIController*.  | [optional] 
**Thin** | **bool** | This optional property can be used to filter disks based on whether they are thin-provisioned or not: if set to true, only thin-provisioned disks are returned, and vice-versa.  | [optional] 
**Encrypted** | **bool** | This optional property can be used to filter disks based on whether they are encrypted or not.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

