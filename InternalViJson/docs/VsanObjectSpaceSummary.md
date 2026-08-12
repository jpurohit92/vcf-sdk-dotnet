# Vcenter.ViJson.OpenApi.Model.VsanObjectSpaceSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjType** | **string** | The vSAN object type.  It could be one of types defined in below enumerations: *VsanObjectTypeEnum_enum*, *VsanObjectTypeEnum90_enum*  | [optional] 
**OverheadB** | **long** | The overhead for this type of vSAN object in byte.  The overhead includes the space like replica data, witness metadata and RAID 5/6 parity data etc. The sum of overhead, temporary overhead and the primary data size will equal to the object total used size  | [optional] 
**TemporaryOverheadB** | **long** | The temporary overhead for this type of vSAN object in byte.  The temporary overhead include the space like used for data moving and will be released eventually.  | [optional] 
**PrimaryCapacityB** | **long** | The primary capacity for this type of vSAN object in byte.  The primary data is the actual user data written into physical disk which doesn&#39;t include any overhead, e.g. temporary overhead or replica data.  | [optional] 
**ProvisionCapacityB** | **long** | The total provisioned capacity for this type of vSAN object in byte.  It&#39;s the total user requested logical capacity from the vSAN data store  | [optional] 
**ReservedCapacityB** | **long** | The total reserved capacity for this type of vSAN object in byte.  When user create the virtual disk from vSAN datastore, he/she can specify how many physical space should be reserved for the virtual disk through disk provisioning policy or legacy thick provisioning.  | [optional] 
**OverReservedB** | **long** | The total over reserved capacity for this type of vSAN object in byte.  It indicates how much capacity is over-reserved between the total reserved capacity and the actual user data written into disk. In other words, such space is potentially wasted, and reducing the reservation would free up space.  | [optional] 
**PhysicalUsedB** | **long** | The total of physically used capacity for this type of vSAN object in byte.  It indicates how much data are written into the physical disk.  | [optional] 
**UsedB** | **long** | The total of used capacity for this type of vSAN object in byte.  It&#39;s the max value between physically used capacity and the reserved capacity.  | [optional] 
**ObjTypeExt** | **string** | Extended type for extension object to identify different extension volume  | [optional] 
**ObjTypeExtDesc** | **string** | Description of extended type for extension object  | [optional] 
**SnapshotUsedB** | **long** | The physical storage consumed by vSAN snapshots.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

