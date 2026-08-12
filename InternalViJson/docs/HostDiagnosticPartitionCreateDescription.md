# Vcenter.ViJson.OpenApi.Model.HostDiagnosticPartitionCreateDescription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Layout** | [**HostDiskPartitionLayout**](HostDiskPartitionLayout.md) | Layout describing the format of the disk In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property.  To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 
**DiskUuid** | **string** | The UUID of the SCSI disk on which to create the diagnostic partition.  This disk UUID will match that found in the identification field of the creation spec.  See also *HostScsiDisk*, *ScsiLun.uuid*.  | 
**Spec** | [**HostDiagnosticPartitionCreateSpec**](HostDiagnosticPartitionCreateSpec.md) | Creation specification for diagnostic partition  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

