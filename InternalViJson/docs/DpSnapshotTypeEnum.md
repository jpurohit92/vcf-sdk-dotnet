# Vcenter.ViJson.OpenApi.Model.DpSnapshotTypeEnum
Indicates the type of snapshot taken on a given protected entity.  Possible values: - `crashConsistent`: Crash Consistent snapshot. - `applicationConsistent`: Application Consistent snapshot.      Generally used for linux GOS to run pre-freeze and post-thaw scripts. - `vssAppConsistentFull`:       Deprecated as of vSphere API 8.0 release. There is no replacement as this value is unused. VSS Application Consistent Snapshot whereby a full backup is requested regardless of whether files have been marked as backed up or not. Correlates to VSS\\_BT\\_FULL. Applicable only for windows VMs.      This is deprecated. - `vssAppConsistentCopy`:       Deprecated as of vSphere API 8.0 release. There is no replacement as this value is unused. VSS Application Consistent Snapshot whereby files on disk will be copied regardless of the state of each file's backup history, and the backup history will not be updated. Correlates to VSS\\_BT\\_COPY. Applicable only for windows VMs.      This is deprecated. - `metadataOnly`: Metadata only snapshot is similar to a crash consistent snapshot, with the exception that COW operation is not performed on snapshot extents of a 'metadataOnly' snapshot.      It is generally used for restore operations like 'In-place' restore and 'Failback'. - `vssAppConsistent` - `snapshotTypeUnknown`: The value to be used when the older version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

