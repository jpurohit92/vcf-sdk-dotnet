# Vcenter.ViJson.OpenApi.Model.VsanObjectInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectoryName** | **string** | The friendly name of a namespace object.  | [optional] 
**VsanObjectUuid** | **string** | vSAN object UUID.  If not set, object couldn&#39;t be found in the current cluster.  | [optional] 
**VsanHealth** | **string** | Health of the vSAN object, as seen by the host.  The possible value is &#39;inaccessible&#39;, &#39;reduced-availability-with-no-rebuild&#39;, &#39;reduced-availability-with-no-rebuild-delay-timer&#39;, &#39;reduced-availability-with-active-rebuild&#39;, &#39;data-move&#39;, &#39;non-availability-related-reconfig&#39;, &#39;non-availability-related-incompliance&#39;, &#39;healthy&#39;  | [optional] 
**PolicyAttributes** | [**List&lt;KeyValue&gt;**](KeyValue.md) | vSAN policy attributes used for the policy of the object.  Not set if the object couldn&#39;t be found, or if the object is not healthy enough to determine its policy. Its format is key-value pair list, each key-value pair represents one attribute, the key is the attribute name, the value is the attribute value represented by string format.  | [optional] 
**SpbmProfileUuid** | **string** | UUID of SPBM profile used for the policy of the object when it was applied to vSAN Object.  Not set if the object couldn&#39;t be found, if the object is not healthy enough to determine its policy, or if the object doesn&#39;t use a SPBM managed policy.  | [optional] 
**SpbmProfileGenerationId** | **string** | Generation ID of SPBM profile used for the policy of the object when it was applied to vSAN Object.  Not set if the object couldn&#39;t be found, if the object is not healthy enough to determine its policy, or if the object doesn&#39;t use a SPBM managed policy.  | [optional] 
**SpbmComplianceResult** | [**VsanStorageComplianceResult**](VsanStorageComplianceResult.md) | Describes the results of profile compliance checking for a vSAN object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

