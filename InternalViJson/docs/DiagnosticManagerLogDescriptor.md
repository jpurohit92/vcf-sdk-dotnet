# Vcenter.ViJson.OpenApi.Model.DiagnosticManagerLogDescriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A key to identify the log file for browsing and download operations.  | 
**FileName** | **string** | The filename of the log.  | 
**Creator** | **string** | The application that generated the log file.  For more information on currently supported creators, see *DiagnosticManagerLogCreator_enum*.  | 
**Format** | **string** | Describes the format of the log file.  For more information on currently supported formats, see *DiagnosticManagerLogFormat_enum*.  | 
**MimeType** | **string** | Describes the mime-type of the returned file.  Typical mime-types include: - text/plain - for a plain log file  | 
**Info** | [**Description**](Description.md) | Localized description of log file.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

