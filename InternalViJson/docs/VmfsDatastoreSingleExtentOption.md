# Vcenter.ViJson.OpenApi.Model.VmfsDatastoreSingleExtentOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Layout** | [**HostDiskPartitionLayout**](HostDiskPartitionLayout.md) | The partition table layout that the disk will have if this provisioning option is selected.  In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 
**PartitionFormatChange** | **bool** | Indicates whether selecting this option will change the partition format type on the disk.  See also *HostDiskPartitionInfoPartitionFormat_enum*.  | [optional] 
**VmfsExtent** | [**HostDiskPartitionBlockRange**](HostDiskPartitionBlockRange.md) | The block range to be used as an extent in a VMFS datastore.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

