# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lease** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *HttpNfcLease* object this information belongs to.  Refers instance of *HttpNfcLease*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *VirtualMachine* or *VirtualApp* this lease covers.  Refers instance of *ManagedEntity*.  | 
**DeviceUrl** | [**List&lt;HttpNfcLeaseDeviceUrl&gt;**](HttpNfcLeaseDeviceUrl.md) | The deviceUrl property contains a mapping from logical device keys to URLs.  | [optional] 
**TotalDiskCapacityInKB** | **long** | Total capacity in kilobytes of all disks in all Virtual Machines covered by this lease.  This can be used to track progress when transferring disks.  | 
**LeaseTimeout** | **int** | Number of seconds before the lease times out.  The client extends the lease by calling *HttpNfcLease.HttpNfcLeaseProgress* before the timeout has expired.  | 
**HostMap** | [**List&lt;HttpNfcLeaseDatastoreLeaseInfo&gt;**](HttpNfcLeaseDatastoreLeaseInfo.md) | Map of URLs for leased hosts for a given datastore.  This is used to look up multi-POST-capable hosts for a datastore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

