# Vcenter.ViJson.OpenApi.Model.VsanHostHclInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Hostname of the host.  | 
**HclChecked** | **bool** | Whether the returned data was checked against the HCL DB.  | 
**ReleaseName** | **string** | Version of ESXi.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means that collection of HCL information failed for this host.  | [optional] 
**Controllers** | [**List&lt;VsanHclControllerInfo&gt;**](VsanHclControllerInfo.md) | Information about all controllers in use by vSAN.  | [optional] 
**Pnics** | [**List&lt;VsanHclNicInfo&gt;**](VsanHclNicInfo.md) | Information about all physical nics  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host system reference.  Refers instance of *HostSystem*.  | [optional] 
**ComputeResource** | [**VsanHclComputeResource**](VsanHclComputeResource.md) | Information about the host compute resource.  | [optional] 
**VsanHostCompatibility** | **List&lt;string&gt;** | vSAN compatibility status of the host.  It will check against all hardware components and aggregate the compatible statuses, like CPUs, memory, physical NICs and disks.  See also *VsanConfigType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

