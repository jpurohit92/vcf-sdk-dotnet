# Vcenter.ViJson.OpenApi.Model.VsanRemoteClusterNotCompatible

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Msg** | **string** | Message describing the issue.  | 
**CompatibilityInfo** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | An array of key-value pair.  This array contains the names of client and server clusters. Minimum and maximum supported format version for the client cluster and server cluster&#39;s format version. Key-value pairs: - \&quot;clientClusterName\&quot;: Name of the cluster mounting the server   cluster - \&quot;serverClusterName\&quot;: Name of the cluster being mounted - \&quot;clientVfvMin\&quot;: Minimum supported client&#39;s target version - \&quot;clientVfvMax\&quot;: Maximum supported client&#39;s target version - \&quot;serverVFV\&quot;: Supported target version for server cluster  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

