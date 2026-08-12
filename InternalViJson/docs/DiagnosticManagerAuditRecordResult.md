# Vcenter.ViJson.OpenApi.Model.DiagnosticManagerAuditRecordResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Records** | **List&lt;string&gt;** | Zero or more audit records returned.  Each audit record is a UTF-8 string in RFC 5424 format. See RFC 5424, page 8, for the ABNF grammar.  The HOSTNAME and MSGID fields are set to \&quot;-\&quot;, the structured data contains the audit record parameters, no unstructured data will be present, and each record is terminated with an ASCII LF (newline).  | [optional] 
**NextToken** | **string** | The token to be used for subsequent read operations.  The string is \&quot;opaque\&quot;; the format of this data changes over time.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

