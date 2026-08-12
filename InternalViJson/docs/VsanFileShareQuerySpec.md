# Vcenter.ViJson.OpenApi.Model.VsanFileShareQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **string** | The name of the domain which the share belongs to.  If not specified, the file shares under all the domains will be queried.  | [optional] 
**Uuids** | **List&lt;string&gt;** | List of the vSAN file share UUIDs to be queried.  | [optional] 
**Names** | **List&lt;string&gt;** | List of vSAN file share names to be queried.  | [optional] 
**Offset** | **string** | All file shares are sorted in alphabetical order.  The offset indicates the starting element of the file share name. For the query of multiple pages the value should be the nextOffset of the return value of the last query. For more explanation, see #nextOffset. If the offset cannot be found in the list, the next file share in alphabetical order will be returned as the first element.  | [optional] 
**Limit** | **long** | This field sets the upper limit for the maximum number of shares to be returned per page.  Default and maximum value for pagination limit is 64. If the limit is larger than the allowed pagination size or is a negative number, an InvalidArgument exception will be thrown.  | [optional] 
**ManagedBy** | **List&lt;string&gt;** | The filter for the managing entity of the file share.  Valid values are in the *VsanFileShareManagingEntity_enum* field.  See also *VsanFileShareManagingEntity_enum*.  | [optional] 
**Protocols** | **List&lt;string&gt;** | The protocol types to be queried.  See also *VsanFileProtocol_enum*.  | [optional] 
**PageNumber** | **long** | The page number to be returned.  The page number can be used to browse the pages of file shares returned between different pages. The page number starts from 1, and defaults to 1. An InvalidArgument will be thrown if the page number is set to a negative number or exceeds the maximum number of pages to be returned. The shares in the pagination starts from the offset specified by the \\#offset parameter.  | [optional] 
**Properties** | [**VsanFileShareQueryProperties**](VsanFileShareQueryProperties.md) | Specify the share properties to be returend.  If not specified, all the properties will be queried and returned. It is highly recommended to include the needed properties only to improve the query performance.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

