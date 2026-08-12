# Vcenter.ViJson.OpenApi.Model.VsanFileShareNetPermission

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ips** | **string** | The client IP information the share user entity.  Currently the following IP range formats will be supported: - Single IPv4 address, e.g., 123.23.23.123 - The network&#39;s IP address with subnet mask, e.g., 123.23.23.0/24 - IP address ranges specified with &#39;-&#39;, e.g., 123.23.23.123-123.23.23.128 - The string &#39;\\*&#39; which implies all clients  | 
**Permissions** | **string** | Permissions assigned to the specified user entity.  No permission will be assigned to this client matching the IP information if the field is not set.  See also *VsanFileShareAccessType_enum*.  | [optional] 
**AllowRoot** | **bool** | Whether to squash the root user or not.  Only takes effect when the net permission for the file share is set to READ\\_WRITE mode.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

