# Vcenter.ViJson.OpenApi.Model.VsanCapacityReservationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostRebuildThreshold** | **string** | Controls whether the host rebuild threshold is reported to the Capacity View and whether vSAN reserves capacity in the cluster to be able to repair objects after a host failure.  If hostRebuildState is set to enforced and capacitity usage goes beyond the host rebuild threshold, vSAN will fail to create Virtual Machines, Virtual Disks, Snapshots, etc. But IO from existing Virtual Machine will not be failed. - Default value: Reported    See also *VsanCapacityReservationState_enum*.  | [optional] 
**VsanOpSpaceThreshold** | **string** | Controls whether the vSAN operation space threshold is reported to the Capacity View and whether vSAN reserves capacity in the cluster to be able to perform internal operations.  If vsanOpSpaceState is set to enforced and capacitity usage goes beyond the vSAN operation space threshold, vSAN will fail to create Virtual Machines, Virtual Disks, Snapshots, etc. But IO from existing Virtual Machine will not be failed. - Default value: Reported    See also *VsanCapacityReservationState_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

