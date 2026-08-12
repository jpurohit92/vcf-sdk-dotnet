# Vcenter.ViJson.OpenApi.Model.VsanHclDiskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | Disk Device name.  | 
**Model** | **string** | Detected model name.  If set, this model name is a more accurate model name for the device. Typically the physical device model instead of a generic logical drive name reported by ESXi for RAID groups on RAID controllers.  | [optional] 
**IsSsd** | **bool** | If set, indicates a more accurate identification of the device.  Typically the physical device type instead of a generic logical drive type reported by ESXi for RAID groups on RAID controllers.  | [optional] 
**VsanDisk** | **bool** | True if the disk is used by vSAN.  It may be safe to ignore issues reported on drive which are not vSAN disks. Remediation will only touch disks used by vSAN.  | 
**Issues** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Any issues detected with the configuration of the device on the controller.  | [optional] 
**RemediableIssues** | **List&lt;string&gt;** | Keys of issues which can be remediated.  | [optional] 
**Uuid** | **string** | Universally unique identifier for the LUN used to identify ScsiLun across multiple servers.  See *ScsiLun.uuid*  | [optional] 
**Capacity** | **long** | The disk capacity in bytes.  | [optional] 
**VsanCompatibility** | **List&lt;string&gt;** | A list of supported vSAN storage types.  E.g. \\[&#39;diskGroup&#39;, &#39;singleTier&#39;\\].  See also *VsanDiskCompatibilityType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

