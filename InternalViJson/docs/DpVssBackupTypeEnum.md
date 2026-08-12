# Vcenter.ViJson.OpenApi.Model.DpVssBackupTypeEnum
Indicates the backup type for a VSS snapshot.  Applicable only for windows VMs. Refer to `VSS_BACKUP_TYPE` enumeration on MSDN.  Possible values: - `vssBackupTypeFull`: This correlates to `VSS_BT_FULL`, whereby a full backup is requested, regardless of whether files have been marked as backed up or not. - `vssBackupTypeCopy`: This correlates to `VSS_BT_COPY`, whereby files on disk will be copied, regardless of the state of each file's backup history, and the backup history will not be updated. - `vssBackupTypeUnknown`: The value to be used when the older version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

