# Vcenter.ViJson.OpenApi.Model.DiskClaimConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskType** | **string** | Specify the vSAN ESA storage tier to which the disks should be added to.  For eg, to add disks to single tier storage pool, specify &#39;SingleTier&#39; in the diskType attribute. Please see *StoragePoolDiskType_enum* for supported vSAN ESA storage tiers.  See also *StoragePoolDiskType_enum*.  | 
**DiskNamePrefix** | **string** | All disks starting with prefix or matching the disk name specified in this attribute will be claimed.  For eg, if \\&#x60;diskNamePrefix &#x3D; naa\\&#x60;, then all disks with disks starting with prefix \\&#x60;naa\\&#x60; will be claimed. If \\&#x60;diskNamePrefix &#x3D; mpx.vmhba0:C0:T4:L0\\&#x60;, all disks matching this disk name will be claimed on all hosts in the vSAN cluster.  | [optional] 
**NumberOfDisks** | **int** | This attribute can be used to specify number of disks to be claimed on every host in the cluster.  | [optional] 
**DiskModel** | **string** | This attribute can be used to specify disk model to be claimed on every host in the cluster.  | [optional] 
**Vendor** | **string** | This attribute can be used to specify disks belonging to a particular vendor type to be claimed on every host in the cluster.  | [optional] 
**DiskCapacity** | **long** | Specify disk capacity in MegaByte (MB).  Disks of specified size will be claimed on all hosts in the cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

