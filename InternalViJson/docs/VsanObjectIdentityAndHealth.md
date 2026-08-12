# Vcenter.ViJson.OpenApi.Model.VsanObjectIdentityAndHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identities** | [**List&lt;VsanObjectIdentity&gt;**](VsanObjectIdentity.md) | vSAN Object identities.  | [optional] 
**Health** | [**VsanObjectOverallHealth**](VsanObjectOverallHealth.md) | vSAN Object health.  | [optional] 
**SpaceSummary** | [**List&lt;VsanObjectSpaceSummary&gt;**](VsanObjectSpaceSummary.md) | vSAN space usage summaries for each of vSAN object type defined in below enumerations: *VsanObjectTypeEnum_enum*, *VsanObjectTypeEnum90_enum*  | [optional] 
**RawData** | **string** | The raw Json string for objects identity and health structure.  It&#39;s internal used only for performance purpose.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

