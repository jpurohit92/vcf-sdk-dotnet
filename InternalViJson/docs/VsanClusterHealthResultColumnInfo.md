# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthResultColumnInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | The column label  | 
**Type** | **string** | Type of this column, a valid type can be either of the following: 1.  string 2\\. mor 3\\. health 4\\. long 5\\. float 6\\. listMor 7\\. dynamic 8\\. vsanObjectHealth, which is the enumeration type of all of vSAN object health status Note that \&quot;dynamic\&quot; means the column type can be either of the 1-6 listed above, and it must follow the convention: For MOR: ManagedObjectReference:&amp;lt;class&amp;gt;:&amp;lt;id&amp;gt; For listMor: ManagedObjectReference:&amp;lt;class&amp;gt;:&amp;lt;id&amp;gt;, ManagedObjectReference:&amp;lt;class&amp;gt;:&amp;lt;id&amp;gt;, ... For HostReference: HostReference:&amp;lt;hostname&amp;gt; or HostReference:&amp;lt;ip&amp;gt; For others: type:&amp;lt;value&amp;gt;, e.g. string:&amp;lt;string&amp;gt;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

