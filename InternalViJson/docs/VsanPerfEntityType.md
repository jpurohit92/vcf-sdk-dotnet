# Vcenter.ViJson.OpenApi.Model.VsanPerfEntityType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The entity type name.  It is used to compose the entity reference id, which is &amp;lt;entity\\_type\\_name&amp;gt;:&amp;lt;entity\\_uuid&amp;gt;   For an example: host-domclient:&amp;lt;hostUuid&amp;gt; is used to identify a vSAN host for querying stats in vSAN clients consumption viewpoint.  | 
**Id** | **string** | Id for the entity type.  | 
**Graphs** | [**List&lt;VsanPerfGraph&gt;**](VsanPerfGraph.md) | The supported metrics (organized by graphs) for this entity type  | 
**Description** | **string** | The description of the entity type.  | [optional] 
**AdvancedGraphs** | [**List&lt;VsanPerfGraph&gt;**](VsanPerfGraph.md) | The advanced supported metrics (organized by graphs) for this entity type, these graphs will be shown in performance for support page.  | [optional] 
**VerboseGraphs** | [**List&lt;VsanPerfGraph&gt;**](VsanPerfGraph.md) | The verbose supported metrics (organized by graphs) for this entity type, these graphs will be shown in performance for support detail page.  | [optional] 
**HotspotGraphs** | [**List&lt;VsanPerfGraph&gt;**](VsanPerfGraph.md) | The hotspot supported metrics (organized by graphs) for this entity type, these graphs will be shown in performance top contributors page.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

