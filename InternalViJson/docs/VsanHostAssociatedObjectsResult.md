# Vcenter.ViJson.OpenApi.Model.VsanHostAssociatedObjectsResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;VsanHostAssociatedObjects&gt;**](VsanHostAssociatedObjects.md) | SPBM profile associated objects.  As SPBM could query with SPBM profile generation number not specified and there could exists objects applied with same SPBM profile Id but different SPBM profile generation, result is an array of type *VsanHostAssociatedObjects*. Each item in the array is one SPBM generation found in vSAN for the SPBM profile ID. For example, if SPBM called VsanAssociatedObjects with SPBM profile xxx and there exists 2 generations (generation number 1 and 2) in vSAN. Then returned result will have an array of size 2. One item is spbmProfileId&#x3D;&#39;xxx&#39; and spbmGenNum&#x3D;1 with objects associated with it. The other item is spbmProfileId&#x3D;&#39;xxx&#39; and spbmGenNum&#x3D;2 with objects associated with it.  | 
**Offset** | **int** | Offset for next query to use.  If there is no more object to query, offset will be -1.  | 
**Limit** | **int** | limit for next query to use  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

