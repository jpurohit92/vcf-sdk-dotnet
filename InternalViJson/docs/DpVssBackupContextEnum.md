# Vcenter.ViJson.OpenApi.Model.DpVssBackupContextEnum
Indicates the backup context to be used for a VSS snapshot.  Applicable only for windows VMs. Refer to `VSS_SNAPSHOT_CONTEXT` enumeration on MSDN.  Possible values: - `vssBackupContextAuto`: This option lets the guest automatically select the right backup context among the values below. - `vssBackupContextBackup`: This correlates to `VSS_CTX_BACKUP`.      It specifies that a shadow copy should be created by involving VSS writers to quiesce their respective application's data. A shadow copy created under this context has auto-release, non-persistent attributes: in other words, it is deleted upon the termination of a backup operation. - `vssBackupContextFileShareBackup`: This correlates to `VSS_CTX_FILE_SHARE_BACKUP`.      It specifies that a shadow copy should be created without involving any VSS writer. A shadow copy created under this context has auto-release, non-persistent attributes: in other words, it is deleted upon the termination of a backup operation. - `vssBackupContextUnknown`: The value to be used when the older version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

