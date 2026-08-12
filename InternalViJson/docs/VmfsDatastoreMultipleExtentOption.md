# Vcenter.ViJson.OpenApi.Model.VmfsDatastoreMultipleExtentOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Layout** | [**HostDiskPartitionLayout**](HostDiskPartitionLayout.md) | The partition table layout that the disk will have if this provisioning option is selected.  In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 
**PartitionFormatChange** | **bool** | Indicates whether selecting this option will change the partition format type on the disk.  See also *HostDiskPartitionInfoPartitionFormat_enum*.  | [optional] 
**VmfsExtent** | [**List&lt;HostDiskPartitionBlockRange&gt;**](HostDiskPartitionBlockRange.md) | The block ranges to be used as extents in a VMFS datastore.  The first block range will be the head partition.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

