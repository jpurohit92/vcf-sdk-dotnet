# Vcenter.ViJson.OpenApi.Model.GuestPosixFileAttributes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModificationTime** | **DateTime** | The date and time the file was last modified.  If this property is not specified when passing a *GuestFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest*, the default value will be the time when the file is created inside the guest.  | [optional] 
**AccessTime** | **DateTime** | The date and time the file was last accessed.  If this property is not specified when passing a *GuestFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest*, the default value will be the time when the file is created inside the guest.  | [optional] 
**SymlinkTarget** | **string** | The target for the file if it&#39;s a symbolic link.  This is currently only set for Linux guest operating systems, but may be supported in the future on Windows guest operating systems that support symbolic links. This property gives information about files when returned from *GuestFileManager.ListFilesInGuest* or *GuestFileManager.InitiateFileTransferFromGuest* as part of a *GuestFileAttributes* object. This property will be ignored when passing a *GuestFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest* or *GuestFileManager.ChangeFileAttributesInGuest*. If the file is a symbolic link, then the attributes of the target are returned, not those of the symbolic link.  | [optional] 
**OwnerId** | **int** | The owner ID.  If this property is not specified when passing a *GuestPosixFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest*, the default value will be the owner Id of the user who invoked the file transfer operation.  | [optional] 
**GroupId** | **int** | The group ID.  If this property is not specified when passing a *GuestPosixFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest*, the default value will be the group Id of the user who invoked the file transfer operation.  | [optional] 
**Permissions** | **long** | The file permissions.  When creating a file with *GuestFileManager.InitiateFileTransferToGuest*, these are in chmod(2) format. When reporting on existing files, these are in stat(2) format. If this property is not specified when passing a *GuestPosixFileAttributes* object to *GuestFileManager.InitiateFileTransferToGuest*, the file will be created with 0644 permissions.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

