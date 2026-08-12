# Vcenter.ViJson.OpenApi.Model.VsanPerfGraph

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Graph ID (i.e.  In the vSphere web client, this is used as a ID for composing the AskVmware link, for example: http://www.vmware.com/esx/support/askvmware/index.php?eventtype&#x3D;&amp;lt;id&amp;gt;&amp;amp;language&#x3D;en\\_US).  | 
**Metrics** | [**List&lt;VsanPerfMetricId&gt;**](VsanPerfMetricId.md) | The metrics to display in the graph.  | 
**Unit** | **string** | The unit for metrics in the graph.  See also *VsanPerfStatsUnitType_enum*.  | 
**Threshold** | [**VsanPerfThreshold**](VsanPerfThreshold.md) | The threshold in the graph  | [optional] 
**Name** | **string** | The display name of the graph.  | [optional] 
**Description** | **string** | The description of the graph.  | [optional] 
**SecondGraph** | [**VsanPerfGraph**](VsanPerfGraph.md) | The second y-axis support.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

