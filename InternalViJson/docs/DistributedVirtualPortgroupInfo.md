# Vcenter.ViJson.OpenApi.Model.DistributedVirtualPortgroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SwitchName** | **string** | The name of the switch.  | 
**SwitchUuid** | **string** | The UUID of the switch.  | 
**PortgroupName** | **string** | The name of the portgroup.  | 
**PortgroupKey** | **string** | The key of the portgroup.  | 
**PortgroupType** | **string** | The type of portgroup.  See *DistributedVirtualPortgroupPortgroupType_enum*  | 
**UplinkPortgroup** | **bool** | Whether this portgroup is an uplink portgroup.  | 
**Portgroup** | [**ManagedObjectReference**](ManagedObjectReference.md) | The portgroup.  Refers instance of *DistributedVirtualPortgroup*.  | 
**NetworkReservationSupported** | **bool** | Indicates whether network bandwidth reservation is supported on the portgroup  | [optional] 
**BackingType** | **string** | Backing type of portgroup.  See *DistributedVirtualPortgroup*.*DistributedVirtualPortgroupBackingType_enum* for possible values. The default value is \&quot;standard\&quot;.  | [optional] 
**LogicalSwitchUuid** | **string** | The logical switch UUID, which is used by NSX portgroup  | [optional] 
**SegmentId** | **string** | The segment ID of logical switch, which is used by NSX portroup  | [optional] 
**SubnetId** | **string** | The subnet ID of logical switch  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

