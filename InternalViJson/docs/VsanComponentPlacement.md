# Vcenter.ViJson.OpenApi.Model.VsanComponentPlacement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Component type.  The type can be \&quot;Concatenation\&quot;, \&quot;RAID\\_1\&quot;, \&quot;RAID\\_0\&quot;, \&quot;Component\&quot; or else.  | 
**Children** | [**List&lt;VsanComponentPlacement&gt;**](VsanComponentPlacement.md) | Component placement tree structure.  The root node is the component type \&quot;Concatenation\&quot;, \&quot;RAID\\_1\&quot;, \&quot;RAID\\_0\&quot; or else. For the leaf nodes: - The *VsanComponentPlacement.type* set to \&quot;Component\&quot;. - The *VsanComponentPlacement.basicInfo* is set. - This field is unset.  | [optional] 
**BasicInfo** | [**VsanComponentBasicInfo**](VsanComponentBasicInfo.md) | Component basic information.  Set only when the component type is \&quot;Component\&quot;, and the component is a leaf node.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

